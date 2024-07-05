using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_Unity.Interfaces;

namespace DI_Unity.Data_Layer
{
    class Orders : IOrders
    {
        public void DisplayOrders()
        {
            Console.WriteLine("These are the List of Orders...");
        }
    }
}
