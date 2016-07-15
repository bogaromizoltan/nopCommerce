using Nop.Core.Data;
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

        public MyPortalController(IRepository<MyPortalRecord> repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            return View("~/Plugins/Extension.MyPortal/Views/Index.cshtml");
        }
    }
}
