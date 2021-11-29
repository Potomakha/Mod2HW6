using Mod2HW6.Models.ElectricalApps;

namespace Mod2HW6.Interfaces
{
    public interface IDeviceContainer
    {
        public bool Add(ElectricalApps item);
        public ElectricalApps[] GetComponents();
    }
}
