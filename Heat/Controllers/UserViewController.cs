using Heat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Heat.Controllers
{
    public class UserViewController : Controller
    {
        private HeatEntities db = new HeatEntities();
        // GET: UserView
        public ActionResult Index()
        {
            var couples = db.Couples.Include(c => c.Combo).Include(c => c.DanceLevel).Include(c => c.DanceType).Include(c => c.HeatList).Include(c => c.Pro);
            
            var firstValue = Enumerable.First(couples);
          
            return View(couples.ToList());
        }
    }
}