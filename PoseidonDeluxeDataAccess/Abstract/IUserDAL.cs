using PoseidonDeluxeCore.DataAccess;
using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeDataAccess.Abstract
{
   public interface IUserDAL:IEntityRepository<Users>
    {
    }
}
