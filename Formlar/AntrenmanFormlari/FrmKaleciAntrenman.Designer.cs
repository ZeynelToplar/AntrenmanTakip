namespace AntrenmanTakip.Formlar.AntrenmanFormlari
{
    partial class FrmKaleciAntrenman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKaleciAntrenman));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOturumKapat = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnGeriGit = new System.Windows.Forms.Button();
            this.gridViewSporcular = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mevki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFalsolu = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnYerden = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnHavadan = new System.Windows.Forms.Button();
            this.btnKarsidan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAntrenmanTuru = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.timerAntrenman = new System.Windows.Forms.Timer(this.components);
            this.ModbusScan = new System.Windows.Forms.Timer(this.components);
            this.txtBasariliAtis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAntrenmanBaslat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSporcular)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.toolTip1.SetToolTip(this.btnOturumKapat, resources.GetString("btnOturumKapat.ToolTip"));
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
            this.toolTip1.SetToolTip(this.btnSettings, resources.GetString("btnSettings.ToolTip"));
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
            this.toolTip1.SetToolTip(this.btnGeriGit, resources.GetString("btnGeriGit.ToolTip"));
            this.btnGeriGit.UseVisualStyleBackColor = true;
            this.btnGeriGit.Click += new System.EventHandler(this.btnGeriGit_Click);
            // 
            // gridViewSporcular
            // 
            this.gridViewSporcular.BackgroundColor = System.Drawing.Color.White;
            this.gridViewSporcular.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewSporcular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSporcular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.gridViewSporcular, "gridViewSporcular");
            this.gridViewSporcular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ad,
            this.Soyad,
            this.Yas,
            this.Boy,
            this.Kilo,
            this.Mevki});
            this.gridViewSporcular.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewSporcular.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewSporcular.MultiSelect = false;
            this.gridViewSporcular.Name = "gridViewSporcular";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSporcular.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridViewSporcular.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewSporcular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewSporcular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewSporcular_CellClick);
            // 
            // Id
            // 
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            // 
            // Ad
            // 
            resources.ApplyResources(this.Ad, "Ad");
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            resources.ApplyResources(this.Soyad, "Soyad");
            this.Soyad.Name = "Soyad";
            // 
            // Yas
            // 
            resources.ApplyResources(this.Yas, "Yas");
            this.Yas.Name = "Yas";
            // 
            // Boy
            // 
            resources.ApplyResources(this.Boy, "Boy");
            this.Boy.Name = "Boy";
            // 
            // Kilo
            // 
            resources.ApplyResources(this.Kilo, "Kilo");
            this.Kilo.Name = "Kilo";
            // 
            // Mevki
            // 
            resources.ApplyResources(this.Mevki, "Mevki");
            this.Mevki.Name = "Mevki";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFalsolu);
            this.groupBox1.Controls.Add(this.btnSag);
            this.groupBox1.Controls.Add(this.btnYerden);
            this.groupBox1.Controls.Add(this.btnSol);
            this.groupBox1.Controls.Add(this.btnHavadan);
            this.groupBox1.Controls.Add(this.btnKarsidan);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnFalsolu
            // 
            this.btnFalsolu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFalsolu.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnFalsolu, "btnFalsolu");
            this.btnFalsolu.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnFalsolu.Name = "btnFalsolu";
            this.btnFalsolu.UseVisualStyleBackColor = false;
            this.btnFalsolu.Click += new System.EventHandler(this.btnFalsolu_Click);
            // 
            // btnSag
            // 
            this.btnSag.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSag.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSag, "btnSag");
            this.btnSag.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnSag.Name = "btnSag";
            this.btnSag.UseVisualStyleBackColor = false;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnYerden
            // 
            this.btnYerden.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnYerden.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnYerden, "btnYerden");
            this.btnYerden.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnYerden.Name = "btnYerden";
            this.btnYerden.UseVisualStyleBackColor = false;
            this.btnYerden.Click += new System.EventHandler(this.btnYerden_Click);
            // 
            // btnSol
            // 
            this.btnSol.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSol.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSol, "btnSol");
            this.btnSol.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnSol.Name = "btnSol";
            this.btnSol.UseVisualStyleBackColor = false;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnHavadan
            // 
            this.btnHavadan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHavadan.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnHavadan, "btnHavadan");
            this.btnHavadan.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnHavadan.Name = "btnHavadan";
            this.btnHavadan.UseVisualStyleBackColor = false;
            this.btnHavadan.Click += new System.EventHandler(this.btnHavadan_Click);
            // 
            // btnKarsidan
            // 
            this.btnKarsidan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnKarsidan.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnKarsidan, "btnKarsidan");
            this.btnKarsidan.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnKarsidan.Name = "btnKarsidan";
            this.btnKarsidan.UseVisualStyleBackColor = false;
            this.btnKarsidan.Click += new System.EventHandler(this.btnKarsidan_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblAntrenmanTuru
            // 
            resources.ApplyResources(this.lblAntrenmanTuru, "lblAntrenmanTuru");
            this.lblAntrenmanTuru.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAntrenmanTuru.Name = "lblAntrenmanTuru";
            // 
            // lblZaman
            // 
            resources.ApplyResources(this.lblZaman, "lblZaman");
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Click += new System.EventHandler(this.lblZaman_Click);
            // 
            // timerAntrenman
            // 
            this.timerAntrenman.Interval = 1000;
            this.timerAntrenman.Tick += new System.EventHandler(this.timerAntrenman_Tick);
            // 
            // ModbusScan
            // 
            this.ModbusScan.Tick += new System.EventHandler(this.ModbusScan_Tick);
            // 
            // txtBasariliAtis
            // 
            resources.ApplyResources(this.txtBasariliAtis, "txtBasariliAtis");
            this.txtBasariliAtis.Name = "txtBasariliAtis";
            this.txtBasariliAtis.TextChanged += new System.EventHandler(this.txtBasariliAtis_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.Image = global::AntrenmanTakip.Properties.Resources.save48px;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAntrenmanBaslat
            // 
            this.btnAntrenmanBaslat.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAntrenmanBaslat.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAntrenmanBaslat, "btnAntrenmanBaslat");
            this.btnAntrenmanBaslat.Image = global::AntrenmanTakip.Properties.Resources.baslat4_48px;
            this.btnAntrenmanBaslat.Name = "btnAntrenmanBaslat";
            this.btnAntrenmanBaslat.UseVisualStyleBackColor = false;
            this.btnAntrenmanBaslat.Click += new System.EventHandler(this.btnAntrenmanBaslat_Click);
            // 
            // FrmKaleciAntrenman
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBasariliAtis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAntrenmanBaslat);
            this.Controls.Add(this.lblAntrenmanTuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridViewSporcular);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmKaleciAntrenman";
            this.Load += new System.EventHandler(this.FrmKaleciAntrenman_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSporcular)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOturumKapat;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGeriGit;
        private System.Windows.Forms.DataGridView gridViewSporcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFalsolu;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnYerden;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnHavadan;
        private System.Windows.Forms.Button btnKarsidan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAntrenmanTuru;
        private System.Windows.Forms.Button btnAntrenmanBaslat;
        private System.Windows.Forms.Label lblZaman;
        public System.Windows.Forms.Timer timerAntrenman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mevki;
        private System.Windows.Forms.Timer ModbusScan;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtBasariliAtis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}