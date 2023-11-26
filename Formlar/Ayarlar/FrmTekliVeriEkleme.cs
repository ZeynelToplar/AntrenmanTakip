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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Cursors = System.Windows.Forms.Cursors;

namespace AntrenmanTakip.Formlar.Ayarlar
{
    public partial class FrmTekliVeriEkleme : Form
    {
        public FrmTekliVeriEkleme()
        {
            InitializeComponent();
        }
        string systemLanguage = "";
        object topKonumlari = null;
        object topGelisSekilleri = null;
        object vurusBicimleri = null;
        private void FrmTekliVeriEkleme_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            Kullanicilar authenticateUser = DbService.GetUser(Context.kullanici.Id);
            if (authenticateUser.YetkiId == 0)
            {
                var sporcular = (from s in Context._context.Sporcular
                                 join m in Context._context.Mevkiler on s.MevkiId equals m.Id
                                 select new
                                 {
                                     Id = s.Id,
                                     Adi = s.Adi,
                                     Soyadi = s.Soyadi,
                                     Yas = s.Yas,
                                     Boy = s.Boy,
                                     Kilo = s.Kilo,
                                     Ulke = s.Ulke,
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
                        sporcu.Ulke,
                        sporcu.Adi,
                        sporcu.Soyadi,
                        sporcu.Yas,
                        sporcu.Boy,
                        sporcu.Kilo,
                        mevki
                        });
                    }
                    else
                    {
                        gridViewSporcular.Rows.Add(new object[]
                        {
                        sporcu.Id,
                        sporcu.Ulke,
                        sporcu.Adi,
                        sporcu.Soyadi,
                        sporcu.Yas,
                        sporcu.Boy,
                        sporcu.Kilo,
                        sporcu.Mevkiler.Adi
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
                                 where ks.KullaniciId == authenticateUser.Id
                                 select new
                                 {
                                     Id = s.Id,
                                     Ulke = s.Ulke,
                                     Adi = s.Adi,
                                     Soyadi = s.Soyadi,
                                     Yas = s.Yas,
                                     Boy = s.Boy,
                                     Kilo = s.Kilo,
                                     Mevkiler = s.Mevkiler
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
                        sporcu.Ulke,
                        sporcu.Adi,
                        sporcu.Soyadi,
                        sporcu.Yas,
                        sporcu.Boy,
                        sporcu.Kilo,
                        mevki
                        });
                    }
                    else
                    {
                        gridViewSporcular.Rows.Add(new object[]
                        {
                        sporcu.Id,
                        sporcu.Ulke,
                        sporcu.Adi,
                        sporcu.Soyadi,
                        sporcu.Yas,
                        sporcu.Boy,
                        sporcu.Kilo,
                        sporcu.Mevkiler.Adi
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

            cmbTopKonumlari.DataSource = topKonumlari;
            cmbTopKonumlari.ValueMember = "Id";
            if (systemLanguage == "Turkish")
                cmbTopKonumlari.DisplayMember = "Adi";
            else if (systemLanguage == "English")
                cmbTopKonumlari.DisplayMember = "EAdi";

            cmbTopGelisSekli.DataSource = topGelisSekilleri;
            cmbTopGelisSekli.ValueMember = "Id";
            if (systemLanguage == "Turkish")
                cmbTopGelisSekli.DisplayMember = "Adi";
            else if (systemLanguage == "English")
                cmbTopGelisSekli.DisplayMember = "Eadi";

            cmbVurusBicimleri.DataSource = vurusBicimleri;
            cmbVurusBicimleri.ValueMember = "Id";
            if (systemLanguage == "Turkish")
                cmbVurusBicimleri.DisplayMember = "Adi";
            else if (systemLanguage == "English")
                cmbVurusBicimleri.DisplayMember = "EAdi";


            cmbTopKonumlari.SelectedIndex = 0;
            cmbTopGelisSekli.SelectedIndex = 0;
            cmbVurusBicimleri.SelectedIndex = 0;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != null)
            {
                List<Sporcular> arananSporcular = Context._context.Sporcular.Where(s => s.Adi.Contains(textBox1.Text) || s.Soyadi.Contains(textBox1.Text) || s.Yas.ToString().Contains(textBox1.Text)).ToList();
                gridViewSporcular.Rows.Clear();
                foreach (var sporcu in arananSporcular)
                {
                    string mevki = "";
                    if (systemLanguage == "English")
                    {
                        mevki = InfService.ConvertToEnglish(sporcu.Mevkiler.Adi);
                        gridViewSporcular.Rows.Add(new object[]
                        {
                        sporcu.Id,
                        sporcu.Ulke,
                        sporcu.Adi,
                        sporcu.Soyadi,
                        sporcu.Yas,
                        sporcu.Boy,
                        sporcu.Kilo,
                        mevki
                        });
                    }
                    else
                    {
                        gridViewSporcular.Rows.Add(new object[]
                        {
                        sporcu.Id,
                        sporcu.Ulke,
                        sporcu.Adi,
                        sporcu.Soyadi,
                        sporcu.Yas,
                        sporcu.Boy,
                        sporcu.Kilo,
                        sporcu.Mevkiler.Adi
                        });
                    }
                }
            }
            else
            {
                gridViewSporcular.Rows.Clear();
                FrmTekliVeriEkleme_Load(sender, e);
            }
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (systemLanguage == "Turkish")
                textBox1.Text = "Sporcu Ara...";
            else if (systemLanguage == "English")
                textBox1.Text = "Search Player";
        }
        int sporcuId = 0;
        Sporcular sporcu;
        private void gridViewSporcular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = gridViewSporcular.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gridViewSporcular.Rows[selectedrowindex];
            sporcuId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            sporcu = new Sporcular()
            {
                Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                Adi = Convert.ToString(selectedRow.Cells["Ad"].Value),
                Soyadi = Convert.ToString(selectedRow.Cells["Soyad"].Value),
                Yas = Convert.ToInt32(selectedRow.Cells["Yas"].Value),
                Boy = Convert.ToInt32(selectedRow.Cells["Boy"].Value),
                Kilo = Convert.ToInt32(selectedRow.Cells["Kilo"].Value)
            };
        }

        private void cmbTopKonumlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            topKonumlari = cmbTopKonumlari.SelectedValue;
        }

