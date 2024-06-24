using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Dotnet
{
    class CompareToEg
    {
        public static void Main()
        {
            const int a = 5;
            const int b = 6;
            const int c = 5;
            Console.WriteLine(a.CompareTo(b));

            // CompareTo compares 2 value types /ref types and returns either
            // -1 : when the first number is smaller
            //  1 : when the first number is larger
            //  0 : when both are equal

            Console.WriteLine(b.CompareTo(a));
            Console.WriteLine(c.CompareTo(a));

            //if we would like to compare objects then we need to implement the CompareTo() of the IComparable Interface
            Console.WriteLine("----------Objects Comaprison----------");
            List<SmartPhone> smartphones = new List<SmartPhone>()
            {
                new SmartPhone()
                {
                    Name="One Plus 8",
                    IsFlagship = true,
                    Price = 65000
                },
                new SmartPhone()
                {
                    Name="IPhone 11",
                    IsFlagship = true,
                    Price = 135000
                },
                new SmartPhone()
                {
                    Name="Samsung Note 10",
                    IsFlagship = true,
                    Price = 85000
                },
                new SmartPhone()
                {
                    Name="Vivo",
                    IsFlagship = true,
                    Price = 50000
                },
            };

            smartphones.Sort();  // this calls for the CompareTo()
            foreach(var item in smartphones)
            {
                Console.WriteLine(item.ToString());
            }
            Console.Read();
        }
    }

    public class SmartPhone : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsFlagship { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            SmartPhone sp2 = obj as SmartPhone;
            if (sp2 != null)
            {
                return this.Price.CompareTo(sp2.Price);
            }
            else
            {
                throw new ArgumentException("Object doesnt have a proper price");
            }
        }

         //let us override the ToString() of the Object class to display data,  the way we want to
        public override string ToString()
        {
            return "Name of the Phone :" + Name + " || " + " Price : " + Price + " || "
                + " Is Flagship Product : " + IsFlagship;
        } 
    }

}
