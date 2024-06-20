using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Dotnet
{
    class BaseClass
    {
        //parametrized constructor
        public BaseClass(string s):this(2,2.5f)
        {
            Console.WriteLine("Base " + s);
        }

        public BaseClass(int x, float f):this()
        {
            Console.WriteLine(x +  " " + f);
        }
        public BaseClass()
        {
            Console.WriteLine("Instantiated thru Empty constructor ");
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass(string str):base(str)
        {
            Console.WriteLine("Derived");
        }

        public DerivedClass()
        {
        Console.WriteLine("Empty Derived");
        }

        public DerivedClass(int x):this()
        {
            Console.WriteLine(x);
        }
    }
}
