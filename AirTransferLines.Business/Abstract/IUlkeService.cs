using AirTransferLines.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface IUlkeService
    {
        List<Ulke> GetAll();
        Ulke GetByID(int ID);
        void Add(Ulke entity);
        void Update(Ulke entity);
        void Delete(Ulke entity);
    }
}
