using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingPrj
{
    public partial class OtherPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Response.Write(string.Format("The Name is {0} and the Email Id is :{1}",
                    Context.Items["Name"].ToString(), Context.Items["Email"].ToString()));
            }
            catch (NullReferenceException nre)
            {
                Response.Write(nre.Message);
            }
        }
    }
}