using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Dotnet
{
    interface IProducts
    {
        string ProductDetails();
    }

    interface ISales 
    {
        string ProductDetails();
    }

    class Business : IProducts, ISales
    {
        //explicit implementation of a method of an interface by referencing the interface name
        string IProducts.ProductDetails()  // does not allow modifiers/specifiers if explicit
        {
            return "This is ProductDetails Method of IProducts";
        }

        string ISales.ProductDetails()
        {
            return "This is ProductDetails Method of ISales";
        }

        //default interface method, that can be accessed using the implenting class
        public string ProductDetails()  // does not allow modifiers/specifiers if explicit
        {
            return "This is ProductDetails Method of IProducts";
        }

        public static void Main()
        {
            Business business = new Business();
            // business.   //cannot access implemented methods with the class object
            //but we can access it with

            //1. by making the implementing class object typecasted to an interface
            Console.WriteLine(((IProducts)business).ProductDetails());

            Console.WriteLine(((ISales)business).ProductDetails()); 

            Console.WriteLine("*******************");

            //2. interface reference variable
            IProducts iprd = new Business();
            ISales isl = new Business();

            Console.WriteLine(iprd.ProductDetails()); 
            Console.WriteLine(isl.ProductDetails());

            Console.WriteLine("-----------------");
            Console.WriteLine(business.ProductDetails());   // calling the default inetrface method

            Console.Read();
        }
    }
}
