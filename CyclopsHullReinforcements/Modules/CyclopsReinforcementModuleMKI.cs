using System.Collections.Generic;
using CyclopsHullReinforcements.Modules;
using SMLHelper.V2.Crafting;
using Sprite = Atlas.Sprite;
namespace CyclopsReinforcementUpgrades.Modules
{

    public class CyclopsReinforcementModuleMKI : BaseCyclopsReinforcementModule
    {
        // Reduces damage 0.2
        public override float ReinforcementMultiplier => 2;

        public CyclopsReinforcementModuleMKI() : base
        (
            1,
            "Increase the Reinforcement of the cyclops. Not stackable"
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
                    new Ingredient(TechType.VehicleArmorPlating, 1),
                    new Ingredient(TechType.PlasteelIngot, 1),
                    new Ingredient(TechType.AdvancedWiringKit, 1)
                }
            };
        }
        protected override Sprite GetItemSprite()
        {
            return LoadSprite("mki.png");
        }
    }
}