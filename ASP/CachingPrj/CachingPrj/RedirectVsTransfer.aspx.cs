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
           // Response.Redirect("OtherPage.aspx");

            //2.
            Server.Transfer("OtherPage.aspx");
        }
    }
}