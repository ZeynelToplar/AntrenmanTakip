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
    public partial class FrmSporcuAtama : Form
    {
        public FrmSporcuAtama()
        {
            InitializeComponent();
        }
        string systemLanguage = "";
        private void FrmSporcuAtama_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            var antrenorler = Context._context.Kullanicilar.Where(k => k.YetkiId == 1).ToList();
            foreach (var item in antrenorler)
            {
                string yetki = "";
                if (systemLanguage == "Turkish")
                    yetki = "Antrenör";
                else if (systemLanguage == "English")
                    yetki = "Coach";
                gridViewAntrenorler.Rows.Add(new object[]
                {
                    item.Id,
                    item.KullaniciAdi,
                    item.Ad,
                    item.Soyad,
                    yetki
                });
            }

            var sporcular = Context._context.Sporcular.Include(x => x.Mevkiler).ToList();
            foreach (var item in sporcular)
            {
                gridViewSporcular.Rows.Add(new object[]
                {
                    item.Id,
                    item.Adi,
                    item.Soyadi,
                    item.Yas,
                    item.Kilo,
                    item.Boy,
                    item.Mevkiler.Adi,
                });
            }
        }


        List<int> sporcular = null;
        List<int> antrenorler = null;
        private void gridViewAntrenorler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            antrenorler = new List<int>();
            for (int i = 0; i < gridViewAntrenorler.SelectedRows.Count; i++)
            {
                var selectedrow = gridViewAntrenorler.SelectedRows[i].Cells[0].Value;
                antrenorler.Add(Convert.ToInt32(selectedrow));
            }
        }

        private void gridViewSporcular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sporcular = new List<int>();
            for (int i = 0; i < gridViewSporcular.SelectedRows.Count; i++)
            {
                var selectedrow = gridViewSporcular.SelectedRows[i].Cells[0].Value;
                sporcular.Add(Convert.ToInt32(selectedrow));
            }
        }
        private void btnAtama_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < antrenorler.Count; i++)
            {
                for (int j = 0; j < sporcular.Count; j++)
                {
                    int kullaniciId = Convert.ToInt32(antrenorler[i]);
                    int sporcuId = Convert.ToInt32(sporcular[j]);
                    var kSporcu = Context._context.KullaniciSporcular.FirstOrDefault(k => k.KullaniciId == kullaniciId && k.SporcuId == sporcuId);
                    if(kSporcu == null)
                    {
                        KullaniciSporcular kullaniciSporcular = new KullaniciSporcular()
                        {
                            KullaniciId = Convert.ToInt32(antrenorler[i]),
                            SporcuId = Convert.ToInt32(sporcular[j])
                        };
                        Context._context.KullaniciSporcular.Add(kullaniciSporcular);
                        Context._context.SaveChanges();
                    }
                }
            }
            if(systemLanguage == "Turkish")
                MessageBox.Show("Atama işlemi başarıyla gerçekleşti.");
            else if(systemLanguage == "English")
                MessageBox.Show("The assignment was successful.");
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
    }
}
