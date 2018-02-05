using System;
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
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }

        Genel gnl = new Genel();
        Personeller personel = new Personeller();

        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            /*Sutun adlarını değiştirebiliyoruz

            dataGridView1.Columns["id"].HeaderText = "No";
            dataGridView1.Columns["ad"].HeaderText = "Adı";
            dataGridView1.Columns["soyad"].HeaderText = "Soyadı";
            dataGridView1.Columns["telefon"].HeaderText = "Telefon";
            dataGridView1.Columns["cinsiyet"].HeaderText = "Cinsiyet";
            dataGridView1.Columns["gorev"].HeaderText = "Görev";
            dataGridView1.Columns["dogumTarihi"].HeaderText = "D.Tarihi";
            dataGridView1.Columns["adres"].HeaderText = "Adres";  */
            dataGridView2.DataSource = personel.Listele();
            
            personel.PersonelBilgileri(cbGorev);
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DateTime tarih = Convert.ToDateTime(DateTime.Now.ToLongDateString());

            personel.kaydet(txtAdi.Text, txtSoyadi.Text, mtTelefon.Text, cbCinsiyet.Text,cbGorev.Text,tarih, rtAdres.Text);
           
        }

     

        public DateTime dgmTarihi { get; set; }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dgmTarihi = Convert.ToDateTime(dtpdogumTarihi.Value);
            int id = Convert.ToInt32(lblid.Text);

            personel.guncelle(id,txtAdi.Text, txtSoyadi.Text, cbCinsiyet.Text, mtTelefon.Text, cbGorev.Text, dgmTarihi, rtAdres.Text);
           
            dataGridView2.DataSource = personel.Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblid.Text);

            personel.musteriSil(id);
           
            dataGridView2.DataSource = personel.Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           
            dataGridView2.DataSource = personel.musteriAra(txtAra.Text);
        }



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["id"].Value);
            txtAdi.Text = dataGridView2.Rows[e.RowIndex].Cells["ad"].Value.ToString();
            txtSoyadi.Text = dataGridView2.Rows[e.RowIndex].Cells["soyad"].Value.ToString();
            cbCinsiyet.Text = dataGridView2.Rows[e.RowIndex].Cells["cinsiyet"].Value.ToString();
            mtTelefon.Text = dataGridView2.Rows[e.RowIndex].Cells["telefon"].Value.ToString();
            cbGorev.Text = dataGridView2.Rows[e.RowIndex].Cells["gorev"].Value.ToString();
            dtpdogumTarihi.Value = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["dogumTarihi"].Value);
            rtAdres.Text = dataGridView2.Rows[e.RowIndex].Cells["adres"].Value.ToString();
        }
    }
}
