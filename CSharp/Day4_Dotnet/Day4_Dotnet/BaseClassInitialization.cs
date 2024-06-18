using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class Parent
    {
        int x;
        //internal Parent()   // empty constructor
        //{
        //    Console.WriteLine("This is the Parent..");
        //}
        public Parent(int i)
        {
            x = i;
            Console.WriteLine("Parents Data " + x);
        }
    }

    class Child : Parent
    {
        int y;
        public Child(int a, int b) : base(b)
        {
            Console.WriteLine("This is Child ...");
            y = a;
            Console.WriteLine("Childs Data " + y);
        }


        
    }
    class BaseClassInitialization
    {
        public static void Main()
        {
            Child c = new Child(10,22);
            Console.Read();
        }
    }
}
