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

        public ConstructorTypes(int a, string s, double d) : this(25)
        {
            Console.WriteLine(a+ " " + s + " " + d);
        }
        static void Main(string[] args)
        {
            // ConstructorTypes ct = new ConstructorTypes(5,"Hello",5.5);
            GermanSheperd Gs = new GermanSheperd("Rocky", 2, 5.0);
            Console.WriteLine("-------------");
            childofconstructottypes coc = new childofconstructottypes(150, "Parent", 115.678);
            Console.Read();
        }

    }

    class childofconstructottypes : ConstructorTypes
    {
        public childofconstructottypes(int i, string s, double d): base(i,s,d)
        {
            Console.WriteLine("This is the derived type of constructortypes class");            
        }
    }
    public class Dog
    {
        public string Name;
        public int Age;

        protected Dog()
        {
            Console.WriteLine("We are constructing Dog..");
        }
    }

    public class GermanSheperd : Dog
    {        
        public double fiestyfactor;

        //implicitly invokes the constructor in the base  class
        public GermanSheperd(string name, int age, double ff) 
        {
            Console.WriteLine("Constructing GermanSheperd");
            Name = name;
            Age = age;
            fiestyfactor = ff;
        }
    }
}
