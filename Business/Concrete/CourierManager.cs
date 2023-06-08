using Business.Abstract;
using Core.Aspects.AutofacAspect.Caching;
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
    public class CourierManager : ICourierService
    {
        ICourierDal _courierDal;
        public CourierManager(ICourierDal courierDal)
        {
            _courierDal = courierDal;
        }

        [CacheRemoveAspect("ICourierService.Get")]
        public IResult Add(Courier courier)
        {
            _courierDal.Add(courier);
            return new SuccessResult();
        }

        [CacheRemoveAspect("ICourierService.Get")]
        public IResult Delete(Courier courier)
        {
            _courierDal.Delete(courier);
            return new SuccessResult();
        }
        [CacheAspect]
        public IDataResult<List<Courier>> GetAll()
        {
            return new SuccessDataResult<List<Courier>>(_courierDal.GetAll());
        }
        [CacheAspect]
        public IDataResult<Courier> GetByCourierId(int id)
        {
            var result = new SuccessDataResult<Courier>(_courierDal.Get(c=>c.Id == id));
            return result;
        }
        [CacheAspect]
        public IDataResult<Courier> GetByIdentityNumber(string number)
        {

            var result = new SuccessDataResult<Courier>(_courierDal.Get(c => c.IdentityNumber == number));
            return result;
        }

        [CacheRemoveAspect("ICourierService.Get")]
        public IResult Update(Courier courier)
        {
            _courierDal.Update(courier);
            return new SuccessResult();
        }
    }
}
