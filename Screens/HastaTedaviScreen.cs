using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetisyenproje.Screens
{
    public partial class HastaTedaviScreen : Form
    {
        public HastaTedaviScreen()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e) => Singleton.Instance.ChangeScreen(this, Singleton.Instance.dScreen);

        private void HastaTedaviScreen_Load(object sender, EventArgs e)
        {
            OnLoad();
        }
        public void OnLoad()
        {
            
            diyeteklegrpbox.Visible = false;
            if (Singleton.Instance.secilenHastabilgileri.HastaDiyetTuru != "Diyet Belirtilmedi")
            {
                tedavi_et_btn.Visible = true;
                rapor_goruntule_btn.Visible = true;
            }
            else {
                rapor_goruntule_btn.Visible = false;//Diyet belirtilmişse rapor görüntülenebilecek
                tedavi_et_btn.Visible = false;
            }
            hasta_bilgileri_lbl.Text = Singleton.Instance.secilenHastabilgileri.Hastabilgileri;

            sadeceComboBoxDoldur();

            if (Singleton.Instance.secilenHastabilgileri.HastaHastaligi != "Şikayet Belirtilmedi")
            {
                sikayetlistele_label.Visible = false;
                HastaSikayetleri_combo.Visible = false;
                DiyetTuruCombo_combo.Visible = true;//hasta şikayet belirtmemişse biz şikayeti belirtiyosak diyet henüz aktif deigl
                diyetsec_label.Visible = true;
                diyet_bilgisi.Visible = true;
            }       
            else
            {             
                sikayetlistele_label.Visible = true;
                HastaSikayetleri_combo.Visible = true;
                diyet_bilgisi.Visible = false;
                DiyetTuruCombo_combo.Visible = false;
                diyetsec_label.Visible = false;
                
            }

            hasta_sikayeti.Text = "Hasta şikayeti: " + Singleton.Instance.secilenHastabilgileri.HastaHastaligi;
            diyet_bilgisi.Text= "Diyet Bilgisi : " + Singleton.Instance.secilenHastabilgileri.HastaDiyetTuru;
        }
        public void sadeceComboBoxDoldur()
        {
            Singleton.Instance.islem.ComboBoxDoldur(HastaSikayetleri_combo, "SELECT * from hastaliklar", "hastalikAd", "Yeni Hastalik Ekle");
            Singleton.Instance.islem.ComboBoxDoldur(DiyetTuruCombo_combo, "SELECT * from diyetler", "diyetAd", "Yeni Diyet Ekle");
        }

        private void DiyetTuruCombo_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DiyetTuruCombo_combo.Text== "Yeni Diyet Ekle" && HastaSikayetleri_combo.Text!="Yeni Hastalik Ekle")
            {
                diyeteklegrpbox.Visible = true;
                tedavi_et_btn.Visible = false;
            }
            
            else 
            {
                diyeteklegrpbox.Visible = false;
                tedavi_et_btn.Visible = true;
            }
               
                    
        }
        private void HastaSikayetleri_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HastaSikayetleri_combo.Text == "Yeni Hastalik Ekle")
            {
                hastalikEkleGrpbox.Visible = true;
                diyeteklegrpbox.Visible = false;
                DiyetTuruCombo_combo.Visible = false;
                diyetsec_label.Visible = false;
                diyet_bilgisi.Visible = false;
                tedavi_et_btn.Visible = false;
            }
            else
            {
                hastalikEkleGrpbox.Visible = false;
                DiyetTuruCombo_combo.Visible = true;           
                diyetsec_label.Visible = true;
                diyet_bilgisi.Visible = true;
            }
        }

      private void HastalikEkle_btn_Click(object sender, EventArgs e) =>  Singleton.Instance.islem.HastalikEkle(hastalikAdi_txt.Text, hastaaciklama_txt.Text,this);

        private void DiyetEkle_btn_Click(object sender, EventArgs e) => Singleton.Instance.islem.DiyetEkle(diyetadı_txt.Text,
            pazartesi_txt.Text, sali_txt.Text, carsanba_txt.Text, persenbe_txt.Text, cuma_txt.Text, cumartesi_txt.Text, pazar_txt.Text, this);

        private void Tedavi_et_btn_Click(object sender, EventArgs e)
        {

            if (DiyetTuruCombo_combo.Text != Singleton.Instance.secilenHastabilgileri.HastaDiyetTuru)
            {
                if (Singleton.Instance.secilenHastabilgileri.HastaHastaligi == "Şikayet Belirtilmedi")
                    Singleton.Instance.secilenHastabilgileri.ChangeHastaHastaligi(HastaSikayetleri_combo.Text);
                Singleton.Instance.secilenHastabilgileri.ChangeHastaDiyetbilgisi(DiyetTuruCombo_combo.Text);
                Singleton.Instance.secilenHastabilgileri.ChangeSonKontrolTarihi(DateTime.Parse(DateTime.Now.ToShortDateString()));
                MessageBox.Show(Singleton.Instance.islem.HastaTedaviEt());
            }
            else MessageBox.Show("Zaten hastaya bu diyet türü uygulanıyor lütfen başka diyet türü seçiniz");
        }

        private void rapor_goruntule_btn_Click(object sender, EventArgs e) {
            Singleton.Instance.useAllOnLoadFunctions();
            Singleton.Instance.ChangeScreen(this, Singleton.Instance.showRapor);
            
        }
        
    }
}
