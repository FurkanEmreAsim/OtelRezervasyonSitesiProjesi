using PoseidonDeluxeCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseiodonDeluxeModel.Entities
{
    public class ReservationTypes : IEntity
    {
        public int ReservationTypeID { get; set; }
        public string ReservationType { get; set; }
        public decimal ReservationTypePrice { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }     
        public virtual ICollection<Reservations> Reservation { get; set; }

      
    }
}
