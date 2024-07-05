using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_Unity.Interfaces;

namespace DI_Unity.Business_Layer
{
    class Business      //dependent class/object
    {
        //creating objects of the Abstraction inorder to be injected with the dependency
        IProducts products;
        IOrders orders;

        //DI in the constructor
        public Business(IProducts ip, IOrders io)
        {
            products = ip;
            orders = io;
        }

        public string InsertProducts()
        {
            return products.InsertProducts(); // these calls are actually directed to the implementing classes

        }

        public void DisplayOrders()
        {
            orders.DisplayOrders();
        }
                
    }
}
