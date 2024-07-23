using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_To_Sql_VS
{
    class Program
    {
        static LSCDataContext dc = new LSCDataContext();
        static void Main(string[] args)
        {
            var emp = dc.tblemployees.ToList();

            foreach(var e in emp)
            {
                Console.WriteLine($"EmpId {e.Empid}, EmployeeName {e.Empname} and Salary is {e.Salary}");
            }
            Console.Read();
        }
    }
}
