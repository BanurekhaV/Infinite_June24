using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = txtlogin.Text;
            HiddenField2.Value = txtpassword.Text;
            txtlogin.Text = "";
            txtpassword.Text = string.Empty;
        }

        protected void BtnLoad_Click(object sender, EventArgs e)
        {
           // Response.Redirect("TestForm.aspx"); data stored in the hiddenfield of one page is not 
           //avaialable on other pages
            lblmessage.Text = HiddenField1.Value + " " + HiddenField2.Value;
        }
    }
}