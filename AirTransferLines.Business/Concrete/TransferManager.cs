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
    public class TransferManager : ITransferService
    {
        ITransferDal _transferDal;

        public TransferManager(ITransferDal transferDal)
        {
            _transferDal = transferDal;
        }

        public void Add(Transfer entity)
        {
            _transferDal.Add(entity);
            return ;
        }

        public void Delete(Transfer entity)
        {
            _transferDal.Delete(entity);
            return ;
        }

        public List<Transfer> GetAll()
        {
            return new List<Transfer>(_transferDal.GetAll());
        }

        public List<Transfer> GetAllByTarih(DateTime min,DateTime max)
        {
            return new List<Transfer>(_transferDal.GetAll(t => t.Tarih >= min && t.Tarih <= max));
        }

        public Transfer GetByID(int ID)
        {
            return _transferDal.Get(a => a.TransferID == ID);
        }

        public List<TransferDTO> GetTransferDetails()
        {
            return new List<TransferDTO>(_transferDal.GetTransferDetails());
        }

        public void Update(Transfer entity)
        {
            _transferDal.Update(entity);
            return;
        }

        
    }
}
