using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Viewstate variables of one page are not available to other pages
            //  lblmsg.Text = ViewState["login"].ToString() + " " + ViewState["pass"].ToString();

            //same test with the hidden field does not even show up the hiddenfield object to refer

          //  lblmsg.Text = HiddenField1.Value + " " + HiddenField2.Value;
        }
    }
}