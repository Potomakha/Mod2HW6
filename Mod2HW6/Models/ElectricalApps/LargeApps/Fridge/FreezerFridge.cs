using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2HW6.Models.ElectricalApps.LargeApps.Fridge
{
    public class FreezerFridge : Fridge
    {
        public FreezerFridge()
        {
            FridgeType = FridgeType.Freezer;
        }
    }
}
