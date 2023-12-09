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
    public partial class FrmSolAntrenman : Form
    {
        private FrmAntrenmanSecenekleri _frmAntrenmanSecenekleri;
        private FrmAyarlar _frmAyarlar;
        private FrmGrafikler _frmGrafikler;
        private FrmAntrenmanDetay _frmAntrenmanDetay;
        private FrmRaporlama _frmRaporlama;

        public int id;
        private int s;
        public FrmSolAntrenman()
        {
            InitializeComponent();
        }
        string systemLanguage = ""; 
        private void FrmSolAntrenman_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            int year = DateTime.Now.Year;
            dtimeBaslangic.Value = new DateTime(year, 1, 1);

            //CultureInfo cultureInfo = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            //if (systemLanguage == "English")
            //{
            //    string format = dtimeBaslangic.Value.GetDateTimeFormats(cultureInfo).First();
            //    dtimeBaslangic.CustomFormat = format;

            //    string format2 = dtimeBaslangic.Value.GetDateTimeFormats(cultureInfo).First();
            //    dtimeBitis.CustomFormat = format2;
            //}

            dtimeBaslangic.Value = DateTime.Now.AddMonths(-1);
            //Sporcu Bilgileri
            dynamic sporcu = DbService.GetFootballer(Context.sporcu.Id);
            lblSporcu.Text = $"{sporcu.Adi} {sporcu.Soyadi}";
            lblYas.Text = sporcu.Yas.ToString();
            lblBoy.Text = $"{sporcu.Boy} cm";
            lblKilo.Text = $"{sporcu.Kilo} Kg";
            if (systemLanguage == "Turkish")
                lblMevki.Text = sporcu.Mevkiler.Adi.ToString();
            else if (systemLanguage == "English")
                lblMevki.Text = sporcu.Mevkiler.EAdi.ToString();

            //Antrenman Bilgileri
            var antrenmanlar = DbService.GetPractices(Context.sporcu.Id, 3);
            //gridViewAntrenmanlar.DataSource = antrenmanlar;
            GridviewEkle(antrenmanlar);
            cmbAra.SelectedIndex = 0;
        }
        private void GridviewEkle(List<View_Antrenmanlar> values)
        {
            foreach (var item in values)
            {
                string sure = InfService.Sure(item);
                if (systemLanguage == "Turkish")
                {
                    gridViewAntrenmanlar.Rows.Add(new object[]
                    {
                        item.antId,
                        item.AntrenamTuruId,
                        item.AntrenmanTurleri,
                        $"{item.AntrenmanSayisi}. Antrenman",
                        item.AtisSayisi,
                        item.BasariliAtis,
                        sure,
                        item.Tarih.ToString("dddd, dd MMMM yyyy")
                    });
                }
                else if (systemLanguage == "English")
                {
                    gridViewAntrenmanlar.Rows.Add(new object[]
                    {
                        item.antId,
                        item.AntrenamTuruId,
                        item.EAntrenmanTurleri,
                        $"{item.AntrenmanSayisi}. Training",
                        item.AtisSayisi,
                        item.BasariliAtis,
                        sure,
                        item.Tarih.ToString("dddd, dd MMMM yyyy")
                    });
                }
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            List<View_Antrenmanlar> arananDeger = null;
            if (dtimeBaslangic.Value.Date > dtimeBitis.Value.Date)
            {
                InfService.ShowMessage("Başlangıç tarihi bitiş tarihinden büyük olamaz!", "The start date cannot be greater than the end date!");
            }
            else
            {
                gridViewAntrenmanlar.Rows.Clear();
                if (s > 0 && dtimeBaslangic?.Value != null && dtimeBitis?.Value != null)
                {
                    arananDeger = DbService.GetFilteredValue(Context.sporcu.Id, 3, Convert.ToInt32(cmbAra.SelectedValue), dtimeBaslangic, dtimeBitis);
                }
                else if (dtimeBaslangic?.Value != null && dtimeBitis?.Value != null)
                {
                    arananDeger = DbService.GetFilteredValueOnlyDate(Context.sporcu.Id, 3, dtimeBaslangic, dtimeBitis);
                }
                GridviewEkle(arananDeger);
            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            gridViewAntrenmanlar.Rows.Clear();
            int year = DateTime.Now.Year;
            dtimeBaslangic.Value = new DateTime(year, 1, 1);
            dtimeBitis.Value = DateTime.Now;
            var antrenmanlar = DbService.GetPractices(Context.sporcu.Id, 3);
            GridviewEkle(antrenmanlar);
            s = 0;
            cmbAra.DataSource = null;
            if (systemLanguage == "Turkish")
                cmbAra.Items.Add("Seçiniz...");
            else if (systemLanguage == "English")
                cmbAra.Items.Add("Choose...");
            cmbAra.SelectedIndex = 0;
        }

        private void cmbAra_MouseClick(object sender, MouseEventArgs e)
        {
            s++;
            var antrenmanTurleri = Context._context.View_AntrenmanlarCMB.Where(s => s.SporcuId == Context.sporcu.Id).ToList();
            cmbAra.DataSource = antrenmanTurleri;
            cmbAra.ValueMember = "AntrenmanId";
            if (systemLanguage == "Turkish")
                cmbAra.DisplayMember = "AntrenmanTurleri";
            else if (systemLanguage == "English")
                cmbAra.DisplayMember = "EAntrenmanTurleri";
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

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            if (antrenmanTuruId != 0)
            {
                if (_frmRaporlama == null || _frmRaporlama.IsDisposed)
                {
                    _frmRaporlama = new FrmRaporlama();
                    _frmRaporlama.antrenmanTuruId = antrenmanTuruId;
                    _frmRaporlama.Show();
                }
            }
            else
            {
                InfService.ShowMessage("Lütfen antrenman türünü seçiniz.", "Please select the training type.");
            }
        }
        int antrenmanTuruId;
        int antrenmanId = 0;
        private void gridViewAntrenmanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGrafik.Cursor = Cursors.Hand;
            int selectedrowindex = gridViewAntrenmanlar.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gridViewAntrenmanlar.Rows[selectedrowindex];
            antrenmanTuruId = Convert.ToInt32(selectedRow.Cells["AtuId"].Value);
            antrenmanId = Convert.ToInt32(selectedRow.Cells["Antrenman"].Value);
        }

        private void detaylarıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (antrenmanTuruId == 0)
            {
                InfService.ShowMessage("Lütfen antrenman seçiniz.", "Please select training");
            }
            else
            {
                _frmAntrenmanDetay = new FrmAntrenmanDetay();
                _frmAntrenmanDetay.antrenmanTuruId = antrenmanTuruId;
                _frmAntrenmanDetay.antrenmanId = antrenmanId;
                _frmAntrenmanDetay.Show();
            }
        }
    }
}
