using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Framework;
using WinFileSystem.Data;

namespace WinFileSystem.Controllers
{
    public class ABSWinFileSystemsController : Controller
    {
        private WinFileSystemContext db = new WinFileSystemContext();

        // GET: ABSWinFileSystems
        public ActionResult Index()
        {
            return View(db.ABSWinFileSystems.ToList());
        }

        // GET: ABSWinFileSystems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ABSWinFileSystem aBSWinFileSystem = db.ABSWinFileSystems.Find(id);
            if (aBSWinFileSystem == null)
            {
                return HttpNotFound();
            }
            return View(aBSWinFileSystem);
        }

        // GET: ABSWinFileSystems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ABSWinFileSystems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FATFileSystem aBSWinFileSystem)
        {
            if (ModelState.IsValid)
            {
                db.ABSWinFileSystems.Add(aBSWinFileSystem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aBSWinFileSystem);
        }

        // GET: ABSWinFileSystems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ABSWinFileSystem aBSWinFileSystem = db.ABSWinFileSystems.Find(id);
            if (aBSWinFileSystem == null)
            {
                return HttpNotFound();
            }
            return View(aBSWinFileSystem);
        }

        // POST: ABSWinFileSystems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FATFileSystem aBSWinFileSystem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aBSWinFileSystem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aBSWinFileSystem);
        }

        // GET: ABSWinFileSystems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ABSWinFileSystem aBSWinFileSystem = db.ABSWinFileSystems.Find(id);
            if (aBSWinFileSystem == null)
            {
                return HttpNotFound();
            }
            return View(aBSWinFileSystem);
        }

        // POST: ABSWinFileSystems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ABSWinFileSystem aBSWinFileSystem = db.ABSWinFileSystems.Find(id);
            db.ABSWinFileSystems.Remove(aBSWinFileSystem);
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
