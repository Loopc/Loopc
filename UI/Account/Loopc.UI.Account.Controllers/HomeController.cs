using System.Web.Mvc;
using Loopc.Service.IServiceProvider;
using Loopc.UI.Account.ViewModel;

namespace Loopc.UI.Account.Controllers
{
    public class HomeController : BaseController
    {
        IConfigurationService _configurationService;

        public HomeController(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        public ActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Host = _configurationService.Get("host.account.loopc")
            };

            return View(homeViewModel);
        }
    }
}
