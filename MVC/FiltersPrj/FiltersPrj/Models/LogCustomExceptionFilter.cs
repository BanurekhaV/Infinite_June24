using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;

namespace FiltersPrj.Models
{
    public class LogCustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        //we shall log the exception to a text file inside errorlog folder
        public void OnException(ExceptionContext filtercontext)
        {
            if(!filtercontext.ExceptionHandled)
            {
                var exceptionmessage = filtercontext.Exception.Message;
                var stacktrace = filtercontext.Exception.StackTrace;
                var controllername = filtercontext.RouteData.Values["controller"].ToString();
                var actionname = filtercontext.RouteData.Values["action"].ToString();
                var etype = filtercontext.Exception.GetType();

                string msg = "Date : " + DateTime.Now.ToString() + ", Controller is : " +
                    " " + controllername + " Action method : " + actionname +
                    "Error Message : " + exceptionmessage + "Exception Type : " + etype +
                    Environment.NewLine + "Stack Trace : " + stacktrace;

                File.AppendAllText(HttpContext.Current.Server.MapPath("~/ErrorLog/Log.txt"), msg);
                filtercontext.ExceptionHandled = true;

                if(etype.Equals(typeof(System.NullReferenceException)))
                {
                    filtercontext.Result = new ViewResult()
                    { ViewName = "NullReference" };
                }
                else if (etype.Equals(typeof(System.DivideByZeroException)))
                {
                    filtercontext.Result = new ViewResult()
                    { ViewName = "DivideByZero" };
                }
                else
                {
                    filtercontext.Result = new ViewResult()
                    { ViewName = "Error" };
                }

            }
        }

    }
}