using System;
using System.Collections;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;

using CustomControls;

using static Utilities.Extensions;

namespace Battery
{
    public partial class frmMain : Form
    {
        private SerialPort? _Port = null;
        private decimal _Power = 0.0M;
        private decimal _Current = 0.0M;

        public frmMain()
        {
            InitializeComponent();

            Model3Battery.UpdateStatistics();

            tbCustom.Value = (int)Model3Battery.StateOfCharge;

            GetSerialPortNames();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            this.OnUIThreadAsync(() =>
            {
                _Current = _Power / (decimal)Model3Battery.SummedVoltage;

                lblSummedVoltageValue.Text = $"{Model3Battery.SummedVoltage.ToString("##0.000")}v";
                lblAverageCellValue.Text = $"{Model3Battery.AverageCellVoltage.ToString("0.000")}v";
                lblHighCellValue.Text = $"{Model3Battery.HighCellVoltage.ToString("0.000")}v";
                lblLowCellValue.Text = $"{Model3Battery.LowCellVoltage.ToString("0.000")}V";

                lblCapacityValue.Text = $"{(Model3Battery.BatteryCapacity / 1000).ToString("#0.0")} kWh";
                lblRemainingValue.Text = $"{(Model3Battery.BatteryState / 1000).ToString("#0.0")} kWh";
                lblSoCValue.Text = $"{Model3Battery.StateOfCharge.ToString("#0.0")}%";

                lblCurrentValue.Text = $"{_Current.ToString("#0.0")}A";
                lblPowerValue.Text = $"{_Power.ToString("###0")} watts";

                pbSoC.Value = (int)Model3Battery.StateOfCharge;
                tbCustom.Value = (int)Model3Battery.StateOfCharge;

                if (_Port != null && _Port.IsOpen)
                {
                    WriteSerialData();
                }
            });
        }

        private void btnSetMinimum_Click(object sender, EventArgs e)
        {
            this.OnUIThreadAsync(() =>
            {
                foreach (CustomControls.TeslaCell? c in Model3Battery.CellList)
                {
                    c.Voltage = TeslaCell.MinVoltage;
                }

                tbCustom.Value = (int)Model3Battery.StateOfCharge;
            });
        }

        private void btnSetMaximum_Click(object sender, EventArgs e)
        {
            this.OnUIThreadAsync(() =>
            {
                foreach (CustomControls.TeslaCell? c in Model3Battery.CellList)
                {
                    c.Voltage = TeslaCell.MaxVoltage;
                }

                tbCustom.Value = (int)Model3Battery.StateOfCharge;
            });
        }

        private void tbCustom_ValueChanged(object sender, EventArgs e)
        {
            decimal VoltageRange = (TeslaCell.MaxVoltage - TeslaCell.MinVoltage);
            decimal Percentage = ((decimal)tbCustom.Value) / 100;
            decimal SelectedVoltage = Percentage * VoltageRange;
            decimal Voltage = SelectedVoltage + TeslaCell.MinVoltage;

            lblTrackValue.Text = tbCustom.Value.ToString() + " %";

            this.OnUIThreadAsync(() =>
            {
                foreach (CustomControls.TeslaCell? c in Model3Battery.CellList)
                {
                    c.Voltage = Voltage;
                }

                ApplyVariations();
            });
        }

        private void ApplyVariations()
        {
            if (chkRandom.Checked && tbCustom.Value != 100 && tbCustom.Value != 0)
            {
                int HalfCellCount = Model3Battery.CellList.Count / 2;
                int FullCellCount = Model3Battery.CellList.Count;

                for (int i = 0; i < HalfCellCount; i++)
                {
                    TeslaCell Cell1 = Model3Battery.CellList[i];
                    TeslaCell Cell2 = Model3Battery.CellList[FullCellCount - i - 1];

                    decimal Variation = GetRandomValue(-0.001M, 0.001M);

                    if (Variation >= 0 && (Cell1.Voltage + Variation <= TeslaCell.MaxVoltage && Cell2.Voltage + Variation <= TeslaCell.MaxVoltage) ||
                        Variation < 0 && (Cell1.Voltage + Variation >= TeslaCell.MinVoltage && Cell2.Voltage + Variation >= TeslaCell.MinVoltage)
                       )
                    {
                        Cell1.Voltage += Variation;
                        Cell2.Voltage -= Variation;
                    }
                }
            }
        }

        private void chkCharge_CheckedChanged(object sender, EventArgs e)
        {
            tmrChargeDischarge.Enabled = chkCharge.Checked || chkDischarge.Checked;
        }

        private void chkDischarge_CheckedChanged(object sender, EventArgs e)
        {
            tmrChargeDischarge.Enabled = chkCharge.Checked || chkDischarge.Checked;
        }

        private void tmrChargeDischarge_Tick(object sender, EventArgs e)
        {
            decimal PerSecondVoltageChange = 0.000417216M; // 0.0000043461829176F per cell;
            decimal PerCellVoltageChange = 0.0M;
            decimal CalculatedVoltageChange = 0.0M;

            // https://electronics.stackexchange.com/questions/609200/i-want-to-determine-the-voltage-change-per-second-of-a-lithium-battery-given-a

            _Power = 0.0M;

            this.OnUIThreadAsync(() =>
            {
                // Get charge rate
                if (chkCharge.Checked)
                {
                    _Power = (decimal)nudCharge.Value; // W
                }

                // Get Discharge rate
                if (chkDischarge.Checked)
                {
                    _Power -= (decimal)nudDischarge.Value;  // W
                }

                CalculatedVoltageChange = (_Power / 1000) * PerSecondVoltageChange;
                PerCellVoltageChange = CalculatedVoltageChange; // / Model3Battery.CellList.Count;

                foreach (CustomControls.TeslaCell? c in Model3Battery.CellList)
                {
                    c.Voltage += PerCellVoltageChange;
                }
            });
        }

        private void GetSerialPortNames()
        {
            cmbSerialPort.Items.Clear();

            SortedList Names = new SortedList();

            foreach (string s in SerialPort.GetPortNames())
            {
                if (!Names.ContainsKey(s))
                {
                    Names.Add(s, s);
                }
            }

            foreach (object? n in Names.Keys)
            {
                cmbSerialPort.Items.Add(n.ToString());
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                try
                {
                    _Port.Open();

                    btnStartStop.Text = "Stop";
                }
                catch (Exception ex)
                {

                }

            }
            else
            {
                _Port.Close();
                btnStartStop.Text = "Start";
            }
        }

        private void cmbSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStartStop.Enabled = (cmbSerialPort.SelectedIndex != -1);

            _Port = new SerialPort(cmbSerialPort.Text, 115200, Parity.None, 8, StopBits.One);
        }

        private void WriteSerialData()
        {
            try
            {
                string Runtime = (DateTime.UtcNow - Process.GetCurrentProcess().StartTime.ToUniversalTime()).ToString();
                string Version = Process.GetCurrentProcess().MainModule.FileVersionInfo.ProductVersion.ToString();
                _Port.WriteLine($"================================================================================================");
                _Port.WriteLine($"******* Tesla Model 3 Battery Controller Simulator V {Version} Runtime: {Runtime} *******");
                _Port.WriteLine($"                                                      {DateTime.Now.ToString("D")}  {DateTime.Now.ToString("HH:mm:ss")}");
                _Port.WriteLine($"================================================================================================");

                for (int Index = 0; Index < Model3Battery.CellList.Count; Index += 8)
                {

                    _Port.Write($"  Cell ");
                    for (int CellCounter = Index; CellCounter < Index + 8; CellCounter++)
                    {
                        _Port.Write($"{(Model3Battery.CellList[CellCounter].Index + 1).ToString("00")}: {(Model3Battery.CellList[CellCounter].Voltage).ToString("#.000")}  ");
                        _Port.WriteLine("");

                    }
                }

                _Port.Write($"   Summed Voltage:{Model3Battery.SummedVoltage.ToString("##0.000")}v Average Cell:{Model3Battery.AverageCellVoltage.ToString("0.000")}v High Cell: {Model3Battery.HighCellVoltage.ToString("0.000")}v Low Cell: {Model3Battery.LowCellVoltage.ToString("0.000")}V");
                _Port.WriteLine("");
                _Port.WriteLine("");
                _Port.WriteLine($"  Reported Voltage:{Model3Battery.SummedVoltage.ToString("##0.000")}v Current:{_Current.ToString("#0.0")}A  Power:{_Power.ToString("###0")} watts Temperature:20C");
                _Port.WriteLine("");
                _Port.WriteLine($"    Capacity:{(Model3Battery.BatteryCapacity / 1000).ToString("#0.0")} kWh  Remaining:{(Model3Battery.BatteryState / 1000).ToString("#0.0")} kWh  SOC:{Model3Battery.StateOfCharge.ToString("#0.0")}%");
                _Port.WriteLine($"      Lifetime Charge:1234.567 kWh  Lifetime Discharge:7654.321 kWh");
                _Port.WriteLine($"      Max System Discharge Current: -1.23A Max System Charge Current: 12.34A  (z to reset)");
                _Port.WriteLine("");
                _Port.WriteLine($"  Battery Internal Contactors:4 CLOSED");
                _Port.WriteLine($"           Negative Contactor:ON  Reported ON");
                _Port.WriteLine($"           Positive Contactor:ON  Reported ON");
                _Port.WriteLine("");
                _Port.WriteLine($"  Charge Enable(4):OFF      Heat Enable(5):OFF     Battery Serial Number:TG123456789SXS");
                _Port.WriteLine("");
                _Port.WriteLine($"  Connected to local Access Point: SIMULATED as IP:1.2.3.4 signal strength:-99dBm");
                _Port.WriteLine($" Enter > for configuration screen");
            }
            catch { }
            {
            }
        }
    }
}
