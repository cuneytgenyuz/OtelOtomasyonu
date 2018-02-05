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
    class MusteriKayıt
    {
        public string kisiAdi_soyadi { get; set; }


        Genel gnl = new Genel();

        public static void odaGuncelle(string oda, string kisiAdSoyad)
        {
            Genel gnl = new Genel();
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();
                SqlCommand cmdguncelle = new SqlCommand("update Oda set odayiAlan=@alanKisi, durumu=@durum where odaAdi=@odaAdiS ", gnl.baglanti);
                cmdguncelle.Parameters.AddWithValue("@alanKisi", kisiAdSoyad);
                cmdguncelle.Parameters.AddWithValue("@durum", "Dolu");
                cmdguncelle.Parameters.AddWithValue("@odaAdiS", oda);
                cmdguncelle.ExecuteNonQuery();
                
                cmdguncelle.Dispose();
            }
            catch { }
            finally
            {
                gnl.baglanti.Close();
            }
        }

        public void kayıtAl(string adi, string soyadi, string cinsiyet, string telefon, string mail, string tcNo, string odaAdi, string ucret, DateTime girisTarihi, DateTime cikisTarihi)
        {

            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }

            try
            {
                gnl.baglanti.Open();
                SqlCommand cmdKayıtAl = new SqlCommand("insert into Müsteri values (@adi,@soyadi,@cinsiyet,@telefon,@mail,@tc,@oda,@ucret,@giris,@cikis)", gnl.baglanti);
                cmdKayıtAl.Parameters.AddWithValue("@adi", adi);
                cmdKayıtAl.Parameters.AddWithValue("@soyadi", soyadi);
                cmdKayıtAl.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmdKayıtAl.Parameters.AddWithValue("@telefon", telefon);
                cmdKayıtAl.Parameters.AddWithValue("@mail", mail);
                cmdKayıtAl.Parameters.AddWithValue("@tc", tcNo);
                cmdKayıtAl.Parameters.AddWithValue("@oda", odaAdi);
                cmdKayıtAl.Parameters.AddWithValue("@ucret", ucret);
                cmdKayıtAl.Parameters.AddWithValue("@giris", girisTarihi);
                cmdKayıtAl.Parameters.AddWithValue("@cikis", cikisTarihi);

                cmdKayıtAl.ExecuteNonQuery();
                MessageBox.Show("Müşteri kayıt edilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmdKayıtAl.Dispose();


                kisiAdi_soyadi = adi + " " + soyadi;
                odaGuncelle(odaAdi, kisiAdi_soyadi);

            }
            catch { }
            finally
            {
                gnl.baglanti.Close();
            }
        }

  

    }
}
