using Loopc.UI.Account.ViewModel;

namespace Loopc.Service.Contract
{
    public static class DemoContractExtension
    {
        public static DemoViewModel ToDemoViewModel(this DemoContract demoContract)
        {
            return new DemoViewModel
            {
                Data = demoContract.Data,
                DateTime = demoContract.DateTime
            };
        }
    }
}
