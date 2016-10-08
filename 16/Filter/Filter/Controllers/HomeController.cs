using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filter;
using Filter.Filters;

namespace Filter.Controllers
{
    public class HomeController : Controller
    {
        [CustomAuth(true)]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 使用动作过滤器
        /// </summary>
        /// <returns></returns>
        [CustomAuthTest]
        public string FilterTest()
        {
            return "过滤器测试";
        }

        [RangeException]
        public string RangeTest(int id)
        {
            if (id > 100)
            {
                return string.Format("the id value is:{0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("ids");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}