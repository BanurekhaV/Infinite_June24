using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Dotnet
{
    class PersonDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

              
        public PersonDetails(string f, string l)
        {
            this.FirstName = f;
            this.LastName = l;
        }
    }

    class Persons
    {
        public int Age;
        public PersonDetails pd;  //composition

        public Persons(int age, string fn, string ln)
        {
            Age = age;
            pd = new PersonDetails(fn, ln);
        }

        //shallow copy

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        //deep copy

        public Persons DeepCopy()
        {
            Persons dcopy = new Persons(this.Age, pd.FirstName, pd.LastName);
            return dcopy;
        }
    }
    class Deep_ShallowCopy
    {
        public static void Main()
        {
            Persons p1 = new Persons(22, "Keshava", "T");

            Persons p2 = (Persons)p1.ShallowCopy();
            Console.WriteLine($"The FirstName is {p1.pd.FirstName}, and LastName is {p1.pd.LastName} and the Age is {p1.Age}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"The FirstName is {p2.pd.FirstName}, and LastName is {p2.pd.LastName} and the Age is {p2.Age}");

            p2.pd.FirstName = "AdiKeshava";
            p2.pd.LastName = "S";

            Console.WriteLine(p1.pd.FirstName + " "+ p1.pd.LastName);
            Console.WriteLine(p2.pd.FirstName + " "+ p2.pd.LastName);

            Console.WriteLine("-----Deep Copy-----");

            Persons p3 = p1.DeepCopy();

            Console.WriteLine($"The FirstName is {p1.pd.FirstName}, and LastName is {p1.pd.LastName} and the Age is {p1.Age}");
            Console.WriteLine($"The FirstName is {p3.pd.FirstName}, and LastName is {p3.pd.LastName} and the Age is {p3.Age}");
            Console.WriteLine("-----------------");
            p3.pd.LastName = "Thummala";

            Console.WriteLine(p1.pd.LastName);
            Console.WriteLine(p3.pd.LastName);

            p2.Age = 30;

            Console.WriteLine("P1's Age after Change : " + p1.Age);
            Console.WriteLine("P2's Age after Change : " + p2.Age);
            Console.WriteLine("P3's Age after Change : " + p3.Age);
            Console.Read();
        }
    }
}
