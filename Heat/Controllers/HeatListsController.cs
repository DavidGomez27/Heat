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
    public class HeatListsController : Controller
    {
        private HeatEntities db = new HeatEntities();

        // GET: HeatLists
        public ActionResult Index()
        {
            return View(db.HeatLists.ToList());
        }

        // GET: HeatLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeatList heatList = db.HeatLists.Find(id);
            if (heatList == null)
            {
                return HttpNotFound();
            }
                        
            var viewModel = new HeatCoupleViewModel
            {                
                heatlist = heatList,
                couples = (from couple in db.Couples
                           where couple.HeatList.Name.Contains(heatList.Name)                                                      
                           select couple).ToList()
            };

            return View(viewModel);

        }

        // GET: HeatLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeatLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HeatListID,Status,Time,Name")] HeatList heatList)
        {
            if (ModelState.IsValid)
            {
                db.HeatLists.Add(heatList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(heatList);
        }

        // GET: HeatLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeatList heatList = db.HeatLists.Find(id);
            if (heatList == null)
            {
                return HttpNotFound();
            }
            return View(heatList);
        }

        // POST: HeatLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HeatListID,Status,Time,Name")] HeatList heatList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(heatList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(heatList);
        }

        // GET: HeatLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeatList heatList = db.HeatLists.Find(id);
            if (heatList == null)
            {
                return HttpNotFound();
            }
            return View(heatList);
        }

        // POST: HeatLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HeatList heatList = db.HeatLists.Find(id);
            db.HeatLists.Remove(heatList);
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
