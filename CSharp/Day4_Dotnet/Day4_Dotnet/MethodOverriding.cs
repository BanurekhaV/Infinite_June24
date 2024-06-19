using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class Shape
    {
        protected float R , L, B;

        //function to calculate Area of shape
        public virtual float Area()  //marking a function virtual allows the derived classes to override
        {
            return 3.14f * R ;
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.Write("Enter Length :");
            L = float.Parse(Console.ReadLine());

            Console.Write("Enter Breadth :");
            B = float.Parse(Console.ReadLine());
        }

        public override float Area()  // redefining the base class method in child class
        {
            GetLB();
            return L * B;
        }
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.WriteLine("enter Radius");
            R = Convert.ToSingle(Console.ReadLine());
        }
        public override float Area()
        {
            GetRadius();
            return 3.14f * R * R;
        }
    }
    class MethodOverriding
    {

        public static void Main()
        {
            //Rectangle r = new Rectangle();
            //r.GetLB();
            //Console.WriteLine(r.Area());
            //Circle c = new Circle();
            //c.GetRadius();
            //Console.WriteLine(c.Area()); 

            Shape shape = new Shape();
            Console.WriteLine("Original shape objects address {0}", shape.GetHashCode());
            float area = shape.Area();  // give 0 as output
            Console.WriteLine(area);

            shape = new Rectangle();  // co variance
            Console.WriteLine("Current shape objects address {0}", shape.GetHashCode());
            Console.WriteLine(shape.Area());  // gives some valid output based on the input

            shape = new Circle();
            Console.WriteLine("Latest shape objects address {0}", shape.GetHashCode());
            Console.WriteLine(shape.Area());            
            Console.Read();
        }
    }
}
