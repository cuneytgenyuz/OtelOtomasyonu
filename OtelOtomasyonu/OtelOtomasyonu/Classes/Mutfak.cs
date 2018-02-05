using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace OtelOtomasyonu
{
    class Mutfak
    {
        Genel gnl = new Genel();

        public string mutfakMi { get; set; }
        public string odaMi { get; set; }
        public ArrayList kategoriler = new ArrayList();

        public void mutfakEkle(string urunAdi, string kategori, string adet, string fiyat, string firma, DateTime gelisTarihi)
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                if (mutfakMi=="Mutfak")
                {
                     SqlCommand cmdMutfak = new SqlCommand("insert into mutfak values (@urunAdi,@kategori,@adet,@fiyat,@firma,@gelisTarihi)", gnl.baglanti);
                    cmdMutfak.Parameters.AddWithValue("@urunAdi", urunAdi);
                    cmdMutfak.Parameters.AddWithValue("@kategori", kategori);
                    cmdMutfak.Parameters.AddWithValue("@adet", adet);
                    cmdMutfak.Parameters.AddWithValue("@fiyat", fiyat);
                    cmdMutfak.Parameters.AddWithValue("@firma", firma);
                    cmdMutfak.Parameters.AddWithValue("@gelisTarihi", gelisTarihi);
                    cmdMutfak.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Ürünler eklenmiştir", "Bilgilendirme", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                else if (odaMi == "Oda")
                {
                    SqlCommand cmdMutfak = new SqlCommand("insert into odaUrunleri values (@urunAdi,@kategori,@adet,@fiyat,@firma,@gelisTarihi)", gnl.baglanti);
                    cmdMutfak.Parameters.AddWithValue("@urunAdi", urunAdi);
                    cmdMutfak.Parameters.AddWithValue("@kategori", kategori);
                    cmdMutfak.Parameters.AddWithValue("@adet", adet);
                    cmdMutfak.Parameters.AddWithValue("@fiyat", fiyat);
                    cmdMutfak.Parameters.AddWithValue("@firma", firma);
                    cmdMutfak.Parameters.AddWithValue("@gelisTarihi", gelisTarihi);
                    cmdMutfak.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Ürünler eklenmiştir", "Bilgilendirme", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }

            }

            catch { }

            finally
            {
                gnl.baglanti.Close();
            }
        }

        public DataTable mutfakUrunListele()
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                SqlCommand cmdMutfakAl = new SqlCommand("select * from mutfak", gnl.baglanti);
                SqlDataAdapter daMutfakAl = new SqlDataAdapter(cmdMutfakAl);
                DataTable dtMutfakAl = new DataTable();
                daMutfakAl.Fill(dtMutfakAl);
                return dtMutfakAl;

            }

            catch { return null; }

            finally
            {
                gnl.baglanti.Close();
            }
        }

        public DataTable odaUrunListele()
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                SqlCommand cmdOdaAl = new SqlCommand("select * from odaUrunleri", gnl.baglanti);
                SqlDataAdapter daOdaAl = new SqlDataAdapter(cmdOdaAl);
                DataTable dtOdaAl = new DataTable();
                daOdaAl.Fill(dtOdaAl);
                return dtOdaAl;

            }

            catch { return null; }

            finally
            {
                gnl.baglanti.Close();
            }
        }

        public void urunGuncelle(int id, string urunAdi, string kategori, string adet, string fiyat, string firma, DateTime gelisTarihi)
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();
                if (mutfakMi == "Mutfak")
                {
                    SqlCommand cmdGuncelle = new SqlCommand("update mutfak set urunAdi=@urunAdi,kategori=@kategori,adet=@adet,fiyat=@fiyat,firma=@firma,gelisTarihi=@gelisTarihi where id=@id", gnl.baglanti);
                    cmdGuncelle.Parameters.AddWithValue("@urunAdi", urunAdi);
                    cmdGuncelle.Parameters.AddWithValue("@kategori", kategori);
                    cmdGuncelle.Parameters.AddWithValue("@adet", adet);
                    cmdGuncelle.Parameters.AddWithValue("@fiyat", fiyat);
                    cmdGuncelle.Parameters.AddWithValue("@firma", firma);
                    cmdGuncelle.Parameters.AddWithValue("@gelisTarihi", gelisTarihi);
                    cmdGuncelle.Parameters.AddWithValue("@id", id);
                    cmdGuncelle.ExecuteNonQuery();
                    MessageBox.Show("Mutfak ürünleri güncelleme işlemi başarılı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdGuncelle.Dispose();
                }
                else if (odaMi == "Oda")
                {
                    SqlCommand cmdGuncelle = new SqlCommand("update odaUrunleri set urunAdi=@urunAdi,kategori=@kategori,adet=@adet,fiyat=@fiyat,firma=@firma,gelisTarihi=@gelisTarihi where id=@id", gnl.baglanti);
                    cmdGuncelle.Parameters.AddWithValue("@urunAdi", urunAdi);
                    cmdGuncelle.Parameters.AddWithValue("@kategori", kategori);
                    cmdGuncelle.Parameters.AddWithValue("@adet", adet);
                    cmdGuncelle.Parameters.AddWithValue("@fiyat", fiyat);
                    cmdGuncelle.Parameters.AddWithValue("@firma", firma);
                    cmdGuncelle.Parameters.AddWithValue("@gelisTarihi", gelisTarihi);
                    cmdGuncelle.Parameters.AddWithValue("@id", id);
                    cmdGuncelle.ExecuteNonQuery();
                    MessageBox.Show("Oda ürünleri güncelleme işleri başarılı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdGuncelle.Dispose();
                }

            }

            catch { }

            finally
            {
                gnl.baglanti.Close();
            }
        }

        public void urunSil(int id)
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();
                if (mutfakMi == "Mutfak")
                {
                    SqlCommand cmdSil = new SqlCommand("delete mutfak where id=@id", gnl.baglanti);
                    cmdSil.Parameters.AddWithValue("@id", id);
                    cmdSil.ExecuteNonQuery();
                    MessageBox.Show("Mutfak ürünü silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdSil.Dispose();
                }
                else if (odaMi == "Oda")
                {
                    SqlCommand cmdSil = new SqlCommand("delete odaUrunleri where id=@id", gnl.baglanti);
                    cmdSil.Parameters.AddWithValue("@id", id);
                    cmdSil.ExecuteNonQuery();
                    MessageBox.Show("Oda ürünü silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdSil.Dispose();
                }

            }

            catch { }

            finally
            {
                gnl.baglanti.Close();
            }
        }

        public void kategoriListele()
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                if (mutfakMi=="Mutfak")
                {
                    kategoriler.Clear();

                    SqlCommand cmdMutfakKategori = new SqlCommand("select * from MutfakKategori", gnl.baglanti);
                    SqlDataReader drMutfakKategori = cmdMutfakKategori.ExecuteReader();

                    while (drMutfakKategori.Read())
                    {
                        string kategori = drMutfakKategori["kategoriAdi"].ToString();
                        kategoriler.Add(kategori);
                        

                    }
                    drMutfakKategori.Close();
                }
                else if (odaMi=="Oda")
                {
                    kategoriler.Clear();

                    SqlCommand cmdOdaKategori = new SqlCommand("select * from OdaKategori", gnl.baglanti);
                    SqlDataReader drOdaKategori = cmdOdaKategori.ExecuteReader();

                    while (drOdaKategori.Read())
                    {
                        string kategori = drOdaKategori["kategoriAdi"].ToString();
                        kategoriler.Add(kategori);

                    }
                    drOdaKategori.Close();
                }
                

            }

            catch { }

            finally
            {
                gnl.baglanti.Close();
            }
        }

        public DataTable veriGetirMutfak(string urunAdi)
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                SqlCommand cmdGetir = new SqlCommand("select * from mutfak where urunAdi like '%'+@adi+'%' ", gnl.baglanti);
                cmdGetir.Parameters.AddWithValue("@adi", urunAdi);
                SqlDataAdapter daGetir = new SqlDataAdapter(cmdGetir);
                DataTable dtGetir = new DataTable();
                daGetir.Fill(dtGetir);
                return dtGetir;

            }

            catch { return null; }

            finally
            {
                gnl.baglanti.Close();
            }
        }

        public DataTable veriGetirOda(string urunAdi)
        {
            if (gnl.baglanti.State == ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                SqlCommand cmdGetir = new SqlCommand("select * from odaUrunleri where urunAdi like '%'+@adi+'%' ", gnl.baglanti);
                cmdGetir.Parameters.AddWithValue("@adi", urunAdi);
                SqlDataAdapter daGetir = new SqlDataAdapter(cmdGetir);
                DataTable dtGetir = new DataTable();
                daGetir.Fill(dtGetir);
                return dtGetir;

            }

            catch { return null; }

            finally
            {
                gnl.baglanti.Close();
            }
        }
    }

}

