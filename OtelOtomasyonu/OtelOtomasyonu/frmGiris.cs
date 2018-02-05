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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        Giris giris = new Giris();
        frmAnaEkran frmAna = new frmAnaEkran();

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (txtKullanici.Text==string.Empty||txtSifre.Text==string.Empty)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                giris.girisYap(txtKullanici.Text, txtSifre.Text, DateTime.Now);
                string bilgiTut = txtKullanici.Text + " " + txtSifre.Text;
                if (giris.girisDurumu==bilgiTut)
                {
                    frmAna.Show();
                    this.Hide();
                }
            }

        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?","Bilgilendirme",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
