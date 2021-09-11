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
    public class AracManager : IAracService
    {
        IAracDal _aracDal;

        public AracManager(IAracDal aracDal)
        {
            _aracDal = aracDal;
        }

        public void Add(Arac entity)
        {
            _aracDal.Add(entity);
            return ;
        }

        public void Delete(Arac entity)
        {
            _aracDal.Delete(entity);
            return ;
        }

        public List<Arac> GetAll()
        {
            return new List<Arac>(_aracDal.GetAll());
        }

        public Arac GetByID(int ID)
        {
            return _aracDal.Get(a => a.AracID == ID);
        }

        public void Update(Arac entity)
        {
            _aracDal.Update(entity);
            return ;
        }
    }
}
