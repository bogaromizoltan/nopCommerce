using Nop.Core;
using Nop.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Extension.MyPortal.Domain
{
    public class ParcelRecord : BaseEntity
    {
        //ITT ADATBÁZIS CUCC
        public virtual string ParcelNumber { get; set; }
        public virtual decimal Size { get; set; }

        public virtual int CustomerId { get; set; }

        //public virtual Customer Customer { get; set; }
    }
}
