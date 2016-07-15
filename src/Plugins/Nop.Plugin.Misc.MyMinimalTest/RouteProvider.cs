using Nop.Web.Framework.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Web.Mvc;
using Nop.Plugin.Misc.MyMinimalTest.Infrastructure;

namespace Nop.Plugin.Misc.MyMinimalTest
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

        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Misc.MyMinimalTest.Index", 
                "Plugins/MyMinimalTest/Index",
                new { controller = "MyMinimalTest", action = "Index" },
                new[] { "Nop.Plugin.Misc.MyMinimalTest.Controllers" });

            ViewEngines.Engines.Add(new CustomViewEngine());
        }
    }
}
