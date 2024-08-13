using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomModelBinding.Models;
using CustomModelBinding.CustomBinders;

namespace CustomModelBinding.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index([ModelBinder(typeof(CustomDataBinder))] CustomModel cm)
        {
            //ViewBag.Title = cm.Title;
            ViewBag.perstitle = cm.Title;

            ViewBag.Date = cm.Date;
            return View(cm);
        }

        //for scripts bundle
        public ActionResult BundleMethod()
        {
            return View();
        }
    }
}