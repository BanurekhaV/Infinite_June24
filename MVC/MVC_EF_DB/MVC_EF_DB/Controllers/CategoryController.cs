using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_DB.Models;

namespace MVC_EF_DB.Controllers
{
    public class CategoryController : Controller
    {
        //create an object of the context class
        NorthwindEntities db = new NorthwindEntities();
        // GET: Category

        //2. creating a scaffolded View for fetching categories 
        public ActionResult Index()
        {
            List<Category> catlist = db.Categories.ToList();
            return View(catlist);
        }

        //1. fetch data from the categories DbSet
        public ActionResult GetCategoryDetails()
        {
            List<Category> catlist = db.Categories.ToList();
            return View(catlist);
        }

        //3. Inserting a new category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //passing data from the view to the controller using model object
        [HttpPost]
        public ActionResult Create(Category c)
        {
            db.Categories.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //4. delete a category
        public ActionResult Delete(int Id)
        {
            Category cat = db.Categories.Find(Id);
            return View(cat);
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteCategory(int Id)
        {
            Category c = db.Categories.Find(Id);
            db.Categories.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //5. Edit a category
        public ActionResult Update(int Id)
        {
            Category c = db.Categories.Find(Id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Update(Category c)
        {
            Category cat = db.Categories.Find(c.CategoryID);
            cat.CategoryName = c.CategoryName;
            cat.Description = c.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //6. getting the deatils of a given category Id
        public ActionResult Details(int Id)
        {
            Category c = db.Categories.Find(Id);
            return View(c);
        }

        //7. get category by name in a sorted 
        public ActionResult GetCategoryByName()
        {
            List<string> sortedcat = (from c in db.Categories
                                      orderby c.CategoryName
                                      select c.CategoryName).ToList();

            return View(sortedcat);
        }
    }
}