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
    public partial class DiyetisyenEkle : Form
    {
        public DiyetisyenEkle()
        {
            InitializeComponent();
        }
        private void Exit_btn_Click(object sender, EventArgs e) => Singleton.Instance.ExitTheApplication();
        private void Back_btn_Click(object sender, EventArgs e) {
            Singleton.Instance.aScreen.AdminScreenOnLoad();
            Singleton.Instance.ChangeScreen(this, Singleton.Instance.aScreen); 
        } 

        private void Kayittamamla_btn_Click(object sender, EventArgs e) => Singleton.Instance.islem.DiyetisyenEkle(newtc_txt.Text, newsifre_txt.Text, newad_txt.Text, newsoyad_txt.Text, newtel_txt.Text, newadres_txt.Text, this);
    }
}
