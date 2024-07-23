using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_To_DataTable
{
    class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }
    class Deferred_ImmediateEg
    {
        static void Main()
        {
            var employees = new List<Employees>
            {
                new Employees{Id=1, Name = "John", Salary =30000},
                new Employees{Id=2, Name="Robert", Salary=42000},
                new Employees{Id=3, Name="Peter", Salary=54000}
            };

            //deferred linq example

            //Linq Query Construction
           // var emp = employees.Where(e => e.Salary < 35000).Select(n => n.Name);

            //immediate
            var emp = employees.Where(e => e.Salary < 35000).Select(n => n.Name).ToList();

            //creating another employee instance after linq query construction
            employees.Add(new Employees { Id = 4, Name = "Mark", Salary = 20000 });

            foreach(var item in emp)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
