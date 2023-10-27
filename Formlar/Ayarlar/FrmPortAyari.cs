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
using AntrenmanTakip.Formlar.Ayarlar;

namespace AntrenmanTakip.Formlar.Ayarlar
{
    public partial class FrmPortAyari : Form
    {
        string systemLanguage = "";
        public FrmPortAyari()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            var ayar = Context._context.PortAyari.FirstOrDefault(x => x.Id == 1);
            ayar.Port = txtPort.Text;
            using (DbAntrenmanTakipEntities context = new DbAntrenmanTakipEntities())
            {
                var updatedEntity = context.Entry(ayar);
                updatedEntity.State = System.Data.Entity.EntityState.Modified;
                await context.SaveChangesAsync();
                if(systemLanguage == "Turkish")
                    MessageBox.Show("Port başarıyla değiştirildi.");
                else if(systemLanguage == "English")
                    MessageBox.Show("The port has been successfully changed.");
            }
        }

        private void FrmPortAyari_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            var port = Context._context.PortAyari.FirstOrDefault(x => x.Id == 1);
            txtPort.Text = port.Port;
            Global.Port = port.Port;
        }
    }
}
