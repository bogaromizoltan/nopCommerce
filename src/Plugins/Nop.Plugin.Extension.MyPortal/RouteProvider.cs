using Nop.Plugin.Extension.MyPortal.Infrastructure;
using Nop.Web.Framework.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nop.Plugin.Extension.MyPortal
{
    public class RouteProvider : IRouteProvider
    {
        public int Priority
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void RegisterRoutes(System.Web.Routing.RouteCollection routes)
        {
            routes.MapRoute("Nop.Plugin.Extension.MyPortal.Index",
                "MyPortal/Index",
                new { controller = "MyPortal", action = "Index" },
                new[] { "Nop.Plugin.Extension.MyPortal.Controllers" });

            ViewEngines.Engines.Insert(0, new MyPortalViewEngine());
        }
    }
}
