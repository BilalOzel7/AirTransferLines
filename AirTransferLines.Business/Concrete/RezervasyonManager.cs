using AirTransferLines.Business.Abstract;
using AirTransferLines.Business.Constants;
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
    public class RezervasyonManager : IRezervasyonService
    {
        IRezervasyonDal _rezervasyonDal;

        public RezervasyonManager(IRezervasyonDal rezervasyonDal)
        {
            _rezervasyonDal = rezervasyonDal;
        }

        public IResult Add(Rezervasyon entity)
        {
            _rezervasyonDal.Add(entity);
            return new SuccessResult(Messages.RezervasyonAdded);
        }

        public IResult Delete(Rezervasyon entity)
        {
            _rezervasyonDal.Delete(entity);
            return new SuccessResult(Messages.RezervasyonDeleted);
        }

        public IDataResult<List<Rezervasyon>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Rezervasyon> GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rezervasyon entity)
        {
            _rezervasyonDal.Update(entity);
            return new SuccessResult(Messages.RezervasyonUpdated);
        }
    }
}
