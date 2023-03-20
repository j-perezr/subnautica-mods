using System.Collections.Generic;
using CyclopsHullReinforcements;
using CyclopsHullReinforcements.Modules;
using SMLHelper.V2.Crafting;
using Sprite = Atlas.Sprite;
namespace CyclopsReinforcementUpgrades.Modules
{
    public class CyclopsReinforcementModuleMKII : BaseCyclopsReinforcementModule
    {
        // Reduces Damage 0.3 times
        public override float ReinforcementMultiplier => 3;

        public CyclopsReinforcementModuleMKII() : base
        (
            2,
            "Greatly increase the Reinforcement of the cyclops. Not stackable"
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
                    new Ingredient(Main.CyclopsReinforcementModuleMKI.TechType, 1),
                    new Ingredient(TechType.PlasteelIngot, 1),
                    new Ingredient(TechType.AdvancedWiringKit, 1)     
                }
            };
        }
        protected override Sprite GetItemSprite()
        {
            return LoadSprite("mkii.png");
        }
    }
}