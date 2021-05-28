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

        private void DiyetisyenEkle_Click(object sender, EventArgs e) => Singleton.Instance.ChangeScreen(this, Singleton.Instance.dEkle);

        private void Exit_btn_Click(object sender, EventArgs e) => Singleton.Instance.ExitTheApplication();


        private void Back_btn_Click(object sender, EventArgs e) => Singleton.Instance.ChangeScreen(this, Singleton.Instance.aLogin);

    }
}
