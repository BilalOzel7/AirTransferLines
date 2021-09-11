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
    public class SurucuManager : ISurucuService
    {
        ISurucuDal _surucuDal;

        public SurucuManager(ISurucuDal surucuDal)
        {
            _surucuDal = surucuDal;
        }
        public void Add(Surucu entity)
        {
            _surucuDal.Add(entity);
            return ;
        }

        public void Delete(Surucu entity)
        {
            _surucuDal.Delete(entity);
            return ;
        }

        public List<Surucu> GetAll()
        {
            return new List<Surucu>(_surucuDal.GetAll());
        }

        public Surucu GetByID(int ID)
        {
            return _surucuDal.Get(a => a.SurucuID == ID);
        }

        public List<SurucuDTO> GetSurucuDetails()
        {
            return new List<SurucuDTO>(_surucuDal.GetSurucuDetails());
        }

        public void Update(Surucu entity)
        {
            _surucuDal.Update(entity);
            return ;
        }
    }
}
