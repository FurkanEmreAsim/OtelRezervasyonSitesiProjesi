using PoseidonDeluxeBusiness.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoseiodonDeluxeModel.Entities;
using PoseidonDeluxeDataAccess.Concrete.EntityFrameWork.EntitiesDAccess;
using PoseidonDeluxeDataAccess.Concrete.EntityFrameWork;

namespace PoseidonDeluxeBusiness.Concrete
{
    
   public class RoomManagement:IRoomService
    {
       PoseidonDeluxeDBContext db = new PoseidonDeluxeDBContext();
       EFRoomDAL _efroomDAL;

       public RoomManagement()
       {
           _efroomDAL = new EFRoomDAL();
       }

        public void Add(Rooms item)
        {
            _efroomDAL.Add(item);
        }

        public void Delete(Rooms item)
        {
            _efroomDAL.Delete(item);
        }

        public void Update(Rooms item)
        {
            _efroomDAL.Update(item);
        }

        public ICollection<Rooms> GetAll()
        {
          return  _efroomDAL.GetAll();
        }

        public Rooms GetById(int? item)
        {
           return _efroomDAL.Get(x=>x.RoomNumber==item);
        }


        public ICollection<Rooms> GetEmptyRoomNumbers()
        {

            return _efroomDAL.GetAll(x => x.IsEmpty == true);
            


        }


      
    }
}
