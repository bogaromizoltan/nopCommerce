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
        private ParcelRecordObjectContext _context;
        private IRepository<ParcelRecord> _repo;

        public MyPortalPlugin(ParcelRecordObjectContext context, IRepository<ParcelRecord> repo)
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
            this.AddOrUpdatePluginLocaleResource("Plugins.Extension.MyPortal.Label", "My parcels", "en-US");
            this.AddOrUpdatePluginLocaleResource("Plugins.Extension.MyPortal.Label", "Földjeim", "hu-HU");
            this.AddOrUpdatePluginLocaleResource("Plugins.Extension.MyPortal.Models.ParcelModel.ParcelNumber", "Parcel number", "en-US");
            this.AddOrUpdatePluginLocaleResource("Plugins.Extension.MyPortal.Models.ParcelModel.ParcelNumber", "Helyrajzi szám", "hu-HU");
            this.AddOrUpdatePluginLocaleResource("Plugins.Extension.MyPortal.Models.ParcelModel.Size", "Size", "en-US");
            this.AddOrUpdatePluginLocaleResource("Plugins.Extension.MyPortal.Models.ParcelModel.Size", "Méret", "hu-HU");
            this.AddOrUpdatePluginLocaleResource("Plugins.Extension.MyPortal.CreateNew", "Create new", "en-US");
            this.AddOrUpdatePluginLocaleResource("Plugins.Extension.MyPortal.CreateNew", "Új megadása", "hu-HU");
            _context.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            this.DeletePluginLocaleResource("Plugins.Extension.MyPortal.Label");
            _context.Uninstall();
            base.Uninstall();
        }
    }
}
