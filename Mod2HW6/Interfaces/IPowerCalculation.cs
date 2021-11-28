using Mod2HW6.Models.ElectricalApps;

namespace Mod2HW6.Interfaces
{
    public interface IPowerCalculation
    {
        public int TotalPower(ElectricalApps[] array);
    }
}
