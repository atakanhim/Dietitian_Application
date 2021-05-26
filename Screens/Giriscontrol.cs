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
    public partial class GirisControl : Form
    {
        public GirisControl()
        {
            InitializeComponent();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Singleton.Instance.aLogin.Show();
        }

        private void doctor_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Singleton.Instance.dLogin.Show();
        }

     

        private void Exit_btn_Click(object sender, EventArgs e) => Singleton.Instance.ExitTheApplication();

        private void GirisControl_Load(object sender, EventArgs e)
        {

        }
    }
}
