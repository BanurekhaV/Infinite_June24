using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Securityprj
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if(FormsAuthentication.Authenticate(txtlogin.Text, txtpass.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtlogin.Text, false);
            }
            else
            {
                lblmsg.Text = "Invalid User Name or Password";
            }
        }
    }
}