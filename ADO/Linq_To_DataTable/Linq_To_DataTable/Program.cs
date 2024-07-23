using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Linq_To_DataTable
{
    class DatatableEg
    {
        public static DataTable GetTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Product", typeof(string));

            dt.Rows.Add(1, "Sports Shoes");
            dt.Rows.Add(2, "Memory Stick");
            dt.Rows.Add(3, "Gucci Bags");
            dt.Rows.Add(4, "Swiss Chocolates");
            return dt;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtret = DatatableEg.GetTable();

            //method syntax

            var result = dtret.AsEnumerable().Where(x => x.Field<int>("Id") == 2).FirstOrDefault();

            if(result !=null)
                Console.WriteLine(result["Product"]);
            else
                Console.WriteLine("No Product Found");
            Console.WriteLine("++++++++++++++++++++++++++++++");

            //query syntax
            var datarow = (from prod in dtret.AsEnumerable()
                           where prod.Field<int>("Id") == 3
                           select prod).FirstOrDefault();

            if(datarow !=null)
                Console.WriteLine(datarow["Id"] + " "+ datarow["Product"]);
            else
                Console.WriteLine("No matching product");

            // convert enumerable collection back to a datatable
            Console.WriteLine("***********************************");

            var dt = dtret.AsEnumerable().Where(x => x.Field<int>("id") > 1);

            DataTable tableagain = dt.CopyToDataTable<DataRow>();

            foreach(DataRow dr in tableagain.Rows)
            {
                foreach(DataColumn dc in tableagain.Columns)
                {
                    Console.Write(dr[dc] + "  ");
                }
                Console.WriteLine();
            }    
            Console.Read();
        }
    }
}