        private void cmbTopGelisSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            topGelisSekilleri = cmbTopGelisSekli.SelectedValue;
        }

        private void cmbVurusBicimleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            vurusBicimleri = cmbVurusBicimleri.SelectedValue;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            int tkId = 0, tgsId = 0, vbId = 0;
            DateTime tarih = dateTimePicker1.Value;
            decimal sure = 0m, basariliAtis = 0m;
            tkId = Convert.ToInt32(topKonumlari);
            tgsId = Convert.ToInt32(topGelisSekilleri);
            vbId = Convert.ToInt32(vurusBicimleri);
            sure = numSure.Value;

            //var bolge1 = comboBox1.SelectedText;
            bool isSucceed1 = false, isSucceed2 = false, isSucceed3 = false, isSucceed4 = false, isSucceed5 = false, isSucceed6 = false, isSucceed7 = false, isSucceed8 = false, isSucceed9 = false, isSucceed10 = false;
            if (rdoBasarili1.Checked)
                isSucceed1 = true;
            else if (rdoBasarisiz1.Checked)
                isSucceed1 = false;
            if (rdoBasarili2.Checked)
                isSucceed2 = true;
            else if (rdoBasarisiz2.Checked)
                isSucceed2 = false;
            if (rdoBasarili3.Checked)
                isSucceed3 = true;
            else if (rdoBasarisiz3.Checked)
                isSucceed3 = false;
            if (rdoBasarili4.Checked)
                isSucceed4 = true;
            else if (rdoBasarisiz4.Checked)
                isSucceed4 = false;
            if (rdoBasarili5.Checked)
                isSucceed5 = true;
            else if (rdoBasarisiz5.Checked)
                isSucceed5 = false;
            if (rdoBasarili6.Checked)
                isSucceed6 = true;
            else if (rdoBasarisiz6.Checked)
                isSucceed6 = false;
            if (rdoBasarili7.Checked)
                isSucceed7 = true;
            else if (rdoBasarisiz7.Checked)
                isSucceed7 = false;
            if (rdoBasarili8.Checked)
                isSucceed8 = true;
            else if (rdoBasarisiz8.Checked)
                isSucceed8 = false;
            if (rdoBasarili9.Checked)
                isSucceed9 = true;
            else if (rdoBasarisiz9.Checked)
                isSucceed9 = false;
            if (rdoBasarili10.Checked)
                isSucceed10 = true;
            else if (rdoBasarisiz10.Checked)
                isSucceed10 = false;
            var bolge1 = comboBox1.SelectedItem.ToString();
            var bolge2 = comboBox2.SelectedItem.ToString();
            var bolge3 = comboBox3.SelectedItem.ToString();
            var bolge4 = comboBox4.SelectedItem.ToString();
            var bolge5 = comboBox5.SelectedItem.ToString();
            var bolge6 = comboBox6.SelectedItem.ToString();
            var bolge7 = comboBox7.SelectedItem.ToString();
            var bolge8 = comboBox8.SelectedItem.ToString();
            var bolge9 = comboBox9.SelectedItem.ToString();
            var bolge10 = comboBox10.SelectedItem.ToString();

