using Nop.Plugin.Extension.MyPortal.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Extension.MyPortal.Data
{
    public class MyPortalRecordMap : EntityTypeConfiguration<MyPortalRecord>
    {
        public MyPortalRecordMap()
        {
            ToTable("Parcels");
            HasKey(p => p.Id);
            Property(p => p.ParcelNumber);
            Property(p => p.Size);
            //HasRequired(p => p.Customer).WithOptional(t => t.Parcels);
            //FIGYELEM BELE KELL MÓKOLNI AZ EREDETI CUCCBA A FOREIGN KEY MIATT
        }
    }
}
