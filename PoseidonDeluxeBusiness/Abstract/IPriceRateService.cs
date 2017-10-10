using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeBusiness.Abstract
{
  public  interface IPriceRateService
    {
        void Add(PriceRates item);
        void Delete(PriceRates item);
        void Update(PriceRates item);
        ICollection<PriceRates> GetAll();
        PriceRates GetById(string item);
    }
}
