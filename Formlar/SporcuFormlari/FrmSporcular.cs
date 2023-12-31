﻿using AntrenmanTakip.Formlar.Ayarlar;
using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    public partial class FrmSporcular : Form
    {
        private Form1 _form1;
        private FrmAntrenmanSecenekleri _frmAntrenmanSecenekleri;
        private FrmAyarlar _frmAyarlar;
        private FrmSporcuProfil _frmSporcuProfil;
        private FrmSporcuResimEkle _frmSporcuResimEkle;
        public FrmSporcular()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar authenticateUser = DbService.GetUser(Context.kullanici.Id);
            if (txtAd.Text == "" || txtSoyad.Text == "" || numBoy.Text == "0" || numKilo.Text == "0")
            {
                InfService.ShowMessage("Lütfen gerekli bilgileri giriniz", "Please enter the required information");
            }
            else
            {
                if (authenticateUser.YetkiId == 0)
                {
                    if (txtId.Text != "")
                    {
                        int id = Convert.ToInt32(txtId.Text);
                        Sporcular _sporcu = Context._context.Sporcular.FirstOrDefault(s => s.Id == id);
                        if (_sporcu != null)
                        {
                            InfService.ShowMessage("Bu bilgilere sahip bir sporcu zaten mevcut.", "A player with this information already exists.");
                        }
                    }
                    else
                    {
                        int mevki = Convert.ToInt32(cmbMevki.SelectedValue);
                        int yas = YasHesapla(dateTimePicker1.Value);
                        Sporcular sporcu = new Sporcular()
                        {
                            Adi = txtAd.Text,
                            Soyadi = txtSoyad.Text,
                            Yas = yas,
                            Kilo = Convert.ToInt32(numKilo.Text),
                            Boy = Convert.ToInt32(numBoy.Text),
                            Ulke = Convert.ToInt32(txtUlke.SelectedValue),
                            MevkiId = mevki,
                            ResimId = 14,
                            DogumTarihi = dateTimePicker1.Value
                        };
                        Context._context.Sporcular.Add(sporcu);
                        Context._context.SaveChanges();
                        InfService.ShowMessage($"{txtAd.Text} {txtSoyad.Text} isimli sporcu başarıyla eklendi.", $"The player named {txtAd.Text} {txtSoyad.Text} has been successfully added.");
                        gridViewSporcular.Rows.Clear();
                        FrmSporcular_Load(sender, e);
                        Clear();
                    }

                }
                else if (authenticateUser.YetkiId == 1)
                {
                    if (txtId.Text != "")
                    {
                        Sporcular _sporcu = Context._context.Sporcular.FirstOrDefault(s => s.Id == Convert.ToInt32(txtId.Text));
                        if (_sporcu != null)
                        {
                            InfService.ShowMessage("Bu bilgilere sahip bir sporcu zaten mevcut.", "A player with this information already exists.");
                        }
                    }
                    else
                    {
                        int mevki = Convert.ToInt32(cmbMevki.SelectedValue);
                        
                        int yas = YasHesapla(dateTimePicker1.Value);
                        Sporcular sporcu = new Sporcular()
                        {
                            Adi = txtAd.Text,
                            Soyadi = txtSoyad.Text,
                            Yas = yas,
                            Kilo = Convert.ToInt32(numKilo.Text),
                            Boy = Convert.ToInt32(numBoy.Text),
                            Ulke = Convert.ToInt32(txtUlke.SelectedValue),
                            MevkiId = mevki,
                            ResimId = 14,
                            DogumTarihi = dateTimePicker1.Value
                        };
                        Context._context.Sporcular.Add(sporcu);
                        Context._context.SaveChanges();
                        KullaniciSporcular kullaniciSporcu = new KullaniciSporcular()
                        {
                            KullaniciId = authenticateUser.Id,
                            SporcuId = sporcu.Id
                        };
                        Context._context.KullaniciSporcular.Add(kullaniciSporcu);
                        Context._context.SaveChanges();
                        InfService.ShowMessage($"{txtAd.Text} {txtSoyad.Text} isimli sporcu başarıyla eklendi.", $"The player named {txtAd.Text} {txtSoyad.Text} has been successfully added.");
                        gridViewSporcular.Rows.Clear();
                        FrmSporcular_Load(sender, e);
                        Clear();
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == null || txtSoyad.Text == null ||  numBoy.Text == "0" || numKilo.Text == "0")
            {
                InfService.ShowMessage("Lütfen silmek istediğiniz sporcuyu seçiniz!", "Please select the player you want to delete!");
            }
            else
            {
                if (Context.kullanici.YetkiId == 1)
                {
                    if (InfService.ShowMessage($"{txtAd.Text} {txtSoyad.Text} isimli sporcuyu silmek istediğinize emin misiniz ?", $"Are you sure you want to delete the player named {txtAd.Text} {txtSoyad.Text} ?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(txtId.Text);
                        Sporcular sporcu = Context._context.Sporcular.FirstOrDefault(s => s.Id == id);
                        if (sporcu != null)
                        {
                            KullaniciSporcular kullaniciSporcu = Context._context.KullaniciSporcular.FirstOrDefault(ks => ks.KullaniciId == Context.kullanici.Id && ks.SporcuId == sporcu.Id);
                            Context._context.KullaniciSporcular.Remove(kullaniciSporcu);
                        }
                        InfService.ShowMessage($"{txtAd.Text} {txtSoyad.Text} isimli sporcu başarıyla silinmiştir.", $"The player named {txtAd.Text} {txtSoyad.Text} has been deleted successfully.");
                    }
                }
                else if (Context.kullanici.YetkiId == 0)
                {
                    if (InfService.ShowMessage($"Admin yetkisine sahip olduğunuz için sporcuyu sildiğiniz takdirde sistemdeki herhangi bir antrenör sporcuyu göremeyecektir. Silmek istediğinize emin misiniz ?", $"If you delete the player because you have admin authority, any coach in the system will not be able to see the athlete. Are you sure you want to delete it?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(txtId.Text);
                        Sporcular sporcu = Context._context.Sporcular.FirstOrDefault(s => s.Id == id);
                        if (sporcu != null)
                        {
                            List<KullaniciSporcular> kullaniciSporcu = Context._context.KullaniciSporcular.Where(ks => ks.SporcuId == sporcu.Id).ToList();
                            Context._context.Sporcular.Remove(sporcu);
                            Context._context.KullaniciSporcular.RemoveRange(kullaniciSporcu);
                        }
                        InfService.ShowMessage($"{txtAd.Text} {txtSoyad.Text} isimli sporcu başarıyla silinmiştir.", $"The player named {txtAd.Text} {txtSoyad.Text} has been successfully deleted.");
                    }
                }
                Context._context.SaveChanges();
                gridViewSporcular.Rows.Clear();
                FrmSporcular_Load(sender, e);
                Clear();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == null || txtSoyad.Text == null || numBoy.Text == "0" || numKilo.Text == "0")
            {
                InfService.ShowMessage("Lütfen güncellemek istediğiniz sporcuyu seçiniz!", "Please select the player you want to update!");
            }
            else
            {
                if (InfService.ShowMessage($"{txtAd.Text} {txtSoyad.Text} isimli sporcunun bilgilerini güncellemek istediğinize emin misiniz ?", $"Are you sure you want to update the information of {txtAd.Text} {txtSoyad.Text} ?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int txtId_ = Convert.ToInt32(txtId.Text);
                    Sporcular sporcu = Context._context.Sporcular.FirstOrDefault(s => s.Id == txtId_);
                    if (sporcu != null)
                    {
                        sporcu.Adi = txtAd.Text;
                        sporcu.Soyadi = txtSoyad.Text;
                        sporcu.Yas = Convert.ToInt32(numYas.Value);
                        sporcu.Boy = Convert.ToInt32(numBoy.Text);
                        sporcu.Kilo = Convert.ToInt32(numKilo.Text);
                        sporcu.MevkiId = Convert.ToInt32(cmbMevki.SelectedValue);
                        sporcu.DogumTarihi = dateTimePicker1.Value;
                        sporcu.Ulke = Convert.ToInt32(txtUlke.SelectedValue);
                        Context._context.SaveChanges();
                        InfService.ShowMessage("Güncelleme işlemi başarılı.", "The update was successful.");
                        gridViewSporcular.Rows.Clear();
                        FrmSporcular_Load(sender, e);
                        Clear();
                    }
                }
            }
        }

        private void btnAntrenmanGor_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                InfService.ShowMessage("Görüntülemek istediğiniz sporcuyu seçiniz.", "Select the player you want to view.");
            }
            else
            {
                if (_frmAntrenmanSecenekleri == null || _frmAntrenmanSecenekleri.IsDisposed)
                {
                    _frmAntrenmanSecenekleri = new FrmAntrenmanSecenekleri();
                    Context.sporcu = new Sporcular();
                    Context.sporcu.Id = Convert.ToInt32(txtId.Text);
                    _frmAntrenmanSecenekleri.Show();
                    
                }
            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            numBoy.Text = "";
            numKilo.Text = "";
            numYas.Value = 0;
            txtUlke.SelectedIndex = 0;
            cmbMevki.SelectedIndex = 0;
        }
        string systemLanguage = "";
        private void FrmSporcular_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            Kullanicilar authenticateUser = DbService.GetUser(Context.kullanici.Id);
            if (authenticateUser.YetkiId == 0)
            {
                var sporcular = (from s in Context._context.Sporcular
                                 join m in Context._context.Mevkiler on s.MevkiId equals m.Id
                                 join u in Context._context.ulkeler on s.Ulke equals u.Id
                                 select new
                                 {
                                     Id = s.Id,
                                     Adi = s.Adi,
                                     Soyadi = s.Soyadi,
                                     Yas = s.Yas,
                                     Boy = s.Boy,
                                     Kilo = s.Kilo,
                                     Ulke = u,
                                     DogumTarihi = s.DogumTarihi,
                                     Mevkiler = m
                                 }).ToList();
                //gridViewSporcular.DataSource = sporcular;
                foreach (var sporcu in sporcular)
                {
                    string mevki = "";
                    if (systemLanguage == "English")
                    {
                        mevki = InfService.ConvertToEnglish(sporcu.Mevkiler.Adi);
                        gridViewSporcular.Rows.Add(new object[]
                        {
                        sporcu.Id,
                        sporcu.Ulke.Id,
                        sporcu.Ulke.EUlkeAdi,
                        sporcu.Adi,
                        sporcu.Soyadi,
                        sporcu.Yas,
                        sporcu.Boy,
                        sporcu.Kilo,
                        mevki,
                        sporcu.DogumTarihi?.ToString("dddd, dd MMMM yyyy")
                        });
                    }
                    else
                    {
                        gridViewSporcular.Rows.Add(new object[]
                        {
                        sporcu.Id,
                        sporcu.Ulke.Id,
                        sporcu.Ulke.UlkeAdi,
                        sporcu.Adi,
                        sporcu.Soyadi,
                        sporcu.Yas,
                        sporcu.Boy,
                        sporcu.Kilo,
                        sporcu.Mevkiler.Adi,
                        sporcu.DogumTarihi?.ToString("dddd, dd MMMM yyyy")
                        });
                    }
                }

            }
            else if (authenticateUser.YetkiId == 1)
            {
                //List<KullaniciSporcular> sporcular = Context._context.KullaniciSporcular.Include(x => x.Sporcu).ThenInclude(x => x.Mevki).Where(x => x.KullaniciId == authenticateUser.Id).ToList();
                var sporcular = (from ks in Context._context.KullaniciSporcular
                                 join s in Context._context.Sporcular on ks.SporcuId equals s.Id
                                 join m in Context._context.Mevkiler on s.MevkiId equals m.Id
                                 join u in Context._context.ulkeler on s.Ulke equals u.Id
                                 where ks.KullaniciId == authenticateUser.Id
                                 select new
                                 {
                                     Id = s.Id,
                                     Ulke = u,
                                     Adi = s.Adi,
                                     Soyadi = s.Soyadi,
                                     Yas = s.Yas,
                                     Boy = s.Boy,
                                     Kilo = s.Kilo,
                                     Mevkiler = s.Mevkiler,
                                     DogumTarihi = s.DogumTarihi
                                 }).ToList();
                //gridViewSporcular.DataSource = sporcular;
                foreach (var sporcu in sporcular)
                {
                    string mevki = "";
                    if (systemLanguage == "English")
                    {
                        mevki = InfService.ConvertToEnglish(sporcu.Mevkiler.Adi);
                        gridViewSporcular.Rows.Add(new object[]
                        {
                        sporcu.Id,
                        sporcu.Ulke.Id,
                        sporcu.Ulke.EUlkeAdi,
                        sporcu.Adi,
                        sporcu.Soyadi,
                        sporcu.Yas,
                        sporcu.Boy,
                        sporcu.Kilo,
                        mevki,
                        sporcu.DogumTarihi?.ToString("dddd, dd MMMM yyyy")
                        });
                    }
                    else
                    {
                        gridViewSporcular.Rows.Add(new object[]
                        {
                        sporcu.Id,
                        sporcu.Ulke.Id,
                        sporcu.Ulke.UlkeAdi,
                        sporcu.Adi,
                        sporcu.Soyadi,
                        sporcu.Yas,
                        sporcu.Boy,
                        sporcu.Kilo,
                        sporcu.Mevkiler.Adi,
                        sporcu.DogumTarihi?.ToString("dddd, dd MMMM yyyy")
                        });
                    }
                }
            }
            //Mevki seçenekleri
            var mevkiler = Context._context.Mevkiler.ToList();
            cmbMevki.DataSource = mevkiler;
            cmbMevki.ValueMember = "Id";
            //cmbMevki.DisplayMember = "Adi";
            if (systemLanguage == "Turkish")
                cmbMevki.DisplayMember = "Adi";
            else if(systemLanguage == "English")
                cmbMevki.DisplayMember = "EAdi";

            //Ulkeler 
            var ulkeler = Context._context.ulkeler.ToList();
            txtUlke.DataSource = ulkeler;
            txtUlke.ValueMember = "Id";
            if (systemLanguage == "Turkish")
                txtUlke.DisplayMember = "UlkeAdi";
            else if (systemLanguage == "English")
                txtUlke.DisplayMember = "EUlkeAdi";
        }

        private void gridViewSporcular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = gridViewSporcular.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gridViewSporcular.Rows[selectedrowindex];

            var mevki = Convert.ToString(selectedRow.Cells["Mevki"].Value);
            int mevkiId = 0;
            switch (mevki)
            {
                case "Defans":
                    mevkiId = 1;
                    break;
                case "Defense":
                    mevkiId = 1;
                    break;
                case "Kaleci":
                    mevkiId = 2;
                    break;
                case "Goalkeeper":
                    mevkiId = 2;
                    break;
                case "Forvet":
                    mevkiId = 3;
                    break;
                case "Forward":
                    mevkiId = 3;
                    break;
                case "Orta Saha":
                    mevkiId = 4;
                    break;
                case "Midfielder":
                    mevkiId = 4;
                    break;
            }

            try
            {
                txtId.Text = Convert.ToString(selectedRow.Cells["Id"].Value);
                txtAd.Text = Convert.ToString(selectedRow.Cells["Ad"].Value);
                txtSoyad.Text = Convert.ToString(selectedRow.Cells["Soyad"].Value);
                numBoy.Text = (selectedRow.Cells["Boy"].Value).ToString();
                numKilo.Text = (selectedRow.Cells["Kilo"].Value).ToString();
                numYas.Value = Convert.ToInt32(selectedRow.Cells["Yas"].Value);
                txtUlke.SelectedValue = (selectedRow.Cells["UlkeId"].Value);
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["DogumTarihi"].Value);
                cmbMevki.SelectedValue = mevkiId;
            }
            catch (Exception)
            {

                InfService.ShowMessage("Beklenmeyen bir hata ile karşılaşıldı", "An unexpected error was encountered");

            }
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (_frmAyarlar == null || _frmAyarlar.IsDisposed)
            {
                _frmAyarlar = new FrmAyarlar();
                _frmAyarlar.Show();
            }
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfilGor_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                InfService.ShowMessage("Görüntülemek istediğiniz sporcuyu seçiniz.", "Select the player you want to view.");
            }
            else
            {
                if (_frmSporcuProfil == null || _frmSporcuProfil.IsDisposed)
                {
                    _frmSporcuProfil = new FrmSporcuProfil();
                    Context.sporcu = new Sporcular();
                    Context.sporcu.Id = Convert.ToInt32(txtId.Text);
                    _frmSporcuProfil.Show();
                }
            }
        }

        private void resimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                InfService.ShowMessage("Önce sporcuyu seçiniz.", "First select the player.");
            }
            else
            {
                if (_frmSporcuResimEkle == null || _frmSporcuResimEkle.IsDisposed)
                {
                    _frmSporcuResimEkle = new FrmSporcuResimEkle();
                    _frmSporcuResimEkle.sporcuId = Convert.ToInt32(txtId.Text);
                    _frmSporcuResimEkle.Show();
                }
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (txtAd.Text != null || txtSoyad.Text != null || numBoy.Text != "0" || numKilo.Text != "0")
            {
                int yas = YasHesapla(dateTimePicker1.Value);
                numYas.Value = yas;
            }       
        }

        private int YasHesapla(DateTime dogumTarihi)
        {
            if(DateTime.Now.ToShortDateString() != dogumTarihi.ToShortDateString())
            {
                DateTime dogumGunu = dateTimePicker1.Value;
                DateTime bugun = DateTime.Today;
                int yas = bugun.Year - dogumGunu.Year;
                if (dogumGunu > bugun.AddYears(-yas))
                    yas--;
                return yas;
            }
            return 0;
        }

        private void numKilo_TextChanged(object sender, EventArgs e)
        {

        }

        private void numBoy_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(numBoy.Text, "[^0-9]"))
            {
                InfService.ShowMessage("Lütfen sadece sayı girişi yapınız.", "Please enter only numbers.");
                numBoy.Text = numBoy.Text.Remove(numBoy.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = txtUlke.SelectedValue;
        }
    }
}
