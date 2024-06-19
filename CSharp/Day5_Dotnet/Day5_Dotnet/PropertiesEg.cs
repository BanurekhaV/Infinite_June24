using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Dotnet
{
    class Student
    {
        private string code = "N.A.";
        private string name = "Unknown";
        private int age = 0;
        private float marks = 60;

        //declare properties for all the private members
        public string Code
        {
            get { return code; }
            set { code = value;}
        }

        public int _Age
        {
            get { return age; }
            set { age = value; }
        }

        public float Marks
        {
            get { return marks; }  // only getter and no setter
        }

        public override string ToString()
        {
            return "Code = " + code + ", Name = " + name + " Age = " + age +  " Marks = " + marks;
        }
    }
    class PropertiesEg
    {
        public static void Main()
        {
            Student stud = new Student();

            stud.Code = "S001";
            stud._Age = 13;
            //stud.Marks = 56;  cannot assign value to marks as the property has only get and not set
            Console.WriteLine("student Info : {0}", stud.ToString());
            Console.WriteLine($"student info from outside Code = {stud.Code}, Age = {stud._Age} and " +
                $"Marks = {stud.Marks}");
            Console.Read();
        }
    }
}