            BolgeyeGoreAtisSayisiEkleWithAntrenman(bolge1, bolge2, bolge3, bolge4, bolge5, bolge6, bolge7, bolge8, bolge9, bolge10, isSucceed1, isSucceed2, isSucceed3, isSucceed4, isSucceed5, isSucceed6, isSucceed7, isSucceed8, isSucceed9, isSucceed10, tkId, tgsId, vbId, sure,tarih);

        }

        private int AntrenmanEkle(decimal basariliAtis, int tkId, int tgsId, int vbId, decimal sure,DateTime tarih)
        {
            AntrenmanTurleri antrenamTuru = antrenamTuru = Context._context.AntrenmanTurleri.FirstOrDefault(a => a.TopKonumId == tkId && a.TopGelisSekliId == tgsId && a.VurusBicimiId == vbId); ;


            if (antrenamTuru == null)
            {
                InfService.ShowMessage("Lütfen uyumlu antrenman türlerini seçiniz !", "Please choose compatible training types !");
            }
            else
            {
                Antrenmanlar antrenman_ = antrenman_ = Context._context.Antrenmanlar.Where(a => a.AntrenamTuruId == antrenamTuru.Id && a.SporcuId == sporcuId).OrderByDescending(a => a.AntrenmanSayisi).FirstOrDefault();
                if (sporcuId == 0)
                {
                    InfService.ShowMessage("Lütfen sporcuyu seçiniz !", "Please choose the player !");
                }
                else
                {
                    if (antrenman_ != null)
                    {
                        Antrenmanlar antrenman = new Antrenmanlar()
                        {
                            SporcuId = sporcuId,
                            AntrenamTuruId = antrenamTuru.Id,
                            AtisSayisi = 10,
                            BasariliAtis = Convert.ToInt32(basariliAtis),
                            AntrenmanSuresi = Convert.ToInt32(sure),
                            AntrenmanSayisi = antrenman_.AntrenmanSayisi + 1,
                            Tarih = tarih,
                        };
                        Context._context.Antrenmanlar.Add(antrenman);
                        Context._context.SaveChanges();
                        return antrenman.Id;
                    }
                    else
                    {
                        Antrenmanlar antrenman = new Antrenmanlar()
                        {
                            SporcuId = sporcuId,
                            AntrenamTuruId = antrenamTuru.Id,
                            AtisSayisi = 10,
                            BasariliAtis = Convert.ToInt32(basariliAtis),
                            AntrenmanSuresi = Convert.ToInt32(sure),
                            AntrenmanSayisi = 1,
                            Tarih = tarih
                        };
                        Context._context.Antrenmanlar.Add(antrenman);
                        Context._context.SaveChanges();
                        return antrenman.Id;
                    }
                }
            }
            return 0;

        }

        private void BolgeyeGoreAtisSayisiEkleWithAntrenman(string atisBolge1, string atisBolge2, string atisBolge3, string atisBolge4, string atisBolge5, string atisBolge6, string atisBolge7, string atisBolge8, string atisBolge9, string atisBolge10, bool isSucceeded1, bool isSucceeded2, bool isSucceeded3, bool isSucceeded4, bool isSucceeded5, bool isSucceeded6, bool isSucceeded7, bool isSucceeded8, bool isSucceeded9, bool isSucceeded10, int tkId, int tgsId, int vbId, decimal sure,DateTime tarih)
        {
            AntrenmanTurleri antrenamTuru = antrenamTuru = Context._context.AntrenmanTurleri.FirstOrDefault(a => a.TopKonumId == tkId && a.TopGelisSekliId == tgsId && a.VurusBicimiId == vbId); ;
            string[] bolgeler = new string[10] { atisBolge1, atisBolge2, atisBolge3, atisBolge4, atisBolge5, atisBolge6, atisBolge7, atisBolge8, atisBolge9, atisBolge10 };
            bool[] basariliMi = new bool[10] { isSucceeded1, isSucceeded2, isSucceeded3, isSucceeded4, isSucceeded5, isSucceeded6, isSucceeded7, isSucceeded8, isSucceeded9, isSucceeded10 };

            int basariliAtis = 0;

            for (int i = 0; i < 10; i++)
            {
                if (basariliMi[i])
                    ++basariliAtis;
            }
            int antrenmanId = AntrenmanEkle(basariliAtis, tkId, tgsId, vbId, sure,tarih);
            Context._context.SaveChanges();
            for (int i = 0; i < 10; i++)
            {
                if(antrenmanId == 0)
                    break;
                AntrenmanBolge antrenmanBolge = new AntrenmanBolge()
                {
                    AntrenmanTuruId = antrenamTuru.Id,
                    Bolge = Convert.ToInt32(bolgeler[i]),
                    BasariliMi = basariliMi[i],
                    SporcuId = sporcuId,
                    AntrenmanId = antrenmanId,
                };

                Context._context.AntrenmanBolge.Add(antrenmanBolge);
                Context._context.SaveChanges();
            }
            if(antrenmanId!= 0)
            {
                InfService.ShowMessage("Antrenman kaydı eklendi.", "Training log added.");
            }
        }
        private void numBasariliAtis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numSure_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
