using diyetisyenproje.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetisyenproje.Screens
{
    public partial class ShowRapor : Form
    {
        public ShowRapor()
        {
            InitializeComponent();
        }

        private void ShowRapor_Load(object sender, EventArgs e)
        {
            OnLoad();
        }

        private void BirinciBolum_combo_SelectedIndexChanged(object sender, EventArgs e) => ComboBoxControl();
        public void OnLoad()
        {
            CombotItemsAdd();
            UnVisibleLabels();
        }
        private void CombotItemsAdd()
        {
            birinciBolum_combo.Items.Clear();
            birinciBolum_combo.Items.Add("Hastanın Kişisel Bilgiler");
            birinciBolum_combo.Items.Add("Verilen Diyet Bilgileri");
        }

        private void ComboBoxControl()
        {
            if (birinciBolum_combo.Text == "Hastanın Kişisel Bilgiler")
            {
                ikinciBolumKarar_label.Text = "Verilen Diyet Bilgileri";// başlık olan
                VisibleLabels();
                birinciBolum_label.Text = GetHastaBilgileri(); //birinci bolum  hasta bilgisi
                ikinciBolum_label.Text = GetDiyetBilgileri(); // ikinci bolum verilen diyet bilgisi

            }
            else if (birinciBolum_combo.Text == "Verilen Diyet Bilgileri")
            {
                ikinciBolumKarar_label.Text = "Hastanın Kişisel Bilgileri";// başlık olan
                VisibleLabels();

                birinciBolum_label.Text = GetDiyetBilgileri(); //birinci bolum verilen diyet bilgisi
                ikinciBolum_label.Text = GetHastaBilgileri(); // ikinci bolum hasta bilgisi

            }
            else {
                UnVisibleLabels();
            }
                
        }
        private string GetHastaBilgileri() => Singleton.Instance.secilenHastabilgileri.GetHastabilgileriForString();
        private string GetDiyetBilgileri() => Singleton.Instance.islem.GetVerilenDiyetBilgileri();


        private void VisibleLabels()
        {
            birinciBolum_label.Visible = true;
            ikinciBolum_label.Visible = true;
            ikinciBolumKarar_label.Visible = true;
        }
        private void UnVisibleLabels()
        {
            ikinciBolum_label.Visible = false;
            birinciBolum_label.Visible = false;
            ikinciBolumKarar_label.Visible = false;
        }

        private void Back_btn_Click(object sender, EventArgs e) => Singleton.Instance.ChangeScreen(this, Singleton.Instance.hastaTedaviScreen);

        private void Rapor_donustur_Click(object sender, EventArgs e)
        {
                 Singleton.Instance.islem.VerilenDiyetBilgileriDoldur();// diyet bilgileri dolduruluyor
            if (birinciBolum_combo.Text != "")
            {
                string formatJson = "",formatHtml="";
                if (birinciBolum_combo.Text == "Hastanın Kişisel Bilgiler")
                {
                      /*for json */  formatJson = "Hasta Bilgileri" + Environment.NewLine + JsonConvert.SerializeObject(Singleton.Instance.raporHastaBilgileri) + Environment.NewLine + "Diyet Bilgileri" + Environment.NewLine + JsonConvert.SerializeObject(Singleton.Instance.raporDiyetBilgileri);
                 /*for html */   formatHtml = "Hasta Bilgileri" + "<br>" + JsonConvert.SerializeObject(Singleton.Instance.raporHastaBilgileri) +"<br>"+ "Diyet Bilgileri" + "<br>" + JsonConvert.SerializeObject(Singleton.Instance.raporDiyetBilgileri);

                }
                else if (birinciBolum_combo.Text == "Verilen Diyet Bilgileri")
                {
                    /*for json */formatJson = "Diyet Bilgileri" + Environment.NewLine + JsonConvert.SerializeObject(Singleton.Instance.raporDiyetBilgileri) + Environment.NewLine + "Hasta Bilgileri" + Environment.NewLine + JsonConvert.SerializeObject(Singleton.Instance.raporHastaBilgileri);
                    /*for html */formatHtml = "Diyet Bilgileri" + "<br>" + JsonConvert.SerializeObject(Singleton.Instance.raporDiyetBilgileri) + "<br>" + "Hasta Bilgileri" + "<br>" + JsonConvert.SerializeObject(Singleton.Instance.raporHastaBilgileri);
                }
                //dosya olusturuluyor
                File.WriteAllText(@"kayit.html", formatHtml.ToString());
                MessageBox.Show("Html Dosyasi Olusturuldu");
                File.WriteAllText(@"kayit.json", formatJson.ToString());
                MessageBox.Show("Json Dosyasi Olusturuldu");

                formatJson = File.ReadAllText(@"kayit.json");
                MessageBox.Show(formatJson);
            }
            else
                MessageBox.Show("Lutfen bir format turu seciniz");

        }
    }

}
