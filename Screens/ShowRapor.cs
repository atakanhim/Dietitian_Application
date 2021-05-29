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
            unVisibleLabels();
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
                unVisibleLabels();
            }
                
        }
        private string GetHastaBilgileri() => Singleton.Instance.secilenHastabilgileri.Hastabilgileri;
        private string GetDiyetBilgileri() => Singleton.Instance.islem.GetVerilenDiyetBilgileri();


        private void VisibleLabels()
        {
            birinciBolum_label.Visible = true;
            ikinciBolum_label.Visible = true;
            ikinciBolumKarar_label.Visible = true;
        }
        private void unVisibleLabels()
        {
            ikinciBolum_label.Visible = false;
            birinciBolum_label.Visible = false;
            ikinciBolumKarar_label.Visible = false;
        }

        private void Back_btn_Click(object sender, EventArgs e) => Singleton.Instance.ChangeScreen(this, Singleton.Instance.hastaTedaviScreen);
    }
}
