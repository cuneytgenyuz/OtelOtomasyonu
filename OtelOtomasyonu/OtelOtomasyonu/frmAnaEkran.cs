using System;
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
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void MusteriKayıt_Click(object sender, EventArgs e)
        {
            frmMusteriKayıt frmMKayıt = new frmMusteriKayıt();
            frmMKayıt.Show();
            //this.Hide();
        }

        private void btnMusteriBilgiler_Click(object sender, EventArgs e)
        {
            frmMusteriBilgiler MusteriBilgiler = new frmMusteriBilgiler();
            MusteriBilgiler.Show();
            //this.Hide();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            frmOdalar odalar = new frmOdalar();
            odalar.Show();
            //this.Hide();
        }

        private void btnGazeteOku_Click(object sender, EventArgs e)
        {
            frmGazeteOku gazete = new frmGazeteOku();
            gazete.Show();
            //this.Hide();
        }

      

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            frmMutfak mutfak = new frmMutfak();
            mutfak.Show();
            //this.Hide();
        }

        private void btnPrsnlIslemleri_Click(object sender, EventArgs e)
        {
            frmPersoneller personel = new frmPersoneller();
            personel.Show();
            //this.Hide();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kilitlemek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                frmGiris giris = new frmGiris();
                giris.Show();
                this.Hide();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
