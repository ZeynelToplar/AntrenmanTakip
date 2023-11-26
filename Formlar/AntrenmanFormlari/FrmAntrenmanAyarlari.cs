using AntrenmanTakip.Formlar.Ayarlar;
using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.AntrenmanFormlari
{
    public partial class FrmAntrenmanAyarlari : Form
    {
        private FrmAntrenmanGorsel _frmAntrenmanGorsel;
        public FrmAntrenmanAyarlari()
        {
            InitializeComponent();
        }
        string systemLanguage = "";
        private void FrmAntrenmanAyarlari_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            VerileriGetir();

            var topKonumlari = Context._context.TopKonumlari.ToList();
            cmbTopKonum.DataSource = topKonumlari;
            cmbTopKonum.ValueMember = "Id";
            if (systemLanguage == "Turkish")
                cmbTopKonum.DisplayMember = "Adi";
            else if (systemLanguage == "English")
                cmbTopKonum.DisplayMember = "EAdi";

            var gelisSekilleri = Context._context.TopGelisSekilleri.ToList();
            cmbTopGelisSekli.DataSource = gelisSekilleri;
            cmbTopGelisSekli.ValueMember = "Id";
            if (systemLanguage == "Turkish")
                cmbTopGelisSekli.DisplayMember = "Adi";
            else if (systemLanguage == "English")
                cmbTopGelisSekli.DisplayMember = "EAdi";


        }
        OpenFileDialog fileDialogResim;
        string fileName = string.Empty;
        Stream stream = null;
        string path = string.Empty;
        private void VerileriGetir()
        {
            //List<AntrenmanTurleri> antrenmanTurleri = Context._context.AntrenmanTurleri.Include(atu => atu.TopKonum).Include(atu => atu.TopGelisSekli).Include(atu => atu.VurusBicimi).ThenInclude(vb => vb.Resim).OrderBy(atu => atu.TopKonum.Adi).ThenBy(atu => atu.TopGelisSekli.Adi).ThenBy(atu => atu.VurusBicimi.Adi).ToList();
            var antrenmanTurleri = (from atu in Context._context.AntrenmanTurleri
                                    join tk in Context._context.TopKonumlari on atu.TopKonumId equals tk.Id
                                    join tgs in Context._context.TopGelisSekilleri on atu.TopGelisSekliId equals tgs.Id
                                    join vb in Context._context.VurusBicimleri on atu.VurusBicimiId equals vb.Id
                                    join r in Context._context.Resimler on vb.ResimId equals r.Id
                                    orderby tk.Adi, tgs.Adi, vb.Adi
                                    select new
                                    {
                                        TopKonumId = tk.Id,
                                        TopGelisSekliId = tgs.Id,
                                        VurusBicimiId = vb.Id,
                                        TopKonumlari = tk,
                                        TopGelisSekilleri = tgs,
                                        VurusBicimleri = vb,
                                        Resimler = vb.Resimler
                                    }).ToList();
            foreach (var antrenmanTuru in antrenmanTurleri)
            {
                string vbAdi = "", tkAdi = "", tgsAdi = "";
                if(systemLanguage == "Turkish")
                {
                    vbAdi = antrenmanTuru.VurusBicimleri.Adi.ToString();
                    tkAdi = antrenmanTuru.TopKonumlari.Adi.ToString();
                    tgsAdi = antrenmanTuru.TopGelisSekilleri.Adi.ToString();
                }
                else if(systemLanguage == "English")
                {
                    vbAdi = antrenmanTuru.VurusBicimleri.EAdi.ToString();
                    tkAdi = antrenmanTuru.TopKonumlari.EAdi.ToString();
                    tgsAdi = antrenmanTuru.TopGelisSekilleri.EAdi.ToString();
                }
                gridViewAntrenmanTurleri.Rows.Add(new object[]
                {
                    antrenmanTuru.TopKonumId,
                    antrenmanTuru.TopGelisSekliId,
                    antrenmanTuru.VurusBicimiId,
                    tkAdi,
                    tgsAdi,
                    vbAdi,
                    System.Drawing.Image.FromFile($@"{GetCurrentDirectory()}\{antrenmanTuru.VurusBicimleri.Resimler.Path}")
            });
            }
        }
        private string GetCurrentDirectory()
        {
            string currentDirectory = Environment.CurrentDirectory;
            currentDirectory = currentDirectory.Substring(0, currentDirectory.IndexOf("\\bin"));
            path = Path.Combine(currentDirectory + @"\Resources");
            return path;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
             
            if (InfService.ShowMessage("Yeni antrenman türünü eklemek istediğinize emin misiniz ?", "Are you sure you want to add the new practice type?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int topKonum = Convert.ToInt32(cmbTopKonum.SelectedValue);
                int topGelisSekli = Convert.ToInt32(cmbTopGelisSekli.SelectedValue);
                string vurusBicimi = txtVurusBicimi.Text.Trim();
                string engVurusBicimi = txtEngVurusBicimi.Text.Trim();

                var existVurusBicimi = Context._context.VurusBicimleri.FirstOrDefault(vb => vb.Adi == vurusBicimi);
                if (existVurusBicimi == null)
                {
                    VurusBicimleri yeniVurusBicimi = new VurusBicimleri()
                    {
                        Adi = vurusBicimi,
                        EAdi = engVurusBicimi,
                        ResimId = 15
                    };
                    Context._context.VurusBicimleri.Add(yeniVurusBicimi);
                    Context._context.SaveChanges();
                    AntrenmanTurleri yeniAntrenmanTuru = new AntrenmanTurleri()
                    {
                        TopKonumId = topKonum,
                        TopGelisSekliId = topGelisSekli,
                        VurusBicimiId = yeniVurusBicimi.Id
                    };

                    Context._context.AntrenmanTurleri.Add(yeniAntrenmanTuru);
                    Context._context.SaveChanges();
                    InfService.ShowMessage("Kayıt işlemi başarılı.", "Registration successful.");
                }
                else
                {
                    var existAntrenmanTuru = Context._context.AntrenmanTurleri.FirstOrDefault(a => a.TopKonumId == topKonum && a.TopGelisSekliId == topGelisSekli && a.VurusBicimiId == existVurusBicimi.Id);
                    if (existAntrenmanTuru == null)
                    {
                        AntrenmanTurleri yeniAntrenmanTuru = new AntrenmanTurleri()
                        {
                            TopKonumId = topKonum,
                            TopGelisSekliId = topGelisSekli,
                            VurusBicimiId = existVurusBicimi.Id
                        };
                        Context._context.AntrenmanTurleri.Add(yeniAntrenmanTuru);
                        Context._context.SaveChanges();
                    }
                    else
                    {
                        InfService.ShowMessage("Böyle bir antrenman türü zaten mevcut.", "Such a type of practice already exists.");
                    }
                }
                gridViewAntrenmanTurleri.Rows.Clear();
                VerileriGetir();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int topKonum = Convert.ToInt32(cmbTopKonum.SelectedValue);
            int topGelisSekli = Convert.ToInt32(cmbTopGelisSekli.SelectedValue);
            string vurusBicimi = txtVurusBicmiId.Text;
            if (topKonum != 0 || topGelisSekli != 0 || vurusBicimi != "")
            {
               
                if (InfService.ShowMessage("Silmek istediğinize emin misiniz ?", "Are you sure you want to delete ?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int vBicimi = Convert.ToInt32(vurusBicimi);
                    AntrenmanTurleri antrenmanTuru = Context._context.AntrenmanTurleri.Where(a => a.TopKonumId == topKonum && a.TopGelisSekliId == topGelisSekli && a.VurusBicimiId == vBicimi).FirstOrDefault();
                    var antrenmanlar = Context._context.Antrenmanlar.Where(a => a.AntrenamTuruId == antrenmanTuru.Id).ToList();
                    if (antrenmanlar.Count > 0)
                    {
                        InfService.ShowMessage("Bu antrenman türüne ait yapılan antrenman kayıtları olduğu için silme işlemi gerçekleştiremezsiniz.", "You cannot delete because there are training records for this practice type.");
                    }
                    else
                    {
                        Context._context.AntrenmanTurleri.Remove(antrenmanTuru);
                        Context._context.SaveChanges();
                        InfService.ShowMessage("Silme işlemi başarılı.", "The deletion was successful.");
                        gridViewAntrenmanTurleri.Rows.Clear();
                        VerileriGetir();
                    }
                }
            }
        }

        int topKonum_, topGelisSekli, vurusBicimi;
        AntrenmanTurleri antrenmanTuru;

        private void görselEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_frmAntrenmanGorsel == null || _frmAntrenmanGorsel.IsDisposed)
            {
                _frmAntrenmanGorsel = new FrmAntrenmanGorsel();
                _frmAntrenmanGorsel.antrenmanTuru = antrenmanTuru;
                _frmAntrenmanGorsel.Show();
            }
        }

        private void gridViewAntrenmanTurleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = gridViewAntrenmanTurleri.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gridViewAntrenmanTurleri.Rows[selectedrowindex];

            topKonum_ = Convert.ToInt32(selectedRow.Cells["topKonumId"].Value);
            topGelisSekli = Convert.ToInt32(selectedRow.Cells["topGelisSekliId"].Value);
            vurusBicimi = Convert.ToInt32(selectedRow.Cells["VurusBicimiId"].Value);
            cmbTopKonum.SelectedValue = selectedRow.Cells["topKonumId"].Value;
            cmbTopGelisSekli.SelectedValue = selectedRow.Cells["topGelisSekliId"].Value;
            txtVurusBicimi.Text = Convert.ToString(selectedRow.Cells["VurusBicimi"].Value);
            txtVurusBicmiId.Text = Convert.ToString(selectedRow.Cells["VurusBicimiId"].Value);
            txtEngVurusBicimi.Text = Convert.ToString(selectedRow.Cells["VurusBicimi"].Value);

            //AntrenmanTurleri antrenmanTuru = Context._context.AntrenmanTurleri.Include(a => a.VurusBicimi).ThenInclude(a => a.Resim).Where(a => a.TopKonumId == topKonum && a.TopGelisSekliId == topGelisSekli && a.VurusBicimiId == vurusBicimi).First();

            antrenmanTuru = Context._context.AntrenmanTurleri.FirstOrDefault(atu => atu.TopKonumId == topKonum_ && atu.TopGelisSekliId == topGelisSekli && atu.VurusBicimiId == vurusBicimi);
        }

    }
}
