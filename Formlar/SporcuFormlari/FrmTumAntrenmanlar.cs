using AntrenmanTakip.Formlar.Ayarlar;
using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    public partial class FrmTumAntrenmanlar : Form
    {
        private FrmAntrenmanSecenekleri _frmAntrenmanSecenekleri;
        private FrmAyarlar _frmAyarlar;
        private FrmAntrenmanDetay _frmAntrenmanDetay;
        public FrmTumAntrenmanlar()
        {
            InitializeComponent();
        }
        int s;
        public int id;
        string systemLanguge = "";
        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            dynamic arananDeger = null;
            var dateBa = dtimeBaslangic.Value;
            var dateBi = dtimeBitis.Value;
            if (dtimeBaslangic.Value.Date > dtimeBitis.Value.Date)
            {
                if (systemLanguge == "Turkish")
                    MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (systemLanguge == "English")
                    MessageBox.Show("The start date cannot be greater than the end date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                gridViewAntrenmanlar.Rows.Clear();
                if (s > 0 && dtimeBaslangic.Value != null && dtimeBitis.Value != null)
                {
                    int antrenmanId = Convert.ToInt32(cmbAra.SelectedValue);
                    arananDeger = Context._context.View_Antrenmanlar.Where(a => a.AntrenmanId == antrenmanId && a.Id == Context.sporcu.Id && a.Tarih >= dateBa && a.Tarih <= dateBi).OrderBy(a => a.AntrenmanTurleri).ThenBy(a => a.AntrenmanSayisi).ToList();
                }
                else if (dtimeBaslangic.Value != null && dtimeBitis.Value != null)
                {
                    arananDeger = Context._context.View_Antrenmanlar.Where(a => a.Id == Context.sporcu.Id && a.Tarih >= dtimeBaslangic.Value && a.Tarih <= dtimeBitis.Value).OrderBy(a => a.AntrenmanTurleri).ThenBy(a => a.AntrenmanSayisi).ToList();
                }
                foreach (var aranan in arananDeger)
                {
                    string sure = InfService.Sure(aranan);
                    if (systemLanguge == "Turkish")
                    {
                        gridViewAntrenmanlar.Rows.Add(new object[]
                        {
                            aranan.AntrenamTuruId,
                            aranan.AntrenmanTurleri,
                            $"{aranan.AntrenmanSayisi}. Antrenman",
                            aranan.AtisSayisi,
                            aranan.BasariliAtis,
                            sure,
                            aranan.Tarih.ToString("dddd, dd MMMM yyyy")
                        });
                    }
                    else if (systemLanguge == "English")
                    {
                        gridViewAntrenmanlar.Rows.Add(new object[]
                        {
                            aranan.AntrenamTuruId,
                            aranan.EAntrenmanTurleri,
                            $"{aranan.AntrenmanSayisi}. Training",
                            aranan.AtisSayisi,
                            aranan.BasariliAtis,
                            sure,
                            aranan.Tarih.ToString("dddd, dd MMMM yyyy")
                        });
                    }

                }
            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            gridViewAntrenmanlar.Rows.Clear();
            dtimeBaslangic.Value = DateTime.Now.AddMonths(-1);
            dtimeBitis.Value = DateTime.Now;
            var antrenmanlar = GetViewAntrenmans(Context.sporcu.Id);
            //gridViewAntrenmanlar.DataSource = antrenmanlar;
            foreach (var antrenman in antrenmanlar)
            {
                string sure = InfService.Sure(antrenman);
                if (systemLanguge == "Turkish")
                {
                    gridViewAntrenmanlar.Rows.Add(new object[]
                    {
                        antrenman.AntrenamTuruId,
                        antrenman.AntrenmanTurleri,
                        $"{antrenman.AntrenmanSayisi}. Antrenman",
                        antrenman.AtisSayisi,
                        antrenman.BasariliAtis,
                        sure,
                        antrenman.Tarih.ToString("dddd, dd MMMM yyyy")
                    });
                }
                else if (systemLanguge == "English")
                {
                    gridViewAntrenmanlar.Rows.Add(new object[]
                    {
                        antrenman.AntrenamTuruId,
                        antrenman.EAntrenmanTurleri,
                        $"{antrenman.AntrenmanSayisi}. Training",
                        antrenman.AtisSayisi,
                        antrenman.BasariliAtis,
                        sure,
                        antrenman.Tarih.ToString("dddd, dd MMMM yyyy")
                    });
                }
            }
            s = 0;
            cmbAra.DataSource = null;
            if (systemLanguge == "Turkish")
                cmbAra.Items.Add("Seçiniz...");
            else if (systemLanguge == "English")
                cmbAra.Items.Add("Choose...");
            cmbAra.SelectedIndex = 0;
        }

        private List<View_Antrenmanlar> GetViewAntrenmans(int id)
        {
            return Context._context.View_Antrenmanlar.Where(s => s.Id == Context.sporcu.Id).OrderBy(a => a.AntrenmanTurleri).ThenBy(a => a.AntrenmanSayisi).ToList();
        }

        private void cmbAra_MouseClick(object sender, MouseEventArgs e)
        {
            s++;
            var antrenmanTurleri = Context._context.View_AntrenmanlarCMB.Where(s => s.SporcuId == Context.sporcu.Id).ToList();
            cmbAra.DataSource = antrenmanTurleri;
            cmbAra.ValueMember = "AntrenmanId";
            if (systemLanguge == "Turkish")
                cmbAra.DisplayMember = "AntrenmanTurleri";
            else if (systemLanguge == "English")
                cmbAra.DisplayMember = "EAntrenmanTurleri";
        }

        private void FrmTumAntrenmanlar_Load(object sender, EventArgs e)
        {
            systemLanguge = DbService.GetApplicationLanguage();

            CultureInfo cultureInfo = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            if (systemLanguge == "English")
            {
                string format = dtimeBaslangic.Value.GetDateTimeFormats(cultureInfo).First();
                dtimeBaslangic.CustomFormat = format;

                string format2 = dtimeBaslangic.Value.GetDateTimeFormats(cultureInfo).First();
                dtimeBitis.CustomFormat = format2;
            }
            else if(systemLanguge == "Turkish")
            {
                CultureInfo cultureInfo_ = System.Globalization.CultureInfo.GetCultureInfo("tr-TR");
                string format = dtimeBaslangic.Value.GetDateTimeFormats(cultureInfo_).First();
                dtimeBaslangic.CustomFormat = format;

                string format2 = dtimeBaslangic.Value.GetDateTimeFormats(cultureInfo_).First();
                dtimeBitis.CustomFormat = format2;
            }

            dtimeBaslangic.Value = DateTime.Now.AddMonths(-1);
            //Sporcu Bilgileri
            dynamic sporcu = DbService.GetFootballer(Context.sporcu.Id);
            lblSporcu.Text = $"{sporcu.Adi} {sporcu.Soyadi}";
            lblYas.Text = sporcu.Yas.ToString();
            lblBoy.Text = $"{sporcu.Boy} cm";
            lblKilo.Text = $"{sporcu.Kilo} Kg";
            if (systemLanguge == "Turkish")
                lblMevki.Text = sporcu.Mevkiler.Adi.ToString();
            else if (systemLanguge == "English")
                lblMevki.Text = sporcu.Mevkiler.EAdi.ToString();

            //Antrenman Bilgileri
            var antrenmanlar = GetViewAntrenmans(id);
            //gridViewAntrenmanlar.DataSource = antrenmanlar;
            foreach (var antrenman in antrenmanlar)
            {
                string sure = InfService.Sure(antrenman);
                if (systemLanguge == "Turkish")
                {
                    gridViewAntrenmanlar.Rows.Add(new object[]
                    {
                        antrenman.AntrenamTuruId,
                        antrenman.AntrenmanTurleri,
                        $"{antrenman.AntrenmanSayisi}. Antrenman",
                        antrenman.AtisSayisi,
                        antrenman.BasariliAtis,
                        sure,
                        antrenman.Tarih.ToString("dddd, dd MMMM yyyy")
                    });
                }
                else if (systemLanguge == "English")
                {
                    gridViewAntrenmanlar.Rows.Add(new object[]
                    {
                        antrenman.AntrenamTuruId,
                        antrenman.EAntrenmanTurleri,
                        $"{antrenman.AntrenmanSayisi}. Training",
                        antrenman.AtisSayisi,
                        antrenman.BasariliAtis,
                        sure,
                        antrenman.Tarih.ToString("dddd, dd MMMM yyyy")
                    });
                }
            }
            cmbAra.SelectedIndex = 0;
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmAntrenmanSecenekleri = new FrmAntrenmanSecenekleri();
            _frmAntrenmanSecenekleri.Show();
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

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        int antrenmanId = 0;
        private void gridViewAntrenmanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = gridViewAntrenmanlar.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gridViewAntrenmanlar.Rows[selectedrowindex];
            antrenmanId = Convert.ToInt32(selectedRow.Cells["AntrenmanTuruId"].Value);
        }

        private void detaylarıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(antrenmanId == 0)
            {
                if(systemLanguge == "Turkish")
                    MessageBox.Show("Lütfen antrenman seçiniz.");
                else if(systemLanguge == "English")
                    MessageBox.Show("Please select training");
            }
            else
            {
                _frmAntrenmanDetay = new FrmAntrenmanDetay();
                _frmAntrenmanDetay.antrenmanId = antrenmanId;
                _frmAntrenmanDetay.Show();
            }
        }
    }
}
