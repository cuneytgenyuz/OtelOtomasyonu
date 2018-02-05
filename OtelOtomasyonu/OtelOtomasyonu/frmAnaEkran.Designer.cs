namespace OtelOtomasyonu
{
    partial class frmAnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaEkran));
            this.btnMusteriKayıt = new System.Windows.Forms.Button();
            this.btnMusteriBilgiler = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.btnGazeteOku = new System.Windows.Forms.Button();
            this.btnMutfak = new System.Windows.Forms.Button();
            this.btnPrsnlIslemleri = new System.Windows.Forms.Button();
            this.btnKilit = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnMusteriKayıt
            // 
            this.btnMusteriKayıt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMusteriKayıt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriKayıt.BackgroundImage")));
            this.btnMusteriKayıt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriKayıt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriKayıt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriKayıt.Location = new System.Drawing.Point(54, 32);
            this.btnMusteriKayıt.Name = "btnMusteriKayıt";
            this.btnMusteriKayıt.Size = new System.Drawing.Size(175, 179);
            this.btnMusteriKayıt.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnMusteriKayıt, "Yeni Müşteri");
            this.btnMusteriKayıt.UseVisualStyleBackColor = false;
            this.btnMusteriKayıt.Click += new System.EventHandler(this.MusteriKayıt_Click);
            // 
            // btnMusteriBilgiler
            // 
            this.btnMusteriBilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMusteriBilgiler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriBilgiler.BackgroundImage")));
            this.btnMusteriBilgiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriBilgiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriBilgiler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriBilgiler.Location = new System.Drawing.Point(244, 32);
            this.btnMusteriBilgiler.Name = "btnMusteriBilgiler";
            this.btnMusteriBilgiler.Size = new System.Drawing.Size(158, 179);
            this.btnMusteriBilgiler.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnMusteriBilgiler, "Müşteri Bilgileri");
            this.btnMusteriBilgiler.UseVisualStyleBackColor = false;
            this.btnMusteriBilgiler.Click += new System.EventHandler(this.btnMusteriBilgiler_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOdalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdalar.BackgroundImage")));
            this.btnOdalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdalar.Location = new System.Drawing.Point(425, 32);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(348, 179);
            this.btnOdalar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnOdalar, "Odalar");
            this.btnOdalar.UseVisualStyleBackColor = false;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // btnGazeteOku
            // 
            this.btnGazeteOku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGazeteOku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGazeteOku.BackgroundImage")));
            this.btnGazeteOku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGazeteOku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGazeteOku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGazeteOku.Location = new System.Drawing.Point(425, 246);
            this.btnGazeteOku.Name = "btnGazeteOku";
            this.btnGazeteOku.Size = new System.Drawing.Size(168, 186);
            this.btnGazeteOku.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnGazeteOku, "Gazeteler");
            this.btnGazeteOku.UseVisualStyleBackColor = false;
            this.btnGazeteOku.Click += new System.EventHandler(this.btnGazeteOku_Click);
            // 
            // btnMutfak
            // 
            this.btnMutfak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMutfak.BackgroundImage")));
            this.btnMutfak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMutfak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMutfak.Location = new System.Drawing.Point(54, 246);
            this.btnMutfak.Name = "btnMutfak";
            this.btnMutfak.Size = new System.Drawing.Size(348, 186);
            this.btnMutfak.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnMutfak, "Mutfak");
            this.btnMutfak.UseVisualStyleBackColor = true;
            this.btnMutfak.Click += new System.EventHandler(this.btnMutfak_Click);
            // 
            // btnPrsnlIslemleri
            // 
            this.btnPrsnlIslemleri.BackColor = System.Drawing.Color.Teal;
            this.btnPrsnlIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrsnlIslemleri.BackgroundImage")));
            this.btnPrsnlIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrsnlIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrsnlIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrsnlIslemleri.Location = new System.Drawing.Point(607, 246);
            this.btnPrsnlIslemleri.Name = "btnPrsnlIslemleri";
            this.btnPrsnlIslemleri.Size = new System.Drawing.Size(166, 186);
            this.btnPrsnlIslemleri.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnPrsnlIslemleri, "Personeller");
            this.btnPrsnlIslemleri.UseVisualStyleBackColor = false;
            this.btnPrsnlIslemleri.Click += new System.EventHandler(this.btnPrsnlIslemleri_Click);
            // 
            // btnKilit
            // 
            this.btnKilit.BackColor = System.Drawing.Color.Transparent;
            this.btnKilit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKilit.BackgroundImage")));
            this.btnKilit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKilit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKilit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKilit.Location = new System.Drawing.Point(78, 467);
            this.btnKilit.Name = "btnKilit";
            this.btnKilit.Size = new System.Drawing.Size(304, 151);
            this.btnKilit.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnKilit, "Kilitle");
            this.btnKilit.UseVisualStyleBackColor = false;
            this.btnKilit.Click += new System.EventHandler(this.btnKilit_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(469, 467);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(304, 151);
            this.btnCikis.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnCikis, "Çıkış");
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 641);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKilit);
            this.Controls.Add(this.btnPrsnlIslemleri);
            this.Controls.Add(this.btnMutfak);
            this.Controls.Add(this.btnGazeteOku);
            this.Controls.Add(this.btnOdalar);
            this.Controls.Add(this.btnMusteriBilgiler);
            this.Controls.Add(this.btnMusteriKayıt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriKayıt;
        private System.Windows.Forms.Button btnMusteriBilgiler;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Button btnGazeteOku;
        private System.Windows.Forms.Button btnMutfak;
        private System.Windows.Forms.Button btnPrsnlIslemleri;
        private System.Windows.Forms.Button btnKilit;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}