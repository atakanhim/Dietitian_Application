using diyetisyenproje.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetisyenproje
{
    class Singleton
    {
        private Singleton()
        {

        }
        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        //Functions
      

        public void ChangeScreen(Form hide ,Form show)// ekran degistiriyor
        {
            hide.Hide();
            show.Show();
        }

        public void ExitTheApplication() =>Application.Exit();// uygullamayı sonlandırıyopr
        // Classes 
        public DataIslemleri islem = new DataIslemleri();
        public CurrentDiyetisyen currentDiyetisyen = new CurrentDiyetisyen();

        // Forms
        public GirisControl girisScreen = new GirisControl();
        public DiyetisyenEkle dEkle = new DiyetisyenEkle();
        public DiyetisyenLogin dLogin = new DiyetisyenLogin();
        public DiyetisyenScreen dScreen = new DiyetisyenScreen();


        public AdminLogin aLogin = new AdminLogin();
        public AdminScreen aScreen = new AdminScreen();
    }
}
