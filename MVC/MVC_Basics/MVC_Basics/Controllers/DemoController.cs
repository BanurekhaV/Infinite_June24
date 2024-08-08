using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}