using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace ControllerFactory.Controllers
{
    public class RemoteDataController : AsyncController
    {
        // GET: RemoteData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Data()
        {
            return View();
        }

        public async Task<ActionResult> DataAsync()
        {

            string data = await new ControllerFactory.Service.RemoteService().GetRemoteDataAsync();
            return View("Data", (object)data);
        }

       
    }
}