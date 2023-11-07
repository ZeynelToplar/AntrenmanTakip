using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.Ayarlar
{
    public partial class frmKullaniciDuzenleme : Form
    {
        public Kullanicilar _kullanici;
        public frmKullaniciDuzenleme(Kullanicilar kullanici)
        {
            InitializeComponent();
            _kullanici = new Kullanicilar()
            {
                Id = kullanici.Id,
                KullaniciAdi = kullanici.KullaniciAdi,
                Ad = kullanici.Ad,
                Soyad = kullanici.Soyad,
                YetkiId = kullanici.YetkiId,
                Mail = kullanici.Mail
            };
        }
        string systemLanguage = "";
        private void frmKullaniciDuzenleme_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            if (systemLanguage == "Turkish")
            {
                cmbYetki.Items.AddRange(new object[]
                {
                    "Admin",
                    "Antrenör"
                });
            }
            else
            {
                cmbYetki.Items.AddRange(new object[]
                {
                    "Admin",
                    "Coach"
                });
            }
            txtKullaniciAdi.Text = _kullanici.KullaniciAdi;
            txtAd.Text = _kullanici.Ad;
            txtSoyad.Text = _kullanici.Soyad;
            cmbYetki.SelectedIndex = _kullanici.YetkiId;
            txtMail.Text = _kullanici.Mail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            if (systemLanguage == "Turkish")
                message = $"Kullanıcının bilgilerini değiştirmek istediğinize emin misiniz ?";
            else if (systemLanguage == "English")
                message = $"Are you sure you want to change the user's information? ?";
            if (MessageBox.Show(message, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Kullanicilar kullanici = Context._context.Kullanicilar.FirstOrDefault(k => k.Id == _kullanici.Id);
                kullanici.KullaniciAdi = txtKullaniciAdi.Text;
                kullanici.Ad = txtAd.Text;
                kullanici.Soyad = txtSoyad.Text;
                kullanici.YetkiId = cmbYetki.SelectedIndex;
                kullanici.Mail = txtMail.Text;
                Context._context.SaveChanges();
                if(systemLanguage == "Turkish")
                    MessageBox.Show("Kullanıcı bilgileri başarıyla düzenlenmiştir.");
                else if(systemLanguage == "English")
                    MessageBox.Show("User information has been successfully edited.");
                this.Close();
            }
        }
    }
}
