using System;
using System.Web.Mvc;

namespace Loopc.Foundation.Web.Attribute
{
    public class RequireLoginAttribute : ActionFilterAttribute
    {
        private RequireLoginAttribute()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (IsAsync(filterContext))
            {
                filterContext.HttpContext.Response.StatusCode = 500;
                filterContext.Result = null;
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult("Login", null);
            }
        }

        private bool IsAsync(ActionExecutingContext filterContext)
        {
            var request = filterContext.HttpContext.Request.Headers["X-Requested-With"];
            return request != null && request.Equals("XMLHttpRequest", StringComparison.OrdinalIgnoreCase);
        }

        private bool IsAuthenticated()
        {
            return false;
        }
    }
}
