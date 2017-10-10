using PoseidonDeluxeCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseiodonDeluxeModel.Entities
{
    public class Rooms : IEntity
    {
        public int RoomNumber { get; set; }
        public decimal RoomPrice { get; set; }
        public string RoomImage { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<ReservationCustomerRoom> ReservationCustomerRoom { get; set; }
    }
}
