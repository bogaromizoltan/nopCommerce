using Nop.Core.Data;
using Nop.Core.Plugins;
using Nop.Plugin.Extension.MyPortal.Data;
using Nop.Plugin.Extension.MyPortal.Domain;
using Nop.Services.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Extension.MyPortal
{
    public class MyPortalPlugin : BasePlugin
    {
        private MyPortalRecordObjectContext _context;
        private IRepository<MyPortalRecord> _repo;

        public MyPortalPlugin(MyPortalRecordObjectContext context, IRepository<MyPortalRecord> repo)
        {
            _context = context;
            _repo = repo;
        }

        public bool Authenticate()
        {
            return true; //...TODO
        }

        public override void Install()
        {
            this.AddOrUpdatePluginLocaleResource("Plugins.Extension.MyPortal.Label", "My site", "en-US");
            this.AddOrUpdatePluginLocaleResource("Plugins.Extension.MyPortal.Label", "My site", "hu-HU");
            _context.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            this.DeletePluginLocaleResource("Plugins.Extension.MyPortal.Label");
            _context.Uninstall();
            base.Uninstall();
        }

        public Web.Framework.Menu.SiteMapNode BuildMenuItem()
        {
            return null; //TOdO BLAVLAJSFdilhasdilgh
        }
    }
}
