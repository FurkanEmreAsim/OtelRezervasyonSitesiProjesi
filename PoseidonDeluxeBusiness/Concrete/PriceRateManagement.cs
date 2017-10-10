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
   public class PriceRateManagement:IPriceRateService
    {

        EFPriceRateDAL _efpricerateDAL;

        public PriceRateManagement()
        {
            _efpricerateDAL = new EFPriceRateDAL();
        }

        public void Add(PriceRates item)
        {
            _efpricerateDAL.Add(item);
        }

        public void Delete(PriceRates item)
        {
            _efpricerateDAL.Delete(item);
        }

        public void Update(PriceRates item)
        {
            _efpricerateDAL.Update(item);
        }

        public ICollection<PriceRates> GetAll()
        {
            return _efpricerateDAL.GetAll();
        }

        public PriceRates GetById(string item)
        {
           return _efpricerateDAL.Get(x=>x.PriceRateID==item);
        }

        
    }
}
