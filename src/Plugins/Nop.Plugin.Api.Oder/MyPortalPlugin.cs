using Nop.Core.Data;
using Nop.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Api.Order
{
    public class MyPortalPlugin : BasePlugin
    {

        public MyPortalPlugin()
        {

        }

        public bool Authenticate()
        {
            return true; //...TODO
        }

        public override void Install()
        {
            base.Install();
        }

        public override void Uninstall()
        {
            base.Uninstall();
        }
    }
}
