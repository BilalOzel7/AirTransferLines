using AirTransferLines.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface IAracService
    {
        List<Arac> GetAll();
        Arac GetByID(int ID);
        void Add(Arac entity);
        void Update(Arac entity);
        void Delete(Arac entity);
    }
}
