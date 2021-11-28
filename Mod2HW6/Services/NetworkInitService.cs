using Mod2HW6.Interfaces;
using Mod2HW6.Models.ElectricalApps;
using Mod2HW6.Models.ElectricalApps.KitchenApp.CoffeeMachine;
using Mod2HW6.Models.ElectricalApps.KitchenApp.Microwave;
using Mod2HW6.Models.ElectricalApps.LargeApps.Fridge;
using Mod2HW6.Models.ElectricalApps.LargeApps.Stove;
using Mod2HW6.Models.ElectricalApps.LargeApps.Washing;

namespace Mod2HW6.Services
{
    public class NetworkInitService : INetworkInitialize
    {
        private readonly ElectricalApps[] _apps;

        public NetworkInitService()
        {
            _apps = new ElectricalApps[]
            {
                new ElectronicMicrowave { Name = "Микроволновка-1", Power = 2000, SwithedOn = true },
                new MechanicalMicrowave { Name = "Микроволновка (старая)", Power = 1992, SwithedOn = false },
                new CapsuleCoffeeMachine { Name = "Кофеделка", Power = 150, SwithedOn = false },
                new Washing { Name = "Стиралка", Power = 31231, SwithedOn = true },
                new ElectroStove { Name = "Плита", Power = 100, SwithedOn = true },
                new FullFridge { Name = "Холодос", Power = 777, SwithedOn = true }
            };
        }

        public ElectricalApps[] GetAll()
        {
            return _apps;
        }
    }
}
