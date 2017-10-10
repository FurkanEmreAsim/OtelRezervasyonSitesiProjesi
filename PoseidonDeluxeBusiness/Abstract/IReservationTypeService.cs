using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeBusiness.Abstract
{
   public interface IReservationTypeService
    {
        void Add(ReservationTypes item);
        void Delete(ReservationTypes item);
        void Update(ReservationTypes item);
        ICollection<ReservationTypes> GetAll();
        ReservationTypes GetById(int? item);
    }
}
