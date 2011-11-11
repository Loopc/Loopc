using System.Web.Mvc;
using Loopc.UI.Auth.ViewModel;

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

        [HttpPost]
        public JsonResult Login(string email, string password)
        {
            return Json(new JsonResultViewModel { });
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Register(string email, string password)
        {
            return Json(new JsonResultViewModel { });
        }

        public ActionResult Forgotten()
        {
            return View();
        }
    }
}
