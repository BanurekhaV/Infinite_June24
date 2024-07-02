using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Dotnet
{
    public class Employee
    {
        public int ID { get; }
        public string Name { get; }
        //autoproperties
        public float salary { get; } = 50000;

        public float Sal { get; private set; }
        public float Sal1 { get; protected set; }
        public string Company { get; } = "Infinite Ltd.";
        public Employee()
        {
            ID = 10;
            Name = "Infinite";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary initialization before C# 6.0
            Dictionary<string, string> employee = new Dictionary<string, string>()
            {
                {"John", "E100" },
                {"Ben", "E200" },
                {"Tom", "E300" },
            };

           // employee.Add("John", "E100");
            //with 6.0
            Dictionary<string, string> employee1 = new Dictionary<string, string>()
            {
                ["John"] = "E100",
                ["Ben"] = "E200",
                ["Tom"] = "E300",
            };

            foreach(KeyValuePair<string,string> kvp in employee1)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            //literal movements - for enhanced readability

            var lit1 = 478_1254_369_844;  // digit seperator
            var lit2 = 0Xa3_73; // hexadecimal 
            var lit3 = 1100_1101_1100_0011; //binary

            Console.WriteLine($"Lit 1: {lit1}, Lit 2: {lit2} and Lit 3: {lit3}");

            //  LocalFunctions();

            Console.WriteLine("___________________________________");
            NewEmployees.LocalFunction2();
            Console.Read();
        }

        public static void LocalFunctions()
        {
            int a = 10, b = 5;
            int tot = Sum(a, b);  // calling a local function within the parent function
            int diff = Difference(a, b);
            Console.WriteLine($"The Sum of {a} and {b} is {tot}");
            Console.WriteLine($"The difference between {a} and {b} is {diff}");

            int Sum(int x, int y)
            {
                return a += x+y;  // enclosing scopes variables can be accessed in local functions
            }
            
            int Difference(int x, int y)
            {
                return x - y;
            }

            Console.WriteLine(Sum(23, 6)); 
        }

        
    }

    class NewEmployees
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public static void LocalFunction2()
        {
            NewEmployees e1 = new NewEmployees()
            {
                ID = 100,
                Name = "Prakash",
                Salary = 5000,
                Department = "IT"
            };
            bool IsInserted = AddEmployee(e1);
            Console.WriteLine("Is Employee 1 Added :{0}", IsInserted);
            NewEmployees e2 = new NewEmployees()
            {
                ID = 200,
                Name = "Mahesh",
                Salary = 6000,
                Department = "HR"
            };
           IsInserted = AddEmployee(e2);
            Console.WriteLine("Is Employee 2 Added :{0}", IsInserted);
        }

        //parent function

        public static bool AddEmployee(NewEmployees e)
        {
            var validationresult = IsRequestValid();
            if (validationresult == false)
            {
                Console.WriteLine($"Could not add Employee to the database");
                return false;
            }
            else
                Console.WriteLine("Employee added successfully");
                return true;

            //local function
            bool IsRequestValid()
            {
                if (e.Salary > 5000)
                    return true;
                else 
                    return false;
            }
        }
    }
}
