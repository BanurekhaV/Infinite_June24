using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day13_CalculatorLibrary;
using Day13_CalculatorLibrary_Extension1;

namespace Calculator_LibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClass cc = new CalculatorClass();
            Console.WriteLine("The Sum of 2 nos :{0}",cc.AddNos(56, 10)); ;
            Console.WriteLine("The Difference of 2 nos :{0}",cc.SubtractNos(25,10));

            Console.WriteLine("The Product of 2 nos :{0}",cc.MultiplyNos(10, 5));
            Console.WriteLine("The Division of 2 nos :{0}", cc.DivideNos(10,5));
            Console.Read();
        }
    }
}
