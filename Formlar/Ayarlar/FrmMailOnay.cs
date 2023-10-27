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
    public partial class FrmMailOnay : Form
    {
        private FrmSifremiUnuttum _frmSifremiUnuttum;
        public int kod;
        public FrmMailOnay()
        {
            InitializeComponent();
        }
        string systemLanguage = "";
        private void FrmMailOnay_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int kod_ = Convert.ToInt32(txtOnayKodu.Text);
            if(kod_ == null)
            {
                if(systemLanguage == "Turkish")
                    MessageBox.Show("Lütfen mailinize gelen onay kodunu giriniz.");
                else
                    MessageBox.Show("Please enter the confirmation code sent to your e-mail.");
            }
            else
            {
                if(kod_ == kod) 
                {
                    this.Close();
                    _frmSifremiUnuttum = new FrmSifremiUnuttum();
                    _frmSifremiUnuttum.Show();
                }
                else
                {
                    if(systemLanguage == "Turkish")
                        MessageBox.Show("Geçersiz kod");
                    else
                        MessageBox.Show("Invalid code");
                }
            }
        }
    }
}
