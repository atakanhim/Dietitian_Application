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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        private void Admingiris_btn_Click(object sender, EventArgs e) =>Singleton.Instance.islem.AdminLoginControl(username_txt.Text, password_txt.Text,this);
        private void Exit_btn_Click(object sender, EventArgs e) => Singleton.Instance.ExitTheApplication();
        private void Back_btn_Click(object sender, EventArgs e) =>  Singleton.Instance.ChangeScreen(this,Singleton.Instance.girisScreen);

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
