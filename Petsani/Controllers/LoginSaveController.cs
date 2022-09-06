using Petsani.Helper;
using Petsani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Petsani.Controllers
{
    public class LoginSaveController : Controller
    {
        // GET: LoginSave
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(mUsers Users)

        {
            
            hDB db = new hDB();
            Users.Status = true;
            Users.UserType = 2;
            db.Users.Add(Users);
            db.SaveChanges();
            return View();

        }
    }
}