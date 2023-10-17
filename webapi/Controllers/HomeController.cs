using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Services;

namespace webapi.Controllers
{
    public class HomeController : Controller
    {
        private StopService stopService;
        
        public HomeController()
        {
            stopService = new StopService();
        }

        /*public List<StopModel> Index()
        {
            var stops = stopService.GetStops();
            return Json(stops.ToArray(), JsonRequestBehavior.AllowGet);
        }*/
    }
}
