namespace Mod2HW6.Models.ElectricalApps.LargeApps.Washing
{
    public class Washing : LageApps
    {
        public Washing()
        {
            LargeAppType = LargeAppType.Washing;
        }

        public int MaxSpinSpeed { get; init; }
    }
}
