using System.Web.Mvc;
using Ninject.Modules;

namespace Loopc.IOC.BindingModule
{
    public class OtherBindingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ControllerActionInvoker>().To<InjectionActionInvoker>().InSingletonScope();
        }
    }
}
