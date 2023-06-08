using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class EfVehicleDal:EfEntityReposBase<Vehicle,CourierDbContext >, IVehicleDal
    {
    }
}
