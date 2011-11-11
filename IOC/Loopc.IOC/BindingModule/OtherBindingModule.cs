using System.Web.Mvc;
using Ninject.Modules;
using Loopc.Foundation.Web.Session;

namespace Loopc.IOC.BindingModule
{
    public class OtherBindingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ControllerActionInvoker>().To<InjectionActionInvoker>().InSingletonScope();
            Bind<ISessionProvider>().To<DefaultSessionProvider>().InSingletonScope();
        }
    }
}
