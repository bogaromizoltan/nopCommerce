using Nop.Core;
using Nop.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainPage.Controllers
{
    public class AgrarPortalController : Controller
    {
        private readonly IWorkContext _workContext = EngineContext.Current.Resolve<IWorkContext>();

        // GET: AgrarPortal
        public ActionResult Index()
        {
            //int myid = _workContext.CurrentCustomer.Id;
            ViewBag.myid = 12;
            return View();
        }
    }
}