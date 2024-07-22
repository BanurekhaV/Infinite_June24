using System;
using System.Data;

namespace BuildingRelations
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. let us create an in-memory cache (dataset)
            DataSet dsEmployment = new DataSet("Employement");

            //2. add data table 1
            DataTable dtEmployees = new DataTable("Employees");

            //3. define columns to the datatable
            DataColumn[] dcEmployees = new DataColumn[4];
            dcEmployees[0] = new DataColumn("Empcode", System.Type.GetType("System.Int32"));
            dcEmployees[1] = new DataColumn("EmpName", System.Type.GetType("System.String"));
            dcEmployees[2] = new DataColumn("EmpDept", System.Type.GetType("System.String"));
            dcEmployees[3] = new DataColumn("EmpStatusID", System.Type.GetType("System.Int32"));

            //4. Add the above columns to the datatbale
            dtEmployees.Columns.Add(dcEmployees[0]);
            dtEmployees.Columns.Add(dcEmployees[1]);
            dtEmployees.Columns.Add(dcEmployees[2]);
            dtEmployees.Columns.Add(dcEmployees[3]);

            //5. now let us add rows with data
            DataRow drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "1";
            drEmpRows["EmpName"] = "Aishwarya";
            drEmpRows["EmpDept"] = "IT";
            drEmpRows["EmpStatusID"] = "1";

            //6. now add the above row to the table collection
            dtEmployees.Rows.Add(drEmpRows);

            //repeat step 5 and 6 for as many rows we want to have in the datatable
            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "2";
            drEmpRows["EmpName"] = "Rajesh";
            drEmpRows["EmpDept"] = "Finance";
            drEmpRows["EmpStatusID"] = "3";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "3";
            drEmpRows["EmpName"] = "Suraj";
            drEmpRows["EmpDept"] = "Accounts";
            drEmpRows["EmpStatusID"] = "1";
                        
            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "4";
            drEmpRows["EmpName"] = "Swapna";
            drEmpRows["EmpDept"] = "Finance";
            drEmpRows["EmpStatusID"] = "3";
                        
            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "5";
            drEmpRows["EmpName"] = "Gurukiran";
            drEmpRows["EmpDept"] = "Operations";
            drEmpRows["EmpStatusID"] = "4";
            
            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "6";
            drEmpRows["EmpName"] = "Tanmayee";
            drEmpRows["EmpDept"] = "Admin";
            drEmpRows["EmpStatusID"] = "4";
                       
            dtEmployees.Rows.Add(drEmpRows);

            //7. create another table
            DataTable dtEmpStatus = new DataTable("EmployeeStatus");

            //8. Columns for table 2
            DataColumn[] dcStatus = new DataColumn[2];
            dcStatus[0] = new DataColumn("EmpStatusID", System.Type.GetType("System.Int32"));
            dcStatus[1] = new DataColumn("EmpStatus", System.Type.GetType("System.String"));

            //9. adding columns to the table
            dtEmpStatus.Columns.Add(dcStatus[0]);
            dtEmpStatus.Columns.Add(dcStatus[1]);

            //10. rows for table 2 and add it to the tables by repeating 

            DataRow drStatus = dtEmpStatus.NewRow();

            drStatus["EmpStatusID"] = "1";
            drStatus["EmpStatus"] = "Full Time";

            dtEmpStatus.Rows.Add(drStatus);

            drStatus = dtEmpStatus.NewRow();

            drStatus["EmpStatusID"] = "2";
            drStatus["EmpStatus"] = "Part Time";

            dtEmpStatus.Rows.Add(drStatus);

            drStatus = dtEmpStatus.NewRow();

            drStatus["EmpStatusID"] = "3";
            drStatus["EmpStatus"] = "Contract";

            dtEmpStatus.Rows.Add(drStatus);
            drStatus = dtEmpStatus.NewRow();

            drStatus["EmpStatusID"] = "4";
            drStatus["EmpStatus"] = "Intern";

            dtEmpStatus.Rows.Add(drStatus);

            //11. add both the tables to the dataset

            dsEmployment.Tables.Add(dtEmployees);
            dsEmployment.Tables.Add(dtEmpStatus);

            //12. setting relationship between 2 datatables of the dataset

            //12.1 primary key and foreign key
            DataColumn parent = dsEmployment.Tables["EmployeeStatus"].Columns["EmpStatusID"];
            DataColumn child = dsEmployment.Tables["Employees"].Columns["EmpStatusID"];

            //12.2 setting the relation
            DataRelation emprel = new DataRelation("EmpStatusRelation", parent, child);

            //12.3 adding relation to the dataset
            dsEmployment.Relations.Add(emprel);


            //13. Display Data as per the relationship
            Console.WriteLine("===================================================================");
            Console.WriteLine("Status ID             |             Employee Status     ");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach(DataRow row in dsEmployment.Tables["EmployeeStatus"].Rows)
            
                Console.WriteLine("{0}             |          {1}", row["EmpStatusID"], row["EmpStatus"]);
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("EmpCode \t     |      Empname\t       |    Department\t        |        EmployeeStatus");
                Console.WriteLine("---------------------------------------------------------------------------------------");

            foreach (DataRow row in dsEmployment.Tables["Employees"].Rows)
            {
                //Console.WriteLine("{0}    \t     |      {1}   \t       |     {2}    \t      |       {3}", row["Empcode"],
                //    row["EmpName"], row["EmpDept"], row["EmpStatusID"]);


                //if we want the type of employement as a string and not id
                Console.WriteLine("******************************************************");
                int irow = int.Parse(row["EmpStatusID"].ToString());

                DataRow currentrow = dsEmployment.Tables["EmployeeStatus"].Rows[irow - 1];
                Console.WriteLine("{0}    \t     |      {1}   \t       |     {2}    \t      |       {3}", row["Empcode"],
                    row["EmpName"], row["EmpDept"], currentrow["EmpStatus"]);
            }
            Console.Read();

        }
    }
}
