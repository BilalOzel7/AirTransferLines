﻿using AirTransferLines.Entities;
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
        IDataResult<List<Rezervasyon>> GetAll();
        IDataResult<Rezervasyon> GetByID(int ID);
        IResult Add(Rezervasyon entity);
        IResult Update(Rezervasyon entity);
        IResult Delete(Rezervasyon entity);
    }
}