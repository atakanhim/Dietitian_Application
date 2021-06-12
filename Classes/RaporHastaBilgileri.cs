namespace diyetisyenproje.Screens
{
    public class RaporHastaBilgileri
    {
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Sikayet { get; set; }
        public string Diyet { get; set; }
        public string KayitT { get; set; }
        public string SonkontrolT { get; set; }
        public string Diyetisyen { get; set; }
        public RaporHastaBilgileri()
        {
              
        
        }
        public void SetHastabilgileri(string tc, string isim, string soyisim, string telefon, string sikayet,
                                     string diyetturu, string kayittarih, string sontarih,
                                     string hastaninDiyetisyeni)
        {
            this.Ad = isim;
            this.Tc = tc;
            this.Soyad = soyisim;
            this.Telefon = telefon;
            this.Sikayet = sikayet;
            this.Diyet = diyetturu;
            this.KayitT = kayittarih;
            this.SonkontrolT = sontarih;
            this.Diyetisyen = hastaninDiyetisyeni;
        }

    }

}
