using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeBusiness.Abstract
{
   public interface IUserService
    {
        void Add(Users item);
        void Delete(Users item);
        void Update(Users item);
        ICollection<Users> GetAll();
        Users GetById(int? item);
        Users GetByEmailandPassword(string item, string item2);
        
    }
}
