using Loopc.Service.IServiceProvider;
using Loopc.Service.ServieImplementation;
using Ninject.Modules;

namespace Loopc.IOC.BindingModule
{
    public class ServiceBindingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IConfigurationService>().To<ConfigurationService>().InSingletonScope();
        }
    }
}
