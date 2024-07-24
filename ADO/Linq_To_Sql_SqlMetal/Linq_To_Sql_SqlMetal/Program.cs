using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Linq_To_Sql_SqlMetal
{
    class Program
    {
        static string connstr = ConfigurationManager.ConnectionStrings["NwindConnstr"].ConnectionString;
        static NorthwindContext db = new NorthwindContext(connstr);
        static void Main(string[] args)
        {
            Customers c1 = new Customers();
            var cust = from c in db.Customers
                       orderby c.ContactName
                       select c;

            foreach(var v in cust)
            {
                Console.WriteLine($"{v.CustomerID}, {v.ContactName}");
            }
            Console.Read();
        }
    }
}
