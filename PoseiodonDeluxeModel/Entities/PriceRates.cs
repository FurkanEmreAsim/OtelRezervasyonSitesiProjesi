using PoseidonDeluxeCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseiodonDeluxeModel.Entities
{
    public class PriceRates : IEntity
    {
        public string PriceRateID { get; set; }
        public string RateName { get; set; }
        public decimal Rate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
