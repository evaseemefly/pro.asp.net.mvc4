using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Filters
{
    public class RangeExceptionAttribute:FilterAttribute,IExceptionFilter
    {
        
       public void OnException(ExceptionContext filterContext)
        {
            if(!filterContext.ExceptionHandled&&filterContext.Exception is ArgumentOutOfRangeException)
            {
                filterContext.Result = new RedirectResult("~/Content/RangeErrorPage.html");
            }
        }
    }
}