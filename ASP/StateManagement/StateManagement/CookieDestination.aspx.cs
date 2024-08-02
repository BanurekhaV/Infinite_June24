using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class CookieDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            //persistent cookie
            //HttpCookie rc = Request.Cookies["OurEgCookie"];
            //lbldata1.Text = rc["d1"];
            //lbldata2.Text = rc["d2"];

            //non persistant cookie
            lbldata1.Text = Request.Cookies["lname"].Value.ToString();
            lbldata2.Text = Request.Cookies["password"].Value.ToString();
        }
    }
}