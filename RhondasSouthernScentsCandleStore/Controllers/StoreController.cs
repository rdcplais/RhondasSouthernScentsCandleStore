using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RhondasSouthernScentsCandleStore.Models;

namespace RhondasSouthernScentsCandleStore.Controllers
{
    public class StoreController : Controller
    {
        RhondasSouthernScentsCandleStoreEntities storeDB = new RhondasSouthernScentsCandleStoreEntities();

        // GET: Store
        public ActionResult Index()
        {
            var candlecategories = storeDB.CandleCategories.ToList();
            return View(candlecategories);
        }
        // GET: Browse
        public ActionResult Browse(string candlecategory)
        {
            // Retrieve Candle Category and its Associated Candle from database
            var CandleCategoryModel = storeDB.CandleCategories.Include("Candles").Single(c=> c.CategoryName == candlecategory);
            return View(CandleCategoryModel);
        }
        // GET: Details
        public ActionResult Details(int id)
        {
            var candle = storeDB.Candles.Find(id);
            return View(candle);
        }
    }
}