namespace AntrenmanTakip.Formlar.Ayarlar
{
    partial class FrmMailGonderme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMailGonderme));
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKodGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            resources.ApplyResources(this.txtMail, "txtMail");
            this.txtMail.Name = "txtMail";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnKodGonder
            // 
            this.btnKodGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnKodGonder, "btnKodGonder");
            this.btnKodGonder.Name = "btnKodGonder";
            this.btnKodGonder.UseVisualStyleBackColor = true;
            this.btnKodGonder.Click += new System.EventHandler(this.btnKodGonder_Click);
            // 
            // FrmMailGonderme
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKodGonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMailGonderme";
            this.Load += new System.EventHandler(this.FrmMailGonderme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKodGonder;
    }
}