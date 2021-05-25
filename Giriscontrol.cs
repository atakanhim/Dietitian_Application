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
    public partial class girisekrani : Form
    {
        public girisekrani()
        {
            InitializeComponent();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Singleton.Instance.adminlogin.Show();
        }

        private void doctor_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Singleton.Instance.login.Show();
        }
    }
}
