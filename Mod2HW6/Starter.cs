using System;
using System.Text;
using Mod2HW6.Interfaces;
using Mod2HW6.Models.ElectricalApps;
using Mod2HW6.Services;
using Mod2HW6.Extensions;

namespace Mod2HW6
{
    public class Starter
    {
        private readonly IDeviceContainer _deviceContainer;
        private readonly INetworkInitialize _networkInitService;
        private readonly IPowerCalculation _powerCalculation;

        // public Starter()
        // {
        // }
        public Starter(IDeviceContainer deviceContainer, INetworkInitialize networkInitialize, IPowerCalculation powerCalculation)
        {
            _deviceContainer = deviceContainer;
            _networkInitService = networkInitialize;
            _powerCalculation = powerCalculation;
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
            var totalPower = _powerCalculation.TotalPower(devices);

            Display(devices);
            Console.WriteLine($"Результирующая мощность оборудования: {totalPower} B");
            Console.WriteLine(string.Empty);

            Array.Sort(devices, new AppliancesComparerService());
            Console.WriteLine("Массив отсортирован по мощности");
            Display(devices);
            Console.WriteLine(string.Empty);

            Console.WriteLine("Выборка приборов:");
            var filteredArray = devices.Filter("о", 1000);
            Display(filteredArray);
        }

        private void Display(ElectricalApps[] array)
        {
            var deviceInfo = new StringBuilder();

            foreach (var item in array)
            {
                deviceInfo.AppendLine($"{item.Name}. Мощность: {item.Power} В");
            }

            Console.Write(deviceInfo.ToString());
        }
    }
}
