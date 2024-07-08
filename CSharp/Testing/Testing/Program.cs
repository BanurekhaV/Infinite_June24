using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
    }
    public class Program
    {
        public string Login(string userid, string password)
        {
            if (string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(password))
            {
                return "UserId or Password cannot be empty";
            }
            else if (userid == "Admin" && password == "Admin@123")
            {
                return "Welcome Admin";
            }
            else
                return "Incorrect User Id or Password";
        }

        public List<Employee> EmpData()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{Id=100,Name="Nithin",Salary=45000,Gender="Male"},
                new Employee{Id=101,Name="Saivardhan",Salary=45000,Gender="Male"},
                new Employee{Id=102,Name="Bindu",Salary=45000,Gender="Female"},
                new Employee{Id=103,Name="Sripriya",Salary=45000,Gender="Female"}
            };
            return emplist;
        }

        public List<Employee>GetEmployee(int id)
        {
            List<Employee> emp = new List<Employee>();
            Program prog = new Program();
            var elist = prog.EmpData();
            foreach(var v in elist)
            {
                if (v.Id == id)
                {
                    emp.Add(v);
                }
            }
            return emp;
        }

        public int Add2Nos(int x, int y)
        { 
            return x + y;
        }

        
        static void Main(string[] args)
        {
        }
    }

    public class Accounts
    {
        string Accno;
        float balance = 1000;

        public Accounts(string accno)
        {
            Accno = accno;
        }
        public float CheckBalance()
        {
            return balance;
        }

       
        public void Deposit(float amt)
        {
            balance += amt;
        }

        public void Withdraw(float amt)
        {
            if (balance >= amt)
                balance -= amt;
            else
                throw new Exception("Not Enough balance to withdraw");
        }

    }
}
