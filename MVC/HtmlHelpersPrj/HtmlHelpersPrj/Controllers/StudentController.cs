using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelpersPrj.Models;

namespace HtmlHelpersPrj.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //1. strongly types helper
        public ActionResult StronglyTypedHelper()
        {
            return View();
        }

        //2. Templated helper

        public ActionResult TemplatedHelper()
        {
            return View();
        }

        //3. Templated Helper for the entire Model
        public ActionResult TemplateForModel()
        {
            return View();
        }

        //4. Display Template
        public ActionResult StdDetails()
        {
            Student stud = new Student()
            {
                RollNo = 1,
                Name = "Mohit",
                Address = "Mumbai"
            };
            ViewData["stddata"] = stud;
           // return View();
           return View(stud);

        }

        //5. standard helper
        public ActionResult StandardHelper()
        {
            return View();
        }
    }
}