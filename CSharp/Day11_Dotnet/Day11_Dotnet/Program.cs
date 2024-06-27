using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("The number of Generations : " + GC.MaxGeneration);
            Program p = new Program();
           
            Console.WriteLine("The Gen number of the Object P is " + GC.GetGeneration(p));
            Console.WriteLine("The Total Memory : "+ GC.GetTotalMemory(true));
            GC.Collect(0);
            Console.WriteLine("Garbage collection in Gen 0 : "+ GC.CollectionCount(0));

            Console.Read();

        }
    }
}
