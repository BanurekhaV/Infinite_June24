using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Dotnet
{
    interface IName
    {
        string Name { get; set; }
    }

    class Employee : IName
    {
        public string Name { get; set; }  //class employee has implemented the property of IName
    }

    class Company : IName
    {
        private string _company; // declaring a private field member
        public int _age { get; set; }

        public string Name
        {
            get { return _company; }
            set { _company = value; }
        }

    }
    class Interface_WithProperties
    {
        static void Main()
        {
            IName Emp = new Employee();
            Emp.Name = "Vijendra";

            IName Comp = new Company();
            Comp.Name = "Infinite";  // inherited property of the IName interface

            Company c = new Company();
            c.Name = "Infinite Ltd.,";
            c._age = 20;  //local property of the company class
            Console.WriteLine($"Employee Named {Emp.Name} works for {Comp.Name} which is {c._age} years old and the new Name is {c.Name}");

            Console.Read();

        }
    }
    
}
