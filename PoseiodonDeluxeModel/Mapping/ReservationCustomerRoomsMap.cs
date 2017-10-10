using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseiodonDeluxeModel.Mapping
{
   public class ReservationCustomerRoomsMap:EntityTypeConfiguration<ReservationCustomerRoom>
    {
       public ReservationCustomerRoomsMap()
       {
           ToTable("ReservationCustomerRoom");

           HasKey(x => new { x.CustomerID, x.ReservationID, x.RoomID });

           HasRequired(x => x.Customer).WithMany(x =>x.ReservationCustomerRoom ).HasForeignKey(x => x.CustomerID);

           HasRequired(x => x.Reservation).WithMany(x => x.ReservationCustomerRoom).HasForeignKey(x => x.ReservationID);

           HasRequired(x => x.Room).WithMany(x => x.ReservationCustomerRoom).HasForeignKey(x => x.RoomID);


       }
    }
}
