using Heat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Heat.Controllers
{
    
    public class HomeController : Controller
    {
        private HeatEntities db = new HeatEntities();
        public ActionResult Index()
        {
            var couples = db.Couples.Include(c => c.Combo).Include(c => c.DanceLevel).Include(c => c.DanceType).Include(c => c.HeatList).Include(c => c.Pro);      
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