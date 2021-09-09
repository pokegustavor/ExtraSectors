using HarmonyLib;
using System;

namespace ExtraSectors
{
    [HarmonyPatch(typeof(PLGalaxy), "Setup")]
    class Patch
    {
        static void Postfix(PLGalaxy __instance, PLRand ___m_RandomGenerator) 
        {
            for (int k = 0; k < 3000; k++)
            {
                PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                {
                    randomSectorInfo.Name = __instance.StarNameGenerator.GetName(__instance.Seed + randomSectorInfo.ID) + " Sys (" + randomSectorInfo.ID + ")";
                    randomSectorInfo.MySPI.HasPlanet = true;
                    randomSectorInfo.VisualIndication = ESectorVisualIndication.CANYON;
                    break;
                }
            }
            for (int k = 0; k < 3000; k++)
            {
                PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                {
                    randomSectorInfo.Name = __instance.StarNameGenerator.GetName(__instance.Seed + randomSectorInfo.ID) + " Sys (" + randomSectorInfo.ID + ")";
                    randomSectorInfo.VisualIndication = ESectorVisualIndication.MOLTEN_ASTEROID;
                    break;
                }
            }
            for (int j = 0; j < __instance.GenGalaxyScale * 8; j++)
            {
                for (int k = 0; k < 3000; k++)
                {
                    PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                    if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                    {
                        randomSectorInfo.VisualIndication = ESectorVisualIndication.SPACE_JELLIES;
                        break;
                    }
                }
                for (int k = 0; k < 3000; k++)
                {
                    PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                    if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                    {
                        randomSectorInfo.VisualIndication = ESectorVisualIndication.STRANGE_OBJECT_RAD;
                        break;
                    }
                }
            }
            for (int k = 0; k < 3000; k++)
            {
                PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                {
                    randomSectorInfo.Name = __instance.StarNameGenerator.GetName(__instance.Seed + randomSectorInfo.ID) + " Sys (" + randomSectorInfo.ID + ")";
                    randomSectorInfo.MySPI.HasPlanet = true;
                    randomSectorInfo.VisualIndication = ESectorVisualIndication.GREY_PLAINS;
                    break;
                }
            }
            for (int k = 0; k < 3000; k++)
            {
                PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                {
                    randomSectorInfo.Name = __instance.StarNameGenerator.GetName(__instance.Seed + randomSectorInfo.ID) + " Sys (" + randomSectorInfo.ID + ")";
                    randomSectorInfo.MySPI.HasPlanet = true;
                    randomSectorInfo.VisualIndication = ESectorVisualIndication.CAVE_BASE;
                    break;
                }
            }
        }
        [HarmonyPatch(typeof(PLFactionInfo_Infected), "CreateStartingPoints")]
        class CreateInfectedCave
        {
            static void Postfix(PLGalaxy ___m_Galaxy, int inSeed)
            {
                for (int j = 0; j < ___m_Galaxy.GenGalaxyScale * 8; j++)
                {
                    for (int k = 0; k < 3000; k++)
                    {
                        PLSectorInfo randomSectorInfo = ___m_Galaxy.GetRandomSectorInfo(inSeed + k);
                        if (randomSectorInfo.MySPI.Faction == 4)
                        {
                            randomSectorInfo.VisualIndication = ESectorVisualIndication.INFECTED_SPACE_CAVE;
                            break;
                        }
                    }
                }
            }
        }
        [HarmonyPatch(typeof(PLInfectedCaveEncounter), MethodType.Constructor, new Type[] { typeof(PLEncounter), typeof(int) })]
        class InfectedCave
        {
            static void Postfix(PLInfectedCaveEncounter __instance) 
            {
                __instance.DisableShieldsInSector = true;
            }
        }
    }
}
