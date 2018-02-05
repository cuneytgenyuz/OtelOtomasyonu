using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace OtelOtomasyonu
{
    class Personeller
    {
        Genel gnl = new Genel();

        private string _gorev;


        public string gorev
        {
            get { return _gorev; }
            set { _gorev = value; }
        }
        public string guncelleDurum { get; set; }
        public string silDurum { get; set; }




        public void kaydet(string ad, string soyad, string telefon, string cinsiyet, string gorev, DateTime dogumTarihi, string adres)
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }


            try
            {
                gnl.baglanti.Open();

                SqlCommand cmdKaydet = new SqlCommand("insert into personel values (@ad,@soyad,@telefon,@cinsiyet,@gorev,@dogumTarihi,@adres)", gnl.baglanti);
                cmdKaydet.Parameters.AddWithValue("@ad", ad);
                cmdKaydet.Parameters.AddWithValue("@soyad", soyad);
                cmdKaydet.Parameters.AddWithValue("@telefon", telefon);
                cmdKaydet.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmdKaydet.Parameters.AddWithValue("@gorev", gorev);
                cmdKaydet.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);
                cmdKaydet.Parameters.AddWithValue("@adres", adres);
                cmdKaydet.ExecuteNonQuery();

                MessageBox.Show("Personel kayıt edilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmdKaydet.Dispose();

            }
            catch { }
            finally
            {
                gnl.baglanti.Close();
            }


        }

        public void guncelle(int id, string adi, string soyadi, string cinsiyet, string telefon, string gorev, DateTime dogumTarihi, string adres)
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                SqlCommand cmdGuncelle = new SqlCommand("update personel set ad=@ad, soyad=@soyad,cinsiyet=@cinsiyet,telefon=@telefon,gorev=@gorev,dogumTarihi=@dogumTarihi,adres=@adres where id=@id", gnl.baglanti);
                cmdGuncelle.Parameters.AddWithValue("@ad", adi);
                cmdGuncelle.Parameters.AddWithValue("@soyad", soyadi);
                cmdGuncelle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmdGuncelle.Parameters.AddWithValue("@telefon", telefon);
                cmdGuncelle.Parameters.AddWithValue("@gorev", gorev);
                cmdGuncelle.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);
                cmdGuncelle.Parameters.AddWithValue("@adres", adres);
                cmdGuncelle.Parameters.AddWithValue("@id", id);
                cmdGuncelle.ExecuteNonQuery();
                guncelleDurum = adi + " " + soyadi + "isimli kişinin verileri güncellenmiştir.";

            }

            catch { }

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

                SqlCommand cmdSil = new SqlCommand("delete personel where id=@id", gnl.baglanti);
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

        public DataTable Listele()
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }

            try
            {
                gnl.baglanti.Open();

                SqlCommand cmdListe = new SqlCommand("select * from personel", gnl.baglanti);
                SqlDataAdapter daListe = new SqlDataAdapter(cmdListe);
                DataTable tablo = new DataTable();
                daListe.Fill(tablo);
                return tablo;

            }
            catch { return null; }
            finally
            {
                gnl.baglanti.Close();
            }
        }

        public void PersonelBilgileri(ComboBox cb)
        {
            cb.Items.Clear();

            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }


            gnl.baglanti.Open();

            SqlCommand komut = new SqlCommand("select gorev from personel", gnl.baglanti);


            if (gnl.baglanti.State == ConnectionState.Closed)
            {
                gnl.baglanti.Open();
            }

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                Personeller prsnl = new Personeller();

                prsnl.gorev = oku["gorev"].ToString();

                cb.Items.Add(prsnl);

            }
            oku.Close();
            gnl.baglanti.Close();

        }

        public override string ToString()
        {
            return gorev;
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
                SqlCommand cmdAra = new SqlCommand("select * from personel where ad like '%'+@ad+'%' ", gnl.baglanti);
                cmdAra.Parameters.AddWithValue("@ad", adi);
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
