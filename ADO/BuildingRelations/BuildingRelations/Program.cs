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
            dcEmployees[1] = new DataColumn("EmpName", System.Type.GetType("System.string"));
            dcEmployees[2] = new DataColumn("EmpDept", System.Type.GetType("System.string"));
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
        }
    }
}
