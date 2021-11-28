using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2HW6.Models.ElectricalApps.LargeApps.Stove
{
    public class GasStove : Stove
    {
        public GasStove()
        {
            StoveType = StoveType.Gas;
        }
    }
}
