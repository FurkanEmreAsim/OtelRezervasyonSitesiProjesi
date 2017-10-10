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
   public class ReservationTypeManagement:IReservationTypeService
    {

       EFReservationTypeDAL _efreservationtypeDAL;

       public ReservationTypeManagement()
       {
           _efreservationtypeDAL = new EFReservationTypeDAL();
       }

        public void Add(ReservationTypes item)
        {
            _efreservationtypeDAL.Add(item);
        }

        public void Delete(ReservationTypes item)
        {
            _efreservationtypeDAL.Delete(item);
        }

        public void Update(ReservationTypes item)
        {
            _efreservationtypeDAL.Update(item);
        }

        public ICollection<ReservationTypes> GetAll()
        {
           return  _efreservationtypeDAL.GetAll();
        }

        public ReservationTypes GetById(int? item)
        {
            return _efreservationtypeDAL.Get(x=>x.ReservationTypeID==item);
        }

        
    }
}
