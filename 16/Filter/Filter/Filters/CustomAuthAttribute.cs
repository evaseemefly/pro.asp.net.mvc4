using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Filters
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {
        private bool localAllowed;

        public CustomAuthAttribute(bool allowedParam)
        {
            localAllowed = allowedParam;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.IsLocal)
            {
                return localAllowed;
            }
            else
            {
                return true;
            }

        }

        public class CustomActionAttribute : FilterAttribute, IActionFilter
        {
            public void OnActionExecuting(ActionExecutingContext filterContext)
            {
                if (filterContext.HttpContext.Request.IsLocal)
                {
                    filterContext.Result = new HttpNotFoundResult();
                }
            }
            public void OnActionExecuted(ActionExecutedContext filterContext)
            {
                // not yet implemented        }
            }

        }
    }
}