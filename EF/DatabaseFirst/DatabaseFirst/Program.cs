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
            var emp = db.tblemployees.ToList();

            foreach(var e in emp)
            {
                Console.WriteLine(e.Empid + " " + e.Empname +  " "+ e.Salary) ;
            }

            Console.Read();
        }
    }
}
