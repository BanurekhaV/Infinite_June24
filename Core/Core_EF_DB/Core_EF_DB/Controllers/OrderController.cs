using Microsoft.AspNetCore.Mvc;
using Core_EF_DB.Repository;

namespace Core_EF_DB.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrderController(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public IActionResult Index()
        {
            return View(_ordersRepository.GetCustOrdersOrders("VINET"));
        }
    }
}
