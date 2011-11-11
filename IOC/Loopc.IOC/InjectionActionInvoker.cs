using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;

namespace Loopc.IOC
{
    public class InjectionActionInvoker : ControllerActionInvoker
    {
        readonly IKernel _kernel;

        public InjectionActionInvoker(IKernel kernel)
        {
            _kernel = kernel;
        }

        protected override ActionExecutedContext InvokeActionMethodWithFilters(
            ControllerContext controllerContext,
            IList<IActionFilter> filters,
            ActionDescriptor actionDescriptor,
            IDictionary<string, object> parameters)
        {
            foreach (IActionFilter actionFilter in filters)
            {
                _kernel.Inject(actionFilter);
            }
            return base.InvokeActionMethodWithFilters(controllerContext, filters, actionDescriptor, parameters);
        }
    }
}
