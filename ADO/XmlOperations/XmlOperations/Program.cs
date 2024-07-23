using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.IO;


namespace XmlOperations
{
    class Program
    {
        static DataSet ds = new DataSet("DS");
        static void Main(string[] args)
        {
            // XmlWriter();
            XmlReader();
           // XmlSchemaWriter();
            //XmlSchemaReader();
            Console.Read();
        }

        public static void XmlWriter()
        {
            try
            {
                creatingContent();
                //create a streamwriter object to write the dataset data

                StreamWriter sw = new StreamWriter("Studentdata.xml");
                ds.WriteXml(sw); //writes the ds content as an xml file
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void XmlReader()
        {
            DataSet ds1 = new DataSet();

            ds1.ReadXml("Studentdata.xml");  //fills the dataset with data

            foreach(DataTable dt in ds1.Tables)
            {
                Console.WriteLine(dt);
                for(int i =0; i < dt.Columns.Count; i++)
                {
                    Console.Write("\t" + "\t" + dt.Columns[i].ColumnName);
                }
                Console.WriteLine();

                foreach(DataRow r in dt.Rows)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        Console.Write("\t" + "\t" + r[j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("------------------------------------------------------");
                foreach (var row in dt.AsEnumerable())
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        Console.Write("\t" +    "\t" + row[j]);
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void XmlSchemaWriter()
        {
            creatingContent();
            ds.WriteXmlSchema("StudentSchema");
        }

        public static void XmlSchemaReader()
        {
            ds = new DataSet("ourdata");
            StreamReader sr = new StreamReader("StudentSchema");
            ds.ReadXmlSchema(sr);

            XmlTextWriter writer = new XmlTextWriter(Console.Out);
            ds.WriteXmlSchema(writer);
        }
        static void creatingContent()
        {
            ds.Namespace = "StdNameSpace";
            DataTable stdTable = new DataTable("Student");

            DataColumn col1 = new DataColumn("Name");
            DataColumn col2 = new DataColumn("Address");

            stdTable.Columns.Add(col1);
            stdTable.Columns.Add(col2);

            ds.Tables.Add(stdTable);

            DataRow dr = stdTable.NewRow();
            dr["Name"] = "Naveen";
            dr["Address"] = "Bhopal";

            stdTable.Rows.Add(dr);

            dr = stdTable.NewRow();
            dr["Name"] = "Chithra";
            dr["Address"] = "Chennai";

            stdTable.Rows.Add(dr);

            dr = stdTable.NewRow();
            dr["Name"] = "Rakshitha";
            dr["Address"] = "Jaipur";

            stdTable.Rows.Add(dr);
            dr = stdTable.NewRow();
            dr["Name"] = "Shakshi";
            dr["Address"] = "Ranchi";

            stdTable.Rows.Add(dr);

            ds.AcceptChanges();
        }
    }
}
