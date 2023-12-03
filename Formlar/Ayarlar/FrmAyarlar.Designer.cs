namespace AntrenmanTakip.Formlar.Ayarlar
{
    partial class FrmAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyarlar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ayarlarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.kişiselAyarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğişikliğiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilSeçenekleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diğerAyarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sporcuAtaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antrenmanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serbestVeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.portAyarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğişikliğiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarTabControl = new System.Windows.Forms.TabControl();
            this.tabPageDigerAyarlar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.gridViewKullanicilar = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ayarlarMenuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.ayarlarTabControl.SuspendLayout();
            this.tabPageDigerAyarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // ayarlarMenuStrip
            // 
            this.ayarlarMenuStrip.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ayarlarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiselAyarlarToolStripMenuItem,
            this.dilSeçenekleriToolStripMenuItem,
            this.kullanıcıToolStripMenuItem,
            this.antrenmanlarToolStripMenuItem,
            this.serbestVeriToolStripMenuItem,
            this.portAyarıToolStripMenuItem});
            resources.ApplyResources(this.ayarlarMenuStrip, "ayarlarMenuStrip");
            this.ayarlarMenuStrip.Name = "ayarlarMenuStrip";
            // 
            // kişiselAyarlarToolStripMenuItem
            // 
            this.kişiselAyarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgilerToolStripMenuItem,
            this.şifreDeğişikliğiToolStripMenuItem});
            this.kişiselAyarlarToolStripMenuItem.Name = "kişiselAyarlarToolStripMenuItem";
            resources.ApplyResources(this.kişiselAyarlarToolStripMenuItem, "kişiselAyarlarToolStripMenuItem");
            // 
            // bilgilerToolStripMenuItem
            // 
            this.bilgilerToolStripMenuItem.Name = "bilgilerToolStripMenuItem";
            resources.ApplyResources(this.bilgilerToolStripMenuItem, "bilgilerToolStripMenuItem");
            this.bilgilerToolStripMenuItem.Click += new System.EventHandler(this.bilgilerToolStripMenuItem_Click);
            // 
            // şifreDeğişikliğiToolStripMenuItem
            // 
            this.şifreDeğişikliğiToolStripMenuItem.Name = "şifreDeğişikliğiToolStripMenuItem";
            resources.ApplyResources(this.şifreDeğişikliğiToolStripMenuItem, "şifreDeğişikliğiToolStripMenuItem");
            this.şifreDeğişikliğiToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğişikliğiToolStripMenuItem_Click);
            // 
            // dilSeçenekleriToolStripMenuItem
            // 
            this.dilSeçenekleriToolStripMenuItem.Name = "dilSeçenekleriToolStripMenuItem";
            resources.ApplyResources(this.dilSeçenekleriToolStripMenuItem, "dilSeçenekleriToolStripMenuItem");
            this.dilSeçenekleriToolStripMenuItem.Click += new System.EventHandler(this.dilSeçenekleriToolStripMenuItem_Click);
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.diğerAyarlarToolStripMenuItem,
            this.sporcuAtaToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            resources.ApplyResources(this.kullanıcıToolStripMenuItem, "kullanıcıToolStripMenuItem");
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            resources.ApplyResources(this.ekleToolStripMenuItem, "ekleToolStripMenuItem");
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // diğerAyarlarToolStripMenuItem
            // 
            this.diğerAyarlarToolStripMenuItem.Name = "diğerAyarlarToolStripMenuItem";
            resources.ApplyResources(this.diğerAyarlarToolStripMenuItem, "diğerAyarlarToolStripMenuItem");
            this.diğerAyarlarToolStripMenuItem.Click += new System.EventHandler(this.diğerAyarlarToolStripMenuItem_Click);
            // 
            // sporcuAtaToolStripMenuItem
            // 
            this.sporcuAtaToolStripMenuItem.Name = "sporcuAtaToolStripMenuItem";
            resources.ApplyResources(this.sporcuAtaToolStripMenuItem, "sporcuAtaToolStripMenuItem");
            this.sporcuAtaToolStripMenuItem.Click += new System.EventHandler(this.sporcuAtaToolStripMenuItem_Click);
            // 
            // antrenmanlarToolStripMenuItem
            // 
            this.antrenmanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görüntüleToolStripMenuItem});
            this.antrenmanlarToolStripMenuItem.Name = "antrenmanlarToolStripMenuItem";
            resources.ApplyResources(this.antrenmanlarToolStripMenuItem, "antrenmanlarToolStripMenuItem");
            // 
            // görüntüleToolStripMenuItem
            // 
            this.görüntüleToolStripMenuItem.Name = "görüntüleToolStripMenuItem";
            resources.ApplyResources(this.görüntüleToolStripMenuItem, "görüntüleToolStripMenuItem");
            this.görüntüleToolStripMenuItem.Click += new System.EventHandler(this.görüntüleToolStripMenuItem_Click);
            // 
            // serbestVeriToolStripMenuItem
            // 
            this.serbestVeriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1});
            this.serbestVeriToolStripMenuItem.Name = "serbestVeriToolStripMenuItem";
            resources.ApplyResources(this.serbestVeriToolStripMenuItem, "serbestVeriToolStripMenuItem");
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            resources.ApplyResources(this.ekleToolStripMenuItem1, "ekleToolStripMenuItem1");
            this.ekleToolStripMenuItem1.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // portAyarıToolStripMenuItem
            // 
            this.portAyarıToolStripMenuItem.Name = "portAyarıToolStripMenuItem";
            resources.ApplyResources(this.portAyarıToolStripMenuItem, "portAyarıToolStripMenuItem");
            this.portAyarıToolStripMenuItem.Click += new System.EventHandler(this.portAyarıToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.şifreDeğişikliğiToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            resources.ApplyResources(this.düzenleToolStripMenuItem, "düzenleToolStripMenuItem");
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            resources.ApplyResources(this.silToolStripMenuItem, "silToolStripMenuItem");
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // şifreDeğişikliğiToolStripMenuItem1
            // 
            this.şifreDeğişikliğiToolStripMenuItem1.Name = "şifreDeğişikliğiToolStripMenuItem1";
            resources.ApplyResources(this.şifreDeğişikliğiToolStripMenuItem1, "şifreDeğişikliğiToolStripMenuItem1");
            this.şifreDeğişikliğiToolStripMenuItem1.Click += new System.EventHandler(this.şifreDeğişikliğiToolStripMenuItem1_Click);
            // 
            // ayarlarTabControl
            // 
            this.ayarlarTabControl.ContextMenuStrip = this.contextMenuStrip1;
            this.ayarlarTabControl.Controls.Add(this.tabPageDigerAyarlar);
            resources.ApplyResources(this.ayarlarTabControl, "ayarlarTabControl");
            this.ayarlarTabControl.Name = "ayarlarTabControl";
            this.ayarlarTabControl.SelectedIndex = 0;
            // 
            // tabPageDigerAyarlar
            // 
            this.tabPageDigerAyarlar.Controls.Add(this.button1);
            this.tabPageDigerAyarlar.Controls.Add(this.txtAra);
            this.tabPageDigerAyarlar.Controls.Add(this.gridViewKullanicilar);
            resources.ApplyResources(this.tabPageDigerAyarlar, "tabPageDigerAyarlar");
            this.tabPageDigerAyarlar.Name = "tabPageDigerAyarlar";
            this.tabPageDigerAyarlar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Image = global::AntrenmanTakip.Properties.Resources.guncelle2_48px;
            this.button1.Name = "button1";
            this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAra
            // 
            resources.ApplyResources(this.txtAra, "txtAra");
            this.txtAra.Name = "txtAra";
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // gridViewKullanicilar
            // 
            this.gridViewKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.gridViewKullanicilar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewKullanicilar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewKullanicilar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.gridViewKullanicilar, "gridViewKullanicilar");
            this.gridViewKullanicilar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KullaniciAdi,
            this.Ad,
            this.Soyad,
            this.Yetki});
            this.gridViewKullanicilar.ContextMenuStrip = this.contextMenuStrip1;
            this.gridViewKullanicilar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewKullanicilar.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewKullanicilar.MultiSelect = false;
            this.gridViewKullanicilar.Name = "gridViewKullanicilar";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewKullanicilar.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridViewKullanicilar.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridViewKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewKullanicilar_CellClick);
            // 
            // Id
            // 
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            // 
            // KullaniciAdi
            // 
            resources.ApplyResources(this.KullaniciAdi, "KullaniciAdi");
            this.KullaniciAdi.Name = "KullaniciAdi";
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
            // Yetki
            // 
            resources.ApplyResources(this.Yetki, "Yetki");
            this.Yetki.Name = "Yetki";
            // 
            // FrmAyarlar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ayarlarTabControl);
            this.Controls.Add(this.ayarlarMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ayarlarMenuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmAyarlar";
            this.Load += new System.EventHandler(this.FrmAyarlar_Load);
            this.ayarlarMenuStrip.ResumeLayout(false);
            this.ayarlarMenuStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ayarlarTabControl.ResumeLayout(false);
            this.tabPageDigerAyarlar.ResumeLayout(false);
            this.tabPageDigerAyarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ayarlarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem kişiselAyarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğişikliğiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilSeçenekleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diğerAyarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antrenmanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.TabControl ayarlarTabControl;
        private System.Windows.Forms.TabPage tabPageDigerAyarlar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView gridViewKullanicilar;
        private System.Windows.Forms.ToolStripMenuItem sporcuAtaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğişikliğiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serbestVeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem portAyarıToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetki;
    }
}