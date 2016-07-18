using Nop.Core;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Plugin.Extension.MyPortal.Domain;
using Nop.Plugin.Extension.MyPortal.Models;
using Nop.Plugin.Extension.MyPortal.Service;
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
        private IParcelService _parcelService;

        private readonly IWorkContext _workContext = EngineContext.Current.Resolve<IWorkContext>();

        public MyPortalController(IParcelService parcelService)
        {
            _parcelService = parcelService;  
        }

        public ActionResult Index()
        {
            var myparcels = _parcelService.GetCurrentCustomersParcels();

            var model = myparcels.Select(p => new ParcelModel { ParcelNumber = p.ParcelNumber, Size = p.Size, CustomerId = p.CustomerId });

            return View("~/Plugins/Extension.MyPortal/Views/Index.cshtml", model: model);
        }

        public ActionResult Create()
        {
            return View("~/Plugins/Extension.MyPortal/Views/Create.cshtml");
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "ParcelNumber,Size,CustomerId")]ParcelModel model)
        {
            if (ModelState.IsValid)
            {
                _parcelService.CreateNewParcel(model.ParcelNumber, model.Size);
                return RedirectToAction("Index", "MyPortal");
            }
            return View("~/Plugins/Extension.MyPortal/Views/Create.cshtml", model: model);
        }
    }
}
