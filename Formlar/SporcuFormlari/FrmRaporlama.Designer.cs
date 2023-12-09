namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    partial class FrmRaporlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlama));
            this.cmbGrafikTuru = new System.Windows.Forms.ComboBox();
            this.cmbIstatistikTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbGrafikTuru
            // 
            this.cmbGrafikTuru.FormattingEnabled = true;
            this.cmbGrafikTuru.Items.AddRange(new object[] {
            resources.GetString("cmbGrafikTuru.Items"),
            resources.GetString("cmbGrafikTuru.Items1"),
            resources.GetString("cmbGrafikTuru.Items2")});
            resources.ApplyResources(this.cmbGrafikTuru, "cmbGrafikTuru");
            this.cmbGrafikTuru.Name = "cmbGrafikTuru";
            // 
            // cmbIstatistikTuru
            // 
            this.cmbIstatistikTuru.FormattingEnabled = true;
            this.cmbIstatistikTuru.Items.AddRange(new object[] {
            resources.GetString("cmbIstatistikTuru.Items"),
            resources.GetString("cmbIstatistikTuru.Items1")});
            resources.ApplyResources(this.cmbIstatistikTuru, "cmbIstatistikTuru");
            this.cmbIstatistikTuru.Name = "cmbIstatistikTuru";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnRaporAl
            // 
            resources.ApplyResources(this.btnRaporAl, "btnRaporAl");
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // FrmRaporlama
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIstatistikTuru);
            this.Controls.Add(this.cmbGrafikTuru);
            this.Name = "FrmRaporlama";
            this.Load += new System.EventHandler(this.FrmRaporlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGrafikTuru;
        private System.Windows.Forms.ComboBox cmbIstatistikTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRaporAl;
    }
}