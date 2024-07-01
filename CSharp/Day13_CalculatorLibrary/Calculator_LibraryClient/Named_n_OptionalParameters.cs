using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_LibraryClient
{
    class Named_n_OptionalParameters
    {
        //named vs positional parameters example
        static double Add(int x, float f, double d)
        {
            return x + f + d;
        }

        //example for optional parameter
        public static int AddNumber(int fnum, [Optional] int secnum)
        {
            return fnum + secnum;
        }

        //default parameter example

        public static int AddGivenNos(int fnumber, int secnumber =10)
        {
            return fnumber + secnumber;
        }
        static void Main()
        {
            //1. Calling the method using postitional parameters
            Console.WriteLine(Add(25, 56.45f, 123.45));  //(int as first parameter, float as second, and double as third)

            //named aeguments can be supplied to the Add function as below:

            Console.WriteLine(Add(x:25, f:56.45f,d:123.45)); //named but positional
            Console.WriteLine(Add(d:123.45,x:25,f:56.45f));

            //positional parameters cannot follow named arguments. It throws compiler error
           // Console.WriteLine(Add(x:25, d: 123.45, 56.45f));

            //named arguments can follow postional arguments
            Console.WriteLine(Add(25, f:56.45f, d: 123.45));
            Console.WriteLine(Add(25, d: 123.45, f: 56.45f));

            Console.WriteLine("----calling Optional Parameter----");
            Console.WriteLine(AddNumber(90,10));


            Console.WriteLine("----calling Default Parameter----");
            Console.WriteLine(AddGivenNos(50,20));
            Console.Read();
        }
    }


}
