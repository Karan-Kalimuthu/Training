using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training.Models;

namespace Training.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStaffDetails()
        {
            StaffProgram db = new StaffProgram();
            var result = db.GetStaff();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //public JsonResult InsertData(string Name, int Age, string Address, string Cource)
        //{
        //    StaffProgram db = new StaffProgram();
        //    var result = db.InsertData(Name: Name, Age: Age,Address:Address,Cource:Cource );
        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}
    }
}