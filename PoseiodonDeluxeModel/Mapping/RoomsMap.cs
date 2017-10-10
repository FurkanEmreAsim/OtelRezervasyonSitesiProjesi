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
   public class RoomsMap:EntityTypeConfiguration<Rooms>
    {
       public RoomsMap()
       {
           ToTable("Room");

           HasKey(x => x.RoomNumber);

           Property(x => x.RoomNumber).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

         //  Property(x => x.RoomPrice).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

           Property(x => x.RoomPrice).IsRequired();

           Property(x => x.RoomImage).IsOptional();

           Property(x => x.IsEmpty).IsRequired();

           Property(x => x.IsActive).IsRequired();

           Property(x => x.CreationDate).IsRequired();

           Property(x => x.LastModifiedDate).IsOptional();

           Property(x => x.CreatedBy).IsOptional();


       }
    }
}
