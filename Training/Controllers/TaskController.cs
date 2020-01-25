using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training.Models;

namespace Training.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetTaskDetails()
        {
            TaskProgram db = new TaskProgram();
            var result = db.GetTask();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}