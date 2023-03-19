using HarmonyLib;
using CyclopsReinforcementUpgrades.Utils;

namespace CyclopsReinforcementUpgrades.Patches
{
    /**
     * Patch the CyclopsDamagePoint component, in damge reduction the cyclops
     */
    [HarmonyPatch(typeof(CyclopsDamagePoint))]
    public class CyclopsDamagePoint
    {
       
    }
}