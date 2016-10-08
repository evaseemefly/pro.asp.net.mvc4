using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        // GET: Admin


        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Create()
        {
            return View();
        }

        public ViewResult Edit(int productId)
        {
            return View();
        }
    }
}