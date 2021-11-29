using Mod2HW6.Configs;
using Mod2HW6.Interfaces;
using Newtonsoft.Json;

namespace Mod2HW6.Services
{
    public class ConfigurationService : IConfiguration
    {
        private const string ConfigPath = "config.json";
        private readonly FileReader _reader;

        public ConfigurationService()
        {
            _reader = new FileReader();
        }

        public Config GetConfig()
        {
            var configFile = _reader.ReadFile("config.json");
            var config = JsonConvert.DeserializeObject<Config>(configFile);

            return config;
        }
    }
}
