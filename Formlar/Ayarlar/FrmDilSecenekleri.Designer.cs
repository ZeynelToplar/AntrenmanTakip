namespace AntrenmanTakip.Formlar.Ayarlar
{
    partial class FrmDilSecenekleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDilSecenekleri));
            this.radioTurkce = new System.Windows.Forms.RadioButton();
            this.radioIngilizce = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioTurkce
            // 
            resources.ApplyResources(this.radioTurkce, "radioTurkce");
            this.radioTurkce.Name = "radioTurkce";
            this.radioTurkce.TabStop = true;
            this.radioTurkce.UseVisualStyleBackColor = true;
            // 
            // radioIngilizce
            // 
            resources.ApplyResources(this.radioIngilizce, "radioIngilizce");
            this.radioIngilizce.Name = "radioIngilizce";
            this.radioIngilizce.TabStop = true;
            this.radioIngilizce.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDilSecenekleri
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioIngilizce);
            this.Controls.Add(this.radioTurkce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDilSecenekleri";
            this.Load += new System.EventHandler(this.FrmDilSecenekleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioTurkce;
        private System.Windows.Forms.RadioButton radioIngilizce;
        private System.Windows.Forms.Button button1;
    }
}