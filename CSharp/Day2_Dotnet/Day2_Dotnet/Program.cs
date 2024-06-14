using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    class Program
    {
        static void Main()
        {
            //int x = 10;
            //Console.WriteLine("X  before calling a function is {0}", x);
            //CallByValue(x);  //calling a function
            //Console.WriteLine("X after calling the function is {0}", x);
            //Console.WriteLine("++++++++++++++++++");
            //Program program = new Program();
            //Console.WriteLine("X  before calling a function is {0}", x);
            //program.CallByRef(ref x);

            //Console.WriteLine("X after calling the function is {0}", x);

            //Console.WriteLine("-------out parameter-------");
            //int total, prod, diff, div = 0;
            //div = CalculatorFunc(15, 10, out total, out prod, out diff);
            //Console.WriteLine($"Sum is {total}, Product is {prod}, Difference is {diff}, and Division is {div}");
            // Decisionmaking dm = new Decisionmaking();
            // dm.CheckGrade();
            // dm.CheckGradeWithSwitch();
            Loops loops = new Loops();
            // loops.WhileLoop();
            // loops.DoWhileLoop();
            //  Console.WriteLine("-------for loop with jump st. -------");
            // loops.ForLoop();
            // loops.ImplicitTypeExample();
            // ArraysEg.SingleDimension();
            // ArraysEg.TwoDimension();
            ArraysEg.JaggedArray();
            Console.Read();
        }

        public static void CallByValue(int j) //called function
        {
            Console.WriteLine("J is {0}", j);
            j = 100;
            Console.WriteLine("J is {0}", j);            
        }

        public void CallByRef(ref int j)
        {
            Console.WriteLine("J is {0}", j);
            j = 100;
            Console.WriteLine("J is {0}", j);
        }

        public static int CalculatorFunc(int a, int b, out int sum, out int product, out int difference)
        {
            sum = a + b;
            product = a * b;
            difference = a - b;
            return a / b;            
        }
    }
}
