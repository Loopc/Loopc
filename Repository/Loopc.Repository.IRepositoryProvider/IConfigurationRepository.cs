using Loopc.Repository.Entity;

namespace Loopc.Repository.IRepositoryProvider
{
    public interface IConfigurationRepository
    {
        Configuration Get(string name);
    }
}
