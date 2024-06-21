using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{
    public partial class Employee
    {
        //declare properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public float Salary { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }

        //initialize the properties thru constructor
        public Employee(int id, string name, string job, float sal, string gender, string dept)
        {
            this.ID = id;
            this.Name = name;
            this.Job = job;
            Salary = sal;
            Gender = gender;
            Department = dept;
        }

        //1st indexer to access the properties with their positions
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return ID;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Gender;
                else if (index == 5)
                    return Department;
                else
                    return null;
            }
            set
            {
                if (index == 0)
                    ID = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Job = value.ToString();
                else if (index == 3)
                    Salary = Convert.ToSingle(value);
                else if (index == 4)
                    Gender = value.ToString();
                else if (index == 5)
                    Department = value.ToString();
            }
        }

        //2nd indexer to access the properties with their names
        //thereby we are overloading the indexer
        //public object this[string prop]
        //{
        //    //get
            //{
            //    if (prop.ToUpper() == "ID")
            //        return ID;
            //    else if (prop == "Name")
            //        return Name;
            //}
            //set
            //{              
            //   if (prop=="ID")
            //   ID = Convert.ToInt32(value);

            //}
        
    }
    class IndexersDemo
    {
        public static void Main()
        {
            //creating employee object and setting values thru constructor
            Employee emp = new Employee(101, "Uhalatha", "Programmer", 45000, "Female", "IT");

            //accessing Employee properties using indexers i.e. index position
            Console.WriteLine("EID = " + emp[0]);
            Console.WriteLine("Name = " + emp[1]);
            Console.WriteLine("Salary = " + emp[3]);
            Console.WriteLine("Department = " + emp[5]);

            //now let us change some values of the object using setter
            emp[1] = "Ritesh";
            emp[3] = 50000;
            emp[5] = "Quality";
            Console.WriteLine("===============================");
            Console.WriteLine("EID = " + emp[0]);  // emp["id"]
            Console.WriteLine("Name = " + emp[1]);
            Console.WriteLine("Salary = " + emp[3]);
            Console.WriteLine("Department = " + emp[5]);
          
            Console.Read();
        }
    }

}
