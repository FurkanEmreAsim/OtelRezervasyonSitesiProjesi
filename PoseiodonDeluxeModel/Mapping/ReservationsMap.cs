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
   public class ReservationsMap:EntityTypeConfiguration<Reservations>
    {
       public ReservationsMap()
       {
           //ToTable("Reservation");

           HasKey(x => x.ReservationID);

           Property(x => x.ReservationID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

           Property(x => x.CreatedDate).IsRequired();

           Property(x => x.ReservationPrice).IsRequired();

           Property(x => x.TotalPeople).IsRequired();

           Property(x => x.DateOfEntry).IsRequired();

           Property(x => x.DateOfOut).IsRequired();

           Property(x => x.LastModifiedDate).IsOptional();

           Property(x => x.IsActive).IsRequired();

           HasRequired(x => x.User).WithMany(x => x.Reservation).HasForeignKey(x => x.CreatedBy);

           HasRequired(x => x.ReservationType).WithMany(x => x.Reservation).HasForeignKey(x => x.ReservationTypeID);
       }
    }
}
