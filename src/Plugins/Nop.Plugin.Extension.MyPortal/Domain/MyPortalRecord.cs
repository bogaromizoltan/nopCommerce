using Nop.Core;
using Nop.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Extension.MyPortal.Domain
{
    public class MyPortalRecord : BaseEntity
    {
        //ITT ADATBÁZIS CUCC
        public string ParcelNumber { get; set; }
        public decimal Size { get; set; }

        //public Customer Customer { get; set; }
    }
}
