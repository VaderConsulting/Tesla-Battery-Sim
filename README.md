# Tesla - Model 3 Battery Controller Simulator

A .NET 5 Windows Forms application simulating the Tesla Model 3 high-voltage battery pack. Provides an interactive visual representation of all 96 cells, live battery statistics, a charge/discharge engine, and optional serial-port telemetry output that mimics a real Tesla BMS console.

**Source last updated:** 2022-02-17

**Initiated:** 2022-02-18 · **Framework:** .NET 5 Windows Forms · **Solution:** `Tesla.sln`

---

## Overview

Hosts the `TeslaBattery` custom control (from the companion **CustomControls** library) which renders 96 individual `TeslaCell` controls. Each cell tracks its own voltage within the valid lithium-ion operating range (3.000 V - 4.150 V) and colour-codes changes in real time.

---

## Features

- **96-cell visual display** - each cell colour-coded green (rising) / salmon (falling)
- **Live statistics** - pack voltage, average/high/low cell voltage, state of charge (%), remaining kWh
- **Charge / Discharge simulation** - configurable wattage with calculated per-cell voltage change/sec
- **Random variation mode** - applies small random offsets to simulate real cell imbalance
- **Serial telemetry output** - 115,200 baud BMS-style status report

---

## Battery Model

| Parameter | Value |
|-----------|-------|
| Cell count | 96 |
| Cell min voltage | 3.000 V |
| Cell max voltage | 4.150 V |
| Nominal pack capacity | 73,500 Wh (73.5 kWh) |

```
SoC% = (SummedVoltage - MinPackVoltage) / (MaxPackVoltage - MinPackVoltage) x 100
```

---

## Requirements

- .NET 5 SDK (Windows)
- CustomControls_5 project (companion solution)