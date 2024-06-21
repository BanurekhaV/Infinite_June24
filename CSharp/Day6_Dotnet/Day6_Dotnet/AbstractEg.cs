using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{
    abstract class Shape
    {
        protected int R, L, B;
        //declare an abstract method
        abstract public int Area();

        //declare a non-abstract method
        public virtual int Circumference()
        {
            Console.WriteLine("Calculates Circumference of a shape");
            return 1;
        }
    }

    class Square : Shape
    {
        int side;

        public Square(int a)
        {
            side = a;
        }

        public override int Area()
        {
            return side * side;
        }

        public override int Circumference()
        {
            Console.WriteLine("Squares Circumference ..");
            return base.Circumference();
        }
    }
    class AbstractEg
    {
        public static void Main()
        {
            Shape s;  // can declare object of abstract type
                      //  s = new Shape();  but cannot instantiate
            s = new Square(5);
            Console.WriteLine(s.Area());
            Console.WriteLine(s.Circumference());
            Console.Read();
        }
    }
}
