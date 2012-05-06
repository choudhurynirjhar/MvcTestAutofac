using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAutofacTest.Service;

namespace MvcAutofacTest.Controllers
{
    public class HomeController : Controller
    {
        private IWeatherDataProvider weather;

        public HomeController(IWeatherDataProvider weather)
        {
            this.weather = weather;
        }

        public ActionResult Index()
        {
            ViewBag.Message = weather.GetWeatherInfo(07801)["Low Temp"];

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
