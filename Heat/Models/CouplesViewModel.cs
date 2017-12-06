using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Heat.Models
{
    public class CouplesViewModel
    {
        private Couple couple { get; set; }
        public ICollection<Couple> couplesInfo {get;set;}
    }
}