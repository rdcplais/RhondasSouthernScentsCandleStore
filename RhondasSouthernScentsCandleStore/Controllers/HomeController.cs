using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RhondasSouthernScentsCandleStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //        var candlecategories = new List<candle>
            //{
            //    new CandleCategory { Name = "Disco"},
            //    new CandleCategory { Name = "Jazz"},
            //    new CandleCategory { Name = "Rock"}
            //};
            //        return View(genres);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Everything you want to know...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Rhonda's Place";

            return View();
        }
    }
}