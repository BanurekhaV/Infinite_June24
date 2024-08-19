
using Microsoft.EntityFrameworkCore;
using Core_EF_DB.Models;

namespace Core_EF_DB.Repository
{
    public class OrderService :IOrdersRepository
    {
        private readonly NorthwindContext _context;

        public OrderService(NorthwindContext context)
        {
            _context = context;
        }

        public List<CustOrdersOrders> GetCustOrdersOrders(string Customerid)
        {
            //1. calling stored procedure using fromsqlraw()
             List<CustOrdersOrders> orders = _context.CustOrdersOrders.FromSqlRaw("[dbo].[CustOrdersOrders] @p0", new[] { Customerid }).ToList();

            //2. calling stored proc using string interpolation

          //  List<CustOrdersOrders> orders = _context.CustOrdersOrders.FromSqlInterpolated($"CustOrdersOrders @Customerid = {Customerid}").ToList();
            return orders;
        }
    }
}
