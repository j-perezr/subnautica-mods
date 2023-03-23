﻿using System.Collections.Generic;
using SMLHelper.V2.Crafting;
using Sprite = Atlas.Sprite;
namespace SeamothSpeedUpgrades.Modules
{
    public class SeamothSpeedModuleMKIII: BaseSeamothSpeedModule
    {
        public override float SpeedMultiplier => 4;

        public override float PowerConsumptionMultiplier => 1f;

        public SeamothSpeedModuleMKIII() : base
        (
            3,
            "Crazily increase the speed of the SeaMoth at the cost of a much higher power consumption. Not stackable"
        )
        {
        }
        protected override TechData GetBlueprintRecipe()
        {
            return new TechData()
            {
                craftAmount = 1,
                // same recipe has seamoth solar charge
                Ingredients = new List<Ingredient>()
                {
                    new(Main.SeamothSpeedModuleMKII.TechType, 1),
                    new(TechType.AdvancedWiringKit, 1),
                    new(TechType.Aerogel, 1),
                    new(TechType.PrecursorIonCrystal, 1)
                }
            };
        }
        protected override Sprite GetItemSprite()
        {
            return LoadSprite("mkiii.png");
        }
    }
}