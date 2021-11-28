using Mod2HW6.Interfaces;
using Mod2HW6.Models.ElectricalApps;

namespace Mod2HW6.Services
{
    public class ElectricalNetworkService : IDeviceContainer
    {
        private readonly IConfiguration _configuration;
        private int _capacity;
        private ElectricalApps[] _devices;
        public ElectricalNetworkService(IConfiguration configuration)
        {
            _configuration = configuration;
            ContainerCapacity = _configuration.GetConfig().SeviceContainerConfig.ContainerCapacity;
            Init();
        }

        public int ContainerCapacity { get; set; }

        public bool Add(ElectricalApps item)
        {
            if (_capacity == _devices.Length)
            {
                return false;
            }

            _devices[_capacity] = item;
            _capacity++;

            return true;
        }

        public ElectricalApps[] GetComponents()
        {
            var device = new ElectricalApps[_capacity];

            for (var i = 0; i < device.Length; i++)
            {
                device[i] = _devices[i];
            }

            return device;
        }

        private void Init()
        {
            _capacity = 0;
            _devices = new ElectricalApps[ContainerCapacity];
        }
    }
}
