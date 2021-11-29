using System;
using System.Collections.Generic;
using Mod2HW6.Models.ElectricalApps;

namespace Mod2HW6.Services
{
    public class AppliancesComparerService : IComparer<ElectricalApps>
    {
        public int Compare(ElectricalApps x, ElectricalApps y)
        {
            if (x.Power > y.Power)
            {
                return 1;
            }
            else if (x.Power < y.Power)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
