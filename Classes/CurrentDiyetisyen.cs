using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenproje.Classes
{
    class CurrentDiyetisyen : Insan
    {
      
        public string DiyetisyenPassword { get; set; }
        public string DiyetisyenAdres { get; set; }
        public DateTime DiyetisyenIseBaslamaTarihi { get; set; }
       
        public CurrentDiyetisyen()
        {

        }
        public void CurrentDiyetisyenEkle(string diyeTc, string diyePassword, string diyeAd, string diyeSoyad, string diyeTelefon, string diyeAdres, DateTime tarih)
        {
            this.Tc = diyeTc;
            this.DiyetisyenPassword = diyePassword;
            this.Isim = diyeAd;
            this.Soyisim = diyeSoyad;
            this.Telefon = diyeTelefon;
            this.DiyetisyenAdres = diyeAdres;
            this.DiyetisyenIseBaslamaTarihi = tarih;          
        }
    }
}
