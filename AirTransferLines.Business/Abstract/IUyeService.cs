using AirTransferLines.Entities.Concrete;
using AirTransferLines.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface IUyeService
    {
        
        Uye GetByID(int ID);
        void Add(Uye entity);
        void Update(Uye entity);
        void Delete(Uye entity);
        List<UyeDTO> GetUyeDetails();
    }
}
