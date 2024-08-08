using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basics.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        //1. Passing an object to the view that will be used as a model
        public ActionResult Index()
        {
            List<string> flowers = new List<string>()
            {
                "Roses","Lillies","Jasmine","Marigold"
            };
            return View(flowers);
        }

        //2. Passing data thru Viewbag and ViewData
        public ActionResult OfficeRules()
        {
            List<string> rules = new List<string>()
            {
                "Be on Time", "Carry ID card", "Avoid T-Shirts",
                "Complete Work as per Deadlines"
            };
            //1. transfer data thru ViewBag
            //ViewBag.offrules = rules;
            //return View();

            //2. transfer data thru Viewdata
            ViewData["followrules"] = rules;
            return View();
        }

        //3. Checking if the ViewBag or ViewData can pass on the information to further request
        public ActionResult TestDataTransfer()
        {
            ViewBag.data1 = "Data One";
            ViewData["data2"] = "Data Two";
             return View();  // 1. Data passed via Viewbag and ViewData to the current view is accessible

            
            // return Redirect("Index"); //2. redirecting to another action method within the same controller

            //return RedirectToAction("Contact", "Home"); //3. redirecting to action method of other controller
        }
    }
}