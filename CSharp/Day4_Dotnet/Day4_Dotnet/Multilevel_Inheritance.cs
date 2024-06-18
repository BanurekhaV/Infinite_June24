using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class Student 
    {
        private string RollNo;
        string Name;
        string Class;        

        public void GetData()
        {
            Console.WriteLine("Enter Roll No , Name and Class:");
            RollNo = Console.ReadLine();
            Name = Console.ReadLine();
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Name of the Student is : " + Name);
            Console.WriteLine("Roll Number is : " + RollNo);
            Console.WriteLine("The Class is : " + Class);
        }
    }

    class Marks : Student
    {
        protected int[] marks = new int[5];

        public void GetMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter Subject {0} Marks : ", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Marks in subject {0} is {1}", i + 1, marks[i]);
            }
        }
    }

    class Result : Marks
    {
        int Totalmarks;

        public void GetResult()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Totalmarks = Totalmarks + marks[i];
            }
        }

        public void DisplayResult()
        {
            Console.WriteLine("========== Results ===========");
            PutData();
            PutMarks();
            Console.WriteLine("total Marks = " + Totalmarks);
        }
   
    }

    class Multilevel_Inheritance
    {
        public static void Main()
        {
            Result result = new Result();
            result.GetData();
            result.GetMarks();
            result.GetResult();
            result.DisplayResult();
            Console.Read();
        }
    }
}
