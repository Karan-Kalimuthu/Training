using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training.Models;

namespace Training.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Student()
        {
            return View();
        }

        public JsonResult GetStudentDetails()
        {
            StudentProgram db = new StudentProgram();
            var result = db.GetStudent();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //public JsonResult Insertdata(int Age, string Name, DateTime DOB, string Address, string Course)
        //{
        //    StudentProgram db = new StudentProgram();
        //    var result = db.Insertdata(Age: Age, Address: Address, Name: Name, DOB: DOB, Course: Course);
        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}
    }
}