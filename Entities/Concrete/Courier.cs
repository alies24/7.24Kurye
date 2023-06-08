using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Courier : IEntity
    {
        public int Id { get; set; }
        public string CourierName { get; set; }
        public string CourierSurname { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public int VehicleId { get; set; }
    }
}
