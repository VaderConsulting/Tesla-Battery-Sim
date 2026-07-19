namespace Battery
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Model3Battery = new CustomControls.TeslaBattery(this.components);
            this.lblSummedVoltage = new System.Windows.Forms.Label();
            this.lblSummedVoltageValue = new System.Windows.Forms.Label();
            this.lblHighCell = new System.Windows.Forms.Label();
            this.lblHighCellValue = new System.Windows.Forms.Label();
            this.lblLowCellValue = new System.Windows.Forms.Label();
            this.lblLowCell = new System.Windows.Forms.Label();
            this.lblAverageCellValue = new System.Windows.Forms.Label();
            this.lblAverageCell = new System.Windows.Forms.Label();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblCapacityValue = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblSoC = new System.Windows.Forms.Label();
            this.lblRemainingValue = new System.Windows.Forms.Label();
            this.lblSoCValue = new System.Windows.Forms.Label();
            this.btnSetMinimum = new System.Windows.Forms.Button();
            this.btnSetMaximum = new System.Windows.Forms.Button();
            this.tbCustom = new System.Windows.Forms.TrackBar();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.lblTrackValue = new System.Windows.Forms.Label();
            this.nudDischarge = new System.Windows.Forms.NumericUpDown();
            this.nudCharge = new System.Windows.Forms.NumericUpDown();
            this.lblDischargeW = new System.Windows.Forms.Label();
            this.lblChargeW = new System.Windows.Forms.Label();
            this.chkDischarge = new System.Windows.Forms.CheckBox();
            this.chkCharge = new System.Windows.Forms.CheckBox();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblPowerValue = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.pbSoC = new System.Windows.Forms.ProgressBar();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.tmrChargeDischarge = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbCustom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDischarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // Model3Battery
            // 
            this.Model3Battery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Model3Battery.AutoScroll = true;
            this.Model3Battery.AverageCellVoltage = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Model3Battery.BatteryCapacity = new decimal(new int[] {
            73500,
            0,
            0,
            0});
            this.Model3Battery.HighCellVoltage = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Model3Battery.Location = new System.Drawing.Point(12, 12);
            this.Model3Battery.LowCellVoltage = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Model3Battery.MinimumSize = new System.Drawing.Size(300, 100);
            this.Model3Battery.Name = "Model3Battery";
            this.Model3Battery.ReportedVoltage = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Model3Battery.Size = new System.Drawing.Size(860, 591);
            this.Model3Battery.SummedVoltage = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Model3Battery.TabIndex = 1;
            // 
            // lblSummedVoltage
            // 
            this.lblSummedVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummedVoltage.AutoSize = true;
            this.lblSummedVoltage.Location = new System.Drawing.Point(13, 606);
            this.lblSummedVoltage.Name = "lblSummedVoltage";
            this.lblSummedVoltage.Size = new System.Drawing.Size(72, 25);
            this.lblSummedVoltage.TabIndex = 4;
            this.lblSummedVoltage.Text = "Sum. V.";
            // 
            // lblSummedVoltageValue
            // 
            this.lblSummedVoltageValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummedVoltageValue.AutoSize = true;
            this.lblSummedVoltageValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSummedVoltageValue.Location = new System.Drawing.Point(91, 606);
            this.lblSummedVoltageValue.Name = "lblSummedVoltageValue";
            this.lblSummedVoltageValue.Size = new System.Drawing.Size(87, 25);
            this.lblSummedVoltageValue.TabIndex = 5;
            this.lblSummedVoltageValue.Text = "999.999v";
            // 
            // lblHighCell
            // 
            this.lblHighCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHighCell.AutoSize = true;
            this.lblHighCell.Location = new System.Drawing.Point(389, 606);
            this.lblHighCell.Name = "lblHighCell";
            this.lblHighCell.Size = new System.Drawing.Size(50, 25);
            this.lblHighCell.TabIndex = 6;
            this.lblHighCell.Text = "High";
            // 
            // lblHighCellValue
            // 
            this.lblHighCellValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHighCellValue.AutoSize = true;
            this.lblHighCellValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighCellValue.Location = new System.Drawing.Point(445, 606);
            this.lblHighCellValue.Name = "lblHighCellValue";
            this.lblHighCellValue.Size = new System.Drawing.Size(87, 25);
            this.lblHighCellValue.TabIndex = 7;
            this.lblHighCellValue.Text = "999.999v";
            // 
            // lblLowCellValue
            // 
            this.lblLowCellValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLowCellValue.AutoSize = true;
            this.lblLowCellValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLowCellValue.Location = new System.Drawing.Point(588, 606);
            this.lblLowCellValue.Name = "lblLowCellValue";
            this.lblLowCellValue.Size = new System.Drawing.Size(87, 25);
            this.lblLowCellValue.TabIndex = 9;
            this.lblLowCellValue.Text = "999.999v";
            // 
            // lblLowCell
            // 
            this.lblLowCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLowCell.AutoSize = true;
            this.lblLowCell.Location = new System.Drawing.Point(538, 606);
            this.lblLowCell.Name = "lblLowCell";
            this.lblLowCell.Size = new System.Drawing.Size(44, 25);
            this.lblLowCell.TabIndex = 8;
            this.lblLowCell.Text = "Low";
            // 
            // lblAverageCellValue
            // 
            this.lblAverageCellValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAverageCellValue.AutoSize = true;
            this.lblAverageCellValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAverageCellValue.Location = new System.Drawing.Point(271, 606);
            this.lblAverageCellValue.Name = "lblAverageCellValue";
            this.lblAverageCellValue.Size = new System.Drawing.Size(87, 25);
            this.lblAverageCellValue.TabIndex = 11;
            this.lblAverageCellValue.Text = "999.999v";
            // 
            // lblAverageCell
            // 
            this.lblAverageCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAverageCell.AutoSize = true;
            this.lblAverageCell.Location = new System.Drawing.Point(195, 606);
            this.lblAverageCell.Name = "lblAverageCell";
            this.lblAverageCell.Size = new System.Drawing.Size(70, 25);
            this.lblAverageCell.TabIndex = 10;
            this.lblAverageCell.Text = "Av. Cell";
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 1000;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // lblCapacity
            // 
            this.lblCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(13, 644);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(43, 25);
            this.lblCapacity.TabIndex = 12;
            this.lblCapacity.Text = "Cap";
            // 
            // lblCapacityValue
            // 
            this.lblCapacityValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCapacityValue.AutoSize = true;
            this.lblCapacityValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCapacityValue.Location = new System.Drawing.Point(91, 644);
            this.lblCapacityValue.Name = "lblCapacityValue";
            this.lblCapacityValue.Size = new System.Drawing.Size(91, 25);
            this.lblCapacityValue.TabIndex = 13;
            this.lblCapacityValue.Text = "00.0 kWh";
            // 
            // lblRemaining
            // 
            this.lblRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(195, 644);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(47, 25);
            this.lblRemaining.TabIndex = 14;
            this.lblRemaining.Text = "Rem";
            // 
            // lblSoC
            // 
            this.lblSoC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoC.AutoSize = true;
            this.lblSoC.Location = new System.Drawing.Point(389, 644);
            this.lblSoC.Name = "lblSoC";
            this.lblSoC.Size = new System.Drawing.Size(44, 25);
            this.lblSoC.TabIndex = 15;
            this.lblSoC.Text = "SoC";
            // 
            // lblRemainingValue
            // 
            this.lblRemainingValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemainingValue.AutoSize = true;
            this.lblRemainingValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRemainingValue.Location = new System.Drawing.Point(271, 644);
            this.lblRemainingValue.Name = "lblRemainingValue";
            this.lblRemainingValue.Size = new System.Drawing.Size(91, 25);
            this.lblRemainingValue.TabIndex = 16;
            this.lblRemainingValue.Text = "00.0 kWh";
            // 
            // lblSoCValue
            // 
            this.lblSoCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoCValue.AutoSize = true;
            this.lblSoCValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoCValue.Location = new System.Drawing.Point(445, 644);
            this.lblSoCValue.Name = "lblSoCValue";
            this.lblSoCValue.Size = new System.Drawing.Size(68, 25);
            this.lblSoCValue.TabIndex = 17;
            this.lblSoCValue.Text = "00.0 %";
            // 
            // btnSetMinimum
            // 
            this.btnSetMinimum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetMinimum.Location = new System.Drawing.Point(13, 746);
            this.btnSetMinimum.Name = "btnSetMinimum";
            this.btnSetMinimum.Size = new System.Drawing.Size(62, 34);
            this.btnSetMinimum.TabIndex = 18;
            this.btnSetMinimum.Text = "Min";
            this.btnSetMinimum.UseVisualStyleBackColor = true;
            this.btnSetMinimum.Click += new System.EventHandler(this.btnSetMinimum_Click);
            // 
            // btnSetMaximum
            // 
            this.btnSetMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetMaximum.Location = new System.Drawing.Point(81, 747);
            this.btnSetMaximum.Name = "btnSetMaximum";
            this.btnSetMaximum.Size = new System.Drawing.Size(62, 34);
            this.btnSetMaximum.TabIndex = 19;
            this.btnSetMaximum.Text = "Max";
            this.btnSetMaximum.UseVisualStyleBackColor = true;
            this.btnSetMaximum.Click += new System.EventHandler(this.btnSetMaximum_Click);
            // 
            // tbCustom
            // 
            this.tbCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCustom.LargeChange = 10;
            this.tbCustom.Location = new System.Drawing.Point(12, 672);
            this.tbCustom.Maximum = 100;
            this.tbCustom.Name = "tbCustom";
            this.tbCustom.Size = new System.Drawing.Size(851, 69);
            this.tbCustom.TabIndex = 21;
            this.tbCustom.TickFrequency = 5;
            this.tbCustom.Value = 50;
            this.tbCustom.ValueChanged += new System.EventHandler(this.tbCustom_ValueChanged);
            // 
            // chkRandom
            // 
            this.chkRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRandom.AutoSize = true;
            this.chkRandom.Checked = true;
            this.chkRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandom.Location = new System.Drawing.Point(766, 751);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(106, 29);
            this.chkRandom.TabIndex = 23;
            this.chkRandom.Text = "Random";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // lblTrackValue
            // 
            this.lblTrackValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrackValue.AutoSize = true;
            this.lblTrackValue.Location = new System.Drawing.Point(414, 707);
            this.lblTrackValue.Name = "lblTrackValue";
            this.lblTrackValue.Size = new System.Drawing.Size(52, 25);
            this.lblTrackValue.TabIndex = 22;
            this.lblTrackValue.Text = "50 %";
            this.lblTrackValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudDischarge
            // 
            this.nudDischarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudDischarge.Location = new System.Drawing.Point(368, 790);
            this.nudDischarge.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.nudDischarge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDischarge.Name = "nudDischarge";
            this.nudDischarge.Size = new System.Drawing.Size(99, 31);
            this.nudDischarge.TabIndex = 31;
            this.nudDischarge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDischarge.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // nudCharge
            // 
            this.nudCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudCharge.Location = new System.Drawing.Point(118, 790);
            this.nudCharge.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.nudCharge.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCharge.Name = "nudCharge";
            this.nudCharge.Size = new System.Drawing.Size(99, 31);
            this.nudCharge.TabIndex = 30;
            this.nudCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCharge.Value = new decimal(new int[] {
            11000,
            0,
            0,
            0});
            // 
            // lblDischargeW
            // 
            this.lblDischargeW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDischargeW.AutoSize = true;
            this.lblDischargeW.Location = new System.Drawing.Point(473, 793);
            this.lblDischargeW.Name = "lblDischargeW";
            this.lblDischargeW.Size = new System.Drawing.Size(29, 25);
            this.lblDischargeW.TabIndex = 29;
            this.lblDischargeW.Text = "W";
            // 
            // lblChargeW
            // 
            this.lblChargeW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChargeW.AutoSize = true;
            this.lblChargeW.Location = new System.Drawing.Point(222, 792);
            this.lblChargeW.Name = "lblChargeW";
            this.lblChargeW.Size = new System.Drawing.Size(29, 25);
            this.lblChargeW.TabIndex = 26;
            this.lblChargeW.Text = "W";
            // 
            // chkDischarge
            // 
            this.chkDischarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDischarge.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDischarge.Location = new System.Drawing.Point(263, 787);
            this.chkDischarge.Name = "chkDischarge";
            this.chkDischarge.Size = new System.Drawing.Size(99, 35);
            this.chkDischarge.TabIndex = 25;
            this.chkDischarge.Text = "Discharge";
            this.chkDischarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDischarge.UseVisualStyleBackColor = true;
            this.chkDischarge.CheckedChanged += new System.EventHandler(this.chkDischarge_CheckedChanged);
            // 
            // chkCharge
            // 
            this.chkCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCharge.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCharge.Location = new System.Drawing.Point(13, 787);
            this.chkCharge.Name = "chkCharge";
            this.chkCharge.Size = new System.Drawing.Size(99, 35);
            this.chkCharge.TabIndex = 24;
            this.chkCharge.Text = "Charge";
            this.chkCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCharge.UseVisualStyleBackColor = true;
            this.chkCharge.CheckedChanged += new System.EventHandler(this.chkCharge_CheckedChanged);
            // 
            // lblPower
            // 
            this.lblPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(677, 644);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(22, 25);
            this.lblPower.TabIndex = 21;
            this.lblPower.Text = "P";
            // 
            // lblPowerValue
            // 
            this.lblPowerValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPowerValue.AutoSize = true;
            this.lblPowerValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPowerValue.Location = new System.Drawing.Point(705, 644);
            this.lblPowerValue.Name = "lblPowerValue";
            this.lblPowerValue.Size = new System.Drawing.Size(103, 25);
            this.lblPowerValue.TabIndex = 22;
            this.lblPowerValue.Text = "9999 watts";
            // 
            // lblCurrent
            // 
            this.lblCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(677, 606);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(17, 25);
            this.lblCurrent.TabIndex = 19;
            this.lblCurrent.Text = "I";
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentValue.Location = new System.Drawing.Point(700, 606);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(70, 25);
            this.lblCurrentValue.TabIndex = 20;
            this.lblCurrentValue.Text = "9.999A";
            // 
            // pbSoC
            // 
            this.pbSoC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSoC.Location = new System.Drawing.Point(149, 747);
            this.pbSoC.Name = "pbSoC";
            this.pbSoC.Size = new System.Drawing.Size(318, 33);
            this.pbSoC.Step = 1;
            this.pbSoC.TabIndex = 18;
            this.pbSoC.Value = 50;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartStop.Enabled = false;
            this.btnStartStop.Location = new System.Drawing.Point(810, 788);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(62, 34);
            this.btnStartStop.TabIndex = 2;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 793);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(698, 790);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(106, 33);
            this.cmbSerialPort.TabIndex = 0;
            this.cmbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cmbSerialPort_SelectedIndexChanged);
            // 
            // tmrChargeDischarge
            // 
            this.tmrChargeDischarge.Interval = 1000;
            this.tmrChargeDischarge.Tick += new System.EventHandler(this.tmrChargeDischarge_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 834);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblTrackValue);
            this.Controls.Add(this.lblPowerValue);
            this.Controls.Add(this.lblDischargeW);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblCurrentValue);
            this.Controls.Add(this.lblSummedVoltage);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblSoCValue);
            this.Controls.Add(this.lblSummedVoltageValue);
            this.Controls.Add(this.nudDischarge);
            this.Controls.Add(this.lblRemainingValue);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.lblHighCell);
            this.Controls.Add(this.cmbSerialPort);
            this.Controls.Add(this.lblSoC);
            this.Controls.Add(this.Model3Battery);
            this.Controls.Add(this.lblHighCellValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.chkDischarge);
            this.Controls.Add(this.lblLowCell);
            this.Controls.Add(this.tbCustom);
            this.Controls.Add(this.lblCapacityValue);
            this.Controls.Add(this.lblChargeW);
            this.Controls.Add(this.lblLowCellValue);
            this.Controls.Add(this.nudCharge);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.pbSoC);
            this.Controls.Add(this.lblAverageCell);
            this.Controls.Add(this.btnSetMinimum);
            this.Controls.Add(this.lblAverageCellValue);
            this.Controls.Add(this.btnSetMaximum);
            this.Controls.Add(this.chkCharge);
            this.Name = "frmMain";
            this.Text = "Model 3 Battery";
            ((System.ComponentModel.ISupportInitialize)(this.tbCustom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDischarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.TeslaBattery Model3Battery;
        private System.Windows.Forms.Label lblSummedVoltage;
        private System.Windows.Forms.Label lblSummedVoltageValue;
        private System.Windows.Forms.Label lblHighCell;
        private System.Windows.Forms.Label lblHighCellValue;
        private System.Windows.Forms.Label lblLowCellValue;
        private System.Windows.Forms.Label lblLowCell;
        private System.Windows.Forms.Label lblAverageCellValue;
        private System.Windows.Forms.Label lblAverageCell;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblCapacityValue;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblSoC;
        private System.Windows.Forms.Label lblRemainingValue;
        private System.Windows.Forms.Label lblSoCValue;
        private System.Windows.Forms.Button btnSetMinimum;
        private System.Windows.Forms.Button btnSetMaximum;
        private System.Windows.Forms.TrackBar tbCustom;
        private System.Windows.Forms.Label lblTrackValue;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.Label lblDischargeW;
        private System.Windows.Forms.Label lblChargeW;
        private System.Windows.Forms.CheckBox chkDischarge;
        private System.Windows.Forms.CheckBox chkCharge;
        private System.Windows.Forms.ProgressBar pbSoC;
        private System.Windows.Forms.NumericUpDown nudDischarge;
        private System.Windows.Forms.NumericUpDown nudCharge;
        private System.Windows.Forms.Timer tmrChargeDischarge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblPowerValue;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblCurrentValue;
    }
}
