using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu
{
    

    class Odalar
    {
        Genel gnl = new Genel();

        public string alanKisi { get; set; }
        public string drm { get; set; }
        public string butonAdi { get; set; }

        public void odaDegerleri(string odaAdi,string durum)
        {
            if (gnl.baglanti.State==ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            try
            {
                gnl.baglanti.Open();

                SqlCommand cmdOdaAl = new SqlCommand("select * from Oda where odaAdi=@odaAdini AND durumu=@durum ", gnl.baglanti);
                cmdOdaAl.Parameters.AddWithValue("@odaAdini", odaAdi);
                cmdOdaAl.Parameters.AddWithValue("@durum", durum);
                SqlDataReader drOdaAl = cmdOdaAl.ExecuteReader();

                if (drOdaAl.Read())
                {
                    alanKisi = drOdaAl["odayiAlan"].ToString();
                    drm = drOdaAl["durumu"].ToString();
                    butonAdi = drOdaAl["butonAdi"].ToString();

                }
                drOdaAl.Close();

            }

            catch (Exception err){ System.Windows.Forms.MessageBox.Show("" + err);   }

            finally
            {
                gnl.baglanti.Close();
            }
        }

    }
}
