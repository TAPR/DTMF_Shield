using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class UTModule
    {
        public enum ModuleType
        {
            None,
            UT30,
            UT50,
            UT144,
            UT144e,
            UT220,
            UT440,
            UT440e,
            UT1200,
            UT1200e,
            UT1200Wideband,
            UT2400      // the TM-2400 module for 2.4 GHz. In the Japan manual for TM-x42 series
        }

        public ModuleType type;
        public string name;

        public int position; // 0 or 1 or 2

        public decimal txMinFrequencyMHz;
        public decimal txMaxFrequencyMHz;

        public decimal rxMinFrequencyMHz;
        public decimal rxMaxFrequencyMHz;

        public int repeaterOffsetModeIndex;
        public decimal repeaterOffsetMHz;

        public int currentCtcssMode;
        public int currentCtcssFrequencyIndex;

        public decimal currenFrequencyStepKHz;
        public decimal[] frequencyStepKHzOptions;

        public string entryListFileName;

        public UTModule(ModuleType type, string name, int position, decimal txMinFrequencyMHz, decimal txMaxFrequencyMHz, decimal rxMinFrequencyMHz, decimal rxMaxFrequencyMHz, int repeaterOffsetModeIndex, decimal repeaterOffsetMHz, int currentCtcssMode, int currentCtcssFrequencyIndex, decimal currenFrequencyStepKHz, decimal[] frequencyStepKHzOptions, string entryListFileName)
        {
            this.type = type;
            this.name = name;
            this.position = position;
            this.txMinFrequencyMHz = txMinFrequencyMHz;
            this.txMaxFrequencyMHz = txMaxFrequencyMHz;
            this.rxMinFrequencyMHz = rxMinFrequencyMHz;
            this.rxMaxFrequencyMHz = rxMaxFrequencyMHz;
            this.repeaterOffsetModeIndex = repeaterOffsetModeIndex;
            this.repeaterOffsetMHz = repeaterOffsetMHz;
            this.currentCtcssMode = currentCtcssMode;
            this.currentCtcssFrequencyIndex = currentCtcssFrequencyIndex;
            this.currenFrequencyStepKHz = currenFrequencyStepKHz;
            this.frequencyStepKHzOptions = frequencyStepKHzOptions;
            this.entryListFileName = entryListFileName;
        }

        public static UTModule[] moduleTemplates = {
            new UTModule(ModuleType.UT30, "UT-30", -1, 28m, 29m, 28m, 29m, 0, 0, -1, -1, 5m, new [] {5m, 10m, 12.5m, 15m, 25m}, ""),
            new UTModule(ModuleType.UT50, "UT-50", -1, 50m, 53m, 50m, 53m, 0, 0, -1, -1, 5m, new [] {5m, 10m, 12.5m, 15m, 25m}, ""),
            new UTModule(ModuleType.UT144, "UT-144", -1, 118m, 174m, 118m, 174m, 0, 0, -1, -1, 5m, new [] {5m, 10m, 12.5m, 15m, 25m}, ""),
            new UTModule(ModuleType.UT144e, "UT-144E", -1, 118m, 174m, 118m, 174m, 0, 0, -1, -1, 5m, new [] {5m, 10m, 12.5m, 15m, 25m}, ""),
            new UTModule(ModuleType.UT220, "UT-220", -1, 220m, 224m, 220m, 224m, 0, 0, -1, -1, 5m, new [] {5m, 10m, 12.5m, 15m, 25m}, ""),
            new UTModule(ModuleType.UT440, "UT-440", -1, 410m, 470m, 410m, 470m, 0, 0, -1, -1, 5m, new [] {5m, 10m, 12.5m, 15m, 25m}, ""),
            new UTModule(ModuleType.UT440e, "UT-440E", -1, 410m, 470m, 410m, 470m, 0, 0, -1, -1, 5m, new [] {5m, 10m, 12.5m, 15m, 25m}, ""),
            new UTModule(ModuleType.UT1200, "UT-1200", -1, 1200m, 1299m, 1200m, 1299m, 0, 0, -1, -1, 5m, new [] {5m, 10m, 12.5m, 15m, 25m}, ""),
            new UTModule(ModuleType.UT1200e, "UT-1200E", -1, 1200m, 1299m, 1200m, 1299m, 0, 0, -1, -1, 5m, new [] {5m, 10m, 12.5m, 15m, 25m}, ""),
            new UTModule(ModuleType.UT1200Wideband, "UT-1200Wide", -1, 1100m, 1399m, 1100m, 1399m, 0, 0, -1, -1, 5m, new [] {5m, 10m, 12.5m, 15m, 25m}, ""),
            new UTModule(ModuleType.UT2400, "UT-2400", -1, 2400m, 2499m, 2400m, 2499m, 0, 0, -1, -1, 5m, new [] {5m, 10m, 12.5m, 15m, 25m}, ""),
        };
    }
}
