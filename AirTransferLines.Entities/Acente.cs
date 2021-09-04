﻿using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities
{
   public class Acente:IEntity
    {
        public int AcentaID { get; set; }
        public string AcentaAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string Adres { get; set; }
        public string firmaUnvan { get; set; }
        public string Yetkili { get; set; }
        public string Telefon { get; set; }
        public int SehirID { get; set; }
        public int UlkeID { get; set; }
        public int Sozlesme { get; set; }
        public DateTime SozlesmeOnayTarih { get; set; }
        public string Notlar { get; set; }
        public DateTime SonLogin { get; set; }
        public string FaturaAdres { get; set; }
        public string Iban { get; set; }
        public string VergiDaire { get; set; }
        public string VergiNo { get; set; }
        public string YetkiliTelefon { get; set; }
        public string YetkiliEmail { get; set; }
        public decimal Kredi { get; set; }
    }
}
