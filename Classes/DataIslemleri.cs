using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetisyenproje
{
    class DataIslemleri
    {
 
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =diyetisyen.accdb;Persist Security Info=True");
        OleDbCommand komut;

        // form içindeki texboxları temizliyen mühendislik harikası kod
        public void Temizle(Control ctr)
        {
            foreach (Control c in ctr.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c.Controls.Count > 0)
                    Temizle(c);
            }
        }
        // private fonksiyonlar
        private static bool sayiMi(string deger)
        {
            try
            {
                int.Parse(deger);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void OpenConnection() => baglanti.Open();// baglantıyı açtırdık
        private void CloseConnection() => baglanti.Close();// bırdada kapattırıyoruz  2 side tek satır ama böylesi daha iyi
        private OleDbDataReader read(string sorgu)// Data Reader işlemleri burda yapalıcak
        {
            OleDbDataReader oku;
            komut = new OleDbCommand(sorgu, baglanti);
            oku = komut.ExecuteReader();
            return oku;
        }
    

        // public fonksiyonlar
        public bool DiyetisyenEkle(string tc , string password , string ad , string soyad , string telefon,string adres,Form currentForm)
        {
            if (tc == "" || password == "" || ad == "" || soyad == "" || telefon == "" || adres == "")
            {
                MessageBox.Show("Lütfen Tüm alanları doldurun");
                return false;
            }
            else if (sayiMi(tc) == false)
            {
                MessageBox.Show("Lütfen geçerli tc girin");
                return false;
            }
            else if (Convert.ToInt64(tc) > 9999999999 && Convert.ToInt64(tc) < 100000000000)
            {
                MessageBox.Show("Tc numarası 11 haneli olmak zorunda");
                return false;
            }
            else
            {               
                  OpenConnection();
                 OleDbDataReader oku = read("select * from diyetisyen where tc='"+tc+"'");
                 if (oku.Read())
                     MessageBox.Show("Bu tc numarası zaten sistemde kayıtlı \n Lütfen bilgilerinizi kontrol ediniz.","Tc Zaten Kayıtlı !!");

                 CloseConnection();
                 Temizle(currentForm);
                return false;
            }
        }
        public void AdminLoginControl(string username, string password,Form currentForm) // admin giris kontrol ediliyor
        {
            OpenConnection();

            OleDbDataReader oku = read("SELECT * FROM admin where username='"+username+"' AND password='"+password+"'");
            if(oku.Read())
                Singleton.Instance.ChangeScreen(currentForm, Singleton.Instance.aScreen);
            else
                MessageBox.Show("Geçersiz Kullanici adi veya şifre.", "Hatalı Giriş");
            CloseConnection();
            Temizle(currentForm);
        }
        public void DiyetisyenLoginControl(string tc, string sifre, Form currentForm)// diyetisyen giriş konttrol ediliyor
        {
            OpenConnection();
            OleDbDataReader oku = read("SELECT * FROM diyetisyen WHERE diyetisyenTc='" + tc + "'AND diyetisyenPassword='" + sifre + "'");
            if (oku.Read())
            {
                Singleton.Instance.currentDiyetisyen.CurrentDiyetisyenEkle(oku["diyetisyenTc"].ToString(), oku["diyetisyenPassword"].ToString(), oku["diyetisyenAd"].ToString(), 
                    oku["diyetisyenSoyad"].ToString(), oku["diyetisyenTelefon"].ToString(), oku["diyetisyenEvAdres"].ToString(), oku["diyetisyenIseBaslamaTarihi"].ToString());
                CloseConnection();
                Temizle(currentForm);
                Singleton.Instance.ChangeScreen(currentForm, Singleton.Instance.dScreen);
            }
            else
              MessageBox.Show("Geçersiz Tc numarası veya şifre.", "Hatalı Giriş");
            
            CloseConnection();
            Temizle(currentForm);
        }
       
        public DataTable GetViewFromDatebase(string sorgu)// datatable turunde tabloyu doldurup donduruyoruz
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter da;
            OpenConnection();
                    da = new OleDbDataAdapter(sorgu, baglanti);               
                    da.Fill(tablo);
            CloseConnection();
            return tablo;
        }

    }
}
