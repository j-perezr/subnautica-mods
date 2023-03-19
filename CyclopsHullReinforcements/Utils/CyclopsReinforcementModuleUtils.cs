using System.Linq;
using CyclopsHullReinforcements.Modules;
using CyclopsReinforcementUpgrades.Modules;

namespace CyclopsReinforcementUpgrades.Utils
{
    /**
     * Utils for the mod
     */
    public class CyclopsReinforcementModuleUtils
    {
        /**
         * Get the greater cyclops Reinforcement module installed, if there is anyone
         */
        public static BaseCyclopsReinforcementModule GetInstalled(UpgradeConsole upgradeConsole)
        {
            var installedReinforcementModules =
                upgradeConsole.modules.equipment.Values
                              .Where(m => m != null && m.item != null)
                              .Select
                              (
                                  item => Main.CyclopsReinforcementModules.Find(m => m.TechType == item.techType)
                              )
                              .Where(m => m != null)
                              .OrderByDescending
                              (
                                  item => item.UpgradeLevel
                              )
                              .ToList();
            return installedReinforcementModules.FirstOrDefault();
        }
    }
}