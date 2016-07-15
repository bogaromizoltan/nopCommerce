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
                return 0;
            }
        }

        public void RegisterRoutes(System.Web.Routing.RouteCollection routes)
        {
            routes.MapRoute("Plugin.Extension.MyPortal.Index",
                "Plugins/MyPortal/Index",
                new { controller = "MyPortal", action = "Index" },
                new[] { "Nop.Plugin.Extension.MyPortal.Controllers" });

            //ViewEngines.Engines.Add(new MyPortalViewEngine());
        }
    }
}
