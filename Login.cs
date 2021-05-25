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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Singleton.Instance.signUp.Show();
        }
        private void exit_btn_Click(object sender, EventArgs e) => Singleton.Instance.ExitTheApplication();

        private void login_btn_Click(object sender, EventArgs e)
        {

        }

     

        private void back_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
