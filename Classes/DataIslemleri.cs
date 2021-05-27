﻿using System;
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
        private readonly OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =diyetisyen.accdb;Persist Security Info=True");
        OleDbCommand komut;

        // form içindeki texboxları temizliyen mühendislik harikası kod
        public void Temizle(Control ctr)
        {
            foreach (Control c in ctr.Controls)
            {
                if (c is TextBox box)
                    box.Clear();
                if (c.Controls.Count > 0)
                    Temizle(c);
            }
        }
        // private kisa fonksiyonlar
        private static bool SayiMi(string deger)
        {
            try
            {
                long.Parse(deger);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void OpenConnection() => baglanti.Open();// baglantıyı açtırdık
        private void CloseConnection() => baglanti.Close();// bırdada kapattırıyoruz  2 side tek satır ama böylesi daha iyi
        private OleDbDataReader Read(string sorgu)// executeReader işlemi burda
        {
            OleDbDataReader oku;
            komut = new OleDbCommand(sorgu, baglanti);
            oku = komut.ExecuteReader();
            return oku;
        }
        private string Ekle(string sorgu)// ExecuteNonquery işlemi burda
        {
            komut = new OleDbCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            return "Ekleme İşlemi Başarılı";
        }
        private string TextBoxGenelControl(string tc, string telefon="" )// text boxtaki verilen dogru girilip girilmedigne bakıyorum
        {

            if (SayiMi(tc) == false) return "Lütfen geçerli bir tc no girin";
                else if (Convert.ToInt64(tc) / 10000000000 < 1)return "Geçersiz Tc Kimlik Numarası";

            if (telefon != "")
            {
                if (SayiMi(telefon) == false) return "Lütfen geçerli bir deger telefon no girin";
                else if (Convert.ToInt64(telefon) / 1000000000 < 1) return "Telefon numarası başına 0 koymadan geçerli bir teleon numarası giriniz";
            }
            return "";
        }

        // public fonksiyonlar
        public void DiyetisyenEkle(string tc , string password , string ad , string soyad , string telefon,string adres,Form currentForm)
        {
            string txtcontrol = TextBoxGenelControl(tc, telefon);

            if (tc == "" || password == "" || ad == "" || soyad == "" || telefon == "" || adres == "") MessageBox.Show("Lütfen Tüm alanları doldurun");
            else if (txtcontrol != "") MessageBox.Show(txtcontrol,"Hata !!");
            else
            {
                OpenConnection();
                OleDbDataReader oku = Read("select * from diyetisyen where diyetisyenTc='" + tc + "'");
                if (oku.Read()) MessageBox.Show("Bu tc numarası zaten sistemde kayıtlı \n Lütfen bilgilerinizi kontrol ediniz.", "Tc Zaten Kayıtlı !!");
                OleDbDataReader oku2 = Read("select * from diyetisyen where diyetisyenTelefon='" +"0"+ telefon + "'");
                if (oku2.Read()) MessageBox.Show("Bu telefon numarası zaten sistemde kayıtlı \n Lütfen bilgilerinizi kontrol ediniz.", "Telefon Zaten Kayıtlı !!");
                else
                {
                    string sorgu = "insert into diyetisyen(diyetisyenTc, diyetisyenPassword, diyetisyenAd, diyetisyenSoyad, diyetisyenTelefon, diyetisyenEvAdres,diyetisyenIseBaslamaTarihi) values('" + tc + "','" + password + "','" + ad + "','" + soyad + "','" +"0"+ telefon + "','" + adres + "','" + DateTime.Now.ToShortDateString() + "')";              
                    MessageBox.Show(Ekle(sorgu), "Üye Olma Başarılı");
                    Temizle(currentForm);
                }
                CloseConnection();

            }
        }
        public void AdminLoginControl(string username, string password,Form currentForm) // admin giris kontrol ediliyor
        {
            OpenConnection();

                OleDbDataReader oku = Read("SELECT * FROM admin where username='"+username+"' AND password='"+password+"'");
                if(oku.Read())
                    Singleton.Instance.ChangeScreen(currentForm, Singleton.Instance.aScreen);
                else
                    MessageBox.Show("Geçersiz Kullanici adi veya şifre.", "Hatalı Giriş");
                CloseConnection();
            Temizle(currentForm);
        }
        public void DiyetisyenLoginControl(string tc, string sifre, Form currentForm)// diyetisyen giriş konttrol ediliyor
        {
            string txtcontrol = TextBoxGenelControl(tc);

            if (tc == "" || sifre == "") MessageBox.Show("Tüm Alanları Doldurunuz");
            else if (txtcontrol != "") MessageBox.Show(txtcontrol,"Hata !!");

            else
            {
                OpenConnection();
                OleDbDataReader oku = Read("SELECT * FROM diyetisyen WHERE diyetisyenTc='" + tc + "'AND diyetisyenPassword='" + sifre + "'");
                if (oku.Read())
                {
                    Singleton.Instance.currentDiyetisyen.CurrentDiyetisyenEkle(oku["diyetisyenTc"].ToString(), oku["diyetisyenPassword"].ToString(), oku["diyetisyenAd"].ToString(), 
                        oku["diyetisyenSoyad"].ToString(), oku["diyetisyenTelefon"].ToString(), oku["diyetisyenEvAdres"].ToString(), DateTime.Parse(oku["diyetisyenIseBaslamaTarihi"].ToString()));
                    CloseConnection();
                    Temizle(currentForm);
                    Singleton.Instance.ChangeScreen(currentForm, Singleton.Instance.dScreen);
                }
                else
                  MessageBox.Show("Geçersiz Tc numarası veya şifre.", "Hatalı Giriş");
            
                CloseConnection();
                Temizle(currentForm);
            }

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
