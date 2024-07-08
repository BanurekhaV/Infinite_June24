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
        static void Main(string[] args)
        {
        }
    }
}
