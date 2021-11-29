using Microsoft.Extensions.DependencyInjection;
using Mod2HW6.Interfaces;
using Mod2HW6.Services;

namespace Mod2HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IDeviceContainer, ElectricalNetworkService>()
                .AddTransient<IPowerCalculation, PowerCalculationService>()
                .AddTransient<IConfiguration, ConfigurationService>()
                .AddTransient<INetworkInitialize, NetworkInitService>()
                .AddTransient<IReadFile, FileReader>()
                .AddTransient<Starter>()
                .BuildServiceProvider();
            var start = serviceProvider.GetService<Starter>();
            start.Run();
        }
    }
}
