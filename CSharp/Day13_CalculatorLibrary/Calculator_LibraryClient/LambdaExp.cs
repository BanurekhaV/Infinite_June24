using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_LibraryClient
{
    class LambdaExp
    {
        static void Main()
        {
            List<int> numbers = new List<int>()
            {
                36,71,12,15,29,18,27,17,9,34
            };
            //loop to display the list collection
            foreach(var item in numbers)
            {
                Console.WriteLine(item*item);
            }

            //using lambda calculate square of each number in the list
            var squares = numbers.Select(n => n * n);

            Console.WriteLine("---lambda Squares------");

            foreach(var v in squares)
            {
                Console.WriteLine(v);
            }

            //using lambda find all the numbers in the list which are divisible by 3
            List<int> divby3 = numbers.FindAll(x => (x % 3) == 0);

            Console.WriteLine("Numbers divisible by 3........");
            foreach(int x in divby3)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(" Lambda with UDT------");
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{ID =101, Name="SaiVardhan", Salary=47000},
                new Employee{ID =102, Name="Ramesh", Salary=45000},
                new Employee{ID =103, Name="Suresh", Salary=42000},
            };

            //find the employee with id 102
            Employee emp = emplist.Find(e => e.ID == 103);
            if (emp != null)
            {
                Console.WriteLine("ID = {0}, Name = {1}, and Salary = {2}", emp.ID, emp.Name, emp.Salary);
            }
            else
                Console.WriteLine("employee Id not found");

            //sorting the emplist on the basis of name
            IEnumerable<Employee> sortedemployees = emplist.OrderByDescending(x => x.Name);

            foreach(Employee item in sortedemployees)
            {
                Console.WriteLine(item.ID + " " + item.Name + " "+ item.Salary);
            }
            Console.Read();
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }
}
