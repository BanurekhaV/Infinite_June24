using System;
using System.Text;

namespace Day3_Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringOps();
            // Struct_vs_Class();
            EnumerationsEg.EnumOps();
            Console.ReadKey();
        }

        public static void StringOps()
        {
            string s = "Hello";
            Console.WriteLine("S for the First Time is {0}", s.GetHashCode());

            //strings are immutable
            s = "Hello World";
            Console.WriteLine("S after change of value is {0}", s.GetHashCode());

            string s1 = "CSharp";
            Console.WriteLine("S1 new value from the pool {0}", s1.GetHashCode());

            string s2 = s1;  //reference of s1 is assigned to s2
            Console.WriteLine("S2 sharing the same reference as that of s1 {0}", s2.GetHashCode());

            string s3 = "Hello";
            Console.WriteLine("S3, existing value from the pool {0}", s3.GetHashCode());

            //mutable string - stringbuilder
            Console.WriteLine("-------String Builder-------");
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("Sb's hash code :{0}", sb.GetHashCode());
            sb.Append(" World");
            Console.WriteLine("Sb's hash code :{0}", sb.GetHashCode());
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);
        }

        public static void Struct_vs_Class()
        {
            //  Student s1 = new Student();//or
             Student s1 = new Student();
           // Student s1;
            s1.marks1 = 50;
            s1.mark2 = 60;
           // s1.name = "Infinite";
            Console.WriteLine(s1.marks1 + s1.mark2);

            //Student s2 = new Student();
            Student s2;
            // s2 = s1;   //the values of marks1, marks are getting copied to a new structure
            s2 = s1;
            //now after changing the structure to a class, the above assignment will copy the reference of s1 into s2
            Console.WriteLine(s2.marks1 + s2.mark2);

            //let us change the value of any one student variable

            s1.marks1 = 80;
            //s1.mark2 = 80;

            Console.WriteLine("After Changes.......");
            Console.WriteLine(s1.marks1 + s1.mark2);

            Console.WriteLine(s2.marks1 + s2.mark2);

            s2.mark2 = 100;

            Console.WriteLine(s1.marks1 + s1.mark2);

            Console.WriteLine(s2.marks1 + s2.mark2);

        }
    }

    
    class Student
    {
        //public fields 
        public int marks1;
        public int mark2;
       // public string name;
    }
}
