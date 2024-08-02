using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class ApplicationState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnApp_Click(object sender, EventArgs e)
        {
            int count = 0;
            if(Application["visits"]!=null)
            {
                count = Convert.ToInt32(Application["visits"].ToString());
            }
            count = count + 1;
            Application["visits"] = count;
            lblcount.Text = "Total Visits to the Application = " + count.ToString();
        }
    }
}