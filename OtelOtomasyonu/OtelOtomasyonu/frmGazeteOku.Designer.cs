namespace OtelOtomasyonu
{
    partial class frmGazeteOku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGazeteOku));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.milliyetSonDakikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hurriyetSonDakikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vatanSonDakikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sabahSonDakikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGazete = new System.Windows.Forms.Panel();
            this.fanatikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotomaçSporHaberleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.milliyetSonDakikaToolStripMenuItem,
            this.hurriyetSonDakikaToolStripMenuItem,
            this.vatanSonDakikaToolStripMenuItem,
            this.sabahSonDakikaToolStripMenuItem,
            this.fanatikToolStripMenuItem,
            this.fotomaçSporHaberleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // milliyetSonDakikaToolStripMenuItem
            // 
            this.milliyetSonDakikaToolStripMenuItem.Name = "milliyetSonDakikaToolStripMenuItem";
            this.milliyetSonDakikaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.milliyetSonDakikaToolStripMenuItem.Text = "Milliyet Son Dakika";
            this.milliyetSonDakikaToolStripMenuItem.Click += new System.EventHandler(this.milliyetSonDakikaToolStripMenuItem_Click);
            // 
            // hurriyetSonDakikaToolStripMenuItem
            // 
            this.hurriyetSonDakikaToolStripMenuItem.Name = "hurriyetSonDakikaToolStripMenuItem";
            this.hurriyetSonDakikaToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.hurriyetSonDakikaToolStripMenuItem.Text = "Hurriyet Son Dakika";
            this.hurriyetSonDakikaToolStripMenuItem.Click += new System.EventHandler(this.hurriyetSonDakikaToolStripMenuItem_Click);
            // 
            // vatanSonDakikaToolStripMenuItem
            // 
            this.vatanSonDakikaToolStripMenuItem.Name = "vatanSonDakikaToolStripMenuItem";
            this.vatanSonDakikaToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.vatanSonDakikaToolStripMenuItem.Text = "Vatan Son Dakika";
            this.vatanSonDakikaToolStripMenuItem.Click += new System.EventHandler(this.vatanSonDakikaToolStripMenuItem_Click);
            // 
            // sabahSonDakikaToolStripMenuItem
            // 
            this.sabahSonDakikaToolStripMenuItem.Name = "sabahSonDakikaToolStripMenuItem";
            this.sabahSonDakikaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.sabahSonDakikaToolStripMenuItem.Text = "Sabah Son Dakika";
            this.sabahSonDakikaToolStripMenuItem.Click += new System.EventHandler(this.sabahSonDakikaToolStripMenuItem_Click);
            // 
            // pnlGazete
            // 
            this.pnlGazete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGazete.BackgroundImage")));
            this.pnlGazete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGazete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGazete.Location = new System.Drawing.Point(0, 24);
            this.pnlGazete.Name = "pnlGazete";
            this.pnlGazete.Size = new System.Drawing.Size(853, 549);
            this.pnlGazete.TabIndex = 1;
            // 
            // fanatikToolStripMenuItem
            // 
            this.fanatikToolStripMenuItem.Name = "fanatikToolStripMenuItem";
            this.fanatikToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.fanatikToolStripMenuItem.Text = "Fanatik Spor Haberleri";
            // 
            // fotomaçSporHaberleriToolStripMenuItem
            // 
            this.fotomaçSporHaberleriToolStripMenuItem.Name = "fotomaçSporHaberleriToolStripMenuItem";
            this.fotomaçSporHaberleriToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.fotomaçSporHaberleriToolStripMenuItem.Text = "Fotomaç Spor Haberleri";
            // 
            // frmGazeteOku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 573);
            this.Controls.Add(this.pnlGazete);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGazeteOku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Son Dakika Gazeteler";
            this.Load += new System.EventHandler(this.frmGazeteOku_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGazeteOku_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem milliyetSonDakikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hurriyetSonDakikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vatanSonDakikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sabahSonDakikaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGazete;
        private System.Windows.Forms.ToolStripMenuItem fanatikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotomaçSporHaberleriToolStripMenuItem;
    }
}