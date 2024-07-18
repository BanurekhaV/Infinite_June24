using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Connected_Eg1
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            InsertData();  
          //  SelectData();
           // Select_With_Parameters();
            Console.Read();
        }

        //let us create a common function to get the database connection
        private static SqlConnection getConnection()
        {
            con = new SqlConnection("data source = LAPTOP-TJJ7D977; initial catalog = InfiniteDB;" +
                "integrated security = true;");
            con.Open();
            return con;
        }

        //let us create a function to execute sql select statement
        public static void SelectData()
        {
            con = getConnection();
            // option 1
            // cmd = new SqlCommand("select * from tblemployees", con); command text with connection object
            //2 option 
            cmd = new SqlCommand("Select * from tblemployees"); //only command text

            
            cmd.Connection = con;  
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Console.WriteLine(dr[0] + " | " + dr[1] + " | " + dr[2] + " | " + dr[3] + " | " + dr[4]);
            }
        }

        //select with a where predicate

        public static void Select_With_Parameters()
        {
            con = getConnection();
            int deptid;
            Console.WriteLine("Mention the DeptNo to select Employees Data :");
            deptid = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("select * from tblemployees where deptno = @did");

            //now we will associate the C# variable to that of sql variable along with data
            cmd.Parameters.AddWithValue("@did", deptid);
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " | " + dr[1] + " | " + dr[2] + " | " + dr[3] + " | " + dr[4]);
            }
        }

        //insert a record
        public static void InsertData()
        {
            con = getConnection();
            int deptno;
            string deptname;
            float budget;
            string location;
            Console.WriteLine("enter department details");
            deptno = Convert.ToInt32(Console.ReadLine());
            deptname = Console.ReadLine();
            budget = Convert.ToSingle(Console.ReadLine());
            location = Console.ReadLine();

            cmd = new SqlCommand("Insert into tbldepartment values(@deptno,@deptname,@budget,@loc)",con);

            cmd.Parameters.AddWithValue("@deptno", deptno);
            cmd.Parameters.AddWithValue("@deptname", deptname);
            cmd.Parameters.AddWithValue("@budget", budget);
            cmd.Parameters.AddWithValue("@loc", location);

            int result = cmd.ExecuteNonQuery();

            if(result > 0)
                Console.WriteLine("Insertion success");
            else
                Console.WriteLine("Could not insert data");

            SqlCommand cmd1 = new SqlCommand("select * from tbldepartment", con);
            dr = cmd1.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("Deptnumber : {0}", dr[0]);
                Console.WriteLine("Deptname : {0}", dr[1]);
            }
        }
    }
}
