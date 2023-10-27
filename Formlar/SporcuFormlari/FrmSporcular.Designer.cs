namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    partial class FrmSporcular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSporcular));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewSporcular = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mevki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxStrpSporcular = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblMevki = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.numYas = new System.Windows.Forms.NumericUpDown();
            this.numKilo = new System.Windows.Forms.NumericUpDown();
            this.numBoy = new System.Windows.Forms.NumericUpDown();
            this.cmbMevki = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnProfilGor = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.btnAntrenmanGor = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblUlke = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGeriGit = new System.Windows.Forms.Button();
            this.btnOturumKapat = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSporcular)).BeginInit();
            this.ctxStrpSporcular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoy)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.Ulke,
            this.Ad,
            this.Soyad,
            this.Yas,
            this.Boy,
            this.Kilo,
            this.Mevki,
            this.DogumTarihi});
            this.gridViewSporcular.ContextMenuStrip = this.ctxStrpSporcular;
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
            this.gridViewSporcular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewSporcular_CellContentClick);
            // 
            // Id
            // 
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            // 
            // Ulke
            // 
            resources.ApplyResources(this.Ulke, "Ulke");
            this.Ulke.Name = "Ulke";
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
            // DogumTarihi
            // 
            resources.ApplyResources(this.DogumTarihi, "DogumTarihi");
            this.DogumTarihi.Name = "DogumTarihi";
            // 
            // ctxStrpSporcular
            // 
            resources.ApplyResources(this.ctxStrpSporcular, "ctxStrpSporcular");
            this.ctxStrpSporcular.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimEkleToolStripMenuItem});
            this.ctxStrpSporcular.Name = "ctxStrpSporcular";
            this.toolTip1.SetToolTip(this.ctxStrpSporcular, resources.GetString("ctxStrpSporcular.ToolTip"));
            // 
            // resimEkleToolStripMenuItem
            // 
            resources.ApplyResources(this.resimEkleToolStripMenuItem, "resimEkleToolStripMenuItem");
            this.resimEkleToolStripMenuItem.Name = "resimEkleToolStripMenuItem";
            this.resimEkleToolStripMenuItem.Click += new System.EventHandler(this.resimEkleToolStripMenuItem_Click);
            // 
            // lblAd
            // 
            resources.ApplyResources(this.lblAd, "lblAd");
            this.lblAd.Name = "lblAd";
            this.toolTip1.SetToolTip(this.lblAd, resources.GetString("lblAd.ToolTip"));
            // 
            // lblYas
            // 
            resources.ApplyResources(this.lblYas, "lblYas");
            this.lblYas.Name = "lblYas";
            this.toolTip1.SetToolTip(this.lblYas, resources.GetString("lblYas.ToolTip"));
            // 
            // lblSoyad
            // 
            resources.ApplyResources(this.lblSoyad, "lblSoyad");
            this.lblSoyad.Name = "lblSoyad";
            this.toolTip1.SetToolTip(this.lblSoyad, resources.GetString("lblSoyad.ToolTip"));
            // 
            // lblBoy
            // 
            resources.ApplyResources(this.lblBoy, "lblBoy");
            this.lblBoy.Name = "lblBoy";
            this.toolTip1.SetToolTip(this.lblBoy, resources.GetString("lblBoy.ToolTip"));
            // 
            // lblMevki
            // 
            resources.ApplyResources(this.lblMevki, "lblMevki");
            this.lblMevki.Name = "lblMevki";
            this.toolTip1.SetToolTip(this.lblMevki, resources.GetString("lblMevki.ToolTip"));
            // 
            // lblKilo
            // 
            resources.ApplyResources(this.lblKilo, "lblKilo");
            this.lblKilo.Name = "lblKilo";
            this.toolTip1.SetToolTip(this.lblKilo, resources.GetString("lblKilo.ToolTip"));
            // 
            // txtAd
            // 
            resources.ApplyResources(this.txtAd, "txtAd");
            this.txtAd.Name = "txtAd";
            this.toolTip1.SetToolTip(this.txtAd, resources.GetString("txtAd.ToolTip"));
            // 
            // txtSoyad
            // 
            resources.ApplyResources(this.txtSoyad, "txtSoyad");
            this.txtSoyad.Name = "txtSoyad";
            this.toolTip1.SetToolTip(this.txtSoyad, resources.GetString("txtSoyad.ToolTip"));
            // 
            // numYas
            // 
            resources.ApplyResources(this.numYas, "numYas");
            this.numYas.Name = "numYas";
            this.toolTip1.SetToolTip(this.numYas, resources.GetString("numYas.ToolTip"));
            // 
            // numKilo
            // 
            resources.ApplyResources(this.numKilo, "numKilo");
            this.numKilo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numKilo.Name = "numKilo";
            this.toolTip1.SetToolTip(this.numKilo, resources.GetString("numKilo.ToolTip"));
            // 
            // numBoy
            // 
            resources.ApplyResources(this.numBoy, "numBoy");
            this.numBoy.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numBoy.Name = "numBoy";
            this.toolTip1.SetToolTip(this.numBoy, resources.GetString("numBoy.ToolTip"));
            // 
            // cmbMevki
            // 
            resources.ApplyResources(this.cmbMevki, "cmbMevki");
            this.cmbMevki.FormattingEnabled = true;
            this.cmbMevki.Name = "cmbMevki";
            this.toolTip1.SetToolTip(this.cmbMevki, resources.GetString("cmbMevki.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUlke);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.btnProfilGor);
            this.panel1.Controls.Add(this.btnSifirla);
            this.panel1.Controls.Add(this.btnAntrenmanGor);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.cmbMevki);
            this.panel1.Controls.Add(this.numBoy);
            this.panel1.Controls.Add(this.numKilo);
            this.panel1.Controls.Add(this.numYas);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.lblKilo);
            this.panel1.Controls.Add(this.lblUlke);
            this.panel1.Controls.Add(this.lblMevki);
            this.panel1.Controls.Add(this.lblBoy);
            this.panel1.Controls.Add(this.lblSoyad);
            this.panel1.Controls.Add(this.lblYas);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.toolTip1.SetToolTip(this.dateTimePicker1, resources.GetString("dateTimePicker1.ToolTip"));
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUlke
            // 
            resources.ApplyResources(this.txtUlke, "txtUlke");
            this.txtUlke.Name = "txtUlke";
            this.toolTip1.SetToolTip(this.txtUlke, resources.GetString("txtUlke.ToolTip"));
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            this.toolTip1.SetToolTip(this.txtId, resources.GetString("txtId.ToolTip"));
            // 
            // btnProfilGor
            // 
            resources.ApplyResources(this.btnProfilGor, "btnProfilGor");
            this.btnProfilGor.BackColor = System.Drawing.Color.IndianRed;
            this.btnProfilGor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfilGor.Image = global::AntrenmanTakip.Properties.Resources.profil1;
            this.btnProfilGor.Name = "btnProfilGor";
            this.toolTip1.SetToolTip(this.btnProfilGor, resources.GetString("btnProfilGor.ToolTip"));
            this.btnProfilGor.UseVisualStyleBackColor = false;
            this.btnProfilGor.Click += new System.EventHandler(this.btnProfilGor_Click);
            // 
            // btnSifirla
            // 
            resources.ApplyResources(this.btnSifirla, "btnSifirla");
            this.btnSifirla.BackColor = System.Drawing.Color.IndianRed;
            this.btnSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifirla.Image = global::AntrenmanTakip.Properties.Resources.sifirla3_48px;
            this.btnSifirla.Name = "btnSifirla";
            this.toolTip1.SetToolTip(this.btnSifirla, resources.GetString("btnSifirla.ToolTip"));
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // btnAntrenmanGor
            // 
            resources.ApplyResources(this.btnAntrenmanGor, "btnAntrenmanGor");
            this.btnAntrenmanGor.BackColor = System.Drawing.Color.IndianRed;
            this.btnAntrenmanGor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntrenmanGor.Image = global::AntrenmanTakip.Properties.Resources.goruntule2_48px;
            this.btnAntrenmanGor.Name = "btnAntrenmanGor";
            this.toolTip1.SetToolTip(this.btnAntrenmanGor, resources.GetString("btnAntrenmanGor.ToolTip"));
            this.btnAntrenmanGor.UseVisualStyleBackColor = false;
            this.btnAntrenmanGor.Click += new System.EventHandler(this.btnAntrenmanGor_Click);
            // 
            // btnGuncelle
            // 
            resources.ApplyResources(this.btnGuncelle, "btnGuncelle");
            this.btnGuncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Image = global::AntrenmanTakip.Properties.Resources.guncelle2_48px;
            this.btnGuncelle.Name = "btnGuncelle";
            this.toolTip1.SetToolTip(this.btnGuncelle, resources.GetString("btnGuncelle.ToolTip"));
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Image = global::AntrenmanTakip.Properties.Resources.sil2_48px;
            this.btnSil.Name = "btnSil";
            this.toolTip1.SetToolTip(this.btnSil, resources.GetString("btnSil.ToolTip"));
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            resources.ApplyResources(this.btnEkle, "btnEkle");
            this.btnEkle.BackColor = System.Drawing.Color.IndianRed;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Image = global::AntrenmanTakip.Properties.Resources.ekle2_48px;
            this.btnEkle.Name = "btnEkle";
            this.toolTip1.SetToolTip(this.btnEkle, resources.GetString("btnEkle.ToolTip"));
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblUlke
            // 
            resources.ApplyResources(this.lblUlke, "lblUlke");
            this.lblUlke.Name = "lblUlke";
            this.toolTip1.SetToolTip(this.lblUlke, resources.GetString("lblUlke.ToolTip"));
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnGeriGit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOturumKapat, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSettings, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnGeriGit
            // 
            resources.ApplyResources(this.btnGeriGit, "btnGeriGit");
            this.btnGeriGit.FlatAppearance.BorderSize = 0;
            this.btnGeriGit.Image = global::AntrenmanTakip.Properties.Resources.geriGit2_32px;
            this.btnGeriGit.Name = "btnGeriGit";
            this.toolTip1.SetToolTip(this.btnGeriGit, resources.GetString("btnGeriGit.ToolTip"));
            this.btnGeriGit.UseVisualStyleBackColor = true;
            this.btnGeriGit.Click += new System.EventHandler(this.btnGeriGit_Click);
            // 
            // btnOturumKapat
            // 
            resources.ApplyResources(this.btnOturumKapat, "btnOturumKapat");
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
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gridViewSporcular, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.toolTip1.SetToolTip(this.tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // FrmSporcular
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmSporcular";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.FrmSporcular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSporcular)).EndInit();
            this.ctxStrpSporcular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numYas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOturumKapat;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGeriGit;
        private System.Windows.Forms.DataGridView gridViewSporcular;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblMevki;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.NumericUpDown numYas;
        private System.Windows.Forms.NumericUpDown numKilo;
        private System.Windows.Forms.NumericUpDown numBoy;
        private System.Windows.Forms.ComboBox cmbMevki;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Button btnAntrenmanGor;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnProfilGor;
        private System.Windows.Forms.ContextMenuStrip ctxStrpSporcular;
        private System.Windows.Forms.ToolStripMenuItem resimEkleToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.Label lblUlke;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mevki;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
    }
}