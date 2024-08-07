using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ExceptionPrj
{
    public partial class DataForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/Employees.xml"));
                Grid1.DataSource = ds;
                Grid1.DataBind();
            }
            catch (Exception ex)
            {
                ExceptionLogging.LogExceptionDB(ex);
                lblmsg1.Text = "Some Technical error occured.. try after sometime";
            }
        }

        //protected void Page_Error(object sender, EventArgs e)
        //{
        //    Exception ex = Server.GetLastError();
        //    Server.ClearError();
        //    Response.Write(ex.GetType());
        //    Server.Transfer("~/Errors.aspx");
        //   // Response.Redirect("Errors.aspx");
        //}
    }
}