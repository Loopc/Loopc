using Loopc.Service.Contract;

namespace Loopc.Repository.Entity
{
    public static class DemoExtension
    {
        public static DemoContract ToDemoContract(this Demo demo)
        {
            return new DemoContract
            {
                Data = demo.Data,
                DateTime = demo.DateTime
            };
        }
    }
}
