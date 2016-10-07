using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers.Infrastructure
{
    public class CustomRedirectrResult : ActionResult
    {
        public string Url { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {
            string fullUrl = UrlHelper.GenerateContentUrl(Url, context.HttpContext);

            context.HttpContext.Response.Redirect(fullUrl);
        }
    }
}