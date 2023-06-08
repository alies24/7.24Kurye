using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VehicleManager : IVehicleService
    {
        IVehicleDal _vehicleDal;
        public VehicleManager(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;
        }
        public IResult Add(Vehicle vehicle)
        {
            _vehicleDal.Add(vehicle);
            return new SuccessResult();
        }

        public IDataResult<Vehicle> GetById(int id)
        {
            return new SuccessDataResult<Vehicle>(_vehicleDal.Get(i => i.VehicleId == id));
        }

        public IDataResult<List<Vehicle>> GetVehicles()
        {
            return new SuccessDataResult<List<Vehicle>>(_vehicleDal.GetAll());
        }
    }
}
