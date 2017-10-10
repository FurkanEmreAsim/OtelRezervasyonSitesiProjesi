using PoseidonDeluxeBusiness.Abstract;
using PoseidonDeluxeDataAccess.Concrete.EntityFrameWork.EntitiesDAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoseiodonDeluxeModel.Entities;

namespace PoseidonDeluxeBusiness.Concrete
{
   public class ReservationManagement :IReservationService
    {

       EFReservationDAL _efreservationDAL;

       public ReservationManagement()
       {
           _efreservationDAL = new EFReservationDAL();
       }

        public void Add(Reservations item)
        {
            _efreservationDAL.Add(item);
        }

        public void Delete(Reservations item)
        {
            _efreservationDAL.Delete(item);
        }

        public void Update(Reservations item)
        {
            _efreservationDAL.Update(item);
        }

        public ICollection<Reservations> GetAll()
        {
           return _efreservationDAL.GetAll();
        }

        public Reservations GetById(int? item)
        {
          return  _efreservationDAL.Get(x=>x.ReservationID==item);
        }


        public Reservations GetEntryandOutDateByRoomNumber(int RoomNumber)
        {
            return null;
            //return _efreservationDAL.Get(x => x.RoomNumber == RoomNumber);
        }


      
    }
}
