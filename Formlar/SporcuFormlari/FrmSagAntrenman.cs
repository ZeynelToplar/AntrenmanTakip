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
    public partial class FrmSagAntrenman : Form
    {
        private FrmAntrenmanSecenekleri _frmAntrenmanSecenekleri;
        private FrmAyarlar _frmAyarlar;
        private FrmGrafikler _frmGrafikler;

        public int id;
        private int s;
        public FrmSagAntrenman()
        {
            InitializeComponent();
        }
        string systemLanguage = "";
        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            List<View_Antrenmanlar> arananDeger = null;
            if (dtimeBaslangic.Value.Date > dtimeBitis.Value.Date)
            {
                if(systemLanguage == "Turkish")
                    MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if(systemLanguage == "English")
                    MessageBox.Show("The start date cannot be greater than the end date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                gridViewAntrenmanlar.Rows.Clear();
                if (s > 0 && dtimeBaslangic?.Value != null && dtimeBitis?.Value != null)
                {
                    arananDeger = DbService.GetFilteredValue(Context.sporcu.Id, 2, Convert.ToInt32(cmbAra.SelectedValue), dtimeBaslangic, dtimeBitis);
                }
                else if (dtimeBaslangic?.Value != null && dtimeBitis?.Value != null)
                {
                    arananDeger = DbService.GetFilteredValueOnlyDate(Context.sporcu.Id, 2, dtimeBaslangic, dtimeBitis);
                }
                GridviewEkle(arananDeger);
            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            gridViewAntrenmanlar.Rows.Clear();
            dtimeBaslangic.Value = DateTime.Now.AddMonths(-1);
            dtimeBitis.Value = DateTime.Now;
            var antrenmanlar = DbService.GetPractices(Context.sporcu.Id, 2);
            GridviewEkle(antrenmanlar);
            s = 0;
            cmbAra.DataSource = null;
            if (systemLanguage == "Turkish")
                cmbAra.Items.Add("Seçiniz...");
            else if (systemLanguage == "English")
                cmbAra.Items.Add("Choose...");
            cmbAra.SelectedIndex = 0;
        }

        private void FrmSagAntrenman_Load(object sender, EventArgs e)
        {
            btnGrafik.Enabled = false;
            btnGrafik.BackColor = Color.DimGray;
            systemLanguage = DbService.GetApplicationLanguage();

            CultureInfo cultureInfo = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            if (systemLanguage == "English")
            {
                string format = dtimeBaslangic.Value.GetDateTimeFormats(cultureInfo).First();
                dtimeBaslangic.CustomFormat = format;

                string format2 = dtimeBaslangic.Value.GetDateTimeFormats(cultureInfo).First();
                dtimeBitis.CustomFormat = format2;
            }

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
            var antrenmanlar = DbService.GetPractices(Context.sporcu.Id, 2);
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
                        item.AntrenmanId,
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
                        item.AntrenmanId,
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
            if (gridViewAntrenmanlar.Rows.Count > 0)
            {
                if (_frmGrafikler == null || _frmGrafikler.IsDisposed)
                {
                    _frmGrafikler = new FrmGrafikler();
                    _frmGrafikler.antrenmanTuruId = antrenmanTuruId;
                    _frmGrafikler.Show();
                }
            }
            else
            {
                if(systemLanguage == "Turkish")
                    MessageBox.Show("Gösterilecek antrenman kaydı bulunamadı.");
                else if(systemLanguage == "English")
                    MessageBox.Show("No training record found to display.");
            }
        }
        int antrenmanTuruId;
        private void gridViewAntrenmanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGrafik.Enabled = true;
            btnGrafik.BackColor = SystemColors.GradientInactiveCaption;
            btnGrafik.Cursor = Cursors.Hand;
            int selectedrowindex = gridViewAntrenmanlar.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gridViewAntrenmanlar.Rows[selectedrowindex];
            antrenmanTuruId = Convert.ToInt32(selectedRow.Cells["AtuId"].Value);
        }
    }
}
