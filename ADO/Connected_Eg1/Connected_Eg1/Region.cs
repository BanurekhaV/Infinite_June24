using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Connected_Eg1
{
    //-----------------------Business Access Layer BAL--------------------
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        public DataAccess da;
        public string InsertRegion()
        {
            Console.WriteLine("Enter Region ID");
            RegionId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Region Description");
            RegionDescription = Console.ReadLine();
            string retval = DataAccess.InsertRegion(RegionId, RegionDescription);
            return retval;
        }

        public SqlDataReader DisplayRegion()
        {
            SqlDataReader sdr = DataAccess.DisplayRegion();
            return sdr;
        }

        public int getRegionCount()
        {
           int count =  DataAccess.RegionCount();
           return count;
        }

        public string GetRegion()
        {
            Console.WriteLine("Enter the region Id:");
            RegionId = Convert.ToInt32(Console.ReadLine());
           string rname = DataAccess.GetRegion(RegionId);
            return rname;
        }
    }
    //-----------------------------Data Access Layer DAL-------------------
    public class DataAccess
    {
       public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        public static SqlConnection getcon()
        {
            con =  new SqlConnection("data source = LAPTOP-TJJ7D977; initial catalog = Northwind;" +
                "integrated security = true;");
            con.Open();
            return con;
        }

        public static string InsertRegion(int Rid, string rdesc)
        {            
            con = getcon();
            cmd = new SqlCommand("insert into region values(@rid,@rdesc", con);
            cmd.Parameters.AddWithValue("@rid", Rid);
            cmd.Parameters.AddWithValue("@rdesc", rdesc);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
                return "Success";
            else
                return "Failed";
        }

        public static SqlDataReader DisplayRegion()
        {
            con = getcon();
            cmd = new SqlCommand("Select * from region", con);
            dr = cmd.ExecuteReader();
            return dr;
        }

        public static int RegionCount()
        {
            con = getcon();
          cmd= new SqlCommand("select count(regionid) from region", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count;
        }

        public static string GetRegion(int rid)
        {
            con = getcon();
            cmd = new SqlCommand("GetDescription", con);
           
            cmd.CommandType = CommandType.StoredProcedure;  // exec GetDescription @rid
           // option 1.
           // cmd.Parameters.AddWithValue("@rgid", rid);

            //or
            //option 2.
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@rgid";
            param1.Value = rid;
            param1.DbType = DbType.Int32;
            param1.Direction = ParameterDirection.Input;  

            cmd.Parameters.Add(param1);
            
            string regionname = cmd.ExecuteScalar().ToString(); 
           
            return regionname;
        }
               
    }
   

    

    //---------------------Client Program-------------------------

    class Client
    {
        static void Main()
        {
            Region region = new Region();
            SqlDataReader myreader = region.DisplayRegion();
            while (myreader.Read())
            {
                Console.WriteLine(myreader[0] + " " + myreader[1]);
            }
            Console.WriteLine("----------------------------------------");
            //insert region
            Console.WriteLine( "The total no. of Regions are : {0}", region.getRegionCount());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("The Region Description is : {0}", region.GetRegion()); 
            Console.Read();
             
        }
    }
}
