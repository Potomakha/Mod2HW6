namespace Mod2HW6.Models.ElectricalApps.KitchenApp.Microwave
{
    public abstract class Microwave : KitchenApp
    {
        public Microwave()
        {
            KitchenAppType = KitchenAppType.Microwave;
        }

        public ControlType ControlType { get; init; }
    }
}
