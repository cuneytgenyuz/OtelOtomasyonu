using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace OtelOtomasyonu
{
    public partial class frmGazeteOku : Form
    {
        public frmGazeteOku()
        {
            InitializeComponent();
        }
        ChromiumWebBrowser chrome;

        private void frmGazeteOku_Load(object sender, EventArgs e)
        {
            CefSettings ayar = new CefSettings();
            //if (Cef.IsInitialized==false)
            //{
            //    Cef.Initialize(ayar);
            //    chrome = new ChromiumWebBrowser("http://www.google.com");
            //    chrome.Parent = this.pnlGazete;
            //    chrome.BackColor = Color.Gray;
            //    chrome.Dock = DockStyle.Fill;
            //}
            //this.pnlGazete.Controls.Add(chrome);
        }

        private void milliyetSonDakikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("http://www.milliyet.com.tr/sondakika/");
        }

        private void hurriyetSonDakikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("http://www.hurriyet.com.tr/sondakika/");
        }

        private void vatanSonDakikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("http://www.gazetevatan.com/son-dakika/");
        }

        private void sabahSonDakikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("http://www.sabah.com.tr/");
        }

        private void frmGazeteOku_KeyDown(object sender, KeyEventArgs e)
        {
            frmAnaEkran ana = new frmAnaEkran();
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                ana.Show();
            }
        }
    }
}
