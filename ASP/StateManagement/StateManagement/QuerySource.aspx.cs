using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class QuerySource1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("QueryDestination.aspx?uname=" + txtlogin.Text +
                "&password=" + txtpassword.Text);
        }
    }
}