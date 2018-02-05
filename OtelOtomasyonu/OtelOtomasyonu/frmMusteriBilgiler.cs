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
    public partial class frmMusteriBilgiler : Form
    {
        public frmMusteriBilgiler()
        {
            InitializeComponent();
        }

        private void frmMusteriBilgiler_Load(object sender, EventArgs e)
        {
            MusteriBilgileri mb = new MusteriBilgileri();
            dataGridView1.DataSource = mb.tablola();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            txtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["adi"].Value.ToString();
            txtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells["soyadi"].Value.ToString();
            cbCinsiyet.Text = dataGridView1.Rows[e.RowIndex].Cells["cinsiyet"].Value.ToString();
            mtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells["telefon"].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells["mail"].Value.ToString();
            txtTcNo.Text = dataGridView1.Rows[e.RowIndex].Cells["tcNo"].Value.ToString();
            txtAldigiOdalar.Text = dataGridView1.Rows[e.RowIndex].Cells["odaNo"].Value.ToString();
            txtUcret.Text = dataGridView1.Rows[e.RowIndex].Cells["ucret"].Value.ToString();
            dtp1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["girisTarihi"].Value);
            dtp2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["cikisTarihi"].Value);
        }

        private void btnMusterileriGetir_Click(object sender, EventArgs e)
        {
            MusteriBilgileri mb = new MusteriBilgileri();
            dataGridView1.DataSource = mb.tablola();


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            cbCinsiyet.SelectedIndex = -1;
            mtTelefon.Text = "";
            txtMail.Text = "";
            txtTcNo.Text = "";
            txtAldigiOdalar.Text = "";
            txtUcret.Text = "";
            dtp1.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblid.Text);

            MusteriBilgileri mb = new MusteriBilgileri();
            mb.musteriSil(id);
            dataGridView1.DataSource = mb.tablola();

        }
        public DateTime girisT { get; set; }
        public DateTime cikisT { get; set; }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            girisT = Convert.ToDateTime(dtp1.Value);
            cikisT = Convert.ToDateTime(dtp2.Value);
            int id = Convert.ToInt32(lblid.Text);

            MusteriBilgileri mb = new MusteriBilgileri();
            mb.musteriGuncelle(id, txtAdi.Text, txtSoyadi.Text, cbCinsiyet.Text, mtTelefon.Text, txtMail.Text, txtTcNo.Text, txtAldigiOdalar.Text, txtUcret.Text, girisT,cikisT);
            dataGridView1.DataSource = mb.tablola();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MusteriBilgileri mb = new MusteriBilgileri();
            dataGridView1.DataSource = mb.musteriAra(txtArama.Text);
        }
    }
}
