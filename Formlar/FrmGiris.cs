using AntrenmanTakip.Formlar.Ayarlar;
using AntrenmanTakip.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar
{
    public partial class FrmGiris : Form
    {
        private Form1 frm1;
        private FrmMailGonderme _frmMailGonderme;
        public FrmGiris()
        {
            InitializeComponent();
        }

        Diller dil;
        private void FrmGiris_Load(object sender, EventArgs e)
        {
            dil = Context._context.Diller.FirstOrDefault(d => d.Selected);
            if (dil.Language == "Turkish")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            }
            else if (dil.Language == "English")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            }

            this.Controls.Clear();
            InitializeComponent();
        }

        private void FrmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                if(dil.Language == "Turkish")
                    MessageBox.Show("Lütfen bilgilerinizi giriniz.", "Uyarı");
                else if(dil.Language == "English")
                    MessageBox.Show("Please enter your information.", "Warning");
            }
            else
            {
                Kullanicilar kullanici = Context._context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text);
                if (kullanici != null)
                {
                    frm1 = new Form1();
                    Context.kullanici = kullanici;
                    frm1.Show();
                    this.Hide();

                }
                else
                {
                    if(dil.Language == "Turkish")
                        MessageBox.Show("Bilgiler hatalı, lütfen bilgilerinizi kontrol ediniz.", "Uyarı");
                    else if(dil.Language == "English")
                        MessageBox.Show("The information is incorrect, please check your information.","Warning");
                }
            }
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            if (_frmMailGonderme == null || _frmMailGonderme.IsDisposed)
            {
                _frmMailGonderme = new FrmMailGonderme();
                _frmMailGonderme.Show();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmGiris_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                if (dil.Language == "Turkish")
                    MessageBox.Show("Lütfen bilgilerinizi giriniz.", "Uyarı");
                else if (dil.Language == "English")
                    MessageBox.Show("Please enter your information.", "Warning");
            }
            else
            {
                Kullanicilar kullanici = Context._context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text);
                if (kullanici != null)
                {
                    frm1 = new Form1();
                    Context.kullanici = kullanici;
                    frm1.Show();
                    this.Hide();

                }
                else
                {
                    if (dil.Language == "Turkish")
                        MessageBox.Show("Bilgiler hatalı, lütfen bilgilerinizi kontrol ediniz.", "Uyarı");
                    else if (dil.Language == "English")
                        MessageBox.Show("The information is incorrect, please check your information.", "Warning");
                }
            }
        }

        private void FrmGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
                {
                    if (dil.Language == "Turkish")
                        MessageBox.Show("Lütfen bilgilerinizi giriniz.", "Uyarı");
                    else if (dil.Language == "English")
                        MessageBox.Show("Please enter your information.", "Warning");
                }
                else
                {
                    Kullanicilar kullanici = Context._context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text);
                    if (kullanici != null)
                    {
                        frm1 = new Form1();
                        Context.kullanici = kullanici;
                        frm1.Show();
                        this.Hide();

                    }
                    else
                    {
                        if (dil.Language == "Turkish")
                            MessageBox.Show("Bilgiler hatalı, lütfen bilgilerinizi kontrol ediniz.", "Uyarı");
                        else if (dil.Language == "English")
                            MessageBox.Show("The information is incorrect, please check your information.", "Warning");
                    }
                }
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
                {
                    if (dil.Language == "Turkish")
                        MessageBox.Show("Lütfen bilgilerinizi giriniz.", "Uyarı");
                    else if (dil.Language == "English")
                        MessageBox.Show("Please enter your information.", "Warning");
                }
                else
                {
                    Kullanicilar kullanici = Context._context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text);
                    if (kullanici != null)
                    {
                        frm1 = new Form1();
                        Context.kullanici = kullanici;
                        frm1.Show();
                        this.Hide();

                    }
                    else
                    {
                        if (dil.Language == "Turkish")
                            MessageBox.Show("Bilgiler hatalı, lütfen bilgilerinizi kontrol ediniz.", "Uyarı");
                        else if (dil.Language == "English")
                            MessageBox.Show("The information is incorrect, please check your information.", "Warning");
                    }
                }
            }
        }
    }
}
