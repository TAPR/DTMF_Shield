using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006

    public class UTModule
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
            UT1200j,
            UT1200Wideband,
            UT2400      // the TM-2400 module for 2.4 GHz. In the Japan manual for TM-x42 series
        }

        public ModuleType type;
        public ModuleType baseType;
        public string name;
        public string baseName;

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

        // for multiple options, such as EUROPEAN_BAND_PLAN plus WIDEBAND, we use an array.  A single option is an array with a single element
        public enum BandPlanOption
        {
            ANY_BAND_PLAN,
            NORTHAMERICAN_BAND_PLAN,
            EUROPEAN_BAND_PLAN,
            JAPANESE_BAND_PLAN,
            RESTOFWORLD_BAND_PLAN,
        }

        public enum WidebandOption
        {
            NORMAL,
            WIDEBAND
        }

        public BandPlanOption bandPlanOption;
        public WidebandOption widebandOption;

        public UTModule(ModuleType type, ModuleType baseType, string name, string baseName, BandPlanOption bandPlanOption, WidebandOption widebandOption, int position, decimal txMinFrequencyMHz, decimal txMaxFrequencyMHz, decimal rxMinFrequencyMHz, decimal rxMaxFrequencyMHz, int repeaterOffsetModeIndex, decimal repeaterOffsetMHz, int currentCtcssMode, int currentCtcssFrequencyIndex,
            decimal currenFrequencyStepKHz,
            decimal[] frequencyStepKHzOptions,
            decimal[] offsetMHzOptions)
        {
            this.type = type;
            this.baseType = baseType;
            this.name = name;
            this.bandPlanOption = bandPlanOption;
            this.widebandOption = widebandOption;
            this.baseName = baseName;

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
        }

        public static UTModule findBestModule(string baseName, BandPlanOption bandplanOption, WidebandOption widebandOption)
        {
            UTModule bestSoFar = null;
            if (!baseName.Equals("None"))
            {

                foreach (UTModule module in moduleTemplates)
                {
                    if (module.baseName.Equals(baseName))
                    {
                        if (((module.bandPlanOption == bandplanOption) || (module.bandPlanOption == BandPlanOption.ANY_BAND_PLAN))
                            && (module.widebandOption == widebandOption))
                        {
                            return module;
                        }
                        else if ((module.bandPlanOption == bandplanOption) || (module.widebandOption == widebandOption))
                        {
                            bestSoFar = module;
                        }
                    }
                }
            }

            return bestSoFar;
        }

        public static UTModule findBestModule(ModuleType baseType, BandPlanOption bandplanOption, WidebandOption widebandOption)
        {
            UTModule bestSoFar = null;

            // list order: by module (eg: UT30 before UT50), then by bandplan (ANY before NA before EU before JA), then wideband
            foreach (UTModule module in moduleTemplates)
            {
                if (module.baseType == baseType)
                {
                    if (((module.bandPlanOption == bandplanOption) || (module.bandPlanOption == BandPlanOption.ANY_BAND_PLAN))
                        && (module.widebandOption == widebandOption))
                    {
                        // will match a listing that is ANY_BAND_PLAN or the radio's band plan, and matches the wideband option
                        return module;
                    }
                    else if ((module.bandPlanOption == bandplanOption) || (module.bandPlanOption == BandPlanOption.ANY_BAND_PLAN))
                    {
                        // matches bandplan.  may not be best match, because next row may be exact match
                        bestSoFar = module;
                    }
                }
            }

            return bestSoFar;
        }


        public static List<UTModule> findBaseModuleList(ModuleType baseType)
        {
            List<UTModule> baseList = new();
            foreach (UTModule module in moduleTemplates)
            {
                if (module.baseType == baseType)
                {
                    baseList.Add(module);
                }
            }

            return baseList;
        }

        public static UTModule[] moduleTemplates = {
            new UTModule(ModuleType.None, ModuleType.None, "Module Not Installed", "None", BandPlanOption.ANY_BAND_PLAN, WidebandOption.NORMAL, -1,
                0m, 0m, 0m, 0m, 0, 0, -1, -1, 10m,
                new decimal [] {},
                new decimal []{}),
            new UTModule(ModuleType.UT30, ModuleType.UT30, "UT-30", "UT30", BandPlanOption.ANY_BAND_PLAN, WidebandOption.NORMAL, -1,
                28m, 29.7m, 28m, 29.7m, 0, 0, -1, -1, 10m,
                new decimal [] {5m, 10m, 15m, 20m, 25m},
                new decimal []{ +0.1m, -0.1m}),
            new UTModule(ModuleType.UT30, ModuleType.UT30,"UT-30 Wide", "UT30", BandPlanOption.ANY_BAND_PLAN, WidebandOption.WIDEBAND, -1,
                18m, 54m, 26m, 45.999m, 0, 0, -1, -1, 10m,
                new decimal [] {5m, 10m, 15m, 20m, 25m},
                new decimal []{ +0.1m, -0.1m}),

            new UTModule(ModuleType.UT50, ModuleType.UT50, "UT-50", "UT50", BandPlanOption.ANY_BAND_PLAN, WidebandOption.NORMAL, -1,
                50m, 53.995m, 50m, 53.995m, 0, 0, -1, -1, 10m,
                new decimal [] {5m, 10m, 15m, 20m, 25m},
                new decimal []{ +1.0m, -1.0m }),
            new UTModule(ModuleType.UT50, ModuleType.UT50, "UT-50 Wide", "UT50", BandPlanOption.ANY_BAND_PLAN, WidebandOption.WIDEBAND, -1,
                40m, 89.995m, 46m, 76.995m, 0, 0, -1, -1, 10m,
                new decimal [] {5m, 10m, 15m, 20m, 25m},
                new decimal []{ +1.0m, -1.0m }),

            new UTModule(ModuleType.UT144, ModuleType.UT144, "UT-144", "UT144", BandPlanOption.NORTHAMERICAN_BAND_PLAN, WidebandOption.NORMAL, -1,
                144m, 148m, 144m, 148m, 0, 0, -1, -1, 5m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +0.6m, -0.6m}),
            new UTModule(ModuleType.UT144Wideband, ModuleType.UT144, "UT-144 Wide", "UT144", BandPlanOption.NORTHAMERICAN_BAND_PLAN, WidebandOption.WIDEBAND, -1,
                118m, 174.995m, 136m, 174.995m, 0, 0, -1, -1, 5m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +0.6m, -0.6m}),

            new UTModule(ModuleType.UT144e, ModuleType.UT144, "UT-144E", "UT144", BandPlanOption.EUROPEAN_BAND_PLAN, WidebandOption.NORMAL, -1,
                144m, 146m, 144m, 146m, 0, 0, -1, -1, 5m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +0.6m, -0.6m}),
            new UTModule(ModuleType.UT144e, ModuleType.UT144, "UT-144E Wide", "UT144", BandPlanOption.EUROPEAN_BAND_PLAN,  WidebandOption.WIDEBAND, -1,
                118m, 174.995m, 136m, 174.995m, 0, 0, -1, -1, 5m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +0.6m, -0.6m}),

            new UTModule(ModuleType.UT220, ModuleType.UT220, "UT-220", "UT220", BandPlanOption.NORTHAMERICAN_BAND_PLAN, WidebandOption.NORMAL, -1,
                220m, 224m, 220m, 224m, 0, 0, -1, -1, 20m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +1.6m, -1.6m }),
            new UTModule(ModuleType.UT220, ModuleType.UT220, "UT-220 Wide", "UT220", BandPlanOption.NORTHAMERICAN_BAND_PLAN, WidebandOption.WIDEBAND, -1,
                215m, 260.995m, 215m, 235.995m, 0, 0, -1, -1, 20m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +1.6m, -1.6m }),

            new UTModule(ModuleType.UT440, ModuleType.UT440, "UT-440", "UT440", BandPlanOption.NORTHAMERICAN_BAND_PLAN, WidebandOption.NORMAL, -1,
                430m, 449.995m, 430m, 449.995m, 0, 0, -1, -1, 25m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +5.0m, -5.0m }),
            new UTModule(ModuleType.UT440, ModuleType.UT440, "UT-440 Wide", "UT440", BandPlanOption.NORTHAMERICAN_BAND_PLAN, WidebandOption.WIDEBAND, -1,
                410m, 469.995m, 410m, 469.995m, 0, 0, -1, -1, 25m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +5.0m, -5.0m }),
            new UTModule(ModuleType.UT440e, ModuleType.UT440, "UT-440E", "UT440", BandPlanOption.EUROPEAN_BAND_PLAN, WidebandOption.NORMAL, -1,
                430m, 439.995m, 430m, 439.995m, 0, 0, -1, -1, 25m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +1.6m, -1.6m, -7.6m }),
            new UTModule(ModuleType.UT440e, ModuleType.UT440, "UT-440E Wide", "UT440", BandPlanOption.EUROPEAN_BAND_PLAN, WidebandOption.WIDEBAND, -1,
                430m, 469.995m, 410m, 469.995m, 0, 0, -1, -1, 25m,
                new decimal [] {5m, 10m, 15m, 20m, 12.5m, 25m},
                new decimal []{ +1.6m, -1.6m, -7.6m }),

            new UTModule(ModuleType.UT1200, ModuleType.UT1200, "UT-1200", "UT1200", BandPlanOption.NORTHAMERICAN_BAND_PLAN, WidebandOption.NORMAL, -1,
                1240m, 1299.999m, 1240m, 1299.999m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},
                new decimal []{ +12.0m, -12.0m, -20.0m }),
            new UTModule(ModuleType.UT1200Wideband, ModuleType.UT1200, "UT-1200 Wide", "UT1200", BandPlanOption.NORTHAMERICAN_BAND_PLAN, WidebandOption.WIDEBAND, -1,
                1100m, 1399.99m, 1100m, 1399.99m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},
                new decimal []{ +12.0m, -12.0m, -20.0m }),
            new UTModule(ModuleType.UT1200e, ModuleType.UT1200, "UT-1200 E", "UT1200", BandPlanOption.EUROPEAN_BAND_PLAN, WidebandOption.NORMAL, -1,
                1240m, 1299.999m, 1240m, 1299.999m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},
                new decimal []{+35.0m, -6.0m}),   // and a third manual offset: -28.0m, according to Werner OE1RS
            new UTModule(ModuleType.UT1200e, ModuleType.UT1200, "UT-1200 E Wide", "UT1200", BandPlanOption.EUROPEAN_BAND_PLAN, WidebandOption.WIDEBAND, -1,
                1100m, 1399.99m, 1100m, 1399.99m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},
                new decimal []{+35.0m, -6.0m}),   // and a third manual offset: -28.0m, according to Werner OE1RS
            new UTModule(ModuleType.UT1200e, ModuleType.UT1200, "UT-1200J", "UT1200", BandPlanOption.JAPANESE_BAND_PLAN, WidebandOption.NORMAL, -1,
                1240m, 1299.999m, 1240m, 1299.999m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},
                new decimal []{+20.0m, -20.0m}),   // and a third manual offset: -28.0m, according to Werner OE1RS
            new UTModule(ModuleType.UT1200j, ModuleType.UT1200, "UT-1200 J Wide", "UT1200", BandPlanOption.JAPANESE_BAND_PLAN, WidebandOption.WIDEBAND, -1,
                1100m, 1399.99m, 1100m, 1399.99m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},
                new decimal []{+20.0m, -20.0m}),   // and a third manual offset: -28.0m, according to Werner OE1RS

            // actually, the TM-2400 radio, with one, double-high module for 2400 MHz band.
            // it isn't a type 'E' radio.  It's similar to Japanese radios.
            // In many ways, Japanese radios seem more like US/CAN radios than European radios. However, things like the repeater offsets can well be different.
            new UTModule(ModuleType.UT2400, ModuleType.UT2400, "UT 2400", "UT2400", BandPlanOption.ANY_BAND_PLAN, WidebandOption.NORMAL, -1,
                2400m, 2449.999m, 2400m, 2449.999m, 0, 0, -1, -1, 25m,
                new decimal [] {10m, 20m, 12.5m, 25m},  // page 61 of the JP manual.  Apparently the default is 20KHz.
                new decimal []{+20.0m, -20.0m} // page 27 of the JP manual for the TM-2400.  And a third, manual offset, apparently +48MHz, according to Werner OE1RS
                ),
        };
    }
}
