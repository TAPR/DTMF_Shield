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
            UT144Wideband,
            UT220,
            UT440,
            UT440e,
            UT440Wideband,
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

        public enum OffsetType
        {
            CUSTOM = -1,
            SIMPLEX = 0,
            PLUS = 1,
            MINUS = 2,
            DOUBLE_MINUS = 3
        }

        public int currentCtcssMode;
        public int currentCtcssFrequencyIndex;

        public decimal currenFrequencyStepKHz;
        public decimal[] frequencyStepKHzOptions;

        public decimal[] offsetMHzOptions;

        public string entryListFileName;

        // for multiple options, such as EUROPEAN_BAND_PLAN plus WIDEBAND, we use an array.  A single option is an array with a single element
        public enum ModuleOptions
        {
            EUROPEAN_BAND_PLAN,
            WIDEBAND
        }

        public ModuleOptions[] moduleOptions;

        public UTModule(ModuleType type, string name, ModuleOptions[] moduleOptions, int position, decimal txMinFrequencyMHz, decimal txMaxFrequencyMHz, decimal rxMinFrequencyMHz, decimal rxMaxFrequencyMHz, int repeaterOffsetModeIndex, decimal repeaterOffsetMHz, int currentCtcssMode, int currentCtcssFrequencyIndex,
            decimal currenFrequencyStepKHz,
            decimal[] frequencyStepKHzOptions,
            decimal[] offsetMHzOptions,
            string entryListFileName)
        {
            this.type = type;
            this.name = name;
            this.moduleOptions = moduleOptions;
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
            this.offsetMHzOptions = offsetMHzOptions;
            this.entryListFileName = entryListFileName;
        }

        public static UTModule[] moduleTemplates = {
            new UTModule(ModuleType.UT30, "UT-30", new ModuleOptions []{ }, -1,
                28m, 29.7m, 28m, 29.7m, 0, 0, -1, -1, 10m,
                new decimal [] {5m, 10m, 15m, 20m, 25m},
                new decimal []{ +0.1m, -0.1m},
                ""),
            new UTModule(ModuleType.UT30, "UT-30Wide", new ModuleOptions []{ModuleOptions.WIDEBAND}, -1,
                18m, 54m, 26m, 45m, 0, 0, -1, -1, 10m,
                new decimal [] {5m, 10m, 15m, 20m, 25m},
                new decimal []{ +0.1m, -0.1m},
                ""),

            new UTModule(ModuleType.UT50, "UT-50", new ModuleOptions []{ }, -1,
                50m, 54m, 50m, 54m, 0, 0, -1, -1, 10m,
                new decimal [] {5m, 10m, 15m, 20m, 25m},
                new decimal []{ +1.0m, -1.0m },
                ""),
            new UTModule(ModuleType.UT50, "UT-50Wide", new ModuleOptions []{ModuleOptions.WIDEBAND}, -1,
                40m, 90m, 46m, 76m, 0, 0, -1, -1, 10m,
                new decimal [] {5m, 10m, 15m, 20m, 25m},
                new decimal []{ +1.0m, -1.0m },
                ""),

            new UTModule(ModuleType.UT144, "UT-144", new ModuleOptions []{ }, -1,
                144m, 148m, 144m, 148m, 0, 0, -1, -1, 5m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +0.6m, -0.6m},
                ""),
            new UTModule(ModuleType.UT144Wideband, "UT-144 Wide", new ModuleOptions []{ModuleOptions.WIDEBAND}, -1,
                118m, 174m, 136m, 174m, 0, 0, -1, -1, 5m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +0.6m, -0.6m},
                ""),

            new UTModule(ModuleType.UT144e, "UT-144E", new ModuleOptions []{ModuleOptions.EUROPEAN_BAND_PLAN}, -1,
                144m, 146m, 144m, 146m, 0, 0, -1, -1, 5m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +0.6m, -0.6m},
                ""),
            new UTModule(ModuleType.UT144e, "UT-144E Wide", new ModuleOptions []{ ModuleOptions.WIDEBAND, ModuleOptions.EUROPEAN_BAND_PLAN}, -1,
                118m, 174m, 136m, 174m, 0, 0, -1, -1, 5m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +0.6m, -0.6m},
                ""),

            new UTModule(ModuleType.UT220, "UT-220", new ModuleOptions []{ }, -1,
                220m, 224m, 220m, 224m, 0, 0, -1, -1, 20m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +1.6m, -1.6m },
                ""),
            new UTModule(ModuleType.UT220, "UT-220 Wide", new ModuleOptions []{ModuleOptions.WIDEBAND}, -1,
                215m, 260m, 215m, 235m, 0, 0, -1, -1, 20m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +1.6m, -1.6m },
                ""),

            new UTModule(ModuleType.UT440, "UT-440", new ModuleOptions []{ }, -1,
                430m, 450m, 430m, 450m, 0, 0, -1, -1, 25m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +5.0m, -5.0m },
                ""),
            new UTModule(ModuleType.UT440, "UT-440 Wide", new ModuleOptions []{ModuleOptions.WIDEBAND}, -1,
                410m, 470m, 410m, 470m, 0, 0, -1, -1, 25m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +5.0m, -5.0m },
                ""),
            new UTModule(ModuleType.UT440e, "UT-440E", new ModuleOptions []{ModuleOptions.EUROPEAN_BAND_PLAN}, -1,
                430m, 439.995m, 430m, 439.995m, 0, 0, -1, -1, 25m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +1.6m, -1.6m, -7.6m },
                ""),
            new UTModule(ModuleType.UT440e, "UT-440E Wide", new ModuleOptions []{ ModuleOptions.WIDEBAND, ModuleOptions.EUROPEAN_BAND_PLAN}, -1,
                430m, 439.995m, 430m, 439.995m, 0, 0, -1, -1, 25m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +1.6m, -1.6m, -7.6m },
                ""),

            new UTModule(ModuleType.UT1200, "UT-1200", new ModuleOptions []{ }, -1,
                1240m, 1299.999m, 1240m, 1299.999m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},
                new decimal []{ +12.0m, -12.0m, -20.0m },
                ""),
            new UTModule(ModuleType.UT1200e, "UT-1200E", new ModuleOptions []{ModuleOptions.EUROPEAN_BAND_PLAN}, -1,
                1240m, 1299.999m, 1240m, 1299.999m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},
                new decimal []{+35.0m, -6.0m},
                ""),   // and a third manual offset: +28.0m, according to Werner OE1RS
            new UTModule(ModuleType.UT1200Wideband, "UT-1200 Wide", new ModuleOptions []{ModuleOptions.WIDEBAND}, -1,
                1100m, 1399.99m, 1100m, 1399.99m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},
                new decimal[] { +35.0m, -6.0m},
                ""),
            new UTModule(ModuleType.UT1200e, "UT-1200E Wide", new ModuleOptions []{ ModuleOptions.WIDEBAND, ModuleOptions.EUROPEAN_BAND_PLAN}, -1,
                1100m, 1399.99m, 1100m, 1399.99m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},
                new decimal []{+35.0m, -6.0m},
                ""),   // and a third manual offset: +28.0m, according to Werner OE1RS

            // actually, the TM-2400 radio, with one, double-high module for 2400 MHz band.
            new UTModule(ModuleType.UT2400, "UT-2400", new ModuleOptions []{ }, -1,
                2400m, 2449.999m, 2400m, 2449.999m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},
                new decimal []{ },
                ""),
        };
    }
}
