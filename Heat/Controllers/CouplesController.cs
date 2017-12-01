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
    public class CouplesController : Controller
    {
        private HeatEntities db = new HeatEntities();

        // GET: Couples
        public ActionResult Index(string search)
        {
            var couples = db.Couples.Include(c => c.Combo).Include(c => c.DanceLevel).Include(c => c.DanceType).Include(c => c.HeatList).Include(c => c.Pro);
            var dances = db.Couples.Include(c => c.DanceType);
            //search function for partner name only
            if (!String.IsNullOrEmpty(search))
            {
                couples = from couple in couples
                        where couple.Partner.Contains(search) || couple.Number.Contains(search)
                        || couple.DanceType.Dance.Contains(search) || couple.DanceLevel.DanceLevel1.Contains(search) || couple.Pro.Name.Contains(search)
                        || couple.Combo.Combo1.Contains(search) || couple.HeatList.Name.Contains(search)
                        select couple;
            }

           

            return View(couples.ToList());
        }

        // GET: Couples/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Couple couple = db.Couples.Find(id);
            if (couple == null)
            {
                return HttpNotFound();
            }
            return View(couple);
        }

        // GET: Couples/Create
        public ActionResult Create()
        {
            ViewBag.CouplesComboID = new SelectList(db.Comboes, "CouplesComboID", "Combo1");
            ViewBag.DanceLevelID = new SelectList(db.DanceLevels, "DanceLevelID", "DanceLevel1");
            ViewBag.DanceTypeID = new SelectList(db.DanceTypes, "DanceTypeID", "Dance");
            ViewBag.HeatListID = new SelectList(db.HeatLists, "HeatListID", "Status");
            ViewBag.ProID = new SelectList(db.Pros, "ProID", "Name");
            return View();
        }

        // POST: Couples/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CouplesID,Partner,ProID,HeatListID,Number,DanceLevelID,CouplesComboID,DanceTypeID")] Couple couple)
        {
            if (ModelState.IsValid)
            {
                db.Couples.Add(couple);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CouplesComboID = new SelectList(db.Comboes, "CouplesComboID", "Combo1", couple.CouplesComboID);
            ViewBag.DanceLevelID = new SelectList(db.DanceLevels, "DanceLevelID", "DanceLevel1", couple.DanceLevelID);
            ViewBag.DanceTypeID = new SelectList(db.DanceTypes, "DanceTypeID", "Dance", couple.DanceTypeID);
            ViewBag.HeatListID = new SelectList(db.HeatLists, "HeatListID", "Status", couple.HeatListID);
            ViewBag.ProID = new SelectList(db.Pros, "ProID", "Name", couple.ProID);
            return View(couple);
        }

        // GET: Couples/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Couple couple = db.Couples.Find(id);
            if (couple == null)
            {
                return HttpNotFound();
            }
            ViewBag.CouplesComboID = new SelectList(db.Comboes, "CouplesComboID", "Combo1", couple.CouplesComboID);
            ViewBag.DanceLevelID = new SelectList(db.DanceLevels, "DanceLevelID", "DanceLevel1", couple.DanceLevelID);
            ViewBag.DanceTypeID = new SelectList(db.DanceTypes, "DanceTypeID", "Dance", couple.DanceTypeID);
            ViewBag.HeatListID = new SelectList(db.HeatLists, "HeatListID", "Status", couple.HeatListID);
            ViewBag.ProID = new SelectList(db.Pros, "ProID", "Name", couple.ProID);
            return View(couple);
        }

        // POST: Couples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CouplesID,Partner,ProID,HeatListID,Number,DanceLevelID,CouplesComboID,DanceTypeID")] Couple couple)
        {
            if (ModelState.IsValid)
            {
                db.Entry(couple).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CouplesComboID = new SelectList(db.Comboes, "CouplesComboID", "Combo1", couple.CouplesComboID);
            ViewBag.DanceLevelID = new SelectList(db.DanceLevels, "DanceLevelID", "DanceLevel1", couple.DanceLevelID);
            ViewBag.DanceTypeID = new SelectList(db.DanceTypes, "DanceTypeID", "Dance", couple.DanceTypeID);
            ViewBag.HeatListID = new SelectList(db.HeatLists, "HeatListID", "Status", couple.HeatListID);
            ViewBag.ProID = new SelectList(db.Pros, "ProID", "Name", couple.ProID);
            return View(couple);
        }

        // GET: Couples/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Couple couple = db.Couples.Find(id);
            if (couple == null)
            {
                return HttpNotFound();
            }
            return View(couple);
        }

        // POST: Couples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Couple couple = db.Couples.Find(id);
            db.Couples.Remove(couple);
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
