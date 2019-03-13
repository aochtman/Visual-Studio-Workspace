using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspirtrip.Models
{
    public class Itinerary
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public double Cost { get; set; }
        public string CoverPage { get; set; }
        public int UserID { get; set; }

        public virtual User User { get; set; }
        //public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}