using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeBusiness.Abstract
{
   public interface IRoomService
    {
        void Add(Rooms item);
        void Delete(Rooms item);
        void Update(Rooms item);
        ICollection<Rooms> GetAll();
        Rooms GetById(int? item);

        ICollection<Rooms> GetEmptyRoomNumbers();
    }
}
