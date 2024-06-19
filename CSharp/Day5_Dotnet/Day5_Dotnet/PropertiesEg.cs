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
        public string RollNo
        {
            get { return code; }
            set { code = value;}
        }

        public int _Age
        {
            get { return age; }
            set { if (value >= 15)
                    age = 10;
                else age = value;
            }
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

            stud.RollNo = "S001";  // set accessor is invoked
            stud._Age = 13;
            
            //stud.Marks = 56;  cannot assign value to marks as the property has only get and not set
            //Console.WriteLine("student Info : {0}", stud.ToString());
            //Console.WriteLine($"student info from outside Code = {stud.RollNo}, Age = {stud._Age} and " +
            //    $"Marks = {stud.Marks}"); // get accessor is invoked
            //Console.WriteLine("+++++++++++++++++");
            ////let us increment the age
            //stud._Age += 2;
            //Console.WriteLine($"student info from outside Code = {stud.RollNo}, Age = {stud._Age} and " +
            //    $"Marks = {stud.Marks}");
            Console.WriteLine("========= Auto Property Implementation =======");
            AutoStudent autos = new AutoStudent();
            autos.DisplayAutoStudent();
            Console.Read();
        }
    }

    class AutoStudent
    {
        //let us declare and define automatic implementation of properties
        public string RollNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Marks { get; } = 75;

        public void DisplayAutoStudent()
        {
            AutoStudent ast = new AutoStudent();
            ast.RollNo = "R100";
            ast.Name = "Infinite Ltd.";
            ast.Age = 25;
            
            Console.WriteLine($"Student info {ast.RollNo}, {ast.Name}, {ast.Age} and {ast.Marks}");
        }
    }
}
