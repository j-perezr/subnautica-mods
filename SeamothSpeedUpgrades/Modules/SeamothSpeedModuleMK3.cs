﻿using System.Collections.Generic;
using SMLHelper.V2.Crafting;
using Sprite = Atlas.Sprite;
namespace SeamothSpeedUpgrades.Modules
{
    public class SeamothSpeedModuleMK3: BaseSeamothSpeedModule
    {

        public SeamothSpeedModuleMK3() : base
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
                    new(Main.SeamothSpeedModuleMk2.TechType, 1),
                    new(TechType.AdvancedWiringKit, 1),
                    new(TechType.Aerogel, 1),
                    new(TechType.PrecursorIonCrystal, 1)
                }
            };
        }
        protected override Sprite GetItemSprite()
        {
            return LoadSprite("mk3.png");
        }
    }
}