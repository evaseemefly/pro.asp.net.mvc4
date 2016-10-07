using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers.Tests
{
    [TestClass()]
    public class DerivedControllerTests
    {


        [TestMethod()]
        public void IndexTest()
        {
            //准备 创建控制器


            DerivedController target = new DerivedController();

            //动作 调用控制器
            ViewResult result = target.Index();

            Assert.AreEqual("", result.ViewName);
        }

        [TestMethod()]
        public void ShowDateTest()
        {
            //准备 创建控制器
            DerivedController target = new DerivedController();

            ViewResult result = target.ShowDate();

            Assert.AreEqual("", result.ViewData.Model.ToString());

        }

        [TestMethod()]
        public void RedirectTest()
        {
            //准备 创建控制器
            DerivedController target = new DerivedController();

            RedirectToRouteResult result = target.Redirect();

            Assert.IsFalse(result.Permanent);

            Assert.AreEqual("Derived", result.RouteValues["controller"]);
        }
    }
}