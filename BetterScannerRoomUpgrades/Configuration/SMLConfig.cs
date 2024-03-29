﻿namespace BetterScannerRoomUpgrades.Configuration
{
    using SMLHelper.V2.Json;
    using SMLHelper.V2.Options.Attributes;
    /**
     * Class to generate and handle the configuration using SML
     */
    [Menu("Better Scanner Room Upgrades Options")]
    public class SMLConfig : ConfigFile
    {
        /**
         * Min interval in seconds between scan blips. Less than 0.5f (half second) could cause problems.
         */
        public const float MinScanInterval = 1f;
        public const float MaxPowerEfficiency = 90f;
        [Slider
        (
            label: "Max scanner range",
            min: 300,
            max: 4000,
            Step = 100,
            DefaultValue = 1000,
            Tooltip = "The maximum range for the scanner with all the upgrades installed."
        )]
        public int MaxRange = 1000;
        [Slider(label: "Scan interval per upgrade", min: 2, max: 14, Step = 1, DefaultValue = 4, Tooltip = "Number of seconds to reduce the scanning interval for each upgrade installed.")]
        public float SpeedPerModule = 4;
        [Slider(label: "Range increase per upgrade", min: 50, max: 4000, Step = 100, DefaultValue = 200, Tooltip = "The number of meters to increase the scan range for each upgrade installed.")]
        public int RangePerModule = 200;
        [Slider(label: "Default range", min: 300, max: 4000, Step = 100, DefaultValue = 600, Tooltip = "The default scan range with no upgrades installed.")]
        public int DefaultRange = 600;
        [Slider
        (
            label: "Default scan interval",
            min: 1,
            max: 14,
            Step = 1,
            DefaultValue = 9f,
            Tooltip = "The default scan time interval with no upgrades installed."
        )]
        public float DefaultInterval = 9f;
        
        [Slider
        (
            label: "Power efficiency per upgrade",
            min: 0,
            max: MaxPowerEfficiency,
            Step = 5,
            DefaultValue = 20,
            Tooltip = "The percentage of power consumption to reduce for each upgrade installed. For example, if 20, one installed upgrade will reduce the power required by the scanner room a 20%"
        )]
        public float PowerEfficiencyPerModule = 20f;
    }
}

