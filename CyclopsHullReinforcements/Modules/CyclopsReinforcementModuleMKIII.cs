using System.Collections.Generic;
using CyclopsHullReinforcements;
using CyclopsHullReinforcements.Modules;
using SMLHelper.V2.Crafting;
using Sprite = Atlas.Sprite;
namespace CyclopsReinforcementUpgrades.Modules
{
    public class CyclopsReinforcementModuleMKIII : BaseCyclopsReinforcementModule
    {
        // Reduces Damage by 0.4
        public override float ReinforcementMultiplier => 4;

        public CyclopsReinforcementModuleMKIII() : base
        (
            3,
            "Crazily increase the Reinforcement of the cyclops. Not stackable"
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
                    new Ingredient(Main.CyclopsReinforcementModuleMKII.TechType, 1),
                    new Ingredient(TechType.Kyanite, 1),
                    new Ingredient(TechType.PrecursorIonCrystal, 1)
                }
            };
        }
        protected override Sprite GetItemSprite()
        {
            return LoadSprite("mkiii.png");
        }
    }
}