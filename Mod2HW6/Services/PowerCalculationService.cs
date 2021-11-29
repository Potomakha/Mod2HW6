using Mod2HW6.Interfaces;
using Mod2HW6.Models.ElectricalApps;

namespace Mod2HW6.Services
{
    public class PowerCalculationService : IPowerCalculation
    {
        public int TotalPower(ElectricalApps[] array)
        {
            var totalPower = 0;
            foreach (var item in array)
            {
                totalPower += item.Power;
            }

            return totalPower;
        }
    }
}
