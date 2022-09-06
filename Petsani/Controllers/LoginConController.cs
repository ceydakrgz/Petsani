using Petsani.Helper;
using Petsani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;

namespace Petsani.Controllers
{
    public class LoginConController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(mUsers Users)
        {
            hDB db = new hDB();
            var result = db.Users.FirstOrDefault(x=>x.EMail==Users.EMail && x.Password==Users.Password);
            if (result==null)
            {
                //Login failed
                Session["Usr"] = null;
                return RedirectToAction("About","Home");
            }
            else
            {
                Session["Usr"] = result;
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult LoginOut()
        {
            return View();
        }
    }
}