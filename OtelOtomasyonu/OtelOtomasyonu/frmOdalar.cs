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

namespace OtelOtomasyonu
{
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }

        ArrayList odalar = new ArrayList();
        public int deger { get; set; }
        private void frmOdalar_Load(object sender, EventArgs e)
        {
            for(int i=1; i<this.Controls.Count+1; i++)
            {
                Button btn = this.Controls.Find("oda" + i, true)[0] as Button;
                btn.Name = "btnOda" + i;
            }
            string odaAdi = "";
            string yeniDeger = "";
           // bool oldumu =false;
            for (int i = 1; i < this.Controls.Count+1; i++)//1 sn
            {
                odaAdi = Convert.ToString(this.Controls.Find("btnOda" + i.ToString(), true)[0].Text.ToString());
                
                odalar.Add(odaAdi);
             // oldumu = true;
            }
        //  if (oldumu==true)
        //  {
             odalarDurum();
        // }
                        
        }

        public string odaAdiYeni { get; set; }

        void odalarDurum()
        {
            string yeniOda = "";

            Odalar oda = new Odalar();

            try
            {
                //foreach (string odaninAdi in odalar)
                //{
                //    MessageBox.Show(odaninAdi);
                //    oda.odaDegerleri(odaninAdi, "Dolu");
                //    if (oda.drm == "Dolu")
                //    {
                //        yeniOda = odaninAdi;
                //        this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.Red;
                //        this.Controls.Find(oda.butonAdi, true)[0].Text = odaninAdi + " \n" + oda.alanKisi;
                //        oda.drm = "";
                //    }
                //    else if (oda.drm == "Boş")
                //    {
                //        this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.Green;
                //    }
                //}
                // 
                for (int i = 0; i < odalar.Count; i++)
                {
                    oda.odaDegerleri(odalar[i].ToString(), "Dolu");
                    {
                        if (oda.drm == "Dolu")
                        {
                            this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.Red;
                            this.Controls.Find(oda.butonAdi, true)[0].Text = odalar[i] + " \n" + oda.alanKisi;
                            oda.drm = "";
                        }
                        if (oda.drm == "Boş")
                        {
                            this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.Green;
                        }
                    }
                }
            }
            catch (Exception err) { System.Windows.Forms.MessageBox.Show("" + err); }

        }

        private void frmOdalar_KeyDown(object sender, KeyEventArgs e)
        {
            frmAnaEkran ana = new frmAnaEkran();
            if (e.KeyCode==Keys.Escape)
            {
                this.Hide();
                ana.Show();
            }
        }
    }
}
