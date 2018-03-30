using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weather.Models;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WeatherJS()
        {
            return View();
        }
        public ActionResult WeatherOrNot()
        {
            return View();
        }

        public ActionResult PinnedMap()
        {
            return View();
        }
        public ActionResult GoogleSearchAPI()
        {
            return View();
        }

        public JsonResult GetWeather()
        {
            WeatherClass weath = new WeatherClass ();

            return Json(weath.getWeatherForecast(),JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetForecast()
        {
            WeatherClass forecast = new WeatherClass();

            return Json(forecast.getThreeDay(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}