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
   public interface IRezervasyonService
    {
        List<Rezervasyon> GetAll();
        Rezervasyon GetByID(int ID);
        void Add(Rezervasyon entity);
        void Update(Rezervasyon entity);
        void Delete(Rezervasyon entity);
        List<RezervasyonDTO> GetRezervasyonDetails();
    }
}
