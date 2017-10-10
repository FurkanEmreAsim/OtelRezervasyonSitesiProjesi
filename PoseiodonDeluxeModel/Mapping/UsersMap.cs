using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseiodonDeluxeModel.Mapping
{
  public class UsersMap:EntityTypeConfiguration<Users>
    {

      public UsersMap ()
	{
          
         //ToTable("User");

           HasKey(x => x.UserID);

           Property(x => x.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

           Property(x => x.Email).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("Email_Unique") { IsUnique = true }));

           Property(x => x.Email).HasMaxLength(50).IsRequired();

           Property(x => x.Password).HasMaxLength(16).IsRequired();

           Property(x => x.FirstName).HasMaxLength(50).IsRequired();

           Property(x => x.LastName).HasMaxLength(50).IsRequired();

           Property(x => x.CreationDate).IsRequired().HasColumnType("date");

           Property(x => x.LastModifiedDate).IsOptional().HasColumnType("date");

         

         



          
	}


    }
}
