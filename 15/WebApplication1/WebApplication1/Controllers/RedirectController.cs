using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult RedirectToRoute()
        {
            TempData["Message"] = "sms";
            TempData["Date"] = DateTime.Now;
            return RedirectToAction("Index");
        }

         public ActionResult Index()
        {
            return View();
        }
    }
}