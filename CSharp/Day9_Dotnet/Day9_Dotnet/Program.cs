using System;
using System.Collections.Generic;


namespace Day9_Dotnet
{
    public class Employee : IComparable
    {
        int Empid;
        string EmpName;
        public float Empsal;
        string CompanyName;

        public Employee(int id, string name, string cname, float sal)
        {
            Empid = id;
            EmpName = name;
            CompanyName = cname;
            Empsal = sal;
        }

        public int CompareTo(Object obj)
        {
            Employee eobj = obj as Employee;  //typecasting Object to Employee
            if(eobj !=null)
            {
                return this.Empsal.CompareTo(eobj.Empsal);
            }
            return -1;

        }

        

        public override string ToString()
        {
            return String.Format("Employee : " + Empid + " Named :" + EmpName + " Works for :" + CompanyName +
                " and Earns a salary of :" + Empsal);
        }
    }

    class Salary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Empsal.CompareTo(y.Empsal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numlist = new List<int>();
            numlist.Add(5);
            numlist.Add(15);
            numlist.Add(21);
            numlist.Add(13);
            numlist.Sort();
           
            foreach(int x in numlist)
            {
                Console.WriteLine(x);
            }

            List<string> booklist = new List<string>();
            booklist.Add("Fiction");
            booklist.Add("NonFiction");
            booklist.Add("Horror");
            booklist.Add("Comedy");
            booklist.Add("RomCom");

            booklist.Sort();
            foreach(string s in booklist)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-----List with Employee Types----");
            List_of_UDT_Eg();
            Console.Read();
        }

        public static void List_of_UDT_Eg()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(101, "Raghuram", "Infinite", 45000));
            emplist.Add(new Employee(104, "Shivraj", "Infinite", 42000));
            emplist.Add(new Employee(103, "Hamsa", "Infinite", 44000));
            emplist.Add(new Employee(102, "Anitha", "Infinite", 40000));

            foreach(Employee e in emplist)
            {
                Console.WriteLine(e.ToString());
            }

            emplist.Sort();  // to sort udt we have to implement CompareTo() of IComparable interface
            
            Console.WriteLine("After Sort");

           foreach(Employee e in emplist)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("*******************");
            CompareEg();
        }

        public static void CompareEg()
        {
            Employee[] emparr = new Employee[]
           {
                new Employee(201,"Swapna","Infinite",52000),
                new Employee(203,"Bindu","Infinite",50000),
                new Employee(202,"Uhalatha","Infinite",51000),
                new Employee(204,"Aman","Infinite",53000),
           };

            Array.Sort(emparr);

            foreach(var e in emparr)
            {
                Console.WriteLine(e.Empsal);
            }
        }
    }
}
