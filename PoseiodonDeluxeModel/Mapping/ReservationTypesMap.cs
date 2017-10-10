using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseiodonDeluxeModel.Mapping
{
   public class ReservationTypesMap:EntityTypeConfiguration<ReservationTypes>
    {
       public ReservationTypesMap()
       {
           ToTable("ReservationType");

           HasKey(x => x.ReservationTypeID);

           Property(x => x.ReservationTypeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

           Property(x => x.ReservationType).HasMaxLength(50).IsRequired();

           Property(x => x.Description).HasMaxLength(150).IsRequired();

           Property(x => x.CreationDate).IsRequired();

           Property(x => x.LastModifiedDate).IsOptional();

           Property(x => x.CreatedBy).IsOptional();

       }
    }
}
