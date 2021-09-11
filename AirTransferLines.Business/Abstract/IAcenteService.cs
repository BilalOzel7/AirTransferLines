using AirTransferLines.Core.Entities;
using AirTransferLines.Entities;
using AirTransferLines.Entities.DTOs;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface IAcenteService
    {
        List<AcenteDTO> GetAll();
        Acente GetByID(int ID);
        void Add(Acente entity);
        void Update(Acente entity);
        void Delete(Acente entity);
        List<AcenteDTO>  GetAcenteDetails();
    }
}
