using Heat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

using Newtonsoft.Json;


namespace Heat.Controllers
{
    
    public class HomeController : Controller
    {
        private HeatEntities db = new HeatEntities();
        public ActionResult Index()
        {
            var couples = db.Couples.Include(c => c.Combo).Include(c => c.DanceLevel).Include(c => c.DanceType).Include(c => c.HeatList).Include(c => c.Pro);
            //var danceLevel = couples.FirstOrDefault().HeatList.Name;
            //ViewBag.LevelStuff = danceLevel;

            Couple firstCouple = (from h in couples
                                  where h.HeatList.Status == "Now"
                                  select h).First();

            string currentHeat = firstCouple.HeatList.Name;
            string danceLevel = firstCouple.DanceLevel.DanceLevel1;
            string combo = firstCouple.Combo.Combo1;
            string danceType = firstCouple.DanceType.Dance;

            ViewBag.CurrentHeat = currentHeat;
            ViewBag.DanceLevel = danceLevel;
            ViewBag.Combo = combo;
            ViewBag.DanceType = danceType;

            return View(couples.ToList()); 
            
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