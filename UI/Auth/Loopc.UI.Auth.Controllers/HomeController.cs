using System.Web.Mvc;

namespace Loopc.UI.Auth.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return RedirectToAction("login");
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Forgotten()
        {
            return View();
        }
    }
}
