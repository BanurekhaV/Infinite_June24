using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewsPrj.Models;

namespace PartialViewsPrj.Controllers
{
    public class ProductController : Controller
    {
        List<Product> productlist;

        public ProductController()
        {
            productlist = new List<Product>()
            {
                new Product{ProductId=1, ProductName="Shoes", Category="Accessories",
                Description="Smooth Soles for Comfort", Price=3500},
                new Product{ProductId=2, ProductName="Watches", Category="Accessories",
                Description="Smart and user friendly", Price=6500},
                new Product{ProductId=3, ProductName="Curtains", Category="Furnishings",
                Description="Valence Type for Windows", Price=3000},
                new Product{ProductId=4, ProductName="Pillows", Category="Beddings",
                Description="Memory Foam for Comfort", Price=2500},
            };
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(productlist);
        }

        public ActionResult AnotherMethod()
        {
            return View(productlist);
        }

        public PartialViewResult GetAllProducts()
        {
            List<Product> prdlist = new List<Product>()
            {
                new Product{ProductId=1, ProductName="Shoes", Category="Accessories",
                Description="Smooth Soles for Comfort", Price=3500},
                new Product{ProductId=2, ProductName="Watches", Category="Accessories",
                Description="Smart and user friendly", Price=6500},
                new Product{ProductId=3, ProductName="Curtains", Category="Furnishings",
                Description="Valence Type for Windows", Price=3000},
                new Product{ProductId=4, ProductName="Pillows", Category="Beddings",
                Description="Memory Foam for Comfort", Price=2500},
            };
            return PartialView("ProductDetails", prdlist);
        }
    }
}