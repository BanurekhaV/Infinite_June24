using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Dotnet
{
    class Static_functions_Eg
    {
        //fields
        static int data= 5;
        int x ;
        public static void Main()
        {
            //char c; //one byte is allocated
            //int x; //4 bytes are allocated
            //float f; //8 bytes are allloted
           
            //creating and instantiating an object
            Static_functions_Eg sfe = new Static_functions_Eg();
            Console.WriteLine(sfe.Add(10, 12));
            Console.WriteLine("{0}, {1}", data, sfe.x);
            sfe.x = 15;
            Console.WriteLine("{0}, {1}", data, sfe.x);
            //let us create one more object
            Static_functions_Eg sfe1 = new Static_functions_Eg();
            Console.WriteLine(sfe1.Add(15,15));
            data = 50;
            sfe1.x = 25;
            Console.WriteLine("{0}, {1}", data, sfe1.x);

            Console.WriteLine("------------");
            Console.WriteLine("{0}, {1}", data, sfe.x);
            Console.WriteLine("{0}, {1}", data, sfe1.x);
            // OddNos(5);
            // OnlyStatic.Evennos(5);
            Console.ReadKey();
        }

        //instance function
        public int Add(int x, int y)
        {
           return x + y;
        }

        //static function also known as class function
        public static void OddNos(int x)
        {
            if(x % 2 != 0)
                Console.WriteLine("Number is Odd");
            else
                Console.WriteLine("Number is Even");
        }
    }

    class OnlyStatic
    {
        public static void Evennos(int x)
        {
            if(x % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is not even");
        }
    }
}
