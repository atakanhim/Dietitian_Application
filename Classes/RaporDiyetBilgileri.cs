namespace diyetisyenproje.Screens
{
    public class RaporDiyetBilgileri
    {
        public string DiyetAd { get; set; }
        public string Pazartesi { get; set; }
        public string Sali { get; set; }
        public string Carsamba { get; set; }
        public string Persembe { get; set; }
        public string Cuma { get; set; }
        public string Cumartesi { get; set; }
        public string Pazar { get; set; }
        public string Diyet_Olusturan_Diyetisyen { get; set; }
        public RaporDiyetBilgileri()
        {

        }
        public void RaporDiyetBilgileriDoldur(string diyetAd , string pazartesi,string sali, string carsamba, string persembe , string cuma, string cumartesi , string pazar , string diyetolsturandiyetisyen)
        {
            this.DiyetAd = diyetAd;
            this.Pazartesi = pazartesi;
            this.Sali = sali;
            this.Carsamba = carsamba;
            this.Persembe = persembe;
            this.Cuma = cuma;
            this.Cumartesi = cumartesi;
            this.Pazar = pazar;
            this.Diyet_Olusturan_Diyetisyen = diyetolsturandiyetisyen;
        }
  
    }

}
