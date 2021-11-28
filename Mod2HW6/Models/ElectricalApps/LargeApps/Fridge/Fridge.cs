namespace Mod2HW6.Models.ElectricalApps.LargeApps.Fridge
{
    public abstract class Fridge : LageApps
    {
        public Fridge()
        {
            LargeAppType = LargeAppType.Fridge;
        }

        public int UsefulVolume { get; init; }
        public FridgeType FridgeType { get; init; }
    }
}
