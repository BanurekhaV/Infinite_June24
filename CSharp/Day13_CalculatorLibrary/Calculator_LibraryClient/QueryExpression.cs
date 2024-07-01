using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_LibraryClient
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public static List<Student>GetStudents()
        {
            List<Student> stdlist = new List<Student>()
            {
                new Student{ID= 1,Name="Sripriya", Email="sri@gmail.com"},
                new Student{ID= 4,Name="Jahnavi", Email="janvi@gmail.com"},
                new Student{ID= 2,Name="Kajal", Email="kajal@gmail.com"},
                 new Student{ID= 3,Name="Saajna", Email="sj@gmail.com"},
            };
            return stdlist;
        }
    }
    class QueryExpression
    {
        static void Main()
        {
            int[] intval = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> Oddval = from v in intval
                                      where (v % 2) != 0
                                      select v;

            foreach(var item in Oddval)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------Query expression with UDT..");
            List<Student> qlist = (from student in Student.GetStudents()
                                  where student.Name.StartsWith("S")
                                  select student).ToList();

            foreach (var s in qlist)
            {

                Console.WriteLine(s.ID + " "+  s.Name + " "+ s.Email);
            }

            Console.Read();
        }
    }
}
