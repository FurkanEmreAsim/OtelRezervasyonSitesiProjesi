using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeBusiness.Abstract
{
   public interface ICustomerService
    {
        void Add(Customers item);
        void Delete(Customers item);
        void Update(Customers item);
        ICollection<Customers> GetAll();
        Customers GetById(int? item);
    }
}
