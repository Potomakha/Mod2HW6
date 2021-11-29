using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2HW6.Models.ElectricalApps.KitchenApp
{
    public abstract class KitchenApp : ElectricalApps
    {
        public KitchenApp()
        {
            ApplianceType = ApplianceType.Kitchen;
        }

        public KitchenAppType KitchenAppType { get; init; }
    }
}
