using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetisyenproje
{
    public partial class DiyetisyenScreen : Form
    {
        public DiyetisyenScreen()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e) => Singleton.Instance.ChangeScreen(this, Singleton.Instance.dLogin);
        private void Exit_btn_Click(object sender, EventArgs e) => Singleton.Instance.ExitTheApplication();

        private void DiyetisyenScreen_Load(object sender, EventArgs e)
        {
            OnLoad();
        }
        private void OnLoad()
        {
            hasta_bilgileri_lbl.Visible = false;
       
            currenttarih.Text = "Tarih :"+DateTime.Now.ToShortDateString();
            name_label.Text = "Uzm. Diyetisyen " + Singleton.Instance.currentDiyetisyen.Isim.ToUpper() + " " + Singleton.Instance.currentDiyetisyen.Soyisim.ToUpper(); ;
            hastaTablosu.DataSource = Singleton.Instance.islem.GetViewFromDatebase("SELECT * From showHastalar");// data grid dolduruluyor
        }

        private void HastaTedaviEt_Click(object sender, EventArgs e)
        {
            if (hasta_bilgileri_lbl.Visible == false) MessageBox.Show("Lütfen bir hasta seiniz", "HASTA SEC !!");
            else
            {
                Singleton.Instance.hastaTedaviScreen.OnLoad();
                Singleton.Instance.ChangeScreen(this, Singleton.Instance.hastaTedaviScreen);           
            }
        }

        private void HastaTablosu_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            hastaTablosu.CurrentRow.Selected = true;
            if (hastaTablosu.Rows[e.RowIndex].Cells["hastaTc"].FormattedValue.ToString()!="")
            {
                Singleton.Instance.secilenHastabilgileri.SetHastabilgileri(
               hastaTablosu.Rows[e.RowIndex].Cells["hastaTc"].FormattedValue.ToString(),
               hastaTablosu.Rows[e.RowIndex].Cells["hastaAd"].FormattedValue.ToString(),
               hastaTablosu.Rows[e.RowIndex].Cells["hastaSoyad"].FormattedValue.ToString(),
               hastaTablosu.Rows[e.RowIndex].Cells["hastaTelefon"].FormattedValue.ToString(),
               hastaTablosu.Rows[e.RowIndex].Cells["hastaHastaligi"].FormattedValue.ToString(),
               hastaTablosu.Rows[e.RowIndex].Cells["hastaDiyetturu"].FormattedValue.ToString(),
               DateTime.Parse(hastaTablosu.Rows[e.RowIndex].Cells["hastaKayitTarih"].FormattedValue.ToString()),
               DateTime.Parse(hastaTablosu.Rows[e.RowIndex].Cells["hastaSonKontrolTarih"].FormattedValue.ToString()),
               hastaTablosu.Rows[e.RowIndex].Cells["hastaDiyetisyeni"].FormattedValue.ToString()
                );

               
            }
            hasta_bilgileri_lbl.Visible = true;
            hasta_bilgileri_lbl.Text = Singleton.Instance.secilenHastabilgileri.Hastabilgileri;

        }
    }
}
