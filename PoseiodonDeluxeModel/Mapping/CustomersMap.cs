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
   public class CustomersMap:EntityTypeConfiguration<Customers>
    {
       public CustomersMap()
       {
           ToTable("Customer");

           HasKey(x => x.CustomerID);

           Property(x => x.CustomerID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

           Property(x => x.CustomerName).HasMaxLength(50).IsRequired();

           Property(x => x.CustomerLastName).HasMaxLength(50).IsRequired();

           Property(x => x.CustomerCivilization).HasMaxLength(11).IsRequired();

           Property(x => x.Gender).HasMaxLength(6).IsRequired();

           Property(x => x.CreationDate).IsRequired();

           Property(x => x.LastModifiedDate).IsOptional();
           //veritabanı oluştu mu evet sen:)
       }
    }
}
