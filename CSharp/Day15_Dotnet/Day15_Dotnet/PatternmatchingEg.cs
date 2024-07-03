using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Dotnet
{
    public class Shape
    {
        public const float PI = 3.14f;
    }

    public class Circle : Shape
    {
        public double radius { get; }

        public Circle(double r)
        {
            radius = r;
        }
    }

    public class Rectangle : Shape
    {
        public double length { get; }
        public double breadth { get; }

        public Rectangle(double l, double b)
        {
            length = l;
            breadth = b;
        }
    }

    class Traingle : Shape
    {
        public double basev { get; }
        public double height { get; }

        public Traingle(double bs, double h)
        {
            basev = bs;
            height = h;
        }
    }

    class PatternmatchingEg
    {
        static void Main()
        {
            Rectangle square = new Rectangle(8, 8);
            DisplayArea(square);
            Rectangle rectangle = new Rectangle(6, 8);
            DisplayArea(rectangle);
            Circle circle = new Circle(7);
            DisplayArea(circle);
            Traingle traingle = new Traingle(10, 5);
            DisplayArea(traingle);
            //Shape s = null;
            //DisplayArea(s);
            Console.Read();
        }

        ////before c# 7.0 usage of is pattern matching
        //public static void DisplayArea(Shape shape)
        //{

        //  //  if(shape is Circle )
        //   // with 7.0
        //    if(shape is Circle c)
        //    {
        //        //Circle c =(Circle) shape;
        //        Console.WriteLine("Area of Circle is :" + c.radius * c.radius * Shape.PI);
        //    }
        //    //else if(shape is Rectangle)
        //    else if(shape is Rectangle r)
        //    {
        //       // Rectangle r = (Rectangle)shape;
        //        Console.WriteLine("Area of Rectangle is :" + r.length * r.breadth);
        //    }
        //   // else if(shape is Traingle)
        //   else if(shape is Traingle t)
        //    {
        //        //Traingle t = (Traingle)shape;
        //        Console.WriteLine("Area of Trianlge is :"+ 0.5 *t.basev * t.height);
        //    }
        //    else
        //    {
        //        throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
        //    }
        //}

        //pattern matching with switch
        //    public static void DisplayArea(Shape shape)
        //    {
        //        switch(shape)
        //        {
        //            case Circle c:
        //                Console.WriteLine(c.radius*c.radius*Shape.PI);
        //                break;
        //            case Rectangle r:
        //                Console.WriteLine(r.breadth*r.length);
        //                break;
        //            case Traingle t:
        //                Console.WriteLine(0.5*t.basev*t.height);
        //                break;
        //            default:
        //                throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
        //            case null:
        //                throw new ArgumentNullException(nameof(shape));
        //        }

        //    }
        //}

        // switch case with 'when' clause
        public static void DisplayArea(Shape shape)
        {
            switch (shape)
            {
                case Rectangle r when r.length == r.breadth:
                    Console.WriteLine("Area of Square is : " + r.length*r.breadth);
                    break;
                case Rectangle r:
                    Console.WriteLine("Area of Rectangle is "+ r.length * r.breadth);
                    break;
                case Traingle t:
                    Console.WriteLine("Area of Triangle is " + 0.5*t.basev* t.height);
                    break;
                case Circle c:
                    Console.WriteLine("Area of Circle " + c.radius*c.radius * Shape.PI) ;
                    break;
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
                    
            }
        }
    }
}
