using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenproje.Classes
{
    class CurrentDiyetisyen
    {
        public string DiyetisyenTc { get; set; }
        public string DiyetisyenPassword { get; set; }
        public string DiyetisyenAd { get; set; }
        public string DiyetisyenSoyad { get; set; }
        public string DiyetisyenTelefon { get; set; }
        public string DiyetisyenAdres { get; set; }
        public String DiyetisyenIseBaslamaTarihi { get; set; }
        public CurrentDiyetisyen()
        {

        }
        public void CurrentDiyetisyenEkle(string diyeTc, string diyePassword, string diyeAd, string diyeSoyad, string diyeTelefon, string diyeAdres, String tarih)
        {
            this.DiyetisyenTc = diyeTc;
            this.DiyetisyenPassword = diyePassword;
            this.DiyetisyenAd = diyeAd;
            this.DiyetisyenSoyad = diyeSoyad;
            this.DiyetisyenTelefon = diyeTelefon;
            this.DiyetisyenAdres = diyeAdres;
            this.DiyetisyenIseBaslamaTarihi = tarih;
          
        }
    }
}
