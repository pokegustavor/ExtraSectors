using HarmonyLib;

namespace ExtraSectors
{
    [HarmonyPatch(typeof(PLGalaxy), "Setup")]
    class Patch
    {
        static void Postfix(PLGalaxy __instance, PLRand ___m_RandomGenerator) 
        {
            for (int k = 0; k < 1500; k++)
            {
                PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                {
                    randomSectorInfo.Name = "Grandyos Sys (" + randomSectorInfo.ID + ")";
                    randomSectorInfo.VisualIndication = ESectorVisualIndication.CANYON;
                    break;
                }
            }
            for (int k = 0; k < 1500; k++)
            {
                PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                {
                    randomSectorInfo.VisualIndication = ESectorVisualIndication.MOLTEN_ASTEROID;
                    break;
                }
            }
            for (int k = 0; k < 1500; k++)
            {
                PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction == 4)
                {
                    randomSectorInfo.VisualIndication = ESectorVisualIndication.INFECTED_SPACE_CAVE;
                    break;
                }
            }
            for (int k = 0; k < 1500; k++)
            {
                PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                {
                    randomSectorInfo.VisualIndication = ESectorVisualIndication.SPACE_JELLIES;
                    break;
                }
            }
            for (int k = 0; k < 1500; k++)
            {
                PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                {
                    randomSectorInfo.VisualIndication = ESectorVisualIndication.STRANGE_OBJECT_RAD;
                    break;
                }
            }
            for (int k = 0; k < 1500; k++)
            {
                PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                {
                    randomSectorInfo.Name = "Circulos Sys (" + randomSectorInfo.ID + ")";
                    randomSectorInfo.VisualIndication = ESectorVisualIndication.GREY_PLAINS;
                    break;
                }
            }
            for (int k = 0; k < 1500; k++)
            {
                PLSectorInfo randomSectorInfo = __instance.GetRandomSectorInfo(___m_RandomGenerator.Next());
                if (randomSectorInfo.VisualIndication == ESectorVisualIndication.NONE && randomSectorInfo.MySPI.Faction != 4)
                {
                    randomSectorInfo.Name = "Dynamos Sys (" + randomSectorInfo.ID + ")";
                    randomSectorInfo.VisualIndication = ESectorVisualIndication.CANYON;
                    break;
                }
            }
        }
    }
}
