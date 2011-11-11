using System.Web.Mvc;
using System.Web.Routing;
using Loopc.IOC;

namespace Loopc.UI.Auth.Web
{
    public class MvcApplication : InjectionHttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Login", "login", new { controller = "home", action = "login" });
            routes.MapRoute("Register", "register", new { controller = "home", action = "register" });
            routes.MapRoute("Forgotten", "forgotten", new { controller = "home", action = "forgotten" });

            routes.MapRoute(
                "Default", // 路由名称
                "{controller}/{action}/{id}", // 带有参数的 URL
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // 参数默认值
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }
    }
}