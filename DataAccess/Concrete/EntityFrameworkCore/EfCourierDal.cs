using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCourierDal:EfEntityReposBase<Courier, CourierDbContext>, ICourierDal
    {
        public List<CourierDetailsDto> GetCarDetails(Expression<Func<Courier, bool>> filter = null)
        {
            using (CourierDbContext dbContext = new())
            {
                var join = from c in filter == null ? dbContext.Couriers : dbContext.Couriers.Where(filter)
                           join v in dbContext.Vehicles on c.VehicleId equals v.VehicleId
                           select new CourierDetailsDto
                           {
                               CourierName = c.CourierName,
                               CourierSurname = c.CourierSurname,
                               VehicleName = v.VehicleName
                           };
                return join.ToList();
            }

        }
    }
}
