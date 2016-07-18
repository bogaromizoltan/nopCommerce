using Nop.Web.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Extension.MyPortal.Models
{
    public class ParcelModel
    {
        [NopResourceDisplayName("Plugins.Extension.MyPortal.Models.ParcelModel.ParcelNumber")]
        public string ParcelNumber { get; set; }

        [NopResourceDisplayName("Plugins.Extension.MyPortal.Models.ParcelModel.Size")]
        public decimal Size { get; set; }

        public int CustomerId { get; set; }
    }
}
