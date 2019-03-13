using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inspirtrip.Controllers
{
    public class ComingsoonController : Controller
    {
        // GET: Comingsoon
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}