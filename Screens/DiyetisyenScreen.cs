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

        private void back_btn_Click(object sender, EventArgs e) => Singleton.Instance.ChangeScreen(this, Singleton.Instance.dLogin);
        private void exit_btn_Click(object sender, EventArgs e) => Singleton.Instance.ExitTheApplication();

        private void DiyetisyenScreen_Load(object sender, EventArgs e)
        {

            name_label.Text = Singleton.Instance.currentDiyetisyen.DiyetisyenAd;
            string sorgu = "SELECT * From Sorgu1";
           dataGridView1.DataSource = Singleton.Instance.islem.GetViewFromDatebase(sorgu);
        }
       
        
    }
}
