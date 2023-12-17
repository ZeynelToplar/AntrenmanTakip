namespace AntrenmanTakip.Formlar.Ayarlar
{
    partial class FrmAyarlarRaporlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyarlarRaporlama));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewSporcular = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UlkeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mevki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSecilenSporcu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTK = new System.Windows.Forms.ComboBox();
            this.cmbTGS = new System.Windows.Forms.ComboBox();
            this.cmbVB = new System.Windows.Forms.ComboBox();
            this.cmbGrafikTuru = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbIstatistikTuru = new System.Windows.Forms.ComboBox();
            this.lblAy = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.txtYıl = new System.Windows.Forms.TextBox();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.lblSira = new System.Windows.Forms.Label();
            this.txtSira = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSporcular)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewSporcular
            // 
            this.gridViewSporcular.AllowUserToAddRows = false;
            this.gridViewSporcular.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.gridViewSporcular, "gridViewSporcular");
            this.gridViewSporcular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewSporcular.BackgroundColor = System.Drawing.Color.White;
            this.gridViewSporcular.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewSporcular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSporcular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewSporcular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UlkeId,
            this.Ulke,
            this.Ad,
            this.Soyad,
            this.Yas,
            this.Boy,
            this.Kilo,
            this.Mevki,
            this.DogumTarihi});
            this.gridViewSporcular.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewSporcular.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewSporcular.MultiSelect = false;
            this.gridViewSporcular.Name = "gridViewSporcular";
            this.gridViewSporcular.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSporcular.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridViewSporcular.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridViewSporcular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewSporcular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewSporcular_CellClick);
            // 
            // Id
            // 
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // UlkeId
            // 
            resources.ApplyResources(this.UlkeId, "UlkeId");
            this.UlkeId.Name = "UlkeId";
            this.UlkeId.ReadOnly = true;
            // 
            // Ulke
            // 
            resources.ApplyResources(this.Ulke, "Ulke");
            this.Ulke.Name = "Ulke";
            this.Ulke.ReadOnly = true;
            // 
            // Ad
            // 
            resources.ApplyResources(this.Ad, "Ad");
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Soyad
            // 
            resources.ApplyResources(this.Soyad, "Soyad");
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            // 
            // Yas
            // 
            resources.ApplyResources(this.Yas, "Yas");
            this.Yas.Name = "Yas";
            this.Yas.ReadOnly = true;
            // 
            // Boy
            // 
            resources.ApplyResources(this.Boy, "Boy");
            this.Boy.Name = "Boy";
            this.Boy.ReadOnly = true;
            // 
            // Kilo
            // 
            resources.ApplyResources(this.Kilo, "Kilo");
            this.Kilo.Name = "Kilo";
            this.Kilo.ReadOnly = true;
            // 
            // Mevki
            // 
            resources.ApplyResources(this.Mevki, "Mevki");
            this.Mevki.Name = "Mevki";
            this.Mevki.ReadOnly = true;
            // 
            // DogumTarihi
            // 
            resources.ApplyResources(this.DogumTarihi, "DogumTarihi");
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblSecilenSporcu
            // 
            resources.ApplyResources(this.lblSecilenSporcu, "lblSecilenSporcu");
            this.lblSecilenSporcu.Name = "lblSecilenSporcu";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cmbTK
            // 
            this.cmbTK.FormattingEnabled = true;
            resources.ApplyResources(this.cmbTK, "cmbTK");
            this.cmbTK.Name = "cmbTK";
            // 
            // cmbTGS
            // 
            this.cmbTGS.FormattingEnabled = true;
            resources.ApplyResources(this.cmbTGS, "cmbTGS");
            this.cmbTGS.Name = "cmbTGS";
            // 
            // cmbVB
            // 
            this.cmbVB.FormattingEnabled = true;
            resources.ApplyResources(this.cmbVB, "cmbVB");
            this.cmbVB.Name = "cmbVB";
            // 
            // cmbGrafikTuru
            // 
            this.cmbGrafikTuru.FormattingEnabled = true;
            this.cmbGrafikTuru.Items.AddRange(new object[] {
            resources.GetString("cmbGrafikTuru.Items"),
            resources.GetString("cmbGrafikTuru.Items1"),
            resources.GetString("cmbGrafikTuru.Items2")});
            resources.ApplyResources(this.cmbGrafikTuru, "cmbGrafikTuru");
            this.cmbGrafikTuru.Name = "cmbGrafikTuru";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // cmbIstatistikTuru
            // 
            this.cmbIstatistikTuru.FormattingEnabled = true;
            this.cmbIstatistikTuru.Items.AddRange(new object[] {
            resources.GetString("cmbIstatistikTuru.Items"),
            resources.GetString("cmbIstatistikTuru.Items1"),
            resources.GetString("cmbIstatistikTuru.Items2"),
            resources.GetString("cmbIstatistikTuru.Items3")});
            resources.ApplyResources(this.cmbIstatistikTuru, "cmbIstatistikTuru");
            this.cmbIstatistikTuru.Name = "cmbIstatistikTuru";
            this.cmbIstatistikTuru.SelectedIndexChanged += new System.EventHandler(this.cmbIstatistikTuru_SelectedIndexChanged);
            // 
            // lblAy
            // 
            resources.ApplyResources(this.lblAy, "lblAy");
            this.lblAy.Name = "lblAy";
            // 
            // lblYil
            // 
            resources.ApplyResources(this.lblYil, "lblYil");
            this.lblYil.Name = "lblYil";
            // 
            // txtAy
            // 
            resources.ApplyResources(this.txtAy, "txtAy");
            this.txtAy.Name = "txtAy";
            this.txtAy.TextChanged += new System.EventHandler(this.txtAy_TextChanged);
            // 
            // txtYıl
            // 
            resources.ApplyResources(this.txtYıl, "txtYıl");
            this.txtYıl.Name = "txtYıl";
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaporAl.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnRaporAl, "btnRaporAl");
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Name = "label3";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            // 
            // lblBaslangic
            // 
            resources.ApplyResources(this.lblBaslangic, "lblBaslangic");
            this.lblBaslangic.Name = "lblBaslangic";
            // 
            // lblBitis
            // 
            resources.ApplyResources(this.lblBitis, "lblBitis");
            this.lblBitis.Name = "lblBitis";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtBaslangic, "dtBaslangic");
            this.dtBaslangic.Name = "dtBaslangic";
            // 
            // dtBitis
            // 
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtBitis, "dtBitis");
            this.dtBitis.Name = "dtBitis";
            // 
            // lblSira
            // 
            resources.ApplyResources(this.lblSira, "lblSira");
            this.lblSira.Name = "lblSira";
            // 
            // txtSira
            // 
            resources.ApplyResources(this.txtSira, "txtSira");
            this.txtSira.Name = "txtSira";
            this.toolTip1.SetToolTip(this.txtSira, resources.GetString("txtSira.ToolTip"));
            // 
            // FrmAyarlarRaporlama
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSira);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.txtYıl);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.cmbVB);
            this.Controls.Add(this.cmbTGS);
            this.Controls.Add(this.cmbIstatistikTuru);
            this.Controls.Add(this.cmbGrafikTuru);
            this.Controls.Add(this.cmbTK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.lblSira);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.lblAy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSecilenSporcu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridViewSporcular);
            this.Name = "FrmAyarlarRaporlama";
            this.Load += new System.EventHandler(this.FrmAyarlarRaporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSporcular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewSporcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSecilenSporcu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTK;
        private System.Windows.Forms.ComboBox cmbTGS;
        private System.Windows.Forms.ComboBox cmbVB;
        private System.Windows.Forms.ComboBox cmbGrafikTuru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbIstatistikTuru;
        private System.Windows.Forms.Label lblAy;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.TextBox txtYıl;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UlkeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mevki;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Label lblSira;
        private System.Windows.Forms.TextBox txtSira;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}