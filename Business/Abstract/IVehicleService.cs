using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVehicleService
    {
        IResult Add(Vehicle vehicle);
        IDataResult<List<Vehicle>> GetVehicles();
        IDataResult<Vehicle> GetById(int id);
    }
}
