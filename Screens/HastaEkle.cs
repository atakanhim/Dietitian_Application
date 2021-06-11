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
    public partial class HastaEkle : Form
    {
        public HastaEkle()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e) {
            Singleton.Instance.dScreen.OnLoad();
            Singleton.Instance.ChangeScreen(this, Singleton.Instance.dScreen);
        } 
        private void Exit_btn_Click(object sender, EventArgs e) => Singleton.Instance.ExitTheApplication();

        private void HastaEkle_btn_Click(object sender, EventArgs e)
        {
            Singleton.Instance.islem.HastaEkle(newtc_txt.Text,newad_txt.Text,newsoyad_txt.Text,newtel_txt.Text,newHastaligi_txt.Text,this);
        }
    }
}
