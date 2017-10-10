using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeBusiness.Abstract
{
   public interface IReservationService
    {
        void Add(Reservations item);
        void Delete(Reservations item);
        void Update(Reservations item);
        ICollection<Reservations> GetAll();
        Reservations GetById(int? item);
        Reservations GetEntryandOutDateByRoomNumber(int RoomNumber);   
     
    }
}
