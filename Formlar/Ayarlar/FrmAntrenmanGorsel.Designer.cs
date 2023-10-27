namespace AntrenmanTakip.Formlar.Ayarlar
{
    partial class FrmAntrenmanGorsel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAntrenmanGorsel));
            this.lblOnizleme = new System.Windows.Forms.Label();
            this.lblBtnGorsel = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOnizleme
            // 
            resources.ApplyResources(this.lblOnizleme, "lblOnizleme");
            this.lblOnizleme.Name = "lblOnizleme";
            // 
            // lblBtnGorsel
            // 
            resources.ApplyResources(this.lblBtnGorsel, "lblBtnGorsel");
            this.lblBtnGorsel.Name = "lblBtnGorsel";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.Image = global::AntrenmanTakip.Properties.Resources.kaydet48px;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnResim
            // 
            this.btnResim.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnResim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResim.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnResim, "btnResim");
            this.btnResim.Image = global::AntrenmanTakip.Properties.Resources.yükle24px;
            this.btnResim.Name = "btnResim";
            this.btnResim.UseVisualStyleBackColor = false;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // FrmAntrenmanGorsel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.lblOnizleme);
            this.Controls.Add(this.lblBtnGorsel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAntrenmanGorsel";
            this.Load += new System.EventHandler(this.FrmAntrenmanGorsel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Label lblOnizleme;
        private System.Windows.Forms.Label lblBtnGorsel;
        private System.Windows.Forms.Button btnKaydet;
    }
}