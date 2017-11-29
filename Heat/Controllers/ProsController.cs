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
    public class ProsController : Controller
    {
        private HeatEntities db = new HeatEntities();

        // GET: Pros
        public ActionResult Index()
        {
            return View(db.Pros.ToList());
        }

        // GET: Pros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro pro = db.Pros.Find(id);
            if (pro == null)
            {
                return HttpNotFound();
            }
            return View(pro);
        }

        // GET: Pros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProID,Name")] Pro pro)
        {
            if (ModelState.IsValid)
            {
                db.Pros.Add(pro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pro);
        }

        // GET: Pros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro pro = db.Pros.Find(id);
            if (pro == null)
            {
                return HttpNotFound();
            }
            return View(pro);
        }

        // POST: Pros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProID,Name")] Pro pro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pro);
        }

        // GET: Pros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro pro = db.Pros.Find(id);
            if (pro == null)
            {
                return HttpNotFound();
            }
            return View(pro);
        }

        // POST: Pros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pro pro = db.Pros.Find(id);
            db.Pros.Remove(pro);
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
