using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello World..");
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }
    }
}