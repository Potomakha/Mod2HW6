namespace Mod2HW6.Models.ElectricalApps.LargeApps
{
    public abstract class LageApps : ElectricalApps
    {
        public LageApps()
        {
            ApplianceType = ApplianceType.Large;
        }

        public LargeAppType LargeAppType { get; init; }
    }
}
