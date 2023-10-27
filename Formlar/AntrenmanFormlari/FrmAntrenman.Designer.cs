namespace AntrenmanTakip.Formlar.AntrenmanFormlari
{
    partial class FrmAntrenman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAntrenman));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewSporcular = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mevki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.timerAntrenman = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOturumKapat = new System.Windows.Forms.Button();
            this.btnGeriGit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFalsolu = new System.Windows.Forms.Button();
            this.btnYerden = new System.Windows.Forms.Button();
            this.btnHavadan = new System.Windows.Forms.Button();
            this.lblAntrenmanTuru = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKarsidan = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAntrenmanBaslat = new System.Windows.Forms.Button();
            this.txtBasariliAtis = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ModbusScan = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSporcular)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewSporcular
            // 
            resources.ApplyResources(this.gridViewSporcular, "gridViewSporcular");
            this.gridViewSporcular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewSporcular.BackgroundColor = System.Drawing.Color.White;
            this.gridViewSporcular.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewSporcular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSporcular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewSporcular.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewSporcular.MultiSelect = false;
            this.gridViewSporcular.Name = "gridViewSporcular";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSporcular.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridViewSporcular.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // lblZaman
            // 
            resources.ApplyResources(this.lblZaman, "lblZaman");
            this.lblZaman.Name = "lblZaman";
            this.toolTip1.SetToolTip(this.lblZaman, resources.GetString("lblZaman.ToolTip"));
            // 
            // timerAntrenman
            // 
            this.timerAntrenman.Interval = 1000;
            this.timerAntrenman.Tick += new System.EventHandler(this.timerAntrenman_Tick);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnOturumKapat, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGeriGit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSettings, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.gridViewSporcular, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.toolTip1.SetToolTip(this.tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.toolTip1.SetToolTip(this.tableLayoutPanel3, resources.GetString("tableLayoutPanel3.ToolTip"));
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.btnFalsolu);
            this.flowLayoutPanel2.Controls.Add(this.btnYerden);
            this.flowLayoutPanel2.Controls.Add(this.btnHavadan);
            this.flowLayoutPanel2.Controls.Add(this.lblAntrenmanTuru);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.toolTip1.SetToolTip(this.flowLayoutPanel2, resources.GetString("flowLayoutPanel2.ToolTip"));
            // 
            // btnFalsolu
            // 
            resources.ApplyResources(this.btnFalsolu, "btnFalsolu");
            this.btnFalsolu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFalsolu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFalsolu.Image = global::AntrenmanTakip.Properties.Resources.falsolu64px;
            this.btnFalsolu.Name = "btnFalsolu";
            this.toolTip1.SetToolTip(this.btnFalsolu, resources.GetString("btnFalsolu.ToolTip"));
            this.btnFalsolu.UseVisualStyleBackColor = false;
            this.btnFalsolu.Click += new System.EventHandler(this.btnFalsolu_Click);
            // 
            // btnYerden
            // 
            resources.ApplyResources(this.btnYerden, "btnYerden");
            this.btnYerden.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnYerden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYerden.Image = global::AntrenmanTakip.Properties.Resources.durdurVur64px;
            this.btnYerden.Name = "btnYerden";
            this.toolTip1.SetToolTip(this.btnYerden, resources.GetString("btnYerden.ToolTip"));
            this.btnYerden.UseVisualStyleBackColor = false;
            this.btnYerden.Click += new System.EventHandler(this.btnYerden_Click);
            // 
            // btnHavadan
            // 
            resources.ApplyResources(this.btnHavadan, "btnHavadan");
            this.btnHavadan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHavadan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHavadan.Image = global::AntrenmanTakip.Properties.Resources.havadan64px;
            this.btnHavadan.Name = "btnHavadan";
            this.toolTip1.SetToolTip(this.btnHavadan, resources.GetString("btnHavadan.ToolTip"));
            this.btnHavadan.UseVisualStyleBackColor = false;
            this.btnHavadan.Click += new System.EventHandler(this.btnHavadan_Click);
            // 
            // lblAntrenmanTuru
            // 
            resources.ApplyResources(this.lblAntrenmanTuru, "lblAntrenmanTuru");
            this.lblAntrenmanTuru.Name = "lblAntrenmanTuru";
            this.toolTip1.SetToolTip(this.lblAntrenmanTuru, resources.GetString("lblAntrenmanTuru.ToolTip"));
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.btnKarsidan);
            this.flowLayoutPanel1.Controls.Add(this.btnSol);
            this.flowLayoutPanel1.Controls.Add(this.btnSag);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip1.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
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
            // btnSol
            // 
            resources.ApplyResources(this.btnSol, "btnSol");
            this.btnSol.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSol.Image = global::AntrenmanTakip.Properties.Resources.soldan64px;
            this.btnSol.Name = "btnSol";
            this.toolTip1.SetToolTip(this.btnSol, resources.GetString("btnSol.ToolTip"));
            this.btnSol.UseVisualStyleBackColor = false;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnSag
            // 
            resources.ApplyResources(this.btnSag, "btnSag");
            this.btnSag.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSag.Image = global::AntrenmanTakip.Properties.Resources.sagdan64px;
            this.btnSag.Name = "btnSag";
            this.toolTip1.SetToolTip(this.btnSag, resources.GetString("btnSag.ToolTip"));
            this.btnSag.UseVisualStyleBackColor = false;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.btnAntrenmanBaslat, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblZaman, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtBasariliAtis, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnKaydet, 3, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.toolTip1.SetToolTip(this.tableLayoutPanel4, resources.GetString("tableLayoutPanel4.ToolTip"));
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
            // txtBasariliAtis
            // 
            resources.ApplyResources(this.txtBasariliAtis, "txtBasariliAtis");
            this.txtBasariliAtis.Name = "txtBasariliAtis";
            this.toolTip1.SetToolTip(this.txtBasariliAtis, resources.GetString("txtBasariliAtis.ToolTip"));
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
            // ModbusScan
            // 
            this.ModbusScan.Tick += new System.EventHandler(this.ModbusScan_Tick);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            this.toolTip1.SetToolTip(this.toolStrip1, resources.GetString("toolStrip1.ToolTip"));
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5")});
            this.comboBox1.Name = "comboBox1";
            this.toolTip1.SetToolTip(this.comboBox1, resources.GetString("comboBox1.ToolTip"));
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2"),
            resources.GetString("comboBox2.Items3"),
            resources.GetString("comboBox2.Items4"),
            resources.GetString("comboBox2.Items5")});
            this.comboBox2.Name = "comboBox2";
            this.toolTip1.SetToolTip(this.comboBox2, resources.GetString("comboBox2.ToolTip"));
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1"),
            resources.GetString("comboBox3.Items2"),
            resources.GetString("comboBox3.Items3"),
            resources.GetString("comboBox3.Items4"),
            resources.GetString("comboBox3.Items5")});
            this.comboBox3.Name = "comboBox3";
            this.toolTip1.SetToolTip(this.comboBox3, resources.GetString("comboBox3.ToolTip"));
            // 
            // comboBox4
            // 
            resources.ApplyResources(this.comboBox4, "comboBox4");
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            resources.GetString("comboBox4.Items"),
            resources.GetString("comboBox4.Items1"),
            resources.GetString("comboBox4.Items2"),
            resources.GetString("comboBox4.Items3"),
            resources.GetString("comboBox4.Items4"),
            resources.GetString("comboBox4.Items5")});
            this.comboBox4.Name = "comboBox4";
            this.toolTip1.SetToolTip(this.comboBox4, resources.GetString("comboBox4.ToolTip"));
            // 
            // comboBox5
            // 
            resources.ApplyResources(this.comboBox5, "comboBox5");
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            resources.GetString("comboBox5.Items"),
            resources.GetString("comboBox5.Items1"),
            resources.GetString("comboBox5.Items2"),
            resources.GetString("comboBox5.Items3"),
            resources.GetString("comboBox5.Items4"),
            resources.GetString("comboBox5.Items5")});
            this.comboBox5.Name = "comboBox5";
            this.toolTip1.SetToolTip(this.comboBox5, resources.GetString("comboBox5.ToolTip"));
            // 
            // comboBox6
            // 
            resources.ApplyResources(this.comboBox6, "comboBox6");
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            resources.GetString("comboBox6.Items"),
            resources.GetString("comboBox6.Items1"),
            resources.GetString("comboBox6.Items2"),
            resources.GetString("comboBox6.Items3"),
            resources.GetString("comboBox6.Items4"),
            resources.GetString("comboBox6.Items5")});
            this.comboBox6.Name = "comboBox6";
            this.toolTip1.SetToolTip(this.comboBox6, resources.GetString("comboBox6.ToolTip"));
            // 
            // comboBox7
            // 
            resources.ApplyResources(this.comboBox7, "comboBox7");
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            resources.GetString("comboBox7.Items"),
            resources.GetString("comboBox7.Items1"),
            resources.GetString("comboBox7.Items2"),
            resources.GetString("comboBox7.Items3"),
            resources.GetString("comboBox7.Items4"),
            resources.GetString("comboBox7.Items5")});
            this.comboBox7.Name = "comboBox7";
            this.toolTip1.SetToolTip(this.comboBox7, resources.GetString("comboBox7.ToolTip"));
            // 
            // comboBox8
            // 
            resources.ApplyResources(this.comboBox8, "comboBox8");
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            resources.GetString("comboBox8.Items"),
            resources.GetString("comboBox8.Items1"),
            resources.GetString("comboBox8.Items2"),
            resources.GetString("comboBox8.Items3"),
            resources.GetString("comboBox8.Items4"),
            resources.GetString("comboBox8.Items5")});
            this.comboBox8.Name = "comboBox8";
            this.toolTip1.SetToolTip(this.comboBox8, resources.GetString("comboBox8.ToolTip"));
            // 
            // comboBox9
            // 
            resources.ApplyResources(this.comboBox9, "comboBox9");
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            resources.GetString("comboBox9.Items"),
            resources.GetString("comboBox9.Items1"),
            resources.GetString("comboBox9.Items2"),
            resources.GetString("comboBox9.Items3"),
            resources.GetString("comboBox9.Items4"),
            resources.GetString("comboBox9.Items5")});
            this.comboBox9.Name = "comboBox9";
            this.toolTip1.SetToolTip(this.comboBox9, resources.GetString("comboBox9.ToolTip"));
            // 
            // comboBox10
            // 
            resources.ApplyResources(this.comboBox10, "comboBox10");
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            resources.GetString("comboBox10.Items"),
            resources.GetString("comboBox10.Items1"),
            resources.GetString("comboBox10.Items2"),
            resources.GetString("comboBox10.Items3"),
            resources.GetString("comboBox10.Items4"),
            resources.GetString("comboBox10.Items5")});
            this.comboBox10.Name = "comboBox10";
            this.toolTip1.SetToolTip(this.comboBox10, resources.GetString("comboBox10.ToolTip"));
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.toolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // FrmAntrenman
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAntrenman";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.FrmAntrenman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSporcular)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOturumKapat;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGeriGit;
        private System.Windows.Forms.DataGridView gridViewSporcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFalsolu;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnYerden;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnHavadan;
        private System.Windows.Forms.Button btnKarsidan;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblAntrenmanTuru;
        private System.Windows.Forms.Timer ModbusScan;
        private System.Windows.Forms.TextBox txtBasariliAtis;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}