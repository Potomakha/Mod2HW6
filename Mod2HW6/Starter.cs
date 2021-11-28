using Mod2HW6.Interfaces;
using Mod2HW6.Services;

namespace Mod2HW6
{
    public class Starter
    {
        private readonly IDeviceContainer _deviceContainer;
        private readonly INetworkInitialize _networkInitService;

        // public Starter()
        // {
        // }
        public Starter(IDeviceContainer deviceContainer, INetworkInitialize networkInitialize)
        {
            _deviceContainer = deviceContainer;
            _networkInitService = networkInitialize;
        }

        public void Run()
        {
            var devices = _networkInitService.GetAll();

            for (var i = 0; i < devices.Length; i++)
            {
                if (devices[i].SwithedOn)
                {
                    _deviceContainer.Add(devices[i]);
                }
            }

            devices = _deviceContainer.GetComponents();
        }
    }
}
