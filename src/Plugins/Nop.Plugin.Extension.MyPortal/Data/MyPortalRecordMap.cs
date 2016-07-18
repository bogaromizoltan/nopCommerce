using Nop.Plugin.Extension.MyPortal.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Extension.MyPortal.Data
{
    public class ParcelRecordMap : EntityTypeConfiguration<ParcelRecord>
    {
        public ParcelRecordMap()
        {
            ToTable("Parcels");
            HasKey(p => p.Id);
            Property(p => p.ParcelNumber);
            Property(p => p.Size);
            
            //HasRequired(p => p.Customer).WithMany().HasForeignKey(p => p.CustomerId);
        }
    }
}
