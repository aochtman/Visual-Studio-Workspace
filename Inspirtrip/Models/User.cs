﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspirtrip.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}