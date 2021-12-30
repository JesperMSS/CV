using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CV_Siten.Models;

namespace CV_Siten.Controllers
{
    public class WorkplacesController : Controller
    {
        private DB db = new DB();

        // GET: Workplaces
        public ActionResult Index()
        {
            return View(db.Workplaces.ToList());
        }

        // GET: Workplaces/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workplace workplace = db.Workplaces.Find(id);
            if (workplace == null)
            {
                return HttpNotFound();
            }
            return View(workplace);
        }

        // GET: Workplaces/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Workplaces/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,City")] Workplace workplace)
        {
            if (ModelState.IsValid)
            {
                db.Workplaces.Add(workplace);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workplace);
        }

        // GET: Workplaces/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workplace workplace = db.Workplaces.Find(id);
            if (workplace == null)
            {
                return HttpNotFound();
            }
            return View(workplace);
        }

        // POST: Workplaces/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,City")] Workplace workplace)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workplace).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workplace);
        }

        // GET: Workplaces/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workplace workplace = db.Workplaces.Find(id);
            if (workplace == null)
            {
                return HttpNotFound();
            }
            return View(workplace);
        }

        // POST: Workplaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Workplace workplace = db.Workplaces.Find(id);
            db.Workplaces.Remove(workplace);
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
