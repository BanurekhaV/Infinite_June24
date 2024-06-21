using System;
using System.Collections.Generic;



namespace Day7_Dotnet
{
    interface ICustomer
    {
        void Print(string msg);
        int Add(int x, int y, int z);            
    }

    interface ISupplier : IOrders    // an interface inheriting from other interfaces
    {
        void DoPurchase(int qty);
    }

    interface IOrders : IProducts
    {
        void PrintOrders();
    }
    class Customer : ICustomer,ISupplier  //class implementing more than 1 interface
    {
        public int Add(int x, int y, int z)
        {
            z = x + y;
            return z;
        }

        public void Print(string msg)
        {
            Console.WriteLine("Printing ICustomer .." + msg);
        }

        public void DoPurchase(int qty)
        {
            Console.WriteLine("Placed a purchase order for {0} items", qty);
        }

        public void PrintOrders()
        {
            Console.WriteLine("Order is ready for despatch..");
        }

        public string ProductDetails()
        {
            return "All product details are here..";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //will invoke all implementations with the object of the class
            Customer cust = new Customer();
            Console.WriteLine(cust.Add(12,16,0));
            cust.Print("Message");
            cust.DoPurchase(10);
            cust.PrintOrders();

            Console.WriteLine("---------With Interface Instance Reference ---------");
            ICustomer icust = new Customer();
            Console.WriteLine(icust.Add(100, 200, 0));
            icust.Print("Using Interface reference object");

            ISupplier isupp = new Customer();
            isupp.DoPurchase(100);
            isupp.PrintOrders();
            Console.Read();
        }
    }
}
