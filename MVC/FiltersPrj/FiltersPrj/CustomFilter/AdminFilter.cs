using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FiltersPrj.CustomFilter
{
    public class AdminFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool isAdmin = Convert.ToBoolean(filterContext.HttpContext.Session["IsAdmin"]);
            string ReturnUrl = null;
            if(!isAdmin)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {
                        "controller",
                        "Home"
                    },
                    {"action","Login" },
                    {"ReturnUrl" , filterContext.HttpContext.Request.Url.GetComponents(UriComponents.PathAndQuery,
                    UriFormat.SafeUnescaped)}
                });
                ReturnUrl = filterContext.HttpContext.Request.Url.GetComponents(UriComponents.PathAndQuery,
                    UriFormat.SafeUnescaped);
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {
                        "controller",
                        "Home"
                    },
                    {"action","About" },
                    {"ReturnUrl" , filterContext.HttpContext.Request.Url.GetComponents(UriComponents.PathAndQuery,
                    UriFormat.SafeUnescaped)}
                });
                ReturnUrl = filterContext.HttpContext.Request.Url.GetComponents(UriComponents.PathAndQuery,
                    UriFormat.SafeUnescaped);
            }
        }
    }
}