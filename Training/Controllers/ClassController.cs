using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training.Models;

namespace Training.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetClassDetails()
        {
            ClassProgram db = new ClassProgram();
            var result = db.GetClasses();
            return Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}