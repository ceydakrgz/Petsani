using Petsani.Helper;
using Petsani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Petsani.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Biz kimiz.";
            mUsers m = new mUsers()
            {
                Name = "Ceyda",
                LastName = "Karagöz",
                EMail = "ceydaakaragoz@gmail.com",
                Password = "123",
                UserType = 1,
                Status = true

            };
            hDB db = new hDB();
            db.Users.Add(m);
            db.SaveChanges();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "İletişimde olalım.";

            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
    }
}