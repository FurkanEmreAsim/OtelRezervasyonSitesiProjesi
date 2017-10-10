using PoseidonDeluxeCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseiodonDeluxeModel.Entities
{
    public class ReservationCustomerRoom : IEntity
    {
        public int CustomerID { get; set; }

        public int ReservationID { get; set; }

        public int RoomID { get; set; }

        public virtual Customers Customer { get; set; }

        public virtual Reservations Reservation { get; set; }

        public virtual Rooms Room { get; set; }


    }
}
