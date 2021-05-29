using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenproje.Classes
{
    class SecilenHastabilgileri : Insan
    {
        public string HastaHastaligi { get; set;}
        public string HastaDiyetTuru { get; set; }
        public string HastaninDiyetisyeni { get; set; }
        public DateTime HastaKayitTarihi { get; set; }
        public DateTime HastaSonKontrolTarihi { get; set; }
        public override string ToString()
        {
            return string.Format("Hasta Bilgileri:\n\tHasta Tc: {0},Hasta Adı: {1} ",Tc,Isim);
        }
        public SecilenHastabilgileri()
        {
           
        }
        public void SetHastabilgileri(string tc, string isim, string soyisim, string telefon, string sikayet,
                                      string diyetturu, DateTime kayittarih, DateTime sontarih,
                                      string hastaninDiyetisyeni)
        {
            this.Isim = isim;
            this.Tc = tc;
            this.Soyisim = soyisim;
            this.Telefon = telefon;
            this.HastaHastaligi = sikayet;
            this.HastaDiyetTuru = diyetturu;
            this.HastaKayitTarihi = kayittarih;
            this.HastaSonKontrolTarihi = sontarih;
            this.HastaninDiyetisyeni = hastaninDiyetisyeni;
        }
        public void ChangeHastaDiyetbilgisi(string newDiyetbilgisi) => this.HastaDiyetTuru = newDiyetbilgisi;// class uzerinde degiştiriyorum ama database e de ayrı olarak ekliyorum
        public void ChangeHastaHastaligi(string newHastalik) => this.HastaHastaligi = newHastalik;
        public void ChangeSonKontrolTarihi(DateTime newTarih) => this.HastaSonKontrolTarihi = newTarih;

        public string GetHastabilgileriForString()
        {
            string bilgiler = "       Seçilen Hasta Bilgileri ;\n\n" +
            "Hasta Tc : " + this.Tc + "\n\n" +
            "Hasta Adı : " + this.Isim + "\n\n" +
            "Hasta Soyadı: " + this.Soyisim + "\n\n" +
            "Hasta Telefon Numarası: " + this.Telefon + "\n\n" +
            "Hasta Şikayeti : " + this.HastaHastaligi + "\n\n" +
            "Hasta Diyet Türü : " + this.HastaDiyetTuru + "\n\n" +
            "Hasta Kayıt Tarihi : " + this.HastaKayitTarihi.ToShortDateString() + "\n\n" +
            "Hasta Son Kontrol Tarihi : " + this.HastaSonKontrolTarihi.ToShortDateString() + "\n\n" +
            "Hasta Diyetisyeni : Uzm. Diyetisyen " + this.HastaninDiyetisyeni + "\n\n";

            return bilgiler;
        }
       
    }
}
