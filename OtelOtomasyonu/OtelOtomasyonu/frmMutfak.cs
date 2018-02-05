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
    public partial class frmMutfak : Form
    {
        public frmMutfak()
        {
            InitializeComponent();
        }
        Mutfak mtfk = new Mutfak();

        private void rbMutfak_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rbMutfak.Checked==true)
            {
               // dataGridView1.DataSource = null;
                
                dataGridView2.DataSource = mtfk.mutfakUrunListele();
                mtfk.mutfakMi = "Mutfak";
                mtfk.odaMi = "";
                cbKategori.Items.Clear();
                mtfk.kategoriListele();
                for (int i = 0; i < mtfk.kategoriler.Count; i++)
                {
                    cbKategori.Items.Add(mtfk.kategoriler[i].ToString());
                }
            }
        }

        private void rbOda_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOda.Checked == true)
            {
                //dataGridView1.DataSource = null;
                
                dataGridView2.DataSource = mtfk.odaUrunListele();
                mtfk.mutfakMi = "";
                mtfk.odaMi = "Oda";
                cbKategori.Items.Clear();
                mtfk.kategoriListele();
                for (int i = 0; i < mtfk.kategoriler.Count; i++)
                {
                    cbKategori.Items.Add(mtfk.kategoriler[i].ToString());
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DateTime tarih = Convert.ToDateTime(DateTime.Now.ToLongDateString());

            if (rbMutfak.Checked==true)
            {
                mtfk.mutfakEkle(txtUrunAdi.Text, cbKategori.Text, txtUrunAdet.Text, txtUrunFiyat.Text, txtFirmaAdi.Text, tarih);
                
                dataGridView2.DataSource = mtfk.mutfakUrunListele();
            }
            else if (rbOda.Checked==true)
            {
                mtfk.mutfakEkle(txtUrunAdi.Text, cbKategori.Text, txtUrunAdet.Text, txtUrunFiyat.Text, txtFirmaAdi.Text, tarih);
                
                dataGridView2.DataSource = mtfk.odaUrunListele();
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (rbMutfak.Checked==true)
            {
               // dataGridView1.DataSource = null;
                
                dataGridView2.DataSource = mtfk.mutfakUrunListele();
            }
            else if (rbOda.Checked==true)
            {
               // dataGridView1.DataSource = null;
                
                dataGridView2.DataSource = mtfk.odaUrunListele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DateTime tarih = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            int id = Convert.ToInt32(lblid.Text);
            if (rbMutfak.Checked==true)
            {
                mtfk.urunGuncelle(id, txtUrunAdi.Text, cbKategori.Text, txtUrunAdet.Text, txtUrunFiyat.Text, txtFirmaAdi.Text, tarih);
                
                dataGridView2.DataSource = mtfk.mutfakUrunListele();
            }
            else if (rbOda.Checked==true)
            {
                mtfk.urunGuncelle(id, txtUrunAdi.Text, cbKategori.Text, txtUrunAdet.Text, txtUrunFiyat.Text, txtFirmaAdi.Text, tarih);
                
                dataGridView2.DataSource = mtfk.odaUrunListele();
            }
        }

     

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblid.Text);
            mtfk.urunSil(id);
            dataGridView2.DataSource = mtfk.mutfakUrunListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Text = "";
            cbKategori.Text = "";
            txtUrunAdet.Text = "";
            txtUrunFiyat.Text = "";
            txtFirmaAdi.Text = "";
            dtpGelisTarihi.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (rbMutfak.Checked==true)
            {
                
                dataGridView2.DataSource = mtfk.veriGetirMutfak(txtAra.Text);
            }
            else if(rbOda.Checked==true)
            {
                
                dataGridView2.DataSource = mtfk.veriGetirOda(txtAra.Text);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtUrunAdi.Text = dataGridView2.Rows[e.RowIndex].Cells["urunAdi"].Value.ToString();
            cbKategori.Text = dataGridView2.Rows[e.RowIndex].Cells["kategori"].Value.ToString();
            txtUrunAdet.Text = dataGridView2.Rows[e.RowIndex].Cells["adet"].Value.ToString();
            txtUrunFiyat.Text = dataGridView2.Rows[e.RowIndex].Cells["fiyat"].Value.ToString();
            txtFirmaAdi.Text = dataGridView2.Rows[e.RowIndex].Cells["firma"].Value.ToString();
            dtpGelisTarihi.Value = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["gelisTarihi"].Value);
        }
    }
}
