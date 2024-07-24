using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        //let us create an object of the context class
        static InfiniteDBEntities db = new InfiniteDBEntities();
        static void Main(string[] args)
        {           

            //let us verify various entity states
            Console.WriteLine("***********Entity States***********");
            tblemployee emp1 = new tblemployee();
            Console.WriteLine($"State of a newly created Object : {db.Entry(emp1).State}");

            emp1.Empid = 1001;
            emp1.Empname = "Banurekha";
            emp1.Gender = "Female";
            emp1.Salary = 7000;
            emp1.Phoneno = "987654321";
            Console.WriteLine("--------Insertion----------");
             AddEmp(emp1);
            ShowEmployees();
            Console.WriteLine("---------Updation---------");
            UpdateEmp();
            ShowEmployees();
            Console.WriteLine("---------Deletion---------");
            DeleteEmp();
            ShowEmployees();
            Console.Read();
        }

        public static void ShowEmployees()
        {
            var emp = db.tblemployees.ToList();

            foreach (var e in emp)
            {
                Console.WriteLine(e.Empid + " " + e.Empname + " " + e.Salary+ " "+ e.DeptNo);
            }
        }
        public static void AddEmp(tblemployee e)
        {
            Console.WriteLine($"Before Add/Insert, the Entity State : {db.Entry(e).State}");
            db.tblemployees.Add(e);
            Console.WriteLine($"Before Saving Changes , the Entity State :{db.Entry(e).State}");
            db.SaveChanges(); //this functions ensures the changes are made to the database
            Console.WriteLine($"After Insertion, The Entity State : {db.Entry(e).State}");
        }

        public static void UpdateEmp()
        {
            Console.WriteLine("Enter Empid for whom data has to be modified :");
            int eid = Convert.ToInt32(Console.ReadLine());
            tblemployee te = db.tblemployees.Find(eid);
            Console.WriteLine($"Before Update , the Entity State : {db.Entry(te).State}");

            if(te!=null)
            {
                te.DeptNo = 1;
                Console.WriteLine($"After Updation, The Entity State : {db.Entry(te).State}");
                db.SaveChanges();
                Console.WriteLine($"After save changes, The Entity State : {db.Entry(te).State}");
            }
            else
            {
                Console.WriteLine("matching Record not found");
            }

        }

        public static void DeleteEmp()
        {
            tblemployee temp = db.tblemployees.Find(1001);
            Console.WriteLine($" Before Deleting , The Entity State : {db.Entry(temp).State}");
            db.tblemployees.Remove(temp);
            Console.WriteLine($"After Deleting, The Entity State : {db.Entry(temp).State}");
            db.SaveChanges();
            Console.WriteLine($"After save changes , The Entity State : {db.Entry(temp).State}");
        }
    }
}
