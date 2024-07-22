using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BuildingRelations
{
    class Relations_Constraints
    {
        public static void Main()
        {
            DataSet ds = new DataSet();

            DataTable ClassTable = ds.Tables.Add("OurClass");
            ClassTable.Columns.Add("CId", typeof(int));
            ClassTable.Columns.Add("ClassName", typeof(string));

            DataTable StudentTable = ds.Tables.Add("Students");
            StudentTable.Columns.Add("ClassId", typeof(int));
            StudentTable.Columns.Add("SID", typeof(int));
            StudentTable.Columns.Add("SName", typeof(string));

            //initialize pk constraint
            ClassTable.PrimaryKey = new DataColumn[] { ClassTable.Columns["CId"] };

            //add relations to the dataset
            ds.Relations.Add("classstudent", ClassTable.Columns["Cid"], StudentTable.Columns["ClassId"]);


            //to set the foreign key constraint
            DataColumn dcclassid = ds.Tables["OurClass"].Columns["CId"];
            DataColumn dcstudentid = ds.Tables["Students"].Columns["ClassId"];

            ForeignKeyConstraint fkc = new ForeignKeyConstraint("csfkc", dcclassid, dcstudentid);

            //set the rules for foreign key constraint
            fkc.DeleteRule = Rule.SetNull;
            fkc.UpdateRule = Rule.Cascade;

            //add a unique constraint
            UniqueConstraint namecons = new UniqueConstraint(new DataColumn[] { ClassTable.Columns["ClassName"] });

            ds.Tables["OurClass"].Constraints.Add(namecons);

            //now let us give some data and check how these keys and constraints are working

            DataRow dr1 = ds.Tables["OurClass"].NewRow();

            dr1["CId"] = 1;
            dr1["ClassName"] = "Fifth";
            ClassTable.Rows.Add(dr1);

            dr1 = ds.Tables["OurClass"].NewRow();

            dr1["CId"] = 4;
            dr1["ClassName"] = null;
            ClassTable.Rows.Add(dr1);

            dr1 = ds.Tables["OurClass"].NewRow();

            dr1["CId"] = 1;      // primary key violation
            dr1["ClassName"] = "sixth";  //when null throws unique constraint error
            ClassTable.Rows.Add(dr1);

            //let us add data to the students table

            DataRow dr2 = ds.Tables["Students"].NewRow();
            dr2["ClassId"] = 3; //foreign key violation
            dr2["SID"] = 1;
            dr2["SName"] = "Infinite";

            StudentTable.Rows.Add(dr2);

            Console.Read();
        }
    }
}
