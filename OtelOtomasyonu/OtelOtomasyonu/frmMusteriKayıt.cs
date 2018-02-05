using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelOtomasyonu
{
    public partial class frmMusteriKayıt : Form
    {
        public frmMusteriKayıt()
        {
            InitializeComponent();
        }
        Genel gnl = new Genel();

        ArrayList odalar = new ArrayList();
       void koltukYazdır()
       {
           string oda = "";
           for (int i = 0; i < odalar.Count; i++)
           {
               oda += odalar[i].ToString()+",";
           }
           if (odalar.Count>=1)
           {
               oda = oda.Remove(oda.Length - 1, 1);
           }
           txtSeciliOdalar.Text = oda;
       }
       

        private void odaTikla(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor==Color.Green)
            {

               ((Button)sender).BackColor = Color.Orange;
                if (!odalar.Contains(((Button)sender).Text))
                {

                    odalar.Add(((Button)sender).Text);

                }
                koltukYazdır();

            }
            else if (((Button)sender).BackColor==Color.Orange)
            {
                ((Button)sender).BackColor = Color.Green;
                if (odalar.Contains(((Button)sender).Text))
                {
                    odalar.Remove(((Button)sender).Text);

                }
                koltukYazdır();
            }

            
        }

        public DateTime girisT { get; set; }
        public DateTime cikisT { get; set; }
                
        private void btnOdaVer_Click(object sender, EventArgs e)
        {
           girisT = Convert.ToDateTime(dtp1.Value);
           cikisT = Convert.ToDateTime(dtp2.Value);
           MusteriKayıt mk = new MusteriKayıt();
           for (int i = 0; i < odalar.Count; i++)
           {
               string oda = odalar[i].ToString();

               mk.kayıtAl(txtAdi.Text, txtSoyadi.Text, cbCinsiyet.Text, mtTelefon.Text, txtMail.Text, txtTcNo.Text, oda, txtUcret.Text, girisT, cikisT);
                //this.Controls.Find(oda, true)[0].BackColor = Color.Red;
           }
            
            timerKontrol.Start();
            

        }

        private void timerKontrol_Tick(object sender, EventArgs e)
        {
           

            if (gnl.baglanti.State==ConnectionState.Open)
            {
                gnl.baglanti.Close();
            }
            
            try
            {
                
                gnl.baglanti.Open();

                SqlCommand cmdDonustur = new SqlCommand("select * from Oda where durumu=@durum", gnl.baglanti);
                cmdDonustur.Parameters.AddWithValue("@durum","Dolu");
                SqlDataReader drDonustur = cmdDonustur.ExecuteReader();

                while (drDonustur.Read())
                {
                    string btnAdi = drDonustur["butonAdi"].ToString();
                    string durumu = drDonustur["durumu"].ToString();
                    //Button btn = this.Controls.Find(btnAdi, true)[0] as Button;
                    //if(durumu == "Dolu") { btn.BackColor = Color.Red; }
                    //if(durumu == "Boş") { btn.BackColor = Color.Green; }

                    
                    if (durumu == "Dolu") { this.Controls.Find(btnAdi, true)[0].BackColor = Color.Red; }
                    if (durumu == "Boş") { this.Controls.Find(btnAdi, true)[0].BackColor = Color.Green; }
                    
                    //if (btnAdi=="oda1"&&durumu=="Dolu")
                    //{
                    //    btnOda1.BackColor = Color.Red;
                    //}
                    //else if (btnAdi=="oda2"&&durumu=="Dolu") 
                    //{
                    //    btnOda2.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda3" && durumu == "Dolu")
                    //{
                    //    btnOda3.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda4" && durumu == "Dolu")
                    //{
                    //    btnOda4.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda5" && durumu == "Dolu")
                    //{
                    //    btnOda5.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda6" && durumu == "Dolu")
                    //{
                    //    btnOda6.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda7" && durumu == "Dolu")
                    //{
                    //    btnOda7.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda8" && durumu == "Dolu")
                    //{
                    //    btnOda8.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda9" && durumu == "Dolu")
                    //{
                    //    btnOda9.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda10" && durumu == "Dolu")
                    //{
                    //    btnOda10.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda11" && durumu == "Dolu")
                    //{
                    //    btnOda11.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda12" && durumu == "Dolu")
                    //{
                    //    btnOda12.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda13" && durumu == "Dolu")
                    //{
                    //    btnOda13.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda14" && durumu == "Dolu")
                    //{
                    //    btnOda14.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda15" && durumu == "Dolu")
                    //{
                    //    btnOda15.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda16" && durumu == "Dolu")
                    //{
                    //    btnOda16.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda17" && durumu == "Dolu")
                    //{
                    //    btnOda17.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda18" && durumu == "Dolu")
                    //{
                    //    btnOda18.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda19" && durumu == "Dolu")
                    //{
                    //    btnOda19.BackColor = Color.Red;
                    //}
                    //else if (btnAdi == "oda20" && durumu == "Dolu")
                    //{
                    //    btnOda20.BackColor = Color.Red;
                    //}

                }


                gnl.baglanti.Close();
                timerKontrol.Stop();
            }
            catch { }
            finally
            {
                gnl.baglanti.Close();

            }
        }

        private void frmMusteriKayıt_Load(object sender, EventArgs e)
        {
            timerKontrol.Start();
        }
    }
}
