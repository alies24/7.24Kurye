using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Vehicle:IEntity
    {
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
    }
}
