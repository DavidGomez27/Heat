using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Heat.Models;

namespace Heat.Controllers
{
    public class DanceTypesController : Controller
    {
        private HeatEntities db = new HeatEntities();

        // GET: DanceTypes
        public ActionResult Index()
        {
            
            return View(db.DanceTypes.ToList());
        }

        // GET: DanceTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanceType danceType = db.DanceTypes.Find(id);
            if (danceType == null)
            {
                return HttpNotFound();
            }
            return View(danceType);
        }

        // GET: DanceTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DanceTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DanceTypeID,Dance")] DanceType danceType)
        {
            if (ModelState.IsValid)
            {
                db.DanceTypes.Add(danceType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danceType);
        }

        // GET: DanceTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanceType danceType = db.DanceTypes.Find(id);
            if (danceType == null)
            {
                return HttpNotFound();
            }
            return View(danceType);
        }

        // POST: DanceTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DanceTypeID,Dance")] DanceType danceType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danceType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danceType);
        }

        // GET: DanceTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanceType danceType = db.DanceTypes.Find(id);
            if (danceType == null)
            {
                return HttpNotFound();
            }
            return View(danceType);
        }

        // POST: DanceTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DanceType danceType = db.DanceTypes.Find(id);
            db.DanceTypes.Remove(danceType);
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
