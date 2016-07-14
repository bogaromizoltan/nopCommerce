using Nop.Core;
using Nop.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MainPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkContext _workContext = EngineContext.Current.Resolve<IWorkContext>();

        public ActionResult Index()
        {
            int myid = _workContext.CurrentCustomer.Id;
            ViewBag.myid = myid;
            return View();
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