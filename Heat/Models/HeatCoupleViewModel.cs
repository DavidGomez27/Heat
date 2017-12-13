using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Heat.Models
{
    public class HeatCoupleViewModel
    {
        public HeatList heatlist { get; set; }
        public ICollection<Couple> couples { get; set; }
      
    }

}
