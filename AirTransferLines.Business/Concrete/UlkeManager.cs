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
    public class UlkeManager : IUlkeService
    {
        IUlkeDal _ulkeDal;

        public UlkeManager(IUlkeDal ulkeDal)
        {
            _ulkeDal = ulkeDal;
        }

        public void Add(Ulke entity)
        {
            _ulkeDal.Add(entity);
            return ;
        }

        public void Delete(Ulke entity)
        {
            _ulkeDal.Delete(entity);
            return ;
        }

        public List<Ulke> GetAll()
        {
            return new List<Ulke>(_ulkeDal.GetAll());
        }

        public Ulke GetByID(int ID)
        {
            return _ulkeDal.Get(a => a.UlkeID == ID);
        }

        public void Update(Ulke entity)
        {
            _ulkeDal.Update(entity);
            return ;
        }
    }
}
