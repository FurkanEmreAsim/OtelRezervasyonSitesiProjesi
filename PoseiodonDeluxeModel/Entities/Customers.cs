using PoseidonDeluxeCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseiodonDeluxeModel.Entities
{
    public class Customers : IEntity
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerCivilization { get; set; }
        public string Gender { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public virtual ICollection<ReservationCustomerRoom> ReservationCustomerRoom { get; set; }


    }
}
