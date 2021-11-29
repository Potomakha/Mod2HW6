namespace Mod2HW6.Models.ElectricalApps.KitchenApp.CoffeeMachine
{
    public abstract class CoffeeMachine : KitchenApp
    {
        public CoffeeMachine()
        {
            KitchenAppType = KitchenAppType.CoffeeMachine;
        }

        public FillingType FillingType { get; init; }
    }
}
