using Petsani.Helper;
using Petsani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Petsani.Controllers
{
    public class MessageSaveController : Controller
    {
        // GET: MessageSave
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(mContact Messa)
        {
            mContact Mesaj = new mContact();
            {
                Mesaj.Name = Messa.Name;
                Mesaj.Email = Messa.Email;
                Mesaj.Message = Messa.Message;
                Mesaj.Tel = Messa.Tel;
                Mesaj.Time = DateTime.Now;
                
            }
            hDB db = new hDB();
            db.Message.Add(Mesaj);
            db.SaveChanges();
            return View();
        }

        public JsonResult List()
        {
            hDB db = new hDB();
            var message=db.Message.ToList();
            return Json(message, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Detail(int id)
        {
            hDB db = new hDB();
            var message= db.Message.FirstOrDefault(x=> x.ID==id);
            return Json(message, JsonRequestBehavior.AllowGet);

        }
    }
}