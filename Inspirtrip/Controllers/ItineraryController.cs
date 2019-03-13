using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Inspirtrip.DAL;
using Inspirtrip.Models;

namespace Inspirtrip.Controllers
{
    public class ItineraryController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Itinerary
        public ActionResult Index()
        {
            var itineraries = db.Itineraries.Include(i => i.User);
            return View(itineraries.ToList());
        }

        // GET: Itinerary/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itineraries.Find(id);
            if (itinerary == null)
            {
                return HttpNotFound();
            }
            return View(itinerary);
        }

        // GET: Itinerary/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.Users, "ID", "Firstname");
            return View();
        }

        // POST: Itinerary/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Cost,CoverPage,UserID")] Itinerary itinerary)
        {
            if (ModelState.IsValid)
            {
                db.Itineraries.Add(itinerary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.Users, "ID", "Firstname", itinerary.UserID);
            return View(itinerary);
        }

        // GET: Itinerary/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itineraries.Find(id);
            if (itinerary == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.Users, "ID", "Firstname", itinerary.UserID);
            return View(itinerary);
        }

        // POST: Itinerary/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Cost,CoverPage,UserID")] Itinerary itinerary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itinerary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.Users, "ID", "Firstname", itinerary.UserID);
            return View(itinerary);
        }

        // GET: Itinerary/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itineraries.Find(id);
            if (itinerary == null)
            {
                return HttpNotFound();
            }
            return View(itinerary);
        }

        // POST: Itinerary/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Itinerary itinerary = db.Itineraries.Find(id);
            db.Itineraries.Remove(itinerary);
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
