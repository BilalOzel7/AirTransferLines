using AirTransferLines.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface IDilService
    {
        List<Dil> GetAll();
        Dil GetByID(int ID);
        void Add(Dil entity);
        void Update(Dil entity);
        void Delete(Dil entity);
    }
}
