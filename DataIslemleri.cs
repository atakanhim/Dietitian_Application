﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetisyenproje
{
    class DataIslemleri
    {
       //  Provider=Microsoft.ACE.OLEDB.12.0;Data Source =| DataDirectory |\\diyetisyen.accdb;Persist Security Info=True
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =diyetisyen.accdb;Persist Security Info=True");
        OleDbCommand komut;
        public void goster()
        {
            
            baglanti.Open();

            OleDbDataReader oku;
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * from users WHERE ad='"+"atakan"+"'");
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show(oku["soyad"].ToString());

            }


            baglanti.Close();

        }

    }
}