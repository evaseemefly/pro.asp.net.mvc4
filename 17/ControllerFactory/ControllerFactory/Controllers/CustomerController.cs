using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerFactory.Models;

namespace ControllerFactory.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ActionName = "Index",
                ControllerName = "Customer"
            });
        }

        public ViewResult List()
        {
            return View("Result", new Result
            {
                ActionName = "List",
                ControllerName = "Customer"
            });
        }
    }
}