using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Dotnet
{
    class Parent
    {
        int ID;
        public Parent(int x):this()
        {
            ID = x;
            Console.WriteLine(ID);
        }

        public Parent()
        {
            Console.WriteLine("This is another constructor of the Parent");
        }
    }

    class Child : Parent
    {
        string Name;
        public Child(string s, int a):base(a)
        {
            Name = s;
            Console.WriteLine(Name);
        }
    }
    class Example2_Constructors
    {
        public static void Main()
        {

            //  Parent p = new Parent(6);
            //  Child c = new Child("Hai",8);
            DerivedClass dc = new DerivedClass("Message"); // chaining of constructores in the baseclass
            Console.WriteLine("-------------------"); //
            DerivedClass dc1 = new DerivedClass(55);
            Console.Read();
        }
    }
}
