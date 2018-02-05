using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    class Giris
    {
        Genel gnl = new Genel();

        public string kullaniciAdi_tut { get; set; }
        public string sifre_tut { get; set; }

        public string girisDurumu { get; set; }

        public void girisYap(string kullaniciAdi, string sifre, DateTime tarih)
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }

            try
            {
                gnl.baglanti.Open();
                SqlCommand cmdgiris = new SqlCommand("select kullaniciAdi from KullaniciBilgileri where kullaniciAdi=@kulAdi", gnl.baglanti);
                cmdgiris.Parameters.AddWithValue("@kulAdi", kullaniciAdi);
                SqlDataReader dr = cmdgiris.ExecuteReader();

                if (dr.Read())
                {
                    kullaniciAdi_tut = dr["kullaniciAdi"].ToString();
                    SqlCommand cmdgAdi = new SqlCommand("select kullaniciSifre from KullaniciBilgileri where kullaniciSifre=@sifre", gnl.baglanti);
                    cmdgAdi.Parameters.AddWithValue("@sifre", sifre);
                    SqlDataReader drgiris = cmdgAdi.ExecuteReader();

                    if (drgiris.Read())
                    {
                        sifre_tut = drgiris["kullaniciSifre"].ToString();
                        girisDurumu = kullaniciAdi_tut + " " + sifre_tut;
                        SqlCommand cmdTarih = new SqlCommand("update KullaniciBilgileri set girisTarihi=@tarih where kullaniciAdi=@kulAdi AND kullaniciSifre=@sifre", gnl.baglanti);
                        cmdTarih.Parameters.AddWithValue("@tarih", tarih);
                        cmdTarih.Parameters.AddWithValue("@kulAdi", kullaniciAdi_tut);
                        cmdTarih.Parameters.AddWithValue("@sifre", sifre_tut);
                        cmdTarih.ExecuteNonQuery();

                        cmdTarih.Dispose();
                        
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz değerleri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmdgAdi.Dispose();
                    drgiris.Close();
                    
                }
                else
                {
                    MessageBox.Show("Girdiğiniz değerleri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cmdgiris.Dispose();
                dr.Close();
                gnl.baglanti.Close();
           }
            catch { }
            finally
            {
                gnl.baglanti.Close();
            }



        }

    }
}
