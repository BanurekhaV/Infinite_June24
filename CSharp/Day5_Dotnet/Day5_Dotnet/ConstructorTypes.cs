using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Dotnet
{
    class ConstructorTypes
    {
        int var1;
        public ConstructorTypes()
        {
            var1 = 6;
            Console.WriteLine("called thru 2nd constructor" + var1);
        }

        public ConstructorTypes(int x) :this()
        {
            
            Console.WriteLine("This is 2nd Constructor");
        }
        static void Main(string[] args)
        {
            ConstructorTypes ct = new ConstructorTypes(5);
            Console.Read();
        }
    }

    //class test 
    //{
    //    public void checkingPrivateConstruction()
    //    {
    //        ConstructorTypes ct1 = new test();

    //    }
    //}
}
