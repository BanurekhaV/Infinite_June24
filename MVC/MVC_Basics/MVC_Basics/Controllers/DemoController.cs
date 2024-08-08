using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //1. Normal Method that returns a string
        public string NormalMethod()
        {
            return "Hi All !!";
        }

        //2. ViewResult method

        public ViewResult Viewmethod()
        {
            return View();
        }

        //3. ContentResult method
        public ContentResult contentmethod()
        {
            return Content("Happy Day!!", "text/plain");
           // return Content("<h1>Good Morning All</h1>", "text/html");
        }

        //4. empty result method returns nothing
        //can be used to redirect to another action method or can be made non actionable
        [NonAction]
        public EmptyResult Empty()
        {
            int amt = 45000;
            float si = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        //5. jsonresult method
        public JsonResult EmpData()
        {
            Employee employee = new Employee();
            employee.Id = 101;
            employee.Name = "Apurupa";
            employee.Age = 26;
            return Json(employee,JsonRequestBehavior.AllowGet);
        }

        //6. Redirect method
        public ActionResult redirectmethod()
        {
           // return RedirectToAction("Empdata");  //redirecting to the action method of the same controller
            return RedirectToAction("About", "Home");  //redirecting to the action method of other controller
        }
    }
}