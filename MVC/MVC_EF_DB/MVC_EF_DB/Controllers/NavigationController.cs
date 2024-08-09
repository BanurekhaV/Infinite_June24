using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_DB.Models;
using System.Data.Entity;

namespace MVC_EF_DB.Controllers
{
    public class NavigationController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }

        //1. Fetching Data from Multiple tables using navigation property
        public ActionResult MultipleData()
        {
           
             return View(db.Orders.ToList());            
        }
               

        public ActionResult MoreData()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.Orderlist = db.Orders.ToList();
            mymodel.Detaillist = db.Order_Details.ToList();
            mymodel.Custlist = db.Customers.ToList();
            mymodel.Emplist = db.Employees.ToList();
            return View(mymodel);
        }
    }

}