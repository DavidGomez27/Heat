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
    public class CombosController : Controller
    {
        private HeatEntities db = new HeatEntities();

        // GET: Combos
        public ActionResult Index()
        {
            return View(db.Comboes.ToList());
        }

        // GET: Combos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combo combo = db.Comboes.Find(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            return View(combo);
        }

        // GET: Combos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Combos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CouplesComboID,Combo1")] Combo combo)
        {
            if (ModelState.IsValid)
            {
                db.Comboes.Add(combo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(combo);
        }

        // GET: Combos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combo combo = db.Comboes.Find(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            return View(combo);
        }

        // POST: Combos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CouplesComboID,Combo1")] Combo combo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(combo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(combo);
        }

        // GET: Combos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combo combo = db.Comboes.Find(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            return View(combo);
        }

        // POST: Combos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Combo combo = db.Comboes.Find(id);
            db.Comboes.Remove(combo);
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
