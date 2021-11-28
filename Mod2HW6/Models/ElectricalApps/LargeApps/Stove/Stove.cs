namespace Mod2HW6.Models.ElectricalApps.LargeApps.Stove
{
    public abstract class Stove : LageApps
    {
        public Stove()
        {
            LargeAppType = LargeAppType.Stove;
        }

        public StoveType StoveType { get; init; }
        public int BurnersNum { get; init; }
    }
}
