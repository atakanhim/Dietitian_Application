using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Appli
        // Classes 
        public DataIslemleri islem = new DataIslemleri();
        // Forms
        public SignUp signUp = new SignUp();
        public Login login = new Login();
        public AdminLogin adminlogin = new AdminLogin();
    }
}
