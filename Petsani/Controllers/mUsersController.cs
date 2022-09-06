using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Petsani.Helper;
using Petsani.Models;

namespace Petsani.Controllers
{
    public class mUsersController : Controller
    {
        private hDB db = new hDB();

        // GET: mUsers
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: mUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mUsers mUsers = db.Users.Find(id);
            if (mUsers == null)
            {
                return HttpNotFound();
            }
            return View(mUsers);
        }

        // GET: mUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: mUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,LastName,EMail,Password,UserType,Status")] mUsers mUsers)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(mUsers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mUsers);
        }

        // GET: mUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mUsers mUsers = db.Users.Find(id);
            if (mUsers == null)
            {
                return HttpNotFound();
            }
            return View(mUsers);
        }

        // POST: mUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,LastName,EMail,Password,UserType,Status")] mUsers mUsers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mUsers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mUsers);
        }

        // GET: mUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mUsers mUsers = db.Users.Find(id);
            if (mUsers == null)
            {
                return HttpNotFound();
            }
            return View(mUsers);
        }

        // POST: mUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            mUsers mUsers = db.Users.Find(id);
            db.Users.Remove(mUsers);
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
