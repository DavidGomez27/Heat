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
    public class DanceLevelsController : Controller
    {
        private HeatEntities db = new HeatEntities();

        // GET: DanceLevels
        public ActionResult Index()
        {
            return View(db.DanceLevels.ToList());
        }

        // GET: DanceLevels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanceLevel danceLevel = db.DanceLevels.Find(id);
            if (danceLevel == null)
            {
                return HttpNotFound();
            }
            return View(danceLevel);
        }

        // GET: DanceLevels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DanceLevels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DanceLevelID,DanceLevel1")] DanceLevel danceLevel)
        {
            if (ModelState.IsValid)
            {
                db.DanceLevels.Add(danceLevel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danceLevel);
        }

        // GET: DanceLevels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanceLevel danceLevel = db.DanceLevels.Find(id);
            if (danceLevel == null)
            {
                return HttpNotFound();
            }
            return View(danceLevel);
        }

        // POST: DanceLevels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DanceLevelID,DanceLevel1")] DanceLevel danceLevel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danceLevel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danceLevel);
        }

        // GET: DanceLevels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanceLevel danceLevel = db.DanceLevels.Find(id);
            if (danceLevel == null)
            {
                return HttpNotFound();
            }
            return View(danceLevel);
        }

        // POST: DanceLevels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DanceLevel danceLevel = db.DanceLevels.Find(id);
            db.DanceLevels.Remove(danceLevel);
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
