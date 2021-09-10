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
    public class AcenteManager : IAcenteService
    {
        IAcenteDal _acenteDal;
        public AcenteManager(IAcenteDal acenteDal )
        {
            _acenteDal = acenteDal;
        }
        public void Add(Acente acente)
        {
            _acenteDal.Add(acente);
            return ;
        }

        public void Delete(Acente entity)
        {
            _acenteDal.Delete(entity);
            return ;
        }

        public List<AcenteDTO> GetAll()
        {
            return new List<AcenteDTO>(_acenteDal.GetAcenteDetails());
        }

        public   Acente GetByID(int ID)
        {
            return  _acenteDal.Get(a => a.AcenteID == ID);
        }

        public List<AcenteDTO>  GetAcenteDetails()
        {
            return new List<AcenteDTO>(_acenteDal.GetAcenteDetails());
        }

        public void Update(Acente entity)
        {
            _acenteDal.Update(entity);
            return ;
        }
    }
}
