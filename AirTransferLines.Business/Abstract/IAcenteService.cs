using AirTransferLines.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface IAcenteService
    {
        IDataResult<List<Acente>> GetAll();
        IDataResult<Acente> GetByID(int ID);
        IResult Add(Acente car);
        IResult Update(Acente entity);
        IResult Delete(Acente entity);
    }
}
