using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Dotnet
{
    class Readonly_Constant_StaticEg
    {
        //readonly variables declaration
        public readonly int myvar1;  //assigning value to a readonly at the time of decl. for each object but cannot modified
        public readonly int mydata;
        int x; //non static member, available for each object and can be modified
        const float PI = 3.14f; //constant member, 1 per class not modifiable
        static int y = 200; //static member, 1 per class and modifiable



        //constructor
        public Readonly_Constant_StaticEg()
        {
            Console.WriteLine(myvar1);
            myvar1 = 20;
           // mydata = "Readonly Variable";
            Console.WriteLine("Value of Myvar is {0}, and mydata is :{1}", myvar1, mydata);
        }

        public static void Main()
        {
            Readonly_Constant_StaticEg rcs = new Readonly_Constant_StaticEg();
            Console.WriteLine(rcs.myvar1 + " " + rcs.mydata);
            Readonly_Constant_StaticEg rcs2 = new Readonly_Constant_StaticEg();
            Console.WriteLine("Rcs2 data " + rcs2.mydata + " " + rcs2.myvar1);
            Console.WriteLine(PI);
           // rcs.myvar1 = 1;  //not possible
            rcs.x = 10;
            rcs2.x = 100;
            Console.WriteLine($"X is {rcs.x}, Y is {y}, Myvar1 is {rcs.myvar1}, and Constant is {PI} ");
            // PI = 6.6f;  //not possible
            Readonly_Constant_StaticEg.y = 300;
            y = 500;
            Console.WriteLine($"X is {rcs.x}, Y is {y}, Myvar1 is {rcs.myvar1}, and Constant is {PI} ");
            Console.Read();
        }
    }
}
