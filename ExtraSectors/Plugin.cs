using PulsarPluginLoader;

namespace ExtraSectors
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "1.0";

        public override string Author => "pokegustavo";

        public override string ShortDescription => "Re-adds some removed sectors";

        public override string Name => "Extra Sectors";

        public override string HarmonyIdentifier()
        {
            return "pokegustavo.ExtraSectors";
        }
    }
}
