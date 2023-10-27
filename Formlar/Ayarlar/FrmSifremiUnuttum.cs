﻿using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using System;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.Ayarlar
{
    public partial class FrmSifremiUnuttum : Form
    {
        string systemLanguage = "";
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kullanici = Context._context.Kullanicilar.Find(Context.kullanici.Id);
            if(kullanici != null)
            {
                if(txtSifre.Text == txtSifreTekrar.Text)
                {
                    kullanici.Sifre = txtSifre.Text;
                    Context._context.SaveChanges();
                    this.Close();
                    if (systemLanguage == "Turkish")
                        MessageBox.Show("Şifre başarıyla sıfırlanmıştır.");
                    else
                        MessageBox.Show("The password has been reset successfully.");
                }
                else
                {
                    if(systemLanguage == "Turkish")
                        MessageBox.Show("Şifreler uyuşmamaktadır.");
                    else
                        MessageBox.Show("Passwords do not match.");
                }
            }
        }

        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
        }
    }
}
