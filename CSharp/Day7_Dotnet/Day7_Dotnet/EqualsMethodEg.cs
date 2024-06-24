using System;
using static System.Console;
using System.Text;

namespace Day7_Dotnet
{
    class EqualsMethodEg
    {
        public enum Direction { East, West, North, South};
        public static void Main()
        {
            //equality operator with value types
            //int number1 = 10;
            //int number2 = 10;
            //WriteLine($"Number 1 == Number2 : {number1 == number2}");
            //WriteLine($"Number1.Equals(Number2) ?: {number1.Equals(number2)}");
            //Console.WriteLine("--------------------");

            //Direction d1 = Direction.East;
            //Direction d2 = Direction.East;

            //WriteLine(d1 == d2);
            //WriteLine(d1.Equals(d2));
            WriteLine("*************************");
            // Equality_With_ReferenceTypes();
            ReferenceEquals();
            Console.Read();
        }

        public static void ReferenceEquals()
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            Console.WriteLine(Object.ReferenceEquals(sb1,sb2));

            sb1 = sb2;
            Console.WriteLine(Object.ReferenceEquals(sb1, sb2));

            //let us test the string literals
            Console.WriteLine("----------------------");
            string lit1 = "a";
            string lit2 = "a";
            Console.WriteLine(Object.ReferenceEquals(lit1,lit2));
            lit1 = lit2;
            Console.WriteLine(Object.ReferenceEquals(lit1, lit2));

        }
        public static void Equality_With_ReferenceTypes()
        {
            Customers c1 = new Customers();
            c1.FirstName = "Raviteja";
            c1.LastName = "Booraga";

            Customers c2 = c1;
            WriteLine($"C1 == C2 : {c1 == c2} {c1.GetHashCode()} and {c2.GetHashCode()}");
            WriteLine($"C1.Equals(C2) : {c1.Equals(c2)}");

            Console.WriteLine("--------------------");
            c2 = new Customers();
            c2.FirstName = "Raviteja";
            c2.LastName = "B";

            WriteLine($"C1 == C2 : {c1 == c2} {c1.GetHashCode()} and {c2.GetHashCode()}");
            WriteLine($"C1.Equals(C2) : {c1.Equals(c2)}");

        }
    }

    public class Customers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            //ensure that the passed object is not null
            if (obj == null)
            {
                return false;
            }

            //ensure that the passed object is of type Customers
            if (!(obj is Customers))
            {
                return false;
            }

            //we are changing the implementation code of Equals() method
            //of the 'Object' Class to compare the values of 2 objects and not the references
            return (this.FirstName == ((Customers)obj).FirstName) &&
                (this.LastName == ((Customers)obj).LastName);
        }

        //public override int GetHashCode()
        //{
        //    return FirstName.GetHashCode() ^ LastName.GetHashCode();
        //}
    }
}
