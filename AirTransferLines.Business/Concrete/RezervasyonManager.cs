using AirTransferLines.Business.Abstract;
using AirTransferLines.Business.Constants;
using AirTransferLines.DataAccess.Abstract;
using AirTransferLines.Entities;
using AirTransferLines.Entities.DTOs;
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

        public void Add(Rezervasyon entity)
        {
            _rezervasyonDal.Add(entity);
            return ;
        }

        public void Delete(Rezervasyon entity)
        {
            _rezervasyonDal.Delete(entity);
            return ;
        }

        public List<Rezervasyon> GetAll()
        {
            throw new NotImplementedException();
        }

        public Rezervasyon GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void Update(Rezervasyon entity)
        {
            _rezervasyonDal.Update(entity);
            return;
        }
       

        public List<RezervasyonDTO> GetRezervasyonDetails()
        {
            return new List<RezervasyonDTO>(_rezervasyonDal.GetRezervasyonDetails());
        }
    }
}
