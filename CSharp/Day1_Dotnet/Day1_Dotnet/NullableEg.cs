using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Dotnet
{
    class NullableEg
    {
       public static void nullexample()
        {
            //int ? data1 = null;

            //int data2;
            //if (data1 == null)
            //{
            //    data2 = 0;
            //}
            //else
            //    data2 = (int)data1;  //or

            ////  data2 = data1.Value;
            //Console.WriteLine(data2);

            //null coalescing operator to replace the above code
            int ? data1 = 100;
            int data2 = data1 ?? 0;
            Console.WriteLine(data2);
        }
    }
}
