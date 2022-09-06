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
    public class ContactsController : Controller
    {
        private hDB db = new hDB();

        // GET: Contacts
        public ActionResult Index()
        {
            return View(db.Message.ToList());
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mContact mContact = db.Message.Find(id);
            if (mContact == null)
            {
                return HttpNotFound();
            }
            return View(mContact);
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Email,Tel,Message,Time")] mContact mContact)
        {
            if (ModelState.IsValid)
            {
                db.Message.Add(mContact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mContact);
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mContact mContact = db.Message.Find(id);
            if (mContact == null)
            {
                return HttpNotFound();
            }
            return View(mContact);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Email,Tel,Message,Time")] mContact mContact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mContact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mContact);
        }

        // GET: Contacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mContact mContact = db.Message.Find(id);
            if (mContact == null)
            {
                return HttpNotFound();
            }
            return View(mContact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            mContact mContact = db.Message.Find(id);
            db.Message.Remove(mContact);
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
