using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dqdK22CNT3Lesson07db.Models;

namespace dqdK22CNT3Lesson07db.Controllers
{
    public class dqdSinhViensController : Controller
    {
        private dqdK22CNT3Lesson07DbEntities db = new dqdK22CNT3Lesson07DbEntities();

        // GET: dqdSinhViens
        public ActionResult Index()
        {
            return View(db.dqdSinhViens.ToList());
        }

        // GET: dqdSinhViens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dqdSinhVien dqdSinhVien = db.dqdSinhViens.Find(id);
            if (dqdSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(dqdSinhVien);
        }

        // GET: dqdSinhViens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dqdSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "dqdMaSV,dqdHoSV,dqdTenSV,dqdNgaySinh,dqdPhai,dqdPhone,dqdEmail,dqdMaKH")] dqdSinhVien dqdSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.dqdSinhViens.Add(dqdSinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dqdSinhVien);
        }

        // GET: dqdSinhViens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dqdSinhVien dqdSinhVien = db.dqdSinhViens.Find(id);
            if (dqdSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(dqdSinhVien);
        }

        // POST: dqdSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "dqdMaSV,dqdHoSV,dqdTenSV,dqdNgaySinh,dqdPhai,dqdPhone,dqdEmail,dqdMaKH")] dqdSinhVien dqdSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dqdSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dqdSinhVien);
        }

        // GET: dqdSinhViens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dqdSinhVien dqdSinhVien = db.dqdSinhViens.Find(id);
            if (dqdSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(dqdSinhVien);
        }

        // POST: dqdSinhViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dqdSinhVien dqdSinhVien = db.dqdSinhViens.Find(id);
            db.dqdSinhViens.Remove(dqdSinhVien);
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
