using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.Ayarlar
{
    public partial class FrmMailGonderme : Form
    {
        private FrmMailOnay _frmMailOnay;

        string systemLanguage = "";
        public FrmMailGonderme()
        {
            InitializeComponent();
        }

        private void btnKodGonder_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int kod = random.Next(1000, 9999);
            string mail = txtMail.Text;
            var mail_ = Context._context.Kullanicilar.FirstOrDefault(x => x.Mail == mail);
           
            if(mail == "")
            {
                InfService.ShowMessage("Mail adresini alanını boş geçemezsiniz.", "You cannot leave the e-mail address field blank.");
            }
            else
            {
                var kullanici = Context._context.Kullanicilar.FirstOrDefault(k => k.Mail == mail);
                if (kullanici != null)
                {
                    Context.kullanici = kullanici;
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress("teamsolid42@hotmail.com");
                    message.To.Add(txtMail.Text);
                    message.Subject = "Şifre Sıfırlama";
                    if (systemLanguage == "Turkish")
                        message.Body = $"Onay Kodunuz: {kod}";
                    else if (systemLanguage == "English")
                        message.Body = $"Your information code: {kod}";

                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Credentials = new NetworkCredential("teamsolid42@hotmail.com", "solid2022");
                    smtpClient.EnableSsl = true;
                    smtpClient.Host = "smtp.outlook.com";
                    smtpClient.Port = 587;
                    smtpClient.Send(message);
                    InfService.ShowMessage("Onay kodu gönderildi.", "Confirmation code sent.");
                    this.Close();
                    _frmMailOnay = new FrmMailOnay();
                    _frmMailOnay.kod = kod;
                    _frmMailOnay.Show();
                }
                else
                {
                    InfService.ShowMessage("Var olan mail adresi giriniz.", "Enter your existing e-mail address.");
                }
            }
        }

        private void FrmMailGonderme_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
        }
    }
}
