using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingPrj
{
    public partial class AutoGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            GridView1.DataBind();
        }
    }
}