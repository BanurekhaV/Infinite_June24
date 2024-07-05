using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_Unity.Interfaces;

namespace DI_Unity.Data_Layer
{
    class Products : IProducts
    {
        public string InsertProducts()
        {
            string str = "DI Injection Successful.. ";
            Console.WriteLine(str);
            return "Product Inserted Successfully";
         }
    }
}
