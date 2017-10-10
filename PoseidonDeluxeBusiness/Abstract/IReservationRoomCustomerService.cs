using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeBusiness.Abstract
{
   public interface IReservationRoomCustomerService
    {
       void Add(ReservationCustomerRoom item);
        ICollection<ReservationCustomerRoom> GetAll();

         //List<ReservationCustomerRoom> GetReservationCustomerRoom(int RoomNumber);

        
    }
}
