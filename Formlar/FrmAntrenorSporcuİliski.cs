using AntrenmanTakip.Formlar.Ayarlar;
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

namespace AntrenmanTakip.Formlar
{
    public partial class FrmAntrenorSporcuİliski : Form
    {
        private FrmAyarlar _frmAyarlar;
        public FrmAntrenorSporcuİliski()
        {
            InitializeComponent();
        }
        object antrenorId = null;
        string systemLanguage = DbService.GetApplicationLanguage();
        private void FrmAntrenorSporcuİliski_Load(object sender, EventArgs e)
        {
            var antrenorler = Context._context.Kullanicilar.Where(k => k.YetkiId == 1).Select(k => new 
            {
                Id = k.Id,
                AdSoyad = k.Ad + " " + k.Soyad
            }).ToList();
            cmbAntrenorler.DataSource = antrenorler;
            cmbAntrenorler.ValueMember = "Id";
            cmbAntrenorler.DisplayMember = "AdSoyad";
            antrenorId = (cmbAntrenorler.SelectedValue);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            gridViewSporcular.Rows.Clear();
            int antId = Convert.ToInt32(antrenorId);
            var sporcular = Context._context.KullaniciSporcular.Include(ks => ks.Sporcular).Where(k => k.KullaniciId == antId).ToList();
            foreach (var sporcu in sporcular)
            {
                gridViewSporcular.Rows.Add(new object[]
                {
                    sporcu.Sporcular.Id,
                    sporcu.Sporcular.Ulke,
                    sporcu.Sporcular.Adi,
                    sporcu.Sporcular.Soyadi,
                    sporcu.Sporcular.Yas,
                    sporcu.Sporcular.Boy,
                    sporcu.Sporcular.Kilo,
                    sporcu.Sporcular.DogumTarihi,
                    sporcu.Sporcular.Mevkiler.Adi
                });
            }
        }
        private void cmbAntrenorler_SelectedIndexChanged(object sender, EventArgs e)
        {
            antrenorId = (cmbAntrenorler.SelectedValue);
        }

        List<int> sporcular = null;
        private void gridViewSporcular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sporcular = new List<int>();
            for (int i = 0; i < gridViewSporcular.SelectedRows.Count; i++)
            {
                var selectedrow = gridViewSporcular.SelectedRows[i].Cells[0].Value;
                sporcular.Add(Convert.ToInt32(selectedrow));
            }
        }

        private void btnAtamaKaldir_Click(object sender, EventArgs e)
        {
            if(sporcular == null || sporcular[0] == 0) 
            {
                InfService.ShowMessage("Kaldırılacak sporcuları seçiniz.", "Please select the player whose assigments will be cancelled.");
            }
            else
            {
                for (int i = 0; i < sporcular.Count; i++)
                {
                    int antId = Convert.ToInt32(antrenorId);
                    int sporcuId = sporcular[i];
                    var deletedEntity = Context._context.KullaniciSporcular.FirstOrDefault(ks => ks.KullaniciId == antId && ks.SporcuId == sporcuId);
                    Context._context.KullaniciSporcular.Remove(deletedEntity);
                    Context._context.SaveChanges();
                }
                InfService.ShowMessage("İşlem başarılı.", "Process Succesfully");
                btnListele_Click(sender, e);
            }
            
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if(_frmAyarlar == null || _frmAyarlar.IsDisposed)
            {
                _frmAyarlar = new FrmAyarlar();
                _frmAyarlar.Show();
            }
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
    }
}
