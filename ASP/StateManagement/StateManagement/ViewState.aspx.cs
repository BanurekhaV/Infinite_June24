using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            ViewState["login"] = txtlogin.Text;
            ViewState["pass"] = txtpassword.Text;
            txtlogin.Text = string.Empty;
            txtpassword.Text = "";
        }

        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            //1. 
            //Response.Redirect("TestForm.aspx");
            string a = ViewState["login"].ToString();
            string b = ViewState["pass"].ToString();

            lblmessage.Text = "Your Login name is : " + a + " " + "and your password is :" + b;
           // lblmessage.Text = ViewState["login"].ToString() + " " + ViewState["pass"].ToString();

        }
    }
}