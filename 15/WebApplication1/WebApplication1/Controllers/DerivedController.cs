using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication1.Controllers
{
    public class DerivedController : Controller
    {

        public ActionResult ShowIndex(string city, DateTime dt)
        {

            return View(dt);
        }

        public ViewResult ShowDate()
        {
            DateTime dt = DateTime.Now;
            
            return View(dt);
        }

        public RedirectToRouteResult Redirect()
        {
            return RedirectToRoute(new {
                Controller= "Derived",
                Action= "ShowDate",
                ID="SDF"
            });

            return RedirectToAction("Index", "Derived");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index_Context()
        {
            //Request.QueryString;
            //Request.Form;
            return View();
        }

        // GET: Derived
        public ViewResult Index()
        {
            ViewBag.Message = "Hello";
            return View();
            //return View("Index", "_布局页");
            //return new ViewResult {  ViewName}
        }

        public ActionResult ProduceOutput()
        {
            if (Server.MachineName == "ADMIN-PC")
                return new Infrastructure.CustomRedirectrResult { Url = "/Basic/Index" };
            else
            {
                Response.Write("123123");
                return null;
            }

            //以上部分可修改为
            return Redirect("Basic/Index");
        }
    }
}