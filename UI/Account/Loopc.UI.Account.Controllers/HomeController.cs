using System.Web.Mvc;
using Loopc.Service.IServiceProvider;
using Loopc.Service.Contract;

namespace Loopc.UI.Account.Controllers
{
    public class HomeController : BaseController
    {
        IDemoService _demoService;

        public HomeController(IDemoService demoService)
        {
            _demoService = demoService;
        }

        public ActionResult Index()
        {
            var demoContract = _demoService.GetData();
            var demoViewModel = demoContract.ToDemoViewModel();

            return View(demoViewModel);
        }
    }
}
