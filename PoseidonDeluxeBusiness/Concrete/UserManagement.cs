using PoseidonDeluxeBusiness.Abstract;
using PoseidonDeluxeDataAccess.Abstract;
using PoseidonDeluxeDataAccess.Concrete.EntityFrameWork.EntitiesDAccess;
using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeBusiness.Concrete
{
   public class UserManagement : IUserService
    {

       EFUserDAL _userDAL;

       public UserManagement()
       {
            _userDAL=new EFUserDAL();
       }

       public void Add(Users item)
       {
           _userDAL.Add(item);
       }

       public void Delete(Users item)
       {
           _userDAL.Delete(item);
       }

       public void Update(Users item)
       {
           _userDAL.Update(item);
       }

       public Users GetById(int? item)
       {
          return _userDAL.Get(x=>x.UserID==item);
       }
       public ICollection<Users> GetAll()
       {
           return _userDAL.GetAll();
       }
       public Users GetByEmailandPassword(string item, string item2)
       {
           return _userDAL.Get(x => x.Email == item && x.Password == item2);
       }
    }
}
