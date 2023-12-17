using AntrenmanTakip.Formlar.SporcuFormlari;
using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.Ayarlar
{
    public partial class FrmAyarlarRaporlama : Form
    {
        private FrmGrafikler _frmGrafikler;
        public FrmAyarlarRaporlama()
        {
            InitializeComponent();
        }
        int sporcuId;
        private void gridViewSporcular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = gridViewSporcular.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gridViewSporcular.Rows[selectedrowindex];

            string ad = Convert.ToString(selectedRow.Cells["Ad"].Value);
            string soyad = Convert.ToString(selectedRow.Cells["Soyad"].Value);
            txtId.Text = Convert.ToString(selectedRow.Cells["Id"].Value);
            lblSecilenSporcu.Text = $"{ad} {soyad}";
        }
        string systemLanguage = "";
        private void FrmAyarlarRaporlama_Load(object sender, EventArgs e)
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

            var topKonumlari = Context._context.TopKonumlari.Select(tk => new
            {
                Id = tk.Id,
                Adi = tk.Adi,
                EAdi = tk.EAdi
            }).ToList();

            var topGelisSekilleri = Context._context.TopGelisSekilleri.Select(tgs => new
            {
                Id = tgs.Id,
                Adi = tgs.Adi,
                EAdi = tgs.EAdi,
            }).ToList();

            var vurusBicimleri = Context._context.VurusBicimleri.Select(vb => new
            {
                Id = vb.Id,
                Adi = vb.Adi,
                EAdi = vb.EAdi,
            }).ToList();

            cmbTK.DataSource = topKonumlari;
            cmbTK.ValueMember = "Id";
            if (systemLanguage == "Turkish")
                cmbTK.DisplayMember = "Adi";
            else if (systemLanguage == "English")
                cmbTK.DisplayMember = "EAdi";

            cmbTGS.DataSource = topGelisSekilleri;
            cmbTGS.ValueMember = "Id";
            if (systemLanguage == "Turkish")
                cmbTGS.DisplayMember = "Adi";
            else if (systemLanguage == "English")
                cmbTGS.DisplayMember = "Eadi";

            cmbVB.DataSource = vurusBicimleri;
            cmbVB.ValueMember = "Id";
            if (systemLanguage == "Turkish")
                cmbVB.DisplayMember = "Adi";
            else if (systemLanguage == "English")
                cmbVB.DisplayMember = "EAdi";


            cmbTK.SelectedIndex = 0;
            cmbTGS.SelectedIndex = 0;
            cmbVB.SelectedIndex = 0;
        }

        private void cmbIstatistikTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbIstatistikTuru.SelectedIndex == 0)
            {
                lblAy.Visible = false;
                txtAy.Visible = false;
                lblYil.Visible = true;
                txtYıl.Visible = true;
                lblBaslangic.Visible = false;
                lblBitis.Visible = false;
                dtBaslangic.Visible = false;
                dtBitis.Visible = false;
                lblSira.Visible = false;
                txtSira.Visible = false;
            }
            else if(cmbIstatistikTuru.SelectedIndex == 1)
            {
                lblAy.Visible = true;
                txtAy.Visible = true;
                lblYil.Visible = true;
                txtYıl.Visible = true;
                lblBaslangic.Visible = false;
                lblBitis.Visible = false;
                dtBaslangic.Visible = false;
                dtBitis.Visible = false;
                lblSira.Visible = false;
                txtSira.Visible = false;
            }
            else if (cmbIstatistikTuru.SelectedIndex == 2)
            {
                lblAy.Visible = false;
                txtAy.Visible = false;
                lblYil.Visible = false;
                txtYıl.Visible = false;
                lblBaslangic.Visible = true;
                lblBitis.Visible = true;
                dtBaslangic.Visible = true;
                dtBitis.Visible = true;
                lblSira.Visible = false;
                txtSira.Visible = false;
            }
            else if(cmbIstatistikTuru.SelectedIndex == 3)
            {
                lblAy.Visible = false;
                txtAy.Visible = false;
                lblYil.Visible = false;
                txtYıl.Visible = false;
                lblBaslangic.Visible = false;
                lblBitis.Visible = false;
                dtBaslangic.Visible = false;
                dtBitis.Visible = false;
                lblSira.Visible = true;
                txtSira.Visible = true;
            }
        }

        private void txtAy_TextChanged(object sender, EventArgs e)
        {
            if(txtAy.Text != "")
            {
                string pattern = @"^(0?[1-9]|1[0-2])$";
                if (!Regex.IsMatch(txtAy.Text, pattern))
                {
                    InfService.ShowMessage("Lütfen sadece sayı girişi yapınız.", "Please enter only numbers.");
                    txtAy.Text.Remove(txtAy.Text.Length - 2);
                }
            }
        }
        
        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            int tkId, tgsId, vbId, month = DateTime.Now.Month, year = DateTime.Now.Year, chartType = 0, statType = 0;
            tkId = Convert.ToInt32(cmbTK.SelectedValue);
            tgsId = Convert.ToInt32(cmbTGS.SelectedValue);
            vbId = Convert.ToInt32(cmbVB.SelectedValue);
            chartType = cmbGrafikTuru.SelectedIndex;
            statType = cmbIstatistikTuru.SelectedIndex;
            AntrenmanTurleri antrenamTuru = antrenamTuru = Context._context.AntrenmanTurleri.FirstOrDefault(a => a.TopKonumId == tkId && a.TopGelisSekliId == tgsId && a.VurusBicimiId == vbId);
            if (antrenamTuru == null)
            {
                InfService.ShowMessage("Lütfen uyumlu antrenman türlerini seçiniz !", "Please choose compatible training types !");
            }
            else if(txtId.Text == "")
            {
                InfService.ShowMessage("Lütfen sporcuyu seçiniz.", "Please select the player.");
            }
            else if (cmbGrafikTuru.SelectedIndex == -1 || cmbIstatistikTuru.SelectedIndex == -1)
            {
                InfService.ShowMessage("Lüfen Grafik türünü ve İstatistik türünü seçiniz.", "Please select Chart type and Statistics type.");
            }
            else if (Regex.IsMatch(txtYıl.Text, "[^0-9]"))
            {
                InfService.ShowMessage("Lütfen sadece sayı girişi yapınız.", "Please enter only numbers.");
            }
            else if (cmbIstatistikTuru.SelectedIndex == 0 && txtYıl.Text == "")
            {
                InfService.ShowMessage("Lütfen yıl bilgisini giriniz.", "Please enter year information.");
            }
            else if (cmbIstatistikTuru.SelectedIndex == 1 && txtYıl.Text == "" && txtAy.Text == "")
            {
                InfService.ShowMessage("Lütfen yıl ve ay bilgisini giriniz.", "Please enter year and month information.");
            }
            else if (cmbIstatistikTuru.SelectedIndex == 1 && Convert.ToInt32(txtYıl.Text) <= 1923 && Convert.ToInt32(txtYıl.Text) >= DateTime.Now.Year)
            {
                InfService.ShowMessage("Lütfen geçerli bir yıl giriniz.", "Please enter a valid year.");
            }
            else if (cmbIstatistikTuru.SelectedIndex == 2 && dtBaslangic.Value == dtBitis.Value)
            {
                InfService.ShowMessage("Tarihler birbiriyle aynı olamaz.", "It cannot be the same between dates.");
            }
            else if(cmbIstatistikTuru.SelectedIndex == 3 && txtSira.Text == "")
            {
                InfService.ShowMessage("Lütfen getirmek istediğiniz antrenman aralığını giriniz.", "Please enter the training interval you would like to bring.");
            }
            else if (cmbIstatistikTuru.SelectedIndex == 3 && !txtSira.Text.Contains('-'))
            {
                InfService.ShowMessage("Lütfen örnekteki gibi veri girişi yapınız. (1-20)", "Please enter data as in the example. (1-20)");
            }
            else if(cmbIstatistikTuru.SelectedIndex == 2)
            {
                if (_frmGrafikler == null || _frmGrafikler.IsDisposed)
                {
                    grafikSayfasinaVeriGonderme(chartType, statType, antrenamTuru.Id);
                    _frmGrafikler.baslangic = dtBaslangic.Value;
                    _frmGrafikler.bitis = dtBitis.Value;
                    _frmGrafikler.Show();
                }
            }
            else if(cmbIstatistikTuru.SelectedIndex == 1)
            {
                if (_frmGrafikler == null || _frmGrafikler.IsDisposed)
                {
                    if (txtAy.Visible == true)
                        month = Convert.ToInt32(txtAy.Text);
                    grafikSayfasinaVeriGonderme(chartType,statType, antrenamTuru.Id);
                    _frmGrafikler.month = month;
                    _frmGrafikler.year = year;
                    _frmGrafikler.Show();

                }
            }
            else if (cmbIstatistikTuru.SelectedIndex == 0)
            {
                if (_frmGrafikler == null || _frmGrafikler.IsDisposed)
                {
                    grafikSayfasinaVeriGonderme(chartType, statType, antrenamTuru.Id);
                    _frmGrafikler.year = year;
                    _frmGrafikler.Show();
                }
            }
            else if(cmbIstatistikTuru.SelectedIndex == 3)
            {
                if (_frmGrafikler == null || _frmGrafikler.IsDisposed)
                {
                    int sira1, sira2;
                    var str = txtSira.Text.Split('-');
                    sira1 = Convert.ToInt32(str[0]);
                    sira2= Convert.ToInt32(str[1]);
                    grafikSayfasinaVeriGonderme(chartType, statType, antrenamTuru.Id);
                    _frmGrafikler.sira1 = sira1;
                    _frmGrafikler.sira2 = sira2;
                    _frmGrafikler.Show();
                }
            }
        }
        private void grafikSayfasinaVeriGonderme(int chartType,int statType,int antrenmanTuruId)
        {
            Context.sporcu = new Sporcular();
            Context.sporcu.Id = Convert.ToInt32(txtId.Text);
            _frmGrafikler = new FrmGrafikler();
            _frmGrafikler.chartType = chartType;
            _frmGrafikler.statisticType = statType;
            _frmGrafikler.antrenmanTuruId = antrenmanTuruId;
        }
    }
}
