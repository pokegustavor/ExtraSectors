using PulsarModLoader;

namespace ExtraSectors
{
    public class Mod : PulsarMod
    {
        public override string Version => "1.1";

        public override string Author => "pokegustavo";

        public override string ShortDescription => "Re-adds some removed sectors";

        public override string Name => "Extra Sectors";

        public override string HarmonyIdentifier()
        {
            return "pokegustavo.ExtraSectors";
        }
    }
}
