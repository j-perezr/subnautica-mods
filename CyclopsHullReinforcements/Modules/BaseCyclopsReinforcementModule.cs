﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using SMLHelper.V2.Utility;
using UnityEngine;
using Sprite = Atlas.Sprite;
using System.Collections;
using SMLHelper.V2.Assets;

namespace CyclopsHullReinforcements.Modules
{
    /**
     * Base for the CyclopsReinforcementModules
     */
    public abstract class BaseCyclopsReinforcementModule : Equipable
    {
        public abstract float ReinforcementMultiplier { get; }
        public readonly int UpgradeLevel;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public BaseCyclopsReinforcementModule(int upgradeLevel, string description) : base
        (
            "CyclopsReinforcementModuleMK" + String.Concat(Enumerable.Repeat("I", upgradeLevel)),
            "Cyclops Reinforcement Module MK" + String.Concat(Enumerable.Repeat("I", upgradeLevel)),
            description
        )
        {
            this.UpgradeLevel = upgradeLevel;
        }

        public override EquipmentType EquipmentType => EquipmentType.CyclopsModule;

        public override TechType RequiredForUnlock => TechType.Cyclops;

        public override TechGroup GroupForPDA => TechGroup.VehicleUpgrades;

        public override TechCategory CategoryForPDA => TechCategory.VehicleUpgrades;

        public override CraftTree.Type FabricatorType => CraftTree.Type.CyclopsFabricator;

        public override string[] StepsToFabricatorTab => new[] { "CyclopsModules" };

        public override QuickSlotType QuickSlotType => QuickSlotType.Passive;
        public override IEnumerator GetGameObjectAsync(IOut<GameObject> gameObject)
        {
            var taskResult = new TaskResult<GameObject>();
            yield return CraftData.InstantiateFromPrefabAsync(TechType.CyclopsShieldModule, taskResult);
            var obj = taskResult.Get();

            // Get the TechTags and PrefabIdentifiers
            var techTag = obj.GetComponent<TechTag>();
            var prefabIdentifier = obj.GetComponent<PrefabIdentifier>();

            // Change them so they fit to our requirements.
            techTag.type = TechType;
            prefabIdentifier.ClassId = ClassID;
            gameObject.Set(obj);
        }

        protected Sprite LoadSprite(string file)
        {
            Sprite icon = null;
            var iconPath = Path.Combine(AssetsFolder, file);
            if (File.Exists(iconPath))
            {
                Texture2D texture = ImageUtils.LoadTextureFromFile(iconPath);
                icon = ImageUtils.LoadSpriteFromTexture(texture);
            }
            return icon;
        }
    }
}
