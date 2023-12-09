using AntrenmanTakip.Formlar.AntrenmanFormlari;
using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.Ayarlar
{
    public partial class FrmAyarlar : Form
    {
        #region Tanımlamalar 
        private Label lblAd = new Label();
        private Label lblSoyad = new Label();
        private Label lblYas = new Label();
        private Label lblKullaniciAdi = new Label();
        private Label lblEskiSifre = new Label();
        private Label lblYeniSifre = new Label();
        private Label lblSifreTekrar = new Label();
        private Label lblYKullaniciAdi = new Label();
        private Label lblYAd = new Label();
        private Label lblYSoyad = new Label();
        private Label lblYYas = new Label();
        private Label lblYetki = new Label();
        private Label lblYMail = new Label();

        private TextBox txtAd = new TextBox();
        private TextBox txtSoyad = new TextBox();
        private TextBox txtYas = new TextBox();
        private TextBox txtKullaniciAd = new TextBox();
        private TextBox txtId = new TextBox();
        private TextBox txtEskiSifre = new TextBox();
        private TextBox txtYeniSifre = new TextBox();
        private TextBox txtSifreTekrar = new TextBox();
        private TextBox txtYKullaniciAdi = new TextBox();
        private TextBox txtYAd = new TextBox();
        private TextBox txtYSoyad = new TextBox();
        private TextBox txtYYas = new TextBox();
        private TextBox txtYetki = new TextBox();
        private TextBox txtYMail = new TextBox();

        private ComboBox cmbYetki = new ComboBox();

        private Button btnBilgiGuncelle = new Button();
        private Button btnSifreGuncelle = new Button();
        private Button btnKKaydet = new Button();

        private TabPage tabPageBilgiler = new TabPage();
        private TabPage tabPageSifre = new TabPage();
        private TabPage tabPageKEkle = new TabPage();
        #endregion
        #region Form Tanımları 

        private frmKullaniciDuzenleme _frmKullaniciDuzenleme;
        private FrmAntrenmanAyarlari _frmAntrenmanAyarlari;
        private FrmDilSecenekleri _frmDilSecenekleri;
        private FrmSporcuAtama _frmSporcuAtama;
        private FrmTekliVeriEkleme _frmTekliVeriEkleme;
        private frmCokluVeriEkleme _frmCokluVeriEkleme;
        private FrmPortAyari _frmPortAyari;
        private FrmAyarlarRaporlama _frmAyarlarRaporlama;
        #endregion
        public Kullanicilar kullanici;
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        string systemLanguage = "";
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            var searchedUsers = KullanicilariListele().Where(x => x.KullaniciAdi.Contains(txtAra.Text) || x.Ad.Contains(txtAra.Text) || x.Soyad.Contains(txtAra.Text));
            gridViewKullanicilar.Rows.Clear();
            foreach (var searchedUser in searchedUsers)
            {
                string yetki = searchedUser.YetkiId == 0 ? "Admin" : "Antrenör";
                gridViewKullanicilar.Rows.Add(new object[]
               {
                   searchedUser.Id,
                   searchedUser.KullaniciAdi,
                   searchedUser.Ad,
                   searchedUser.Soyad,
                   yetki
               });
            }
        }
        private List<Kullanicilar> KullanicilariListele()
        {
            return Context._context.Kullanicilar.ToList();
        }

        private int sayacBilgiler = 0;
        private void bilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sayacBilgiler == 0)
            {
                // label1
                // 
                lblAd.AutoSize = true;
                lblAd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblAd.Location = new System.Drawing.Point(134, 121);
                lblAd.Name = "lblAd";
                lblAd.Size = new System.Drawing.Size(41, 28);
                lblAd.TabIndex = 0;
                if (systemLanguage == "Turkish")
                    lblAd.Text = "Ad:";
                else if (systemLanguage == "English")
                    lblAd.Text = "Name:";
                // 
                // label2
                // 
                lblSoyad.AutoSize = true;
                lblSoyad.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblSoyad.Location = new System.Drawing.Point(132, 152);
                lblSoyad.Name = "lblSoyad";
                lblSoyad.Size = new System.Drawing.Size(71, 28);
                lblSoyad.TabIndex = 1;
                if (systemLanguage == "Turkish")
                    lblSoyad.Text = "Soyad:";
                else if (systemLanguage == "English")
                    lblSoyad.Text = "Surname:";
                // 
                // txtAd
                // 
                txtAd.Location = new System.Drawing.Point(262, 126);
                txtAd.Name = "txtAd";
                txtAd.Size = new System.Drawing.Size(166, 23);
                txtAd.TabIndex = 4;
                // 
                // txtSoyad
                // 
                txtSoyad.Location = new System.Drawing.Point(262, 155);
                txtSoyad.Name = "txtSoyad";
                txtSoyad.Size = new System.Drawing.Size(166, 23);
                txtSoyad.TabIndex = 5;
                // 
                // label7
                // 
                lblKullaniciAdi.AutoSize = true;
                lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblKullaniciAdi.Location = new System.Drawing.Point(132, 90);
                lblKullaniciAdi.Name = "lblKullaniciAdi";
                lblKullaniciAdi.Size = new System.Drawing.Size(124, 28);
                lblKullaniciAdi.TabIndex = 0;
                if (systemLanguage == "Turkish")
                    lblKullaniciAdi.Text = "Kullanıcı Adı:";
                else if (systemLanguage == "English")
                    lblKullaniciAdi.Text = "Username:";
                // 
                // txtKullaniciAd
                // 
                txtKullaniciAd.Location = new System.Drawing.Point(262, 92);
                txtKullaniciAd.Name = "txtKullaniciAd";
                txtKullaniciAd.Size = new System.Drawing.Size(166, 23);
                txtKullaniciAd.TabIndex = 4;
                // 
                // btnBilgiGuncelle
                // 
                btnBilgiGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                btnBilgiGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                btnBilgiGuncelle.Image = global::AntrenmanTakip.Properties.Resources.bilgiGuncelle24px;
                btnBilgiGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnBilgiGuncelle.Location = new System.Drawing.Point(262, 180);
                btnBilgiGuncelle.Name = "btnBilgiGuncelle";
                btnBilgiGuncelle.Size = new System.Drawing.Size(166, 47);
                btnBilgiGuncelle.TabIndex = 8;
                if (systemLanguage == "Turkish")
                    btnBilgiGuncelle.Text = "Güncelle";
                else if (systemLanguage == "English")
                    btnBilgiGuncelle.Text = "Update";
                btnBilgiGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnBilgiGuncelle.UseVisualStyleBackColor = true;
                btnBilgiGuncelle.Click += BtnBilgiGuncelle_Click;
                // 
                // txtId
                // 
                txtId.Location = new System.Drawing.Point(265, 277);
                txtId.Name = "txtId";
                txtId.Size = new System.Drawing.Size(28, 23);
                txtId.TabIndex = 9;
                txtId.Visible = false;
                // 

                // tabPageBilgiler
                // 
                tabPageBilgiler.Location = new System.Drawing.Point(4, 24);
                tabPageBilgiler.Name = "tabPageBilgiler";
                tabPageBilgiler.Padding = new System.Windows.Forms.Padding(3);
                tabPageBilgiler.Size = new System.Drawing.Size(631, 444);
                tabPageBilgiler.TabIndex = 0;
                if (systemLanguage == "Turkish")
                    tabPageBilgiler.Text = "Bilgiler";
                else if (systemLanguage == "English")
                    tabPageBilgiler.Text = "Informations";
                tabPageBilgiler.UseVisualStyleBackColor = true;
                // 

                Kullanicilar kullanici = DbService.GetUser(Context.kullanici.Id);
                txtKullaniciAd.Text = kullanici?.KullaniciAdi;
                txtAd.Text = kullanici?.Ad;
                txtSoyad.Text = kullanici?.Soyad;
                txtId.Text = kullanici?.Id.ToString();

                tabPageBilgiler.Controls.Add(lblAd);
                tabPageBilgiler.Controls.Add(lblSoyad);
                tabPageBilgiler.Controls.Add(lblYas);
                tabPageBilgiler.Controls.Add(lblKullaniciAdi);
                tabPageBilgiler.Controls.Add(txtAd);
                tabPageBilgiler.Controls.Add(txtSoyad);
                tabPageBilgiler.Controls.Add(txtKullaniciAd);
                tabPageBilgiler.Controls.Add(txtYas);
                tabPageBilgiler.Controls.Add(txtId);
                tabPageBilgiler.Controls.Add(btnBilgiGuncelle);
                ayarlarTabControl.Controls.Add(tabPageBilgiler);
            }
            ayarlarTabControl.SelectedTab = tabPageBilgiler;
            sayacBilgiler++;
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            
            if (InfService.ShowMessage("Bilgilerinizi güncellemek istediğinize emin misiniz ?", "Are you sure you want to update your information?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id_ = Convert.ToInt32(txtId.Text);
                Kullanicilar kullanici = Context._context.Kullanicilar.FirstOrDefault(k => k.Id == id_);
                if (kullanici != null)
                {
                    kullanici.KullaniciAdi = txtKullaniciAd.Text;
                    kullanici.Ad = txtAd.Text;
                    kullanici.Soyad = txtSoyad.Text;
                    Context._context.SaveChanges();
                    InfService.ShowMessage("Bilgiler başarıyla güncellenmiştir.", "The information has been successfully updated.");
                }
            }
        }

        private int sayacSifre = 0;
        private void şifreDeğişikliğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sayacSifre == 0)
            {
                // btnSifreGuncelle
                // 
                btnSifreGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                btnSifreGuncelle.Location = new System.Drawing.Point(262, 173);
                btnSifreGuncelle.Image = global::AntrenmanTakip.Properties.Resources.bilgiGuncelle24px;
                btnSifreGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnSifreGuncelle.Name = "btnSifreGuncelle";
                btnSifreGuncelle.Size = new System.Drawing.Size(166, 47);
                btnSifreGuncelle.TabIndex = 15;
                if (systemLanguage == "Turkish")
                    btnSifreGuncelle.Text = "Şifre Güncelle";
                else
                    btnSifreGuncelle.Text = "Change Password";
                btnSifreGuncelle.TextAlign = ContentAlignment.MiddleRight;
                btnSifreGuncelle.UseVisualStyleBackColor = true;
                btnSifreGuncelle.Click += BtnSifreGuncelle_Click;
                // 
                // txtSifreTekrar
                // 
                txtSifreTekrar.Location = new System.Drawing.Point(320, 139);
                txtSifreTekrar.Name = "txtSifreTekrar";
                txtSifreTekrar.Size = new System.Drawing.Size(166, 23);
                txtSifreTekrar.TabIndex = 14;
                txtSifreTekrar.PasswordChar = '*';
                // 
                // txtYeniSifre
                // 
                txtYeniSifre.Location = new System.Drawing.Point(320, 110);
                txtYeniSifre.Name = "txtYeniSifre";
                txtYeniSifre.Size = new System.Drawing.Size(166, 23);
                txtYeniSifre.TabIndex = 13;
                txtYeniSifre.PasswordChar = '*';
                // 
                // txtEskiSifre
                // 
                txtEskiSifre.Location = new System.Drawing.Point(320, 79);
                txtEskiSifre.Name = "txtEskiSifre";
                txtEskiSifre.Size = new System.Drawing.Size(166, 23);
                txtEskiSifre.TabIndex = 12;
                txtEskiSifre.PasswordChar = '*';
                // 
                // label6
                // 
                lblSifreTekrar.AutoSize = true;
                lblSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblSifreTekrar.Location = new System.Drawing.Point(149, 134);
                lblSifreTekrar.Name = "label6";
                lblSifreTekrar.Size = new System.Drawing.Size(112, 28);
                lblSifreTekrar.TabIndex = 9;
                if (systemLanguage == "Turkish")
                    lblSifreTekrar.Text = "Şifre Tekrar:";
                else
                    lblSifreTekrar.Text = "Confirm Password:";
                // 
                // label5
                // 
                lblYeniSifre.AutoSize = true;
                lblYeniSifre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblYeniSifre.Location = new System.Drawing.Point(149, 105);
                lblYeniSifre.Name = "label5";
                lblYeniSifre.Size = new System.Drawing.Size(95, 28);
                lblYeniSifre.TabIndex = 10;
                if (systemLanguage == "Turkish")
                    lblYeniSifre.Text = "Yeni Şifre:";
                else
                    lblYeniSifre.Text = "New Password:";
                // 
                // label4
                // 
                lblEskiSifre.AutoSize = true;
                lblEskiSifre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblEskiSifre.Location = new System.Drawing.Point(149, 74);
                lblEskiSifre.Name = "label4";
                lblEskiSifre.Size = new System.Drawing.Size(93, 28);
                lblEskiSifre.TabIndex = 11;
                if (systemLanguage == "Turkish")
                    lblEskiSifre.Text = "Eski Şifre:";
                else
                    lblEskiSifre.Text = "Old Password:";
                // 
                // tabPage2
                // 
                tabPageSifre.Location = new System.Drawing.Point(4, 24);
                tabPageSifre.Name = "tabPageSifre";
                tabPageSifre.Padding = new System.Windows.Forms.Padding(3);
                tabPageSifre.Size = new System.Drawing.Size(631, 444);
                tabPageSifre.TabIndex = 1;
                if (systemLanguage == "Turkish")
                    tabPageSifre.Text = "Şifre Değişikliği";
                else
                    tabPageSifre.Text = "Password Change";
                tabPageSifre.UseVisualStyleBackColor = true;
                // 


                tabPageSifre.Controls.Add(lblEskiSifre);
                tabPageSifre.Controls.Add(lblYeniSifre);
                tabPageSifre.Controls.Add(lblSifreTekrar);
                tabPageSifre.Controls.Add(txtEskiSifre);
                tabPageSifre.Controls.Add(txtYeniSifre);
                tabPageSifre.Controls.Add(txtSifreTekrar);
                tabPageSifre.Controls.Add(btnSifreGuncelle);
                ayarlarTabControl.Controls.Add(tabPageSifre);
            }
            ayarlarTabControl.SelectedTab = tabPageSifre;
            sayacSifre++;
        }

        private void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            string eskiSifre = txtEskiSifre.Text, yeniSifre = txtYeniSifre.Text, sifreTekrar = txtSifreTekrar.Text;
            var kullanici = Context._context.Kullanicilar.Find(Context.kullanici.Id);
            if (kullanici != null)
            {
                if (kullanici.Sifre == eskiSifre)
                {
                    if (yeniSifre != sifreTekrar)
                    {
                        InfService.ShowMessage("Şifreler uyuşmamaktadır.", "Passwords do not match.");
                    }
                    else
                    {
                        kullanici.Sifre = yeniSifre;
                        Context._context.Entry(kullanici).State = EntityState.Modified;
                        Context._context.SaveChanges();
                        InfService.ShowMessage("Şifre değişikliği başarıyla gerçekleşmiştir.", "Password change has been successful.");
                        txtEskiSifre.Text = "";
                        txtYeniSifre.Text = "";
                        txtSifreTekrar.Text = "";
                    }
                }
                else
                {
                    InfService.ShowMessage("Girmiş olduğunuz şifre hatalıdır. Lütfen mevcut şifrenizi kontrol ediniz.", "The password you entered is incorrect. Please check your current password.");
                }

            }
        }

        private int sayacEkle = 0;
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sayacEkle == 0)
            {
                // lblYKullaniciAdi
                // 
                lblYKullaniciAdi.AutoSize = true;
                lblYKullaniciAdi.Font = new Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblYKullaniciAdi.Location = new System.Drawing.Point(100, 63);
                lblYKullaniciAdi.Name = "lblYKullaniciAdi";
                lblYKullaniciAdi.Size = new Size(150, 32);
                lblYKullaniciAdi.TabIndex = 0;
                if (systemLanguage == "Turkish")
                    lblYKullaniciAdi.Text = "Kullanıcı Adı:";
                else
                    lblYKullaniciAdi.Text = "Username:";
                // 
                // lblYetki
                // 
                lblYetki.AutoSize = true;
                lblYetki.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblYetki.Location = new System.Drawing.Point(100, 195);
                lblYetki.Name = "lblYetki";
                lblYetki.Size = new System.Drawing.Size(69, 32);
                lblYetki.TabIndex = 4;
                if (systemLanguage == "Turkish")
                    lblYetki.Text = "Yetki:";
                else
                    lblYetki.Text = "Authority:";
                // 
                // lblYSoyad
                // 
                lblYSoyad.AutoSize = true;
                lblYSoyad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblYSoyad.Location = new System.Drawing.Point(100, 127);
                lblYSoyad.Name = "lblYSoyad";
                lblYSoyad.Size = new System.Drawing.Size(84, 32);
                lblYSoyad.TabIndex = 2;
                if (systemLanguage == "Turkish")
                    lblYSoyad.Text = "Soyad:";
                else
                    lblYSoyad.Text = "Surname:";

                // 
                // lblYAd
                // 
                lblYAd.AutoSize = true;
                lblYAd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblYAd.Location = new System.Drawing.Point(100, 95);
                lblYAd.Name = "lblYAd";
                lblYAd.Size = new System.Drawing.Size(48, 32);
                lblYAd.TabIndex = 1;
                if (systemLanguage == "Turkish")
                    lblYAd.Text = "Ad:";
                else
                    lblYAd.Text = "Name:";

                // 
                // lblYMail
                // 
                lblYMail.AutoSize = true;
                lblYMail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lblYMail.Location = new System.Drawing.Point(100, 160);
                lblYMail.Name = "lblYMail";
                lblYMail.Size = new System.Drawing.Size(48, 32);
                lblYMail.TabIndex = 1;
                if (systemLanguage == "Turkish")
                    lblYMail.Text = "E-Posta:";
                else
                    lblYMail.Text = "E-Mail:";

                // 
                // cmbYetki
                // 
                cmbYetki.FormattingEnabled = true;
                if (systemLanguage == "Turkish")
                    cmbYetki.Items.AddRange(new object[] {
                                            "Seçiniz...",
                                            "Admin",
                                            "Antrenör"});
                else
                    cmbYetki.Items.AddRange(new object[] {
                                            "Choose...",
                                            "Admin",
                                            "Coach"});
                cmbYetki.Location = new System.Drawing.Point(256, 198);
                cmbYetki.Name = "cmbYetki";
                cmbYetki.Size = new System.Drawing.Size(171, 23);
                cmbYetki.TabIndex = 10;
                cmbYetki.SelectedIndex = 0;
                // 
                // txtYSoyad
                // 
                txtYSoyad.Location = new System.Drawing.Point(256, 136);
                txtYSoyad.Name = "txtYSoyad";
                txtYSoyad.Size = new System.Drawing.Size(171, 23);
                txtYSoyad.TabIndex = 7;
                // 
                // txtYAd
                // 
                txtYAd.Location = new System.Drawing.Point(256, 104);
                txtYAd.Name = "txtYAd";
                txtYAd.Size = new System.Drawing.Size(171, 23);
                txtYAd.TabIndex = 6;
                // 
                // txtYKullaniciAdi
                // 
                txtYKullaniciAdi.Location = new System.Drawing.Point(256, 72);
                txtYKullaniciAdi.Name = "txtYKullaniciAdi";
                txtYKullaniciAdi.Size = new System.Drawing.Size(171, 23);
                txtYKullaniciAdi.TabIndex = 5;
                // 
                // txtYMail
                // 
                txtYMail.Location = new System.Drawing.Point(256, 163);
                txtYMail.Name = "txtYMail";
                txtYMail.Size = new System.Drawing.Size(171, 23);
                txtYMail.TabIndex = 9;
                // 
                // btnKKaydet
                // 
                btnKKaydet.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                btnKKaydet.Image = global::AntrenmanTakip.Properties.Resources.ekle48px;
                btnKKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnKKaydet.Location = new System.Drawing.Point(256, 230);
                btnKKaydet.Name = "btnKKaydet";
                btnKKaydet.Size = new System.Drawing.Size(171, 59);
                btnKKaydet.TabIndex = 5;
                if (systemLanguage == "Turkish")
                    btnKKaydet.Text = "KAYDET";
                else
                    btnKKaydet.Text = "SAVE";
                btnKKaydet.UseVisualStyleBackColor = true;
                btnKKaydet.Click += BtnKKaydet_Click;
                // 

                //tabPageEkle
                tabPageKEkle.Name = "tabPageEkle";
                if (systemLanguage == "Turkish")
                    tabPageKEkle.Text = "Kullanıcı Ekle";
                else
                    tabPageKEkle.Text = "Add User";
                //

                tabPageKEkle.Controls.Add(lblYKullaniciAdi);
                tabPageKEkle.Controls.Add(lblYAd);
                tabPageKEkle.Controls.Add(lblYSoyad);
                tabPageKEkle.Controls.Add(lblYYas);
                tabPageKEkle.Controls.Add(lblYetki);
                tabPageKEkle.Controls.Add(txtYKullaniciAdi);
                tabPageKEkle.Controls.Add(txtYAd);
                tabPageKEkle.Controls.Add(txtYSoyad);
                tabPageKEkle.Controls.Add(txtYYas);
                tabPageKEkle.Controls.Add(cmbYetki);
                tabPageKEkle.Controls.Add(lblYMail);
                tabPageKEkle.Controls.Add(txtYMail);
                tabPageKEkle.Controls.Add(btnKKaydet);

                ayarlarTabControl.Controls.Add(tabPageKEkle);
            }
            sayacEkle++;
            ayarlarTabControl.SelectedTab = tabPageKEkle;
        }

        private void BtnKKaydet_Click(object sender, EventArgs e)
        {
            int yetki = -1;
            if (cmbYetki.SelectedIndex == 1)
                yetki = 0;
            else if (cmbYetki.SelectedIndex == 2)
                yetki = 1;
            if (txtYKullaniciAdi.Text == "" || txtYAd.Text == "" || txtYSoyad.Text == "" || yetki == -1 || txtYMail.Text == "")
            {
                InfService.ShowMessage("Lütfen bilgileri eksiksiz bir şekilde doldurunuz.", "Please fill in the information completely.");
            }
            else
            {
                Kullanicilar varOlanKullanici = Context._context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtYKullaniciAdi.Text);
                if (varOlanKullanici != null)
                {
                    InfService.ShowMessage("Bu kullanıcı adı zaten mevcut. Farklı bir kullanıcı adı deneyiniz.", "Username already exists. Try a different username.");

                }
                else
                {
                    Kullanicilar kullanici = new Kullanicilar()
                    {
                        KullaniciAdi = txtYKullaniciAdi.Text,
                        Ad = txtYAd.Text,
                        Soyad = txtYSoyad.Text,
                        YetkiId = yetki,
                        Mail = txtYMail.Text,
                        Sifre = "net1"
                    };
                    Context._context.Kullanicilar.Add(kullanici);
                    Context._context.SaveChanges();
                    InfService.ShowMessage("Kullanıcı kayıt işlemi başarılı: Sistem tarafından atanan şifre: net1", "User registration successful: System assigned password: net1");
                    SayfayıYenile();
                }

            }
        }

        private int sayacKSil = 0;
        private void diğerAyarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sayacKSil == 0)
            {
                ayarlarTabControl.TabPages.Add(tabPageDigerAyarlar);
                List<Kullanicilar> kullanicilar = KullanicilariListele();
                foreach (var kullanici in kullanicilar)
                {
                    string yetki = "";
                    if (systemLanguage == "Turkish")
                         yetki = kullanici.YetkiId == 0 ? "Admin" : "Antrenör";
                    else if(systemLanguage == "English")
                        yetki = kullanici.YetkiId == 0 ? "Admin" : "Coach";
                    gridViewKullanicilar.Rows.Add(new object[]
                    {
                        kullanici.Id,
                        kullanici.KullaniciAdi,
                        kullanici.Ad,
                        kullanici.Soyad,
                        yetki
                    });
                }
            }
            ayarlarTabControl.SelectedTab = tabPageDigerAyarlar;
            sayacKSil++;
        }
        private void SayfayıYenile()
        {
            gridViewKullanicilar.Rows.Clear();
            List<Kullanicilar> kullanicilar = KullanicilariListele();
            foreach (var kullanici in kullanicilar)
            {
                string yetki = kullanici.YetkiId == 0 ? "Admin" : "Antrenör";
                gridViewKullanicilar.Rows.Add(new object[]
                {
                        kullanici.Id,
                        kullanici.KullaniciAdi,
                        kullanici.Ad,
                        kullanici.Soyad,
                        yetki
                });
            }
        }

        private void görüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmAntrenmanAyarlari == null || _frmAntrenmanAyarlari.IsDisposed)
            {
                _frmAntrenmanAyarlari = new FrmAntrenmanAyarlari();
                _frmAntrenmanAyarlari.Show();
            }
        }

        private void dilSeçenekleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmDilSecenekleri == null || _frmDilSecenekleri.IsDisposed)
            {
                _frmDilSecenekleri = new FrmDilSecenekleri();
                _frmDilSecenekleri.Show();
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kullanici == null)
            {
                InfService.ShowMessage("Lütfen düzenlemek istediğiniz kullanıcıyı önce seçiniz.", "Please select the user you want to edit first.");
            }
            else
            {
                if (_frmKullaniciDuzenleme == null || _frmKullaniciDuzenleme.IsDisposed)
                {
                    _frmKullaniciDuzenleme = new frmKullaniciDuzenleme(kullanici);
                    _frmKullaniciDuzenleme.Show();
                }
            }
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            ayarlarTabControl.TabPages.Remove(tabPageDigerAyarlar);
            Kullanicilar kullanici = DbService.GetUser(Context.kullanici.Id);
            string yetki = kullanici.YetkiId == 0 ? "Admin" : "Antrenör";
            if (yetki == "Admin")
            {
                kullanıcıToolStripMenuItem.Visible = true;
            }
            else
            {
                kullanıcıToolStripMenuItem.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayfayıYenile();
        }

        private void sporcuAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_frmSporcuAtama == null || _frmSporcuAtama.IsDisposed)
            {
                _frmSporcuAtama = new FrmSporcuAtama();
                _frmSporcuAtama.Show();
            }
        }
        private int KId = 0;
        private void gridViewKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = gridViewKullanicilar.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gridViewKullanicilar.Rows[selectedrowindex];
            KId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            string kAd, kSoyad, kYetki;
            kAd = Convert.ToString(selectedRow.Cells["Ad"].Value);
            kSoyad = Convert.ToString(selectedRow.Cells["Soyad"].Value);
            kYetki = Convert.ToString(selectedRow.Cells["Yetki"].Value);

            //Duzenlenecek kullanıcı 

            kullanici = Context._context.Kullanicilar.FirstOrDefault(k => k.Id == KId);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KId == 0)
            {
                InfService.ShowMessage("Silmek istediğiniz kullanıcıyı seçiniz.", "Select the user you want to delete.");
            }
            else
            {
                Kullanicilar silinecekKullanici = Context._context.Kullanicilar.FirstOrDefault(k => k.Id == KId);
                if (silinecekKullanici != null)
                {
                    
                    if (InfService.ShowMessage($"{silinecekKullanici.Ad} {silinecekKullanici.Soyad} isimli kullanıcıyı silmek istediğinize emin misiniz ? ", $"Are you sure you want to delete {silinecekKullanici.Ad} {silinecekKullanici.Soyad}",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Context._context.Kullanicilar.Remove(silinecekKullanici);
                        Context._context.SaveChanges();
                        InfService.ShowMessage("Kullanıcı başarılı bir şekilde silinmiştir.", "The user has been successfully deleted.");
                        SayfayıYenile();
                    }
                }
                else
                {
                    InfService.ShowMessage("Böyle bir kullanıcı mevcut değil", "No such user exists");
                }
            }
        }

        private void şifreDeğişikliğiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(KId == 0)
            {
                InfService.ShowMessage("Lütfen şifresini sıfırlamak istediğiniz kullanıcıyı seçiniz.", "Please select the user whose password you want to reset.");
            }
            else
            {
                Kullanicilar kullanici = Context._context.Kullanicilar.FirstOrDefault(k => k.Id == KId);
                kullanici.Sifre = "net1";
                Context._context.SaveChanges();
                InfService.ShowMessage("Şifre sıfırlanmıştır. | Atanan şifre:net1", "The password has been reset. | Assigned password: net1");
            }
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(_frmTekliVeriEkleme == null || _frmTekliVeriEkleme.IsDisposed)
            {
                _frmTekliVeriEkleme = new FrmTekliVeriEkleme();
                _frmTekliVeriEkleme.Show();
            }
        }

        private void çokluVeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_frmCokluVeriEkleme == null || _frmCokluVeriEkleme.IsDisposed)
            {
                _frmCokluVeriEkleme = new frmCokluVeriEkleme();
                _frmCokluVeriEkleme.Show();

            }
        }

        private void portAyarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmPortAyari == null || _frmPortAyari.IsDisposed)
            {
                _frmPortAyari = new FrmPortAyari();
                _frmPortAyari.Show();

            }
        }

        private void raporAlToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_frmAyarlarRaporlama == null || _frmAyarlarRaporlama.IsDisposed)
            {
                _frmAyarlarRaporlama = new FrmAyarlarRaporlama();
                _frmAyarlarRaporlama.Show();

            }
        }
    }
}
