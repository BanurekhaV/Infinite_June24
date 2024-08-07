using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Securityprj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Application code is executed here...   ");
            Response.Write(System.Security.Principal.WindowsIdentity.GetCurrent().Name + "<br/>");

            Response.Write("Is the user Authenticated ?  ");
            Response.Write(User.Identity.IsAuthenticated.ToString() + "<br/>");

            Response.Write("Authentication Type , if authenticated   ");
            Response.Write(User.Identity.AuthenticationType + "<br/>");

            Response.Write("User Name, if authenticated ..  ");
            Response.Write(User.Identity.Name + "<br/>");
        }
    }
}