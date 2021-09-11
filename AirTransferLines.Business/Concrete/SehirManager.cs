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
    public class SehirManager : ISehirService
    {
        ISehirDal _sehirDal;

        public SehirManager(ISehirDal sehirDal)
        {
            _sehirDal = sehirDal;
        }

        public void Add(Sehir entity)
        {
            _sehirDal.Add(entity);
            return ;
        }

        public void Delete(Sehir entity)
        {
            _sehirDal.Delete(entity);
            return ;
        }

        public List<Sehir> GetAll()
        {
            return new List<Sehir>(_sehirDal.GetAll());
        }

        public Sehir GetByID(int ID)
        {
            return _sehirDal.Get(a => a.SehirID == ID);
        }

        public void Update(Sehir entity)
        {
            _sehirDal.Update(entity);
            return ;
        }
    }
}
