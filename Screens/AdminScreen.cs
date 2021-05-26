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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void diyetisyenEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Singleton.Instance.dEkle.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e) => Singleton.Instance.ExitTheApplication();


        private void back_btn_Click(object sender, EventArgs e) => Singleton.Instance.ChangeScreen(this, Singleton.Instance.aLogin);

    }
}
