using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingPrj
{
    public partial class RedirectVsTransfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            Context.Items.Add("Name", txtname.Text);
            Context.Items.Add("Email", txtemail.Text);

            //1.
            // Response.Redirect("OtherPage.aspx");  // other page in the same webserver
            //1.1 redirecting to other web server
            //  Response.Redirect("https://www.google.com"); //other page in another server


            //2.
              Server.Transfer("OtherPage.aspx"); // other page in the same webserver
           // Server.Transfer("http://www.google.com");   //other page in another server
        }
    }
}