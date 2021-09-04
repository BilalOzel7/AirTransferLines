using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities
{
   public class Dil:IEntity
    {
        public int fldDilID { get; set; }
        public string fldDilKod { get; set; }
        public string fldBayrak { get; set; }
        public string fldDilAdi { get; set; }
        

    }
}
