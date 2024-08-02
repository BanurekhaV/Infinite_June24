using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationsPrj
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Response.Redirect("Welcome.html");
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}