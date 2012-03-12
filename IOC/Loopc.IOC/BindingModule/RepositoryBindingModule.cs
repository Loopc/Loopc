using Loopc.Repository.IRepositoryProvider;
using Loopc.Repository.RepositoryImplmentation;
using Ninject.Modules;

namespace Loopc.IOC.BindingModule
{
    public class RepositoryBindingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDemoRepository>().To<DemoRepository>().InSingletonScope();
        }
    }
}
