using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OtelOtomasyonu
{
    class MusteriBilgileri
    {

        Genel gnl = new Genel();
        public string guncelleDurum { get; set; }
        public string silDurum { get; set; }

        public DataTable tablola()
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                SqlCommand cmdVeriAl = new SqlCommand("select * from Müsteri", gnl.baglanti);
                SqlDataAdapter daVeriAl = new SqlDataAdapter(cmdVeriAl);
                DataTable tablo = new DataTable();
                daVeriAl.Fill(tablo);
                return tablo;

            }

            catch { return null; }

            finally
            {
                gnl.baglanti.Close();
            }
        }

        public void musteriGuncelle(int id, string adi, string soyadi, string cinsiyet, string telefon, string mail, string tcNo, string odaAdi, string ucret, DateTime girisTarihi, DateTime cikisTarihi)
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                SqlCommand cmdGuncelle = new SqlCommand("update müsteri set adi=@adi, soyadi=@soyadi,cinsiyet=@cinsiyet,telefon=@telefon,mail=@mail,tcNo=@tcNo,odaNo=@odaAdi,ucret=@ucret,girisTarihi=@girisTarihi,cikisTarihi=@cikisTarihi where id=@id", gnl.baglanti);
                cmdGuncelle.Parameters.AddWithValue("@adi", adi);
                cmdGuncelle.Parameters.AddWithValue("@soyadi", soyadi);
                cmdGuncelle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmdGuncelle.Parameters.AddWithValue("@telefon", telefon);
                cmdGuncelle.Parameters.AddWithValue("@mail", mail);
                cmdGuncelle.Parameters.AddWithValue("@tcNo", tcNo);
                cmdGuncelle.Parameters.AddWithValue("@odaAdi", odaAdi);
                cmdGuncelle.Parameters.AddWithValue("@ucret", ucret);
                cmdGuncelle.Parameters.AddWithValue("@girisTarihi", girisTarihi);
                cmdGuncelle.Parameters.AddWithValue("@cikisTarihi", cikisTarihi);
                cmdGuncelle.Parameters.AddWithValue("@id", id);
                cmdGuncelle.ExecuteNonQuery();
                guncelleDurum = adi + " " + soyadi + "isimli kişinin verileri güncellenmiştir.";

            }

            catch {  }

            finally
            {
                gnl.baglanti.Close();
            }
        }

        public void musteriSil(int id)
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                SqlCommand cmdSil = new SqlCommand("delete müsteri where id=@id", gnl.baglanti);
                cmdSil.Parameters.AddWithValue("@id", id);
                cmdSil.ExecuteNonQuery();
                silDurum = "Silme işlemi başarılı!";
            }

            catch { }

            finally
            {
                gnl.baglanti.Close();
            }
        }

        public DataTable musteriAra(string adi)
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                //like içerisinde '%'+ +'%' arama yapılmaktadır
                SqlCommand cmdAra = new SqlCommand("select * from müsteri where adi like '%'+@adi+'%' ", gnl.baglanti);
                cmdAra.Parameters.AddWithValue("@adi", adi);
                SqlDataAdapter daAra = new SqlDataAdapter(cmdAra);
                DataTable dt = new DataTable();
                daAra.Fill(dt);
                return dt;
                
            }

            catch { return null; }

            finally
            {
                gnl.baglanti.Close();
            }
        }
    }
}

