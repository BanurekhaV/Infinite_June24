using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelpersPrj.CustomHelpers
{
    public class CustomHelper
    {
        public static IHtmlString LabelWithmark(string content)
        {
            string htmlstr = String.Format("<label><b><mark><i><del>{0}</del></i</mark></b></label>", content);
            return new HtmlString(htmlstr);
        }
    }
}