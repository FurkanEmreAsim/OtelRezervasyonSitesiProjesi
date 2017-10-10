using PoseidonDeluxeCore.DataAccess.EntityFramework;
using PoseidonDeluxeDataAccess.Abstract;
using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeDataAccess.Concrete.EntityFrameWork.EntitiesDAccess
{
    public class EFReservationDAL:EFEntityRepositoryBase<PoseidonDeluxeDBContext,Reservations>,IReservationDAL
    {
    }
}
