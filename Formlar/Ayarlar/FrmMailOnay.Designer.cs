namespace AntrenmanTakip.Formlar.Ayarlar
{
    partial class FrmMailOnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMailOnay));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOnayKodu = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtOnayKodu
            // 
            resources.ApplyResources(this.txtOnayKodu, "txtOnayKodu");
            this.txtOnayKodu.Name = "txtOnayKodu";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnOnayla, "btnOnayla");
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // FrmMailOnay
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtOnayKodu);
            this.Controls.Add(this.label1);
            this.Name = "FrmMailOnay";
            this.Load += new System.EventHandler(this.FrmMailOnay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOnayKodu;
        private System.Windows.Forms.Button btnOnayla;
    }
}