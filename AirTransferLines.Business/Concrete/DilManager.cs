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
    public class DilManager : IDilService
    {
        IDilDal _dilDal;

        public DilManager(IDilDal dilDal)
        {
            _dilDal = dilDal;
        }

        public void Add(Dil entity)
        {
            _dilDal.Add(entity);
            return ;
        }

        public void Delete(Dil entity)
        {
            _dilDal.Delete(entity);
            return ;
        }

        public List<Dil> GetAll()
        {
            return new List<Dil>(_dilDal.GetAll());
        }

        public Dil GetByID(int ID)
        {
            return _dilDal.Get(a => a.DilID == ID);
        }

        public void Update(Dil entity)
        {
            _dilDal.Update(entity);
            return ;
        }
    }
}
