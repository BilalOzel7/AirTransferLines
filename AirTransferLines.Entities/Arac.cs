using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities
{
   public class Arac:IEntity
    {
        public int fldAracID { get; set; }
        public int AracSayisi { get; set; }
        public string fldAracAdi { get; set; }
        public string fldAracResim { get; set; }
        public int fldDurum { get; set; }
        public int fldSira { get; set; }
        public int fldBagaj { get; set; }
    }
}
