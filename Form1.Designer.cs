namespace AntrenmanTakip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAntrenorler = new System.Windows.Forms.Button();
            this.btnSporcular = new System.Windows.Forms.Button();
            this.btnAntrenman = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOturumKapat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnAntrenorler, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSporcular, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAntrenman, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // btnAntrenorler
            // 
            resources.ApplyResources(this.btnAntrenorler, "btnAntrenorler");
            this.btnAntrenorler.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAntrenorler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntrenorler.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnAntrenorler.Image = global::AntrenmanTakip.Properties.Resources.antrenor128px;
            this.btnAntrenorler.Name = "btnAntrenorler";
            this.toolTip1.SetToolTip(this.btnAntrenorler, resources.GetString("btnAntrenorler.ToolTip"));
            this.btnAntrenorler.UseVisualStyleBackColor = false;
            this.btnAntrenorler.Click += new System.EventHandler(this.btnAntrenorler_Click);
            // 
            // btnSporcular
            // 
            resources.ApplyResources(this.btnSporcular, "btnSporcular");
            this.btnSporcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSporcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSporcular.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSporcular.Image = global::AntrenmanTakip.Properties.Resources.futbolcu;
            this.btnSporcular.Name = "btnSporcular";
            this.toolTip1.SetToolTip(this.btnSporcular, resources.GetString("btnSporcular.ToolTip"));
            this.btnSporcular.UseVisualStyleBackColor = false;
            this.btnSporcular.Click += new System.EventHandler(this.btnSporcular_Click);
            // 
            // btnAntrenman
            // 
            resources.ApplyResources(this.btnAntrenman, "btnAntrenman");
            this.btnAntrenman.BackColor = System.Drawing.Color.IndianRed;
            this.btnAntrenman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntrenman.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAntrenman.Image = global::AntrenmanTakip.Properties.Resources.antrenman;
            this.btnAntrenman.Name = "btnAntrenman";
            this.toolTip1.SetToolTip(this.btnAntrenman, resources.GetString("btnAntrenman.ToolTip"));
            this.btnAntrenman.UseVisualStyleBackColor = false;
            this.btnAntrenman.Click += new System.EventHandler(this.btnAntrenman_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.btnSettings, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOturumKapat, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.toolTip1.SetToolTip(this.tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.Image = global::AntrenmanTakip.Properties.Resources.ayarlar2_32px;
            this.btnSettings.Name = "btnSettings";
            this.toolTip1.SetToolTip(this.btnSettings, resources.GetString("btnSettings.ToolTip"));
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = global::AntrenmanTakip.Properties.Resources.projeyiDurdur32px;
            this.button1.Name = "button1";
            this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOturumKapat
            // 
            resources.ApplyResources(this.btnOturumKapat, "btnOturumKapat");
            this.btnOturumKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOturumKapat.FlatAppearance.BorderSize = 0;
            this.btnOturumKapat.Image = global::AntrenmanTakip.Properties.Resources.oturumKapat32px;
            this.btnOturumKapat.Name = "btnOturumKapat";
            this.toolTip1.SetToolTip(this.btnOturumKapat, resources.GetString("btnOturumKapat.ToolTip"));
            this.btnOturumKapat.UseVisualStyleBackColor = true;
            this.btnOturumKapat.Click += new System.EventHandler(this.btnOturumKapat_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnOturumKapat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSporcular;
        private System.Windows.Forms.Button btnAntrenman;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAntrenorler;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

