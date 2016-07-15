using Nop.Core;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Plugin.Extension.MyPortal.Domain;
using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nop.Plugin.Extension.MyPortal.Controllers
{
    public class MyPortalController : BasePluginController
    {
        private IRepository<MyPortalRecord> _repo;

        private readonly IWorkContext _workContext = EngineContext.Current.Resolve<IWorkContext>();

        public MyPortalController(IRepository<MyPortalRecord> repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            ViewBag.name = _workContext.CurrentCustomer.Username;
            ViewBag.myid = _workContext.CurrentCustomer.Id;
            return View("~/Plugins/Extension.MyPortal/Views/Index.cshtml");
        }
    }
}
