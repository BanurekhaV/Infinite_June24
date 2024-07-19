using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Disconnected_Eg1
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlDataAdapter da;
        static void Main(string[] args)
        {
            // Disconnected_approach();
            Procedures_with_adapter();
            Console.Read();
        }

        public static void Disconnected_approach()
        {
            con = new SqlConnection("data source = LAPTOP-TJJ7D977; initial catalog = Northwind;" +
                "integrated security = true;");
            con.Open();
            da = new SqlDataAdapter("select * from Region", con);
            DataSet ds = new DataSet();

            da.Fill(ds, "NorthwindRegion");
            DataTable dt = ds.Tables["NorthwindRegion"];

            //to access the rows and columns from the datatable
            foreach(DataRow drow in dt.Rows)
            {
                foreach(DataColumn dcol in dt.Columns)
                {
                    Console.Write(drow[dcol]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            //adding one more table to the dataset
            Console.WriteLine("------------------------------------");
            da = new SqlDataAdapter("Select * from Shippers", con);
            da.Fill(ds, "NorthwindShippers");
            dt = ds.Tables["NorthwindShippers"];

            foreach(DataRow dr in dt.Rows)
            {
                foreach(DataColumn dc in dt.Columns)
                {
                    Console.Write(dr[dc]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void Procedures_with_adapter()
        {
            con = new SqlConnection("data source = LAPTOP-TJJ7D977; initial catalog = Northwind;" +
                "integrated security = true;");
            con.Open();
            da = new SqlDataAdapter("[Ten Most Expensive Products]", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt1 = new DataTable();
            da.Fill(dt1);

            foreach(DataRow dr in dt1.Rows)
            {
                foreach(DataColumn dc in dt1.Columns)
                {
                    Console.Write(dr[dc]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
