using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelStateEg.Models;

namespace ModelStateEg.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        //a. if validation succeeds
        public ActionResult UserStatus()
        {
            ViewBag.Status = "Validation Successful";
            return View();
        }

        public ActionResult AddUser()
        {
            User user = new User();
            return View(user);
        }

     [HttpPost]
     public ActionResult AddUser(User user)
        {
            if(string.IsNullOrEmpty(user.Lname))
            {
                ModelState.AddModelError("Lname", "Please give value to Last Name");
            }
            if(user.age <21 || user.age >45)
            {
                ModelState.AddModelError("age", "Age has to be between 21 and 45 only");
            }

            if(!ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                TempData["Lastname"] = user.Lname;
                TempData["age"] = user.age;
                TempData.Keep();
                return RedirectToAction("UserStatus");

            }
        }
    }
}