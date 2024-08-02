using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class SecondSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtngetSession_Click(object sender, EventArgs e)
        {
            lbl1.Text = Session["name"].ToString();
            lbl2.Text = Session["city"].ToString();
        }
    }
}