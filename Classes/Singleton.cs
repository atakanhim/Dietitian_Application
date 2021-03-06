using diyetisyenproje.Classes;
using diyetisyenproje.Screens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        static readonly object _lockobject = new object();
        public static Singleton Instance
        {
            get
            {
                lock (_lockobject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
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
        public void UseAllOnLoadFunctions()
        {
            this.dScreen.OnLoad();
            this.hastaTedaviScreen.OnLoad();
            this.showRapor.OnLoad();
        }

        // json çevirme icin objeler olusturuldu duzgun listelensin diye
        public RaporDiyetBilgileri raporDiyetBilgileri = new RaporDiyetBilgileri();
        public RaporHastaBilgileri raporHastaBilgileri = new RaporHastaBilgileri();

        // uygullamayı sonlandıran kod
        public void ExitTheApplication() =>Application.Exit();
        // Classes 
        public DataIslemleri islem = new DataIslemleri();
        public CurrentDiyetisyen currentDiyetisyen = new CurrentDiyetisyen();
        public SecilenHastabilgileri secilenHastabilgileri = new SecilenHastabilgileri();
     
        // Forms
        public GirisControl girisScreen = new GirisControl();
        public DiyetisyenEkle dEkle = new DiyetisyenEkle();
        public DiyetisyenLogin dLogin = new DiyetisyenLogin();
        public DiyetisyenScreen dScreen = new DiyetisyenScreen();
        public HastaTedaviScreen hastaTedaviScreen = new HastaTedaviScreen();
        public AdminLogin aLogin = new AdminLogin();
        public AdminScreen aScreen = new AdminScreen();
        public ShowRapor showRapor = new ShowRapor();
        public HastaEkle hastaEkle = new HastaEkle();
       
    }
}
