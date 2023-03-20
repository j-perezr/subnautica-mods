namespace CyclopsSolarCharger.Configuration
{
    using SMLHelper.V2.Json;
    using SMLHelper.V2.Options.Attributes;
    /**
     * Class to generate and handle the configuration using SML
     */
    [Menu("Cyclops Solar Charger Options")]
    public class SMLConfig : ConfigFile
    {
        /**
         * Used for validation purposes, to avoid higher values
         */
        public const float MaxDamageReductionValue = 100;

        public const float MinDamageReduction = 0;
        /**
         * Used for validation purposes, to avoid higher values
         */
        [Slider(label: "Reduction MKI", min: MinDamageReduction, max: MaxDamageReductionValue, Step = 5, DefaultValue = 30, Tooltip = "The amount of reduction damage the Cyclops takes MKI")]

        [Slider(label: "Reduction MKII", min: MinDamageReduction, max: MaxDamageReductionValue, Step = 5, DefaultValue = 40, Tooltip = "The amount of reduction damage the Cyclops takes for MKII")]

        [Slider(label: "Reduction MKIII", min: MinDamageReduction, max: MaxDamageReductionValue, Step = 5, DefaultValue = 50, Tooltip = "The amount of reduction damage the Cyclops takes MKIII")]
    }
}

