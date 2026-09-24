# Tesla-Battery-Sim

Tesla-Battery-Sim is a .NET 5 Windows Forms application that simulates the Tesla Model 3 high-voltage battery pack for interactive BMS-style experimentation. It renders all 96 cells, live pack statistics, a configurable charge/discharge engine, and optional serial-port telemetry that mimics a real Tesla BMS console. Each cell tracks voltage in the lithium-ion operating range (3.000 V - 4.150 V) and colour-codes rising versus falling values in real time. The UI hosts the TeslaBattery custom control from the companion CustomControls library.

**Source last updated:** 2022-02-17 · **Language:** C# · **Target:** .NET 5 (net5.0-windows) · **Output:** WinForms exe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `Battery` (`Battery/Battery.csproj`) | C# | WinForms exe | Main simulator host (frmMain) with 96-cell display, stats, charge/discharge, and serial telemetry |
| `CustomControls_5` (external `../CustomControls/CustomControls_5`) | C# | Class library | Companion controls including TeslaBattery / TeslaCell |
| `Utilities_5` (external `../Utilities/Utilities_5`) | C# | Class library | Shared utilities referenced by the solution |

## How to open

Open `Tesla.sln` in Visual Studio. The solution references sibling CustomControls and Utilities trees; keep those folders available beside this repo (or restore matching VaderConsulting companion projects) so project references resolve.

## Requirements

- Visual Studio 2019 to 2022 (solution Format Version 12 / Visual Studio Version 17)
- .NET 5 SDK (Windows) with Windows Forms workload
- Companion CustomControls_5 and Utilities_5 projects (referenced from sibling folders)

## Attribution and provenance

my working copy from OneDrive Historical Dev (folder formerly known as Tesla; GitHub repo Tesla-Battery-Sim). Simulates Model 3 pack behaviour for local experimentation; not affiliated with Tesla, Inc.

## License

MIT (c) 2026 VaderConsulting. See `LICENSE`.

