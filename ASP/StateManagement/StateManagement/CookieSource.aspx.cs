using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class QuerySource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {
            //1. persistent cookies
            //HttpCookie hc = new HttpCookie("OurEgCookie");
            //hc["d1"] = txtlogin.Text;
            //hc["d2"] = txtpassword.Text;

            ////we can set the expiry for the cookie
            //hc.Expires = DateTime.Now.AddMinutes(5);
            //Response.Cookies.Add(hc);
            //Response.Redirect("CookieDestination.aspx");

            //2. non persistant cookie

            Response.Cookies["lname"].Value = txtlogin.Text;
            Response.Cookies["password"].Value = txtpassword.Text;
            Response.Redirect("CookieDestination.aspx");
        }
    }
}