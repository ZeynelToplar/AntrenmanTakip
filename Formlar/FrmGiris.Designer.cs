namespace AntrenmanTakip.Formlar
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Name = "label2";
            // 
            // txtKullaniciAdi
            // 
            resources.ApplyResources(this.txtKullaniciAdi, "txtKullaniciAdi");
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            // 
            // txtSifre
            // 
            resources.ApplyResources(this.txtSifre, "txtSifre");
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Name = "label4";
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.BackColor = System.Drawing.Color.White;
            this.btnSifremiUnuttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifremiUnuttum.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSifremiUnuttum, "btnSifremiUnuttum");
            this.btnSifremiUnuttum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = false;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AntrenmanTakip.Properties.Resources.user128px;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnKapat, "btnKapat");
            this.btnKapat.Image = global::AntrenmanTakip.Properties.Resources.projeyiDurdur32px;
            this.btnKapat.Name = "btnKapat";
            this.toolTip1.SetToolTip(this.btnKapat, resources.GetString("btnKapat.ToolTip"));
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmGiris
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSifremiUnuttum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmGiris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGiris_FormClosed);
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.Enter += new System.EventHandler(this.FrmGiris_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGiris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSifremiUnuttum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}