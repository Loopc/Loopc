using System.Web;
using System.Web.Mvc;

namespace Loopc.IOC
{
    public class InjectionHttpApplication : HttpApplication
    {
        public override void Init()
        {
            ControllerBuilder.Current.SetControllerFactory(new InjectionControllerFactory(new InjectionRepository().Kernel));
        }
    }
}
