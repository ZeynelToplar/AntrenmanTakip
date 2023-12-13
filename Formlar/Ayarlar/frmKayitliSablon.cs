using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.Ayarlar
{
    public partial class frmKayitliSablon : Form
    {
        public frmKayitliSablon()
        {
            InitializeComponent();
        }
        string systemLanguage = "";
        private void frmKayitliSablon_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            var values = Context._context.KayitSablonu.Include(x => x.TopKonumlari).Include(x => x.TopGelisSekilleri).Include(x => x.VurusBicimleri).ToList();

            foreach (var item in values)
            {
                if (systemLanguage == "Turkish")
                {
                    gridViewSablonlar.Rows.Add(new object[]
                    {
                        item.ID,
                        item.TK,
                        item.TGS,
                        item.VB,
                        $"{item.TopKonumlari.Adi} - {item.TopGelisSekilleri.Adi} - {item.VurusBicimleri.Adi}",
                        $"Hedef {item.VK1}",
                        $"Hedef {item.VK2}",
                        $"Hedef {item.VK3}",
                        $"Hedef {item.VK4}",
                        $"Hedef {item.VK5}",
                        $"Hedef {item.VK6}",
                        $"Hedef {item.VK7}",
                        $"Hedef {item.VK8}",
                        $"Hedef {item.VK9}",
                        $"Hedef {item.VK10}",
                    });
                }
                else if (systemLanguage == "English")
                {
                    gridViewSablonlar.Rows.Add(new object[]
                    {
                        item.ID,
                        item.TK,
                        item.TGS,
                        item.VB,
                        $"{item.TopKonumlari.EAdi} - {item.TopGelisSekilleri.EAdi} - {item.VurusBicimleri.Adi}",
                        $"Target {item.VK1}",
                        $"Target {item.VK2}",
                        $"Target {item.VK3}",
                        $"Target {item.VK4}",
                        $"Target {item.VK5}",
                        $"Target {item.VK6}",
                        $"Target {item.VK7}",
                        $"Target {item.VK8}",
                        $"Target {item.VK9}",
                        $"Target {item.VK10}",
                    });
                }
            }
        }
    }
}
