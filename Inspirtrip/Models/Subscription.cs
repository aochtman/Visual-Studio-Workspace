using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspirtrip.Models
{
    public class Subscription
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ItineraryID { get; set; }

        public virtual User User { get; set; }
        public virtual Itinerary Itinerary { get; set; }
    }
}