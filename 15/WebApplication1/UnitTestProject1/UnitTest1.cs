using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System.Web;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //准备 创建控制器
            DerivedController target = new DerivedController();

            //动作 调用控制器
            ViewResult result = target.Index();

            Assert.AreEqual("", result.ViewName);
        }
    }
}
