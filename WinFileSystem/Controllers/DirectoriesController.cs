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
    public class DirectoriesController : Controller
    {
        private WinFileSystemContext db = new WinFileSystemContext();

        // GET: Directories
        public ActionResult Index()
        {
            return View(db.Directories.ToList());
        }

        // GET: Directories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Directory directory = db.Directories.Find(id);
            if (directory == null)
            {
                return HttpNotFound();
            }
            return View(directory);
        }

        // GET: Directories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Directories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Directory directory)
        {
            if (ModelState.IsValid)
            {
                db.Directories.Add(directory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(directory);
        }

        // GET: Directories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Directory directory = db.Directories.Find(id);
            if (directory == null)
            {
                return HttpNotFound();
            }
            return View(directory);
        }

        // POST: Directories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DirId,DirectoryName,Address,CurrentLength,MaximumLength,lastDateAccessed,LastUpdated,OwnerId")] Directory directory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(directory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(directory);
        }

        // GET: Directories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Directory directory = db.Directories.Find(id);
            if (directory == null)
            {
                return HttpNotFound();
            }
            return View(directory);
        }

        // POST: Directories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Directory directory = db.Directories.Find(id);
            db.Directories.Remove(directory);
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
