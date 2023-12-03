namespace AntrenmanTakip.Formlar.AntrenmanFormlari
{
    partial class FrmAntrenmanSecenek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAntrenmanSecenek));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOturumKapat = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnGeriGit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAntrenmanTuru = new System.Windows.Forms.ComboBox();
            this.btnİlerle = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOturumKapat);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnGeriGit);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnOturumKapat
            // 
            this.btnOturumKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOturumKapat.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnOturumKapat, "btnOturumKapat");
            this.btnOturumKapat.Image = global::AntrenmanTakip.Properties.Resources.oturumKapat32px;
            this.btnOturumKapat.Name = "btnOturumKapat";
            this.btnOturumKapat.UseVisualStyleBackColor = true;
            this.btnOturumKapat.Click += new System.EventHandler(this.btnOturumKapat_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Image = global::AntrenmanTakip.Properties.Resources.ayarlar2_32px;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnGeriGit
            // 
            this.btnGeriGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeriGit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnGeriGit, "btnGeriGit");
            this.btnGeriGit.Image = global::AntrenmanTakip.Properties.Resources.geriGit2_32px;
            this.btnGeriGit.Name = "btnGeriGit";
            this.btnGeriGit.UseVisualStyleBackColor = true;
            this.btnGeriGit.Click += new System.EventHandler(this.btnGeriGit_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbAntrenmanTuru
            // 
            this.cmbAntrenmanTuru.FormattingEnabled = true;
            this.cmbAntrenmanTuru.Items.AddRange(new object[] {
            resources.GetString("cmbAntrenmanTuru.Items"),
            resources.GetString("cmbAntrenmanTuru.Items1"),
            resources.GetString("cmbAntrenmanTuru.Items2")});
            resources.ApplyResources(this.cmbAntrenmanTuru, "cmbAntrenmanTuru");
            this.cmbAntrenmanTuru.Name = "cmbAntrenmanTuru";
            // 
            // btnİlerle
            // 
            this.btnİlerle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnİlerle, "btnİlerle");
            this.btnİlerle.Name = "btnİlerle";
            this.btnİlerle.UseVisualStyleBackColor = true;
            this.btnİlerle.Click += new System.EventHandler(this.btnİlerle_Click);
            // 
            // FrmAntrenmanSecenek
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnİlerle);
            this.Controls.Add(this.cmbAntrenmanTuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAntrenmanSecenek";
            this.Load += new System.EventHandler(this.FrmAntrenmanSecenek_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOturumKapat;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGeriGit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAntrenmanTuru;
        private System.Windows.Forms.Button btnİlerle;
    }
}