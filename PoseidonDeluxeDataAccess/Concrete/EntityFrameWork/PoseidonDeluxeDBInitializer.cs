using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeDataAccess.Concrete.EntityFrameWork.EntitiesDAccess
{
    public class PoseidonDeluxeDBInitializer : CreateDatabaseIfNotExists<PoseidonDeluxeDBContext>
    {
        protected override void Seed(PoseidonDeluxeDBContext context)
        {
            #region defaultReservationTypes

            List<ReservationTypes> defaultReservationTypes = new List<ReservationTypes>();

            defaultReservationTypes.Add(new ReservationTypes() { ReservationType = "Standart",ReservationTypePrice=50, Description = "Sadece oda ve kahvaltı dahildir.", CreationDate = DateTime.Now.Date, LastModifiedDate = DateTime.Now.Date });

            defaultReservationTypes.Add(new ReservationTypes() { ReservationType = "Full", ReservationTypePrice = 100, Description = "Oda ve tüm öğünler dahildir.", CreationDate = DateTime.Now.Date, LastModifiedDate = DateTime.Now.Date });

            defaultReservationTypes.Add(new ReservationTypes() { ReservationType = "Full + Full", ReservationTypePrice = 150, Description = "Oda, yemek ve içki dahildir.", CreationDate = DateTime.Now.Date, LastModifiedDate = DateTime.Now.Date });

            foreach (ReservationTypes item in defaultReservationTypes)
            {
                context.ReservationType.Add(item);
            }

            #endregion

            #region defaultPriceRates

            List<PriceRates> defaultPriceRates = new List<PriceRates>();

            defaultPriceRates.Add(new PriceRates() { PriceRateID = "SHİ", RateName = "Standart İki Kişilik HAFTAİÇİ", Rate = 100, CreationDate = DateTime.Now.Date, LastModifiedDate = DateTime.Now.Date });

            defaultPriceRates.Add(new PriceRates() { PriceRateID = "SHS", RateName = "Standart İki Kişilik HAFTASONU", Rate = 130, CreationDate = DateTime.Now.Date, LastModifiedDate = DateTime.Now.Date });

            defaultPriceRates.Add(new PriceRates() { PriceRateID = "ÜHİ", RateName = "Standart Üç Kişilik HAFTAİÇİ", Rate = 120, CreationDate = DateTime.Now.Date, LastModifiedDate = DateTime.Now.Date });

            defaultPriceRates.Add(new PriceRates() { PriceRateID = "ÜHS", RateName = "Standart Üç Kişilik HAFTASONU", Rate = 156, CreationDate = DateTime.Now.Date, LastModifiedDate = DateTime.Now.Date });

            defaultPriceRates.Add(new PriceRates() { PriceRateID = "THİ", RateName = "Standart Tek Kişilik HAFTAİÇİ", Rate = 70, CreationDate = DateTime.Now.Date, LastModifiedDate = DateTime.Now.Date });

            defaultPriceRates.Add(new PriceRates() { PriceRateID = "THS", RateName = "Standart Tek Kişilik HAFTASONU", Rate = 91, CreationDate = DateTime.Now.Date, LastModifiedDate = DateTime.Now.Date });

            foreach (PriceRates item in defaultPriceRates)
            {
                context.PriceRate.Add(item);
            }

            #endregion

            #region defaultRooms

            List<Rooms> defaultRooms = new List<Rooms>();

            for (int i = 100; i < 116; i++)
            {
                defaultRooms.Add(new Rooms() { RoomNumber = i + 1, RoomPrice = 100, IsEmpty = true, IsActive = true, CreationDate = DateTime.Now.Date, LastModifiedDate = DateTime.Now.Date });
            }

          
            foreach (Rooms item in defaultRooms)
            {
                context.Room.Add(item);
            }

            #endregion

            base.Seed(context);
        }
    }
}
