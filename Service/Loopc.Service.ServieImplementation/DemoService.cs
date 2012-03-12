using Loopc.Repository.Entity;
using Loopc.Repository.IRepositoryProvider;
using Loopc.Service.Contract;
using Loopc.Service.IServiceProvider;

namespace Loopc.Service.ServieImplementation
{
    public class DemoService : IDemoService
    {
        IDemoRepository _demoRepository;

        public DemoService(IDemoRepository demoRepository)
        {
            _demoRepository = demoRepository;
        }

        public DemoContract GetData()
        {
            var data = _demoRepository.GetData();
            return data.ToDemoContract();
        }
    }
}
