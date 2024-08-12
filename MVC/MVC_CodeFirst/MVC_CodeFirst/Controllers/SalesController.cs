using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CodeFirst.Models;
using MVC_CodeFirst.Repository;

namespace MVC_CodeFirst.Controllers
{
    public class SalesController : Controller
    {
        IProductRepository<Sales> _salerepo = null;
        // GET: Sales

        public SalesController()
        {
            _salerepo = new ProductRepository<Sales>();
        }
       
        public ActionResult Index()
        {
            var prod = _salerepo.GetAll();
            return View(prod);
        }

        //2. create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Sales s)
        {
            if (ModelState.IsValid)
            {
                _salerepo.Insert(s);
                _salerepo.Save();
                return RedirectToAction("Index");
            }
            return View(s);
        }

        //3. Edit a product
        public ActionResult Edit(int Id)
        {
            var sale = _salerepo.GetById(Id);
            return View(sale);
        }

        [HttpPost]
        public ActionResult Edit(Sales s)
        {
            if (ModelState.IsValid)
            {
                _salerepo.Update(s);
                _salerepo.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(s);
            }
        }

        //4. details of a given product
        public ActionResult Details(int Id)
        {
            var sale = _salerepo.GetById(Id);
            return View(sale);
        }

        //5. deleteing a given product
        public ActionResult Delete(int Id)
        {
            var sale = _salerepo.GetById(Id);
            return View(sale);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int Id)
        {
            var sale = _salerepo.GetById(Id);
            _salerepo.Delete(Id);
            _salerepo.Save();
            return RedirectToAction("Index");
        }
    }
}