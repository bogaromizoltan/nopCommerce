using Nop.Core.Plugins;
using Nop.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace Nop.Plugin.Misc.MyMinimalTest
{
    class MyMinimalTestPlugin : BasePlugin, IMiscPlugin
    {
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "MyMinimalTest";
            routeValues = new RouteValueDictionary { { "Namespaces", "Nop.Plugin.Misc.MyMinimalTest.Controllers" }, { "area", null } };
        }
    }
}
