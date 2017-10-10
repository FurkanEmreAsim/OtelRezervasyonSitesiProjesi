using PoseidonDeluxeCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseiodonDeluxeModel.Entities
{
    public class Reservations : IEntity
    {
       
        public int ReservationID { get; set; }
        public int CreatedBy  { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ReservationTypeID { get; set; }
        public decimal ReservationPrice { get; set; }
        public short TotalPeople { get; set; }
        public DateTime DateOfEntry { get; set; }
        public DateTime DateOfOut { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Users User { get; set; }
        public virtual ReservationTypes ReservationType { get; set; }
        public virtual ICollection<ReservationCustomerRoom> ReservationCustomerRoom { get; set; }



    }
}
