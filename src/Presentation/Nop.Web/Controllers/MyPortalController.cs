using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nop.Web.Framework.Security;

namespace Nop.Web.Controllers
{
    public class MyPortalController : BasePublicController
    {
        // GET: MyPortal
        public ActionResult Index()
        {
            return View();
        }
    }
}