using AirTransferLines.Business.Abstract;
using AirTransferLines.DataAccess.Abstract;
using AirTransferLines.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Concrete
{
    public class AcenteManager : IAcenteService
    {
        IAcenteDal _acenteDal;
        public AcenteManager(IAcenteDal acenteDal )
        {
            _acenteDal = acenteDal;
        }
        public IResult Add(Acente acente)
        {
            _acenteDal.Add(acente);
            return new SuccessResult("Acenta Başarıyla Eklendi.");
        }

        public IResult Delete(Acente entity)
        {
            _acenteDal.Delete(entity);
            return new SuccessResult("Acenta Başarıyla Silindi.");
        }

        public IDataResult<List<Acente>> GetAll()
        {
            return new SuccessDataResult<List<Acente>>(_acenteDal.GetAll());
        }

        public IDataResult<Acente> GetByID(int ID)
        {
            return new SuccessDataResult<Acente>(_acenteDal.Get(a => a.AcentaID == ID));
        }

        public IResult Update(Acente entity)
        {
            _acenteDal.Update(entity);
            return new SuccessResult("Acenta Başarıyla Güncellendi.");
        }
    }
}
