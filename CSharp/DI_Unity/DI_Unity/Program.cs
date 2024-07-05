using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using DI_Unity.Interfaces;
using DI_Unity.Data_Layer;

namespace DI_Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object of the Unity Container
            UnityContainer uc = new UnityContainer();

            //register all relevant types
            uc.RegisterType<IProducts, Products>();
            uc.RegisterType<IOrders, Orders>();

            Business_Layer.Business bl = uc.Resolve<Business_Layer.Business>();
            Console.WriteLine(bl.InsertProducts());
            bl.DisplayOrders();
            Console.Read();
        }
    }
}
