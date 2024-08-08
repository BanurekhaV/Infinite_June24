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
            //List<string> flowers = new List<string>()
            //{
            //    "Roses","Lillies","Jasmine","Marigold"
            //};
            //return View(flowers);
            //List<string> st;
            //st = TempData["stores"] as List<string>;
            // return View(st); //working

            return RedirectToAction("TestTempData");
        }

        public ActionResult TestTempData()
        {
            //List<string> st2;
            //st2 = TempData["stores"] as List<string>;
            //inorder to retain the Tempdata values for further request,
            //we should retain the data as below
            // TempData.Keep();
            // return View(st2);

            return RedirectToAction("About", "Home");
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

        //4. using TempData to transfer values across requests
        public ActionResult FirstTempRequest()
        {
            List<string> stationeries = new List<string>()
            {
                "pens", "pencils","erasers","markers","notebooks"
            };
            TempData["stores"] = stationeries;
            // return View(); //1. This is the usual transfer and it works

            return RedirectToAction("SecondTempRequest");
        }

        public ActionResult SecondTempRequest()
        {
            //List<string> stnlist;
            //stnlist = TempData["stores"] as List<string>;
            //return View(stnlist); // working

            return RedirectToAction("index");  //working
        }

        //5. If we want to have action method name and the view name to be different,
        //then we can give the ActionName selector and map it to a view with different name
        //otr change the view name to match the action name

        [ActionName("Test")]
        public ActionResult DifferentName()
        {
            ViewBag.mydata = "Testing with different names";
            return View("DifferentName");
           // return View();
        }
    }
}