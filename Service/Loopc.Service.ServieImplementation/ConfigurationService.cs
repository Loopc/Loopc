using Loopc.Repository.IRepositoryProvider;
using Loopc.Service.IServiceProvider;

namespace Loopc.Service.ServieImplementation
{
    public class ConfigurationService : IConfigurationService
    {
        IConfigurationRepository _configurationRepository;

        public ConfigurationService(IConfigurationRepository configurationRepository)
        {
            _configurationRepository = configurationRepository;
        }

        public string Get(string name)
        {
            var configuration = _configurationRepository.Get(name);
            return configuration == null ? null : configuration.Value;
        }
    }
}
