using Microsoft.AspNetCore.Mvc;
using Core_EF_DB.Models;
using Core_EF_DB.Repository;
using Core_EF_DB.ViewModel;
using System.Reflection.Metadata.Ecma335;

namespace Core_EF_DB.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository; 

        public ProductController (IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //for viewmodel
        public IActionResult GetProductSupplierDetails()
        {
            dynamic prdsuppinfo = _productRepository.GetProductSupplier();

            List<ProductSupplier> vmodellist = new List<ProductSupplier>();

            foreach (var item in prdsuppinfo)
            {
                ProductSupplier ps = new ProductSupplier();
                ps.ProductId = item.ProductId;
                ps.ProductName = item.ProductName;
                ps.UnitPrice = item.UnitPrice;
                ps.CompanyName = item.CompanyName;

                vmodellist.Add(ps);
            }
            return View(vmodellist);

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
