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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnSifirla = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbAtisOn = new System.Windows.Forms.ComboBox();
            this.cmbAtisDokuz = new System.Windows.Forms.ComboBox();
            this.cmbAtisSekiz = new System.Windows.Forms.ComboBox();
            this.cmbAtisYedi = new System.Windows.Forms.ComboBox();
            this.cmbAtisAlti = new System.Windows.Forms.ComboBox();
            this.cmbAtisBes = new System.Windows.Forms.ComboBox();
            this.cmbAtisDort = new System.Windows.Forms.ComboBox();
            this.cmbAtisUc = new System.Windows.Forms.ComboBox();
            this.cmbAtisIki = new System.Windows.Forms.ComboBox();
            this.cmbAtisBir = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSporcular)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.btnOturumKapat);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnGeriGit);
            this.panel2.Name = "panel2";
            this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
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
            // btnGeriGit
            // 
            resources.ApplyResources(this.btnGeriGit, "btnGeriGit");
            this.btnGeriGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeriGit.FlatAppearance.BorderSize = 0;
            this.btnGeriGit.Image = global::AntrenmanTakip.Properties.Resources.geriGit2_32px;
            this.btnGeriGit.Name = "btnGeriGit";
            this.toolTip1.SetToolTip(this.btnGeriGit, resources.GetString("btnGeriGit.ToolTip"));
            this.btnGeriGit.UseVisualStyleBackColor = true;
            this.btnGeriGit.Click += new System.EventHandler(this.btnGeriGit_Click);
            // 
            // gridViewSporcular
            // 
            resources.ApplyResources(this.gridViewSporcular, "gridViewSporcular");
            this.gridViewSporcular.BackgroundColor = System.Drawing.Color.White;
            this.gridViewSporcular.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewSporcular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSporcular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewSporcular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ad,
            this.Soyad,
            this.Yas,
            this.Boy,
            this.Kilo,
            this.Mevki});
            this.gridViewSporcular.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewSporcular.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewSporcular.MultiSelect = false;
            this.gridViewSporcular.Name = "gridViewSporcular";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSporcular.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridViewSporcular.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridViewSporcular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.gridViewSporcular, resources.GetString("gridViewSporcular.ToolTip"));
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnFalsolu);
            this.groupBox1.Controls.Add(this.btnSag);
            this.groupBox1.Controls.Add(this.btnYerden);
            this.groupBox1.Controls.Add(this.btnSol);
            this.groupBox1.Controls.Add(this.btnHavadan);
            this.groupBox1.Controls.Add(this.btnKarsidan);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // btnFalsolu
            // 
            resources.ApplyResources(this.btnFalsolu, "btnFalsolu");
            this.btnFalsolu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFalsolu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFalsolu.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnFalsolu.Name = "btnFalsolu";
            this.toolTip1.SetToolTip(this.btnFalsolu, resources.GetString("btnFalsolu.ToolTip"));
            this.btnFalsolu.UseVisualStyleBackColor = false;
            this.btnFalsolu.Click += new System.EventHandler(this.btnFalsolu_Click);
            // 
            // btnSag
            // 
            resources.ApplyResources(this.btnSag, "btnSag");
            this.btnSag.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSag.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnSag.Name = "btnSag";
            this.toolTip1.SetToolTip(this.btnSag, resources.GetString("btnSag.ToolTip"));
            this.btnSag.UseVisualStyleBackColor = false;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnYerden
            // 
            resources.ApplyResources(this.btnYerden, "btnYerden");
            this.btnYerden.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnYerden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYerden.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnYerden.Name = "btnYerden";
            this.toolTip1.SetToolTip(this.btnYerden, resources.GetString("btnYerden.ToolTip"));
            this.btnYerden.UseVisualStyleBackColor = false;
            this.btnYerden.Click += new System.EventHandler(this.btnYerden_Click);
            // 
            // btnSol
            // 
            resources.ApplyResources(this.btnSol, "btnSol");
            this.btnSol.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSol.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnSol.Name = "btnSol";
            this.toolTip1.SetToolTip(this.btnSol, resources.GetString("btnSol.ToolTip"));
            this.btnSol.UseVisualStyleBackColor = false;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnHavadan
            // 
            resources.ApplyResources(this.btnHavadan, "btnHavadan");
            this.btnHavadan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHavadan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHavadan.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnHavadan.Name = "btnHavadan";
            this.toolTip1.SetToolTip(this.btnHavadan, resources.GetString("btnHavadan.ToolTip"));
            this.btnHavadan.UseVisualStyleBackColor = false;
            this.btnHavadan.Click += new System.EventHandler(this.btnHavadan_Click);
            // 
            // btnKarsidan
            // 
            resources.ApplyResources(this.btnKarsidan, "btnKarsidan");
            this.btnKarsidan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnKarsidan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKarsidan.Image = global::AntrenmanTakip.Properties.Resources.karsidan64px;
            this.btnKarsidan.Name = "btnKarsidan";
            this.toolTip1.SetToolTip(this.btnKarsidan, resources.GetString("btnKarsidan.ToolTip"));
            this.btnKarsidan.UseVisualStyleBackColor = false;
            this.btnKarsidan.Click += new System.EventHandler(this.btnKarsidan_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // lblAntrenmanTuru
            // 
            resources.ApplyResources(this.lblAntrenmanTuru, "lblAntrenmanTuru");
            this.lblAntrenmanTuru.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAntrenmanTuru.Name = "lblAntrenmanTuru";
            this.toolTip1.SetToolTip(this.lblAntrenmanTuru, resources.GetString("lblAntrenmanTuru.ToolTip"));
            // 
            // lblZaman
            // 
            resources.ApplyResources(this.lblZaman, "lblZaman");
            this.lblZaman.Name = "lblZaman";
            this.toolTip1.SetToolTip(this.lblZaman, resources.GetString("lblZaman.ToolTip"));
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
            this.toolTip1.SetToolTip(this.txtBasariliAtis, resources.GetString("txtBasariliAtis.ToolTip"));
            this.txtBasariliAtis.TextChanged += new System.EventHandler(this.txtBasariliAtis_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // btnKaydet
            // 
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Image = global::AntrenmanTakip.Properties.Resources.save48px;
            this.btnKaydet.Name = "btnKaydet";
            this.toolTip1.SetToolTip(this.btnKaydet, resources.GetString("btnKaydet.ToolTip"));
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAntrenmanBaslat
            // 
            resources.ApplyResources(this.btnAntrenmanBaslat, "btnAntrenmanBaslat");
            this.btnAntrenmanBaslat.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAntrenmanBaslat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntrenmanBaslat.Image = global::AntrenmanTakip.Properties.Resources.baslat4_48px;
            this.btnAntrenmanBaslat.Name = "btnAntrenmanBaslat";
            this.toolTip1.SetToolTip(this.btnAntrenmanBaslat, resources.GetString("btnAntrenmanBaslat.ToolTip"));
            this.btnAntrenmanBaslat.UseVisualStyleBackColor = false;
            this.btnAntrenmanBaslat.Click += new System.EventHandler(this.btnAntrenmanBaslat_Click);
            // 
            // btnSifirla
            // 
            resources.ApplyResources(this.btnSifirla, "btnSifirla");
            this.btnSifirla.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifirla.Image = global::AntrenmanTakip.Properties.Resources.save48px;
            this.btnSifirla.Name = "btnSifirla";
            this.toolTip1.SetToolTip(this.btnSifirla, resources.GetString("btnSifirla.ToolTip"));
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.toolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.toolTip1.SetToolTip(this.label14, resources.GetString("label14.ToolTip"));
            // 
            // cmbAtisOn
            // 
            resources.ApplyResources(this.cmbAtisOn, "cmbAtisOn");
            this.cmbAtisOn.FormattingEnabled = true;
            this.cmbAtisOn.Items.AddRange(new object[] {
            resources.GetString("cmbAtisOn.Items"),
            resources.GetString("cmbAtisOn.Items1"),
            resources.GetString("cmbAtisOn.Items2"),
            resources.GetString("cmbAtisOn.Items3"),
            resources.GetString("cmbAtisOn.Items4"),
            resources.GetString("cmbAtisOn.Items5")});
            this.cmbAtisOn.Name = "cmbAtisOn";
            this.toolTip1.SetToolTip(this.cmbAtisOn, resources.GetString("cmbAtisOn.ToolTip"));
            // 
            // cmbAtisDokuz
            // 
            resources.ApplyResources(this.cmbAtisDokuz, "cmbAtisDokuz");
            this.cmbAtisDokuz.FormattingEnabled = true;
            this.cmbAtisDokuz.Items.AddRange(new object[] {
            resources.GetString("cmbAtisDokuz.Items"),
            resources.GetString("cmbAtisDokuz.Items1"),
            resources.GetString("cmbAtisDokuz.Items2"),
            resources.GetString("cmbAtisDokuz.Items3"),
            resources.GetString("cmbAtisDokuz.Items4"),
            resources.GetString("cmbAtisDokuz.Items5")});
            this.cmbAtisDokuz.Name = "cmbAtisDokuz";
            this.toolTip1.SetToolTip(this.cmbAtisDokuz, resources.GetString("cmbAtisDokuz.ToolTip"));
            // 
            // cmbAtisSekiz
            // 
            resources.ApplyResources(this.cmbAtisSekiz, "cmbAtisSekiz");
            this.cmbAtisSekiz.FormattingEnabled = true;
            this.cmbAtisSekiz.Items.AddRange(new object[] {
            resources.GetString("cmbAtisSekiz.Items"),
            resources.GetString("cmbAtisSekiz.Items1"),
            resources.GetString("cmbAtisSekiz.Items2"),
            resources.GetString("cmbAtisSekiz.Items3"),
            resources.GetString("cmbAtisSekiz.Items4"),
            resources.GetString("cmbAtisSekiz.Items5")});
            this.cmbAtisSekiz.Name = "cmbAtisSekiz";
            this.toolTip1.SetToolTip(this.cmbAtisSekiz, resources.GetString("cmbAtisSekiz.ToolTip"));
            // 
            // cmbAtisYedi
            // 
            resources.ApplyResources(this.cmbAtisYedi, "cmbAtisYedi");
            this.cmbAtisYedi.FormattingEnabled = true;
            this.cmbAtisYedi.Items.AddRange(new object[] {
            resources.GetString("cmbAtisYedi.Items"),
            resources.GetString("cmbAtisYedi.Items1"),
            resources.GetString("cmbAtisYedi.Items2"),
            resources.GetString("cmbAtisYedi.Items3"),
            resources.GetString("cmbAtisYedi.Items4"),
            resources.GetString("cmbAtisYedi.Items5")});
            this.cmbAtisYedi.Name = "cmbAtisYedi";
            this.toolTip1.SetToolTip(this.cmbAtisYedi, resources.GetString("cmbAtisYedi.ToolTip"));
            // 
            // cmbAtisAlti
            // 
            resources.ApplyResources(this.cmbAtisAlti, "cmbAtisAlti");
            this.cmbAtisAlti.FormattingEnabled = true;
            this.cmbAtisAlti.Items.AddRange(new object[] {
            resources.GetString("cmbAtisAlti.Items"),
            resources.GetString("cmbAtisAlti.Items1"),
            resources.GetString("cmbAtisAlti.Items2"),
            resources.GetString("cmbAtisAlti.Items3"),
            resources.GetString("cmbAtisAlti.Items4"),
            resources.GetString("cmbAtisAlti.Items5")});
            this.cmbAtisAlti.Name = "cmbAtisAlti";
            this.toolTip1.SetToolTip(this.cmbAtisAlti, resources.GetString("cmbAtisAlti.ToolTip"));
            // 
            // cmbAtisBes
            // 
            resources.ApplyResources(this.cmbAtisBes, "cmbAtisBes");
            this.cmbAtisBes.FormattingEnabled = true;
            this.cmbAtisBes.Items.AddRange(new object[] {
            resources.GetString("cmbAtisBes.Items"),
            resources.GetString("cmbAtisBes.Items1"),
            resources.GetString("cmbAtisBes.Items2"),
            resources.GetString("cmbAtisBes.Items3"),
            resources.GetString("cmbAtisBes.Items4"),
            resources.GetString("cmbAtisBes.Items5")});
            this.cmbAtisBes.Name = "cmbAtisBes";
            this.toolTip1.SetToolTip(this.cmbAtisBes, resources.GetString("cmbAtisBes.ToolTip"));
            // 
            // cmbAtisDort
            // 
            resources.ApplyResources(this.cmbAtisDort, "cmbAtisDort");
            this.cmbAtisDort.FormattingEnabled = true;
            this.cmbAtisDort.Items.AddRange(new object[] {
            resources.GetString("cmbAtisDort.Items"),
            resources.GetString("cmbAtisDort.Items1"),
            resources.GetString("cmbAtisDort.Items2"),
            resources.GetString("cmbAtisDort.Items3"),
            resources.GetString("cmbAtisDort.Items4"),
            resources.GetString("cmbAtisDort.Items5")});
            this.cmbAtisDort.Name = "cmbAtisDort";
            this.toolTip1.SetToolTip(this.cmbAtisDort, resources.GetString("cmbAtisDort.ToolTip"));
            // 
            // cmbAtisUc
            // 
            resources.ApplyResources(this.cmbAtisUc, "cmbAtisUc");
            this.cmbAtisUc.FormattingEnabled = true;
            this.cmbAtisUc.Items.AddRange(new object[] {
            resources.GetString("cmbAtisUc.Items"),
            resources.GetString("cmbAtisUc.Items1"),
            resources.GetString("cmbAtisUc.Items2"),
            resources.GetString("cmbAtisUc.Items3"),
            resources.GetString("cmbAtisUc.Items4"),
            resources.GetString("cmbAtisUc.Items5")});
            this.cmbAtisUc.Name = "cmbAtisUc";
            this.toolTip1.SetToolTip(this.cmbAtisUc, resources.GetString("cmbAtisUc.ToolTip"));
            // 
            // cmbAtisIki
            // 
            resources.ApplyResources(this.cmbAtisIki, "cmbAtisIki");
            this.cmbAtisIki.FormattingEnabled = true;
            this.cmbAtisIki.Items.AddRange(new object[] {
            resources.GetString("cmbAtisIki.Items"),
            resources.GetString("cmbAtisIki.Items1"),
            resources.GetString("cmbAtisIki.Items2"),
            resources.GetString("cmbAtisIki.Items3"),
            resources.GetString("cmbAtisIki.Items4"),
            resources.GetString("cmbAtisIki.Items5")});
            this.cmbAtisIki.Name = "cmbAtisIki";
            this.toolTip1.SetToolTip(this.cmbAtisIki, resources.GetString("cmbAtisIki.ToolTip"));
            // 
            // cmbAtisBir
            // 
            resources.ApplyResources(this.cmbAtisBir, "cmbAtisBir");
            this.cmbAtisBir.FormattingEnabled = true;
            this.cmbAtisBir.Items.AddRange(new object[] {
            resources.GetString("cmbAtisBir.Items"),
            resources.GetString("cmbAtisBir.Items1"),
            resources.GetString("cmbAtisBir.Items2"),
            resources.GetString("cmbAtisBir.Items3"),
            resources.GetString("cmbAtisBir.Items4"),
            resources.GetString("cmbAtisBir.Items5")});
            this.cmbAtisBir.Name = "cmbAtisBir";
            this.toolTip1.SetToolTip(this.cmbAtisBir, resources.GetString("cmbAtisBir.ToolTip"));
            // 
            // FrmKaleciAntrenman
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbAtisOn);
            this.Controls.Add(this.cmbAtisDokuz);
            this.Controls.Add(this.cmbAtisSekiz);
            this.Controls.Add(this.cmbAtisYedi);
            this.Controls.Add(this.cmbAtisAlti);
            this.Controls.Add(this.cmbAtisBes);
            this.Controls.Add(this.cmbAtisDort);
            this.Controls.Add(this.cmbAtisUc);
            this.Controls.Add(this.cmbAtisIki);
            this.Controls.Add(this.cmbAtisBir);
            this.Controls.Add(this.txtBasariliAtis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.btnSifirla);
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
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbAtisOn;
        private System.Windows.Forms.ComboBox cmbAtisDokuz;
        private System.Windows.Forms.ComboBox cmbAtisSekiz;
        private System.Windows.Forms.ComboBox cmbAtisYedi;
        private System.Windows.Forms.ComboBox cmbAtisAlti;
        private System.Windows.Forms.ComboBox cmbAtisBes;
        private System.Windows.Forms.ComboBox cmbAtisDort;
        private System.Windows.Forms.ComboBox cmbAtisUc;
        private System.Windows.Forms.ComboBox cmbAtisIki;
        private System.Windows.Forms.ComboBox cmbAtisBir;
    }
}