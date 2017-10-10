using PoseidonDeluxeDataAccess.Concrete.EntityFrameWork.EntitiesDAccess;
using PoseiodonDeluxeModel.Entities;
using PoseiodonDeluxeModel.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeDataAccess.Concrete.EntityFrameWork
{
   public class PoseidonDeluxeDBContext:DbContext
    {
       public PoseidonDeluxeDBContext() : base("Server=.;Database=PoseidonDeluxeDB;Integrated Security=True")
       {
           Database.SetInitializer(new PoseidonDeluxeDBInitializer());
       }

       public virtual DbSet<Users> User { get; set; }

       public virtual DbSet<Rooms> Room { get; set; }

       public virtual DbSet<ReservationTypes> ReservationType { get; set; }

       public virtual DbSet<Reservations> Reservation { get; set; }

       public virtual DbSet<ReservationCustomerRoom> ReservationCustomerRoom { get; set; }

       public virtual DbSet<PriceRates> PriceRate { get; set; }

       public virtual DbSet<Customers> Customer { get; set; }


       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Configurations.Add(new UsersMap());
           modelBuilder.Configurations.Add(new CustomersMap());
           modelBuilder.Configurations.Add(new ReservationsMap());
           modelBuilder.Configurations.Add(new ReservationTypesMap());
           modelBuilder.Configurations.Add(new RoomsMap());
           modelBuilder.Configurations.Add(new PriceRatesMap());
           modelBuilder.Configurations.Add(new ReservationCustomerRoomsMap());
       }
    }
}
