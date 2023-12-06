
using LibraryCommuns.Interfaces;
using Microsoft.Extensions.Configuration;


namespace LibraryCommuns.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfiguration _configuration;

        public ConfigurationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetAppSetting(string key)
        {
            return _configuration[key];
        }

        public T GetAppSetting<T>(string key, T defaultValue = default)
        {
            var value = _configuration[key];
            if (value == null)
            {
                return defaultValue;
            }

            return (T)System.Convert.ChangeType(value, typeof(T));
        }
    }
}
