using AirTransferLines.Business.Abstract;
using AirTransferLines.DataAccess.Abstract;
using AirTransferLines.Entities.Concrete;
using AirTransferLines.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Concrete
{
    public class UyeManager : IUyeService
    {
        IUyeDal _uyeDal;

        public UyeManager(IUyeDal uyeDal)
        {
            _uyeDal = uyeDal;
        }

        public void Add(Uye entity)
        {
            _uyeDal.Add(entity);
            return;
        }

        public void Delete(Uye entity)
        {
            _uyeDal.Delete(entity);
            return;
        }

        

        public Uye GetByID(int ID)
        {
            return _uyeDal.Get(a => a.UlkeID == ID);
        }

        public List<UyeDTO> GetUyeDetails()
        {
            return new List<UyeDTO>(_uyeDal.GetUyeDetails());
        }

        public void Update(Uye entity)
        {
            _uyeDal.Update(entity);
            return;
        }
    }
}
