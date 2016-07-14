using Nop.Web.Framework.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Extension.MyPortal.Infrastructure
{
    public class MyPortalViewEngine : ThemeableRazorViewEngine
    {
        public MyPortalViewEngine()
        {
            ViewLocationFormats = new[] { "~/Plugins/Extension.MyPortal/Views/{0}.cshtml" };
            PartialViewLocationFormats = new[] { "~/Plugins/Extension.MyPortal/Views/{0}.cshtml" };
        }
    }
}
