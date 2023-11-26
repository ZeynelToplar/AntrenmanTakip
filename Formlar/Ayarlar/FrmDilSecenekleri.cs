using AntrenmanTakip.Persistence;
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
    public partial class FrmDilSecenekleri : Form
    {
        public FrmDilSecenekleri()
        {
            InitializeComponent();
        }

        string systemLanguage = "";
        private void FrmDilSecenekleri_Load(object sender, EventArgs e)
        {
            systemLanguage = Context._context.Diller.Where(d => d.Selected).First().Language;
            if(systemLanguage == "Turkish")
                radioTurkce.Checked = true;
            else 
                radioIngilizce.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var diller = Context._context.Diller.ToList();
            if (radioIngilizce.Checked)
            {
                foreach (var dil in diller)
                {
                    if (dil.Language == "English")
                        dil.Selected = true;
                    else
                        dil.Selected = false;
                }
            }
            else if (radioTurkce.Checked)
            {
                foreach (var dil in diller)
                {
                    if (dil.Language == "Turkish")
                        dil.Selected = true;
                    else
                        dil.Selected = false;

                }
            }
            Context._context.SaveChanges();
            var selectedLanguage = Context._context.Diller.Where(d => d.Selected).First();
            if (selectedLanguage.Language == "Turkish")
                FrmCustomMessageBox.Show("Dil değişikliği başarılı. Dil değişikliğini uygulamak için programı yeniden başlatın.");
            else if (selectedLanguage.Language == "English")
                FrmCustomMessageBox.Show("Language change successful. Restart the program to apply the language change.");
            // this.Close();


        }
    }
}

