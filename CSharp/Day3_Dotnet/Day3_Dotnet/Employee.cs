using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Dotnet
{
    class Employee
    {
        //fields
        int Empid;
        string EmpName;
        DateTime DOJ;
        float Salary;
        
        //1. constructor
        public Employee()
        {
            Empid = 10;
            EmpName = "Infinite Ltd.";
            DOJ = Convert.ToDateTime("20/2/2024");  //dd/mm/yyyy
            Salary = 50000;
        }

        //2. constructor with arguments/parameters (Parameterized constructor)
        public Employee(int eid, string name, float sal)
        {
            Empid = eid;
            EmpName = name;
            Salary = sal;
        }

        //3. constructor with the usage of  'this' keyword
      internal Employee(int Empid, string EmpName)
        {
           this.Empid = Empid;
           this.EmpName = EmpName;
        }
        //methods/functions

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter id, name, doj and sal :");
            Empid = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            DOJ = Convert.ToDateTime(Console.ReadLine());
            Salary = Convert.ToSingle(Console.ReadLine());
        }

       public void ShowEmpDetails()
        {
            Console.WriteLine($"Employee id{Empid}, Employee Name {EmpName}, DOJ {DOJ} and Salary is {Salary}");
        }

        //destructor
        ~Employee()
        {
            Console.WriteLine("Bye from Employee..");
            Console.Read();
        }
    }

    class EmployeeTest
    {
        public static void Main()
        {
            Employee employee = new Employee(); //invoking empty constructor
          //  employee.GetEmployeeDetails();
            employee.ShowEmpDetails();
            employee = null;
            GC.Collect(); //forces to clear the reference memory immediately
            Console.WriteLine("------------");
            Employee employee2 = new Employee(20,"Pratheeba",25000); // invoking a construtor with 3 parameters
          //  employee2.GetEmployeeDetails();
            employee2.ShowEmpDetails();
            Employee employee3 = new Employee(30, "Nithin");
            Console.Read();

        }
    }
}
