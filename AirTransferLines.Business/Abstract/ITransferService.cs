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
   public interface ITransferService
    {
        List<Transfer> GetAll();
        Transfer GetByID(int ID);
        void Add(Transfer entity);
        void Update(Transfer entity);
        void Delete(Transfer entity);
        List<Transfer> GetAllByTarih(DateTime min, DateTime max);
        List<TransferDTO> GetTransferDetails();
    }
}
