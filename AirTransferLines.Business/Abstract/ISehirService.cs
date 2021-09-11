using AirTransferLines.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface ISehirService
    {
        List<Sehir> GetAll();
        Sehir GetByID(int ID);
        void Add(Sehir entity);
        void Update(Sehir entity);
        void Delete(Sehir entity);
    }
}
