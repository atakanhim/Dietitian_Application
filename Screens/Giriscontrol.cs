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

        private void Admin_btn_Click(object sender, EventArgs e) => Singleton.Instance.ChangeScreen(this, Singleton.Instance.aLogin);

        private void Doctor_btn_Click(object sender, EventArgs e) => Singleton.Instance.ChangeScreen(this, Singleton.Instance.dLogin);



        private void Exit_btn_Click(object sender, EventArgs e) => Singleton.Instance.ExitTheApplication();

        
    }
}
