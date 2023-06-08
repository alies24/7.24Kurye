using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CourierDetailsDto:IDto
    {
        public string CourierName { get; set; }
        public string CourierSurname { get; set; }
        public string VehicleName { get; set; }

    }
}
