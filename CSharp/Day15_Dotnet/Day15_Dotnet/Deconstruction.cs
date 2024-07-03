using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Dotnet
{
    class Deconstruction
    {
        static void Main()
        {
            //1. option1 to deconstruct
            var EmployeeDetails = GetEmployeeDetails(100);
            var ename = EmployeeDetails.Item1;
            var sal = EmployeeDetails.Item2;
            var gender = EmployeeDetails.Item3;
           // var department = EmployeeDetails.Item4;

            Console.WriteLine("Employee Details ..........");
            Console.WriteLine($"Name :{ename}, Salary: {sal}, Gender :{gender}");
            Console.WriteLine("Press any key to exit..");

            //2. option2 to deconstruct
            (string ename1, double sal1, string gender1, string dept) = GetEmployeeDetails(100);

            //3. option 3 to deconstruct
            var (Name, Salary, Gender, Department) = GetEmployeeDetails(100);

            //4. option 4 - not recommended
            (var Name1, var Salary1, string Gender1,var dept1) = GetEmployeeDetails(100);
            Console.Read();
        }

        static (string, double,string,string)GetEmployeeDetails(long EmpId)
        {
            //in real life applns. based on the empid, it should serach the database and if match found return all details
            //hard code
            string EmpName = "Gurukiran";
            double salary = 70000;
            string gender = "Male";
            string dept = "IT";
            return (EmpName, salary, gender, dept);
        }
        
    }
}
