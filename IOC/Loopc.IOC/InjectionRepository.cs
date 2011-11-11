using Loopc.IOC.BindingModule;
using Ninject;

namespace Loopc.IOC
{
    public class InjectionRepository
    {
        readonly IKernel _kernel;

        public InjectionRepository()
        {
            _kernel = new StandardKernel(new ServiceBindingModule(), new RepositoryBindingModule(), new OtherBindingModule());
        }

        public IKernel Kernel
        {
            get { return this._kernel; }
        }
    }
}
