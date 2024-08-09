using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_DB.Models;

namespace MVC_EF_DB.Controllers
{
    public class ShipperController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Shipper
        public ActionResult Index()
        {
            return View(db.Shippers.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //1.  pass data from the view to the controller using forms collection
        public ActionResult Create(FormCollection frm)
        {
            Shipper s = new Shipper();
            s.ShipperID = Convert.ToInt32(frm["ShipperID"]);
            s.CompanyName = frm["CompanyName"].ToString();
            s.Phone = frm["Phone"].ToString();
            db.Shippers.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //2. Passing data from the view to the controller using parameters
        //public ActionResult Create(string CompanyName, string Phone)
        //{
        //    Shipper s = new Shipper();
        //    s.CompanyName = CompanyName;
        //    s.Phone = Phone;
        //    db.Shippers.Add(s);
        //    db.SaveChanges();
        //    return RedirectToAction("index");
        //}

        public ActionResult Edit(int Id)
        {
            Shipper s = db.Shippers.Find(Id);
            return View(s);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection frm)
        {
            Shipper s = db.Shippers.Find(Convert.ToInt32(frm["ShipperID"]));
            s.CompanyName = frm["CompanyName"].ToString();
            s.Phone = frm["Phone"].ToString();
            db.SaveChanges();
            return RedirectToAction("index");
        }

        //calling a stored procedure with input
        public ActionResult SP_WithInput()
        {
            return View(db.CustOrdersOrders("ALFKI"));
        }
    }
}