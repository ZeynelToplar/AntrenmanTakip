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
                string mevki = "";
                if (systemLanguage == "English")
                {
                    mevki = InfService.ConvertToEnglish(item.Mevkiler.Adi);
                    gridViewSporcular.Rows.Add(new object[]
                    {
                        item.Id,
                        item.Adi,
                        item.Soyadi,
                        item.Yas,
                        item.Kilo,
                        item.Boy,
                        mevki,
                    });
                }
                else if(systemLanguage == "Turkish")
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
            if(antrenorler == null || sporcular == null)
            {
                InfService.ShowMessage("Lütfen sporcu ve antrenör seçimini yapınız.", "Please select the player and coach.");
            }
            else
            {
                int result = 0;
                for (int i = 0; i < antrenorler.Count; i++)
                {
                    if(antrenorler.Count > 1)
                    {
                        InfService.ShowMessage("Lütfen sadece bir tane antrenör seçiniz", "Please choose only one coach");
                        break;
                    }
                    for (int j = 0; j < sporcular.Count; j++)
                    {
                        int kullaniciId = Convert.ToInt32(antrenorler[i]);
                        int sporcuId = Convert.ToInt32(sporcular[j]);
                        var kSporcu = Context._context.KullaniciSporcular.FirstOrDefault(k => k.KullaniciId == kullaniciId && k.SporcuId == sporcuId); // hem antrenor hem sporcu eslesmesi kontrol ediliyor 
                        var kSporcu_ = Context._context.KullaniciSporcular.FirstOrDefault(k => k.SporcuId == sporcuId); // sadece sporcuyu cektigimiz kisim ki burada bu sporcu birine atanmis mi diye kontrol ediyoruz
                        var sporcu = Context._context.Sporcular.FirstOrDefault(s => s.Id == sporcuId);
                        if (kSporcu_ != null)
                        {
                            if(kSporcu != null)
                            {
                                InfService.ShowMessage($"{sporcu.Adi} {sporcu.Soyadi} isimli sporcu zaten seçtiğiniz antrenöre atanmıştır.", $"The player named {sporcu.Adi} {sporcu.Soyadi} has already been assigned to the coach you selected.");
                            }
                            else
                            {
                                if (InfService.ShowMessage($"{sporcu.Adi} {sporcu.Soyadi} isimli sporcu farklı bir antrenöre atanmış durumda, değiştirmek istediğinize emin misiniz ?", $"The player named {sporcu.Adi} {sporcu.Soyadi} has been assigned to a different coach. Are you sure you want to change it ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    kSporcu_.KullaniciId = Convert.ToInt32(antrenorler[i]);
                                }
                                result = Context._context.SaveChanges();
                            }
                        }
                        else
                        {
                            KullaniciSporcular kullaniciSporcular = new KullaniciSporcular()
                            {
                                KullaniciId = Convert.ToInt32(antrenorler[i]),
                                SporcuId = Convert.ToInt32(sporcular[j])
                            };
                            Context._context.KullaniciSporcular.Add(kullaniciSporcular);
                            result = Context._context.SaveChanges();
                        }
                    }
                    if(result == 1)
                    {
                        InfService.ShowMessage("İşlem başarıyla gerçekleşti.", "the transaction was completed successfully");
                    }
                }
            }
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
