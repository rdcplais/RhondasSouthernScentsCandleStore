using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RhondasSouthernScentsCandleStore.Models;

namespace RhondasSouthernScentsCandleStore.Controllers
{
    public class StoreManagerController : Controller
    {
        private RhondasSouthernScentsCandleStoreEntities db = new RhondasSouthernScentsCandleStoreEntities();

        // GET: StoreManager
        public ActionResult Index()
        {
            var candles = db.Candles.Include(c => c.CandleCategory).Include(c => c.Scent);
            return View(candles.ToList());
        }

        // GET: StoreManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candle candle = db.Candles.Find(id);
            if (candle == null)
            {
                return HttpNotFound();
            }

            ViewBag.CandleCategoryID = new SelectList(db.CandleCategories, "CandleCategoryID", "CategoryName", candle.CandleCategoryID);
            ViewBag.ScentID = new SelectList(db.Scents, "ScentID", "ScentName", candle.ScentID);
            return View(candle);
        }

        // GET: StoreManager/Create
        public ActionResult Create()
        {
            ViewBag.CandleCategoryID = new SelectList(db.CandleCategories, "CandleCategoryID", "CategoryName");
            ViewBag.ScentID = new SelectList(db.Scents, "ScentID", "ScentName");
            return View();
        }

        // POST: StoreManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CandleID,CandleCategoryID,ScentID,CandleDesc,Price,CandleImgUrl")] Candle candle)
        {
            if (ModelState.IsValid)
            {
                db.Candles.Add(candle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CandleCategoryID = new SelectList(db.CandleCategories, "CandleCategoryID", "CategoryName", candle.CandleCategoryID);
            ViewBag.ScentID = new SelectList(db.Scents, "ScentID", "ScentName", candle.ScentID);
            return View(candle);
        }

        // GET: StoreManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candle candle = db.Candles.Find(id);
            if (candle == null)
            {
                return HttpNotFound();
            }
            ViewBag.CandleCategoryID = new SelectList(db.CandleCategories, "CandleCategoryID", "CategoryName", candle.CandleCategoryID);
            ViewBag.ScentID = new SelectList(db.Scents, "ScentID", "ScentName", candle.ScentID);
            return View(candle);
        }

        // POST: StoreManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CandleID,CandleCategoryID,ScentID,CandleDesc,Price,CandleImgUrl")] Candle candle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candle).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CandleCategoryID = new SelectList(db.CandleCategories, "CandleCategoryID", "CategoryName", candle.CandleCategoryID);
            ViewBag.ScentID = new SelectList(db.Candles, "ScentID", "ScentName", candle.ScentID);
            return View(candle);
        }

        // GET: StoreManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candle candle = db.Candles.Find(id);
            if (candle == null)
            {
                return HttpNotFound();
            }
            return View(candle);
        }

        // POST: StoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Candle candle = db.Candles.Find(id);
            db.Candles.Remove(candle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
