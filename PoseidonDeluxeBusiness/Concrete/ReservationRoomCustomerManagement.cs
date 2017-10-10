using PoseidonDeluxeBusiness.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoseiodonDeluxeModel.Entities;
using PoseidonDeluxeDataAccess.Concrete.EntityFrameWork.EntitiesDAccess;

namespace PoseidonDeluxeBusiness.Concrete
{
   public class ReservationRoomCustomerManagement:IReservationRoomCustomerService
    {

       EFReservationCustomerRoomDAL _efreservationcustomerroomDAL;

       public ReservationRoomCustomerManagement()
       {
           _efreservationcustomerroomDAL = new EFReservationCustomerRoomDAL();
       }

        

        public ICollection<ReservationCustomerRoom> GetAll()
        {
            return  _efreservationcustomerroomDAL.GetAll();
        }




        public void Add(ReservationCustomerRoom item)
        {
            _efreservationcustomerroomDAL.Add(item);
        }




        public ICollection<ReservationCustomerRoom> GetReservationCustomerRoom(int RoomNumber)
        {
            return _efreservationcustomerroomDAL.GetAll(x => x.RoomID == RoomNumber);
        }
    }
}
