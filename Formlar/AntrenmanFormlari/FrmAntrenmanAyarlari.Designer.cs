namespace AntrenmanTakip.Formlar.AntrenmanFormlari
{
    partial class FrmAntrenmanAyarlari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAntrenmanAyarlari));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewAntrenmanTurleri = new System.Windows.Forms.DataGridView();
            this.topKonumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topGelisSekliId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vurusBicimiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topKonum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopGelisSekli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VurusBicimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.görselEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTopKonum = new System.Windows.Forms.Label();
            this.lblGeliSekli = new System.Windows.Forms.Label();
            this.lblVurusBicimi = new System.Windows.Forms.Label();
            this.cmbTopKonum = new System.Windows.Forms.ComboBox();
            this.cmbTopGelisSekli = new System.Windows.Forms.ComboBox();
            this.txtVurusBicimi = new System.Windows.Forms.TextBox();
            this.txtVurusBicmiId = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEngVurusBicimi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAntrenmanTurleri)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewAntrenmanTurleri
            // 
            this.gridViewAntrenmanTurleri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridViewAntrenmanTurleri.BackgroundColor = System.Drawing.Color.White;
            this.gridViewAntrenmanTurleri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewAntrenmanTurleri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewAntrenmanTurleri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.gridViewAntrenmanTurleri, "gridViewAntrenmanTurleri");
            this.gridViewAntrenmanTurleri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topKonumId,
            this.topGelisSekliId,
            this.vurusBicimiId,
            this.topKonum,
            this.TopGelisSekli,
            this.VurusBicimi,
            this.Image});
            this.gridViewAntrenmanTurleri.ContextMenuStrip = this.contextMenuStrip1;
            this.gridViewAntrenmanTurleri.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewAntrenmanTurleri.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewAntrenmanTurleri.MultiSelect = false;
            this.gridViewAntrenmanTurleri.Name = "gridViewAntrenmanTurleri";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewAntrenmanTurleri.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridViewAntrenmanTurleri.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewAntrenmanTurleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewAntrenmanTurleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewAntrenmanTurleri_CellClick);
            // 
            // topKonumId
            // 
            resources.ApplyResources(this.topKonumId, "topKonumId");
            this.topKonumId.Name = "topKonumId";
            // 
            // topGelisSekliId
            // 
            resources.ApplyResources(this.topGelisSekliId, "topGelisSekliId");
            this.topGelisSekliId.Name = "topGelisSekliId";
            // 
            // vurusBicimiId
            // 
            resources.ApplyResources(this.vurusBicimiId, "vurusBicimiId");
            this.vurusBicimiId.Name = "vurusBicimiId";
            // 
            // topKonum
            // 
            resources.ApplyResources(this.topKonum, "topKonum");
            this.topKonum.Name = "topKonum";
            // 
            // TopGelisSekli
            // 
            resources.ApplyResources(this.TopGelisSekli, "TopGelisSekli");
            this.TopGelisSekli.Name = "TopGelisSekli";
            // 
            // VurusBicimi
            // 
            resources.ApplyResources(this.VurusBicimi, "VurusBicimi");
            this.VurusBicimi.Name = "VurusBicimi";
            // 
            // Image
            // 
            resources.ApplyResources(this.Image, "Image");
            this.Image.Name = "Image";
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görselEkleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // görselEkleToolStripMenuItem
            // 
            this.görselEkleToolStripMenuItem.Name = "görselEkleToolStripMenuItem";
            resources.ApplyResources(this.görselEkleToolStripMenuItem, "görselEkleToolStripMenuItem");
            this.görselEkleToolStripMenuItem.Click += new System.EventHandler(this.görselEkleToolStripMenuItem_Click);
            // 
            // lblTopKonum
            // 
            resources.ApplyResources(this.lblTopKonum, "lblTopKonum");
            this.lblTopKonum.Name = "lblTopKonum";
            // 
            // lblGeliSekli
            // 
            resources.ApplyResources(this.lblGeliSekli, "lblGeliSekli");
            this.lblGeliSekli.Name = "lblGeliSekli";
            // 
            // lblVurusBicimi
            // 
            resources.ApplyResources(this.lblVurusBicimi, "lblVurusBicimi");
            this.lblVurusBicimi.Name = "lblVurusBicimi";
            // 
            // cmbTopKonum
            // 
            this.cmbTopKonum.FormattingEnabled = true;
            resources.ApplyResources(this.cmbTopKonum, "cmbTopKonum");
            this.cmbTopKonum.Name = "cmbTopKonum";
            // 
            // cmbTopGelisSekli
            // 
            this.cmbTopGelisSekli.FormattingEnabled = true;
            resources.ApplyResources(this.cmbTopGelisSekli, "cmbTopGelisSekli");
            this.cmbTopGelisSekli.Name = "cmbTopGelisSekli";
            // 
            // txtVurusBicimi
            // 
            resources.ApplyResources(this.txtVurusBicimi, "txtVurusBicimi");
            this.txtVurusBicimi.Name = "txtVurusBicimi";
            // 
            // txtVurusBicmiId
            // 
            resources.ApplyResources(this.txtVurusBicmiId, "txtVurusBicmiId");
            this.txtVurusBicmiId.Name = "txtVurusBicmiId";
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Image = global::AntrenmanTakip.Properties.Resources.temizle32px;
            this.btnSil.Name = "btnSil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.Image = global::AntrenmanTakip.Properties.Resources.ekle2_48px;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtEngVurusBicimi
            // 
            resources.ApplyResources(this.txtEngVurusBicimi, "txtEngVurusBicimi");
            this.txtEngVurusBicimi.Name = "txtEngVurusBicimi";
            // 
            // FrmAntrenmanAyarlari
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtVurusBicmiId);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtEngVurusBicimi);
            this.Controls.Add(this.txtVurusBicimi);
            this.Controls.Add(this.cmbTopGelisSekli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTopKonum);
            this.Controls.Add(this.lblVurusBicimi);
            this.Controls.Add(this.lblGeliSekli);
            this.Controls.Add(this.lblTopKonum);
            this.Controls.Add(this.gridViewAntrenmanTurleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAntrenmanAyarlari";
            this.Load += new System.EventHandler(this.FrmAntrenmanAyarlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAntrenmanTurleri)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewAntrenmanTurleri;
        private System.Windows.Forms.Label lblTopKonum;
        private System.Windows.Forms.Label lblGeliSekli;
        private System.Windows.Forms.Label lblVurusBicimi;
        private System.Windows.Forms.ComboBox cmbTopKonum;
        private System.Windows.Forms.ComboBox cmbTopGelisSekli;
        private System.Windows.Forms.TextBox txtVurusBicimi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtVurusBicmiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn topKonumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn topGelisSekliId;
        private System.Windows.Forms.DataGridViewTextBoxColumn vurusBicimiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn topKonum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopGelisSekli;
        private System.Windows.Forms.DataGridViewTextBoxColumn VurusBicimi;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem görselEkleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEngVurusBicimi;
    }
}