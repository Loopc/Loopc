using Loopc.Repository.Entity;
using Loopc.Repository.IRepositoryProvider;
using System.Linq;
using System.Data.Linq;

namespace Loopc.Repository.RepositoryImplmentation
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        public Configuration Get(string name)
        {
            using (var db = new LoopcDataContext())
            {
                return (from refer in db.GetTable<Configuration>() where refer.Name == name select refer).SingleOrDefault();
            }
        }
    }
}
