using Core_EF_DB.Models;

namespace Core_EF_DB.Repository    
{
    public interface IOrdersRepository
    {
        List<CustOrdersOrders> GetCustOrdersOrders(string Customerid);
    }
}
