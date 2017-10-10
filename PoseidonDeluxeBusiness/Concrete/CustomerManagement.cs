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
   public class CustomerManagement:ICustomerService
    {

       EFCustomerDAL _efcustomerDAL;

       public CustomerManagement()
       {
           _efcustomerDAL = new EFCustomerDAL();
       }


        public void Add(Customers item)
        {
            _efcustomerDAL.Add(item);
        }

        public void Delete(Customers item)
        {
            _efcustomerDAL.Delete(item);
        }

        public void Update(Customers item)
        {
            _efcustomerDAL.Update(item);
        }

        public ICollection<Customers> GetAll()
        {
            return _efcustomerDAL.GetAll();
        }

        public Customers GetById(int? item)
        {
           return _efcustomerDAL.Get(x=>x.CustomerID==item);
        }
    }
}
