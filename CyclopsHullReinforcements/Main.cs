using System.Collections.Generic;
using HarmonyLib;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using CyclopsHullReinforcements.Modules;
using CyclopsReinforcementUpgrades.Modules;

namespace CyclopsHullReinforcements
{
    [BepInPlugin(GUID, PluginName, VersionString)]
    public class Main : BaseUnityPlugin
    {
        private const string PluginName = "CyclopsHullReinforcementsUpgradesBepinex";
        private const string VersionString = "1.0.0";
        private const string Author = "JensDL";
        private const string GUID = "com.jensdl.cyclopshullreinforcementsupgrades";

        public static ManualLogSource Log = new ManualLogSource(PluginName);
        internal static CyclopsReinforcementModuleMKI CyclopsReinforcementModuleMKI = new();
        internal static CyclopsReinforcementModuleMKII CyclopsReinforcementModuleMKII = new();
        internal static CyclopsReinforcementModuleMKII CyclopsReinforcementModuleMKIII = new();

        internal static List<BaseCyclopsReinforcementModule> CyclopsReinforcementModules = new()
        {
            CyclopsReinforcementModuleMKI,
            CyclopsReinforcementModuleMKII,
            CyclopsReinforcementModuleMKII
        };
        /// <summary>
        /// Initialise the configuration settings and patch methods
        /// </summary>
        private void Awake()
        {
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), GUID);
            CyclopsReinforcementModules.ForEach(m => m.Patch());
            Logger.LogInfo($"[{PluginName} {VersionString}] loaded");
            Log = Logger;
        }
    }
}
