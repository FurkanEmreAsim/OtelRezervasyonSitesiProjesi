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
   public class PriceRatesMap:EntityTypeConfiguration<PriceRates>
    {
       public PriceRatesMap()
       {
           ToTable("PriceRates");

           HasKey(x => x.PriceRateID);

           //Property(x => x.PriceRateID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

           Property(x => x.PriceRateID).HasMaxLength(50);

           Property(x => x.RateName).HasMaxLength(50).IsRequired();

           Property(x => x.Rate).IsRequired();

           Property(x => x.CreationDate).IsRequired();

           Property(x => x.LastModifiedDate).IsOptional();

           Property(x => x.CreatedBy).IsOptional();

       }
    }
}
