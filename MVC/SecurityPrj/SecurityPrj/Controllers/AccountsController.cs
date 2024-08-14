using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SecurityPrj.Models;

namespace SecurityPrj.Controllers
{
   
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User umodel)
        {
            using (MVCSecurityDBEntities context = new MVCSecurityDBEntities())
            {
                bool IsvalidUser = context.Users.Any(user => user.UserName.ToLower() ==
                umodel.UserName.ToLower() && user.UserPassword == umodel.UserPassword);

                if(IsvalidUser)
                {
                    FormsAuthentication.SetAuthCookie(umodel.UserName, false);
                    return RedirectToAction("Index", "Employees");
                }
                ModelState.AddModelError("", "Invalid Username or Password");
                return View();
            }
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User u)
        {
            using(MVCSecurityDBEntities context = new MVCSecurityDBEntities())
            {
                context.Users.Add(u);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}