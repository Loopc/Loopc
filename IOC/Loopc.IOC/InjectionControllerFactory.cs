using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;

namespace Loopc.IOC
{
    public class InjectionControllerFactory : DefaultControllerFactory
    {
        readonly IKernel _kernel;

        public InjectionControllerFactory(IKernel kernel)
        {
            _kernel = kernel;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            try
            {
                if (controllerType == null)
                {
                    return base.GetControllerInstance(requestContext, controllerType);
                }

                var controller = _kernel.Get(controllerType) as Controller;
                controller.ActionInvoker = _kernel.Get<ControllerActionInvoker>();
                return controller;
            }
            catch
            {
                return null;
            }
        }

        public override void ReleaseController(IController controller)
        {
            _kernel.Release(controller);
        }
    }
}
