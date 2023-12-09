namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    partial class FrmSagAntrenman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSagAntrenman));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOturumKapat = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnGeriGit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.lblMevki = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblSporcu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAra = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtimeBitis = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.gridViewAntrenmanlar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detaylarıGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Antrenman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntrenmanTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntrenmanSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtisSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasariliAtis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAntrenmanlar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOturumKapat
            // 
            this.btnOturumKapat.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.Image = global::AntrenmanTakip.Properties.Resources.ayarlar2_32px;
            this.btnSettings.Name = "btnSettings";
            this.toolTip1.SetToolTip(this.btnSettings, resources.GetString("btnSettings.ToolTip"));
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnGeriGit
            // 
            this.btnGeriGit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnGeriGit, "btnGeriGit");
            this.btnGeriGit.FlatAppearance.BorderSize = 0;
            this.btnGeriGit.Image = global::AntrenmanTakip.Properties.Resources.geriGit2_32px;
            this.btnGeriGit.Name = "btnGeriGit";
            this.toolTip1.SetToolTip(this.btnGeriGit, resources.GetString("btnGeriGit.ToolTip"));
            this.btnGeriGit.UseVisualStyleBackColor = true;
            this.btnGeriGit.Click += new System.EventHandler(this.btnGeriGit_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.btnGrafik);
            this.panel3.Controls.Add(this.lblMevki);
            this.panel3.Controls.Add(this.lblKilo);
            this.panel3.Controls.Add(this.lblBoy);
            this.panel3.Controls.Add(this.lblYas);
            this.panel3.Controls.Add(this.lblSporcu);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Name = "panel3";
            // 
            // btnGrafik
            // 
            resources.ApplyResources(this.btnGrafik, "btnGrafik");
            this.btnGrafik.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGrafik.FlatAppearance.BorderSize = 0;
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.UseVisualStyleBackColor = false;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // lblMevki
            // 
            resources.ApplyResources(this.lblMevki, "lblMevki");
            this.lblMevki.Name = "lblMevki";
            // 
            // lblKilo
            // 
            resources.ApplyResources(this.lblKilo, "lblKilo");
            this.lblKilo.Name = "lblKilo";
            // 
            // lblBoy
            // 
            resources.ApplyResources(this.lblBoy, "lblBoy");
            this.lblBoy.Name = "lblBoy";
            // 
            // lblYas
            // 
            resources.ApplyResources(this.lblYas, "lblYas");
            this.lblYas.Name = "lblYas";
            // 
            // lblSporcu
            // 
            resources.ApplyResources(this.lblSporcu, "lblSporcu");
            this.lblSporcu.Name = "lblSporcu";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::AntrenmanTakip.Properties.Resources.sagdan64px;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.cmbAra);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtimeBaslangic);
            this.panel1.Controls.Add(this.dtimeBitis);
            this.panel1.Controls.Add(this.btnFiltrele);
            this.panel1.Controls.Add(this.btnSifirla);
            this.panel1.Name = "panel1";
            // 
            // cmbAra
            // 
            this.cmbAra.FormattingEnabled = true;
            this.cmbAra.Items.AddRange(new object[] {
            resources.GetString("cmbAra.Items")});
            resources.ApplyResources(this.cmbAra, "cmbAra");
            this.cmbAra.Name = "cmbAra";
            this.cmbAra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbAra_MouseClick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dtimeBaslangic
            // 
            this.dtimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtimeBaslangic, "dtimeBaslangic");
            this.dtimeBaslangic.Name = "dtimeBaslangic";
            // 
            // dtimeBitis
            // 
            this.dtimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtimeBitis, "dtimeBitis");
            this.dtimeBitis.Name = "dtimeBitis";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnFiltrele, "btnFiltrele");
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSifirla, "btnSifirla");
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // gridViewAntrenmanlar
            // 
            resources.ApplyResources(this.gridViewAntrenmanlar, "gridViewAntrenmanlar");
            this.gridViewAntrenmanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewAntrenmanlar.BackgroundColor = System.Drawing.Color.White;
            this.gridViewAntrenmanlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewAntrenmanlar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewAntrenmanlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewAntrenmanlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Antrenman,
            this.AtuId,
            this.AntrenmanTuru,
            this.AntrenmanSayisi,
            this.AtisSayisi,
            this.BasariliAtis,
            this.Sure,
            this.Tarih});
            this.gridViewAntrenmanlar.ContextMenuStrip = this.contextMenuStrip1;
            this.gridViewAntrenmanlar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewAntrenmanlar.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewAntrenmanlar.MultiSelect = false;
            this.gridViewAntrenmanlar.Name = "gridViewAntrenmanlar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewAntrenmanlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridViewAntrenmanlar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewAntrenmanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewAntrenmanlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewAntrenmanlar_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaylarıGörToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // detaylarıGörToolStripMenuItem
            // 
            this.detaylarıGörToolStripMenuItem.Name = "detaylarıGörToolStripMenuItem";
            resources.ApplyResources(this.detaylarıGörToolStripMenuItem, "detaylarıGörToolStripMenuItem");
            this.detaylarıGörToolStripMenuItem.Click += new System.EventHandler(this.detaylarıGörToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnOturumKapat, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGeriGit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSettings, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gridViewAntrenmanlar, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // Antrenman
            // 
            resources.ApplyResources(this.Antrenman, "Antrenman");
            this.Antrenman.Name = "Antrenman";
            // 
            // AtuId
            // 
            resources.ApplyResources(this.AtuId, "AtuId");
            this.AtuId.Name = "AtuId";
            // 
            // AntrenmanTuru
            // 
            resources.ApplyResources(this.AntrenmanTuru, "AntrenmanTuru");
            this.AntrenmanTuru.Name = "AntrenmanTuru";
            // 
            // AntrenmanSayisi
            // 
            resources.ApplyResources(this.AntrenmanSayisi, "AntrenmanSayisi");
            this.AntrenmanSayisi.Name = "AntrenmanSayisi";
            // 
            // AtisSayisi
            // 
            resources.ApplyResources(this.AtisSayisi, "AtisSayisi");
            this.AtisSayisi.Name = "AtisSayisi";
            // 
            // BasariliAtis
            // 
            resources.ApplyResources(this.BasariliAtis, "BasariliAtis");
            this.BasariliAtis.Name = "BasariliAtis";
            // 
            // Sure
            // 
            resources.ApplyResources(this.Sure, "Sure");
            this.Sure.Name = "Sure";
            // 
            // Tarih
            // 
            resources.ApplyResources(this.Tarih, "Tarih");
            this.Tarih.Name = "Tarih";
            // 
            // FrmSagAntrenman
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmSagAntrenman";
            this.Load += new System.EventHandler(this.FrmSagAntrenman_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAntrenmanlar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOturumKapat;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGeriGit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMevki;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblSporcu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtimeBaslangic;
        private System.Windows.Forms.DateTimePicker dtimeBitis;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.DataGridView gridViewAntrenmanlar;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detaylarıGörToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antrenman;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntrenmanTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntrenmanSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtisSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasariliAtis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
    }
}