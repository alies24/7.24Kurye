using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourierService
    {
        IResult Add(Courier courier);
        IResult Delete(Courier courier);
        IResult Update(Courier courier);
        IDataResult<List<Courier>> GetAll();
        IDataResult<Courier> GetByCourierId(int id);
        IDataResult<Courier> GetByIdentityNumber(string number);
    }
}
