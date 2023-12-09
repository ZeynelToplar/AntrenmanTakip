using AntrenmanTakip.Formlar.Ayarlar;
using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Image = iTextSharp.text.Image;

namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    public partial class FrmSporcuProfil : Form
    {
        private FrmAyarlar _frmAyarlar;
        public int sporcuId;
        public FrmSporcuProfil()
        {
            InitializeComponent();
        }
        string systemLanguage = "";
        private void FrmSporcuProfil_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            var sporcu = Context._context.Sporcular.Include(s => s.Resimler).Include(s => s.Mevkiler).Include(s => s.ulkeler).FirstOrDefault(s => s.Id == Context.sporcu.Id);
            if (sporcu.Resimler != null)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile($@"{InfService.GetCurrentDirectory()}\{sporcu.Resimler.Path}");
            }
            else
            {
                var defaultImage = Context._context.Resimler.FirstOrDefault(r => r.Id == 14);
                pictureBox1.Image = System.Drawing.Image.FromFile($@"{InfService.GetCurrentDirectory()}\{defaultImage.Path}");
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //Kullanıcı bilgilerini label'lara yazdırma
            if (systemLanguage == "Turkish")
                lblUlke.Text = sporcu.ulkeler.UlkeAdi;
            else if (systemLanguage == "English")
                lblUlke.Text = sporcu.ulkeler.EUlkeAdi;

            if (systemLanguage == "Turkish")
                lblMevki.Text = sporcu.Mevkiler.Adi;
            else if (systemLanguage == "English")
                lblMevki.Text = sporcu.Mevkiler.EAdi;

            lblBoy.Text = sporcu.Boy.ToString() + " cm";
            lblKilo.Text = sporcu.Kilo.ToString() + " kg";
            lblYas.Text = sporcu.Yas.ToString();
            lblSporcuAdSoyad.Text = $"{sporcu.Adi} {sporcu.Soyadi}";

            var antrenmanlar = GetViewAntrenmans(Context.sporcu.Id);
            foreach (var antrenman in antrenmanlar)
            {
                string sure = InfService.Sure(antrenman);
                if (systemLanguage == "Turkish")
                {
                    gridViewAntrenmanlar.Rows.Add(new object[]
                    {
                        antrenman.AntrenmanTurleri,
                        $"{antrenman.AntrenmanSayisi}. Antrenman",
                        antrenman.AtisSayisi,
                        antrenman.BasariliAtis,
                        sure,
                        antrenman.Tarih.ToString("dddd, dd MMMM yyyy")
                    });
                }
                else if (systemLanguage == "English")
                {
                    gridViewAntrenmanlar.Rows.Add(new object[]
                    {
                        antrenman.EAntrenmanTurleri,
                        $"{antrenman.AntrenmanSayisi}. Training",
                        antrenman.AtisSayisi,
                        antrenman.BasariliAtis,
                        sure,
                        antrenman.Tarih.ToString("dddd, dd MMMM yyyy")
                    });
                }
            }
        }
        private List<View_Antrenmanlar> GetViewAntrenmans(int id)
        {
            return Context._context.View_Antrenmanlar.Where(s => s.Id == id).OrderBy(a => a.AntrenmanTurleri).ThenBy(a => a.AntrenmanSayisi).ToList();
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = ".PDF";
            saveDialog.Filter = "PDF Document | *PDF";
            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveDialog.FileName;

                iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);

                //Sporcu bilgilerini getirme
                var sporcu = Context._context.Sporcular.Include(s => s.Resimler).Include(s => s.Mevkiler).Include(s => s.ulkeler).FirstOrDefault(s => s.Id == Context.sporcu.Id);

                var antrenmanlar = GetViewAntrenmans(Context.sporcu.Id);

                Document pdfDoc = new Document(PageSize.A4);
                PdfWriter.GetInstance(pdfDoc, new FileStream(filename, FileMode.Create));

                //Sporcunun resmini çekme
                Bitmap bm = new Bitmap(System.Drawing.Image.FromFile($@"{InfService.GetCurrentDirectory()}\{sporcu.Resimler.Path}"), 250, 250);

                //Paragraf oluşturma
                Paragraph pHeading = new Paragraph(new Chunk($"{sporcu.Adi} {sporcu.Soyadi}", FontFactory.GetFont(fontNormal.ToString(), 38)));
                pHeading.Alignment = Element.ALIGN_CENTER;

                string ulke_ = "", mevki_ = "", dogumTarihi_ = "", boy_ = "", kilo_ = "", yas_ = "",antrenman_ = "",antStats_ = "" ,antTuru_ = "", antSayisi_ = "", atis_ = "", basarili_ = "", sure_ = "", tarih_ = "", mevkiAdi = "",sure2_ = "";
                if(systemLanguage == "English")
                {
                    ulke_ = "Country";
                    mevki_ = "Position";
                    boy_ = "Height";
                    kilo_ = "Weight";
                    dogumTarihi_ = "Birthday";
                    yas_ = "Age";
                    antrenman_ = "Practice";
                    antStats_ = "Practice Statistics";
                    antTuru_ = "Practice Type";
                    antSayisi_ = "Order Of Practice";
                    atis_ = "Number of Shoots";
                    basarili_ = "Successfull Shooting";
                    sure_ = "Time";
                    tarih_ = "Date";
                    mevkiAdi = InfService.ConvertToEnglish(sporcu.Mevkiler.Adi);
                    sure2_ = "second";
                }
                else if(systemLanguage == "Turkish")
                {
                    ulke_ = "Ülke";
                    mevki_ = "Mevki";
                    boy_ = "Boy";
                    kilo_ = "Kilo";
                    dogumTarihi_ = "Doğum Tarihi";
                    yas_ = "Yaş";
                    antrenman_ = "Antrenman";
                    antStats_ = "Antrenman İstatistikleri";
                    antTuru_ = "Antrenman Türü";
                    antSayisi_ = "Antrenman Sırası";
                    atis_ = "Atış Sayısı";
                    basarili_ = "Başarılı Atış";
                    sure_ = "Süre";
                    tarih_ = "Tarih";
                    mevkiAdi = sporcu.Mevkiler.Adi;
                    sure2_ = "saniye";
                }
                Paragraph ulke = null;
                if(systemLanguage == "Turkish")
                {
                     ulke = new Paragraph(new Phrase($"{ulke_}: {sporcu.ulkeler.UlkeAdi}", fontNormal));
                }
                else if(systemLanguage == "English")
                {
                     ulke = new Paragraph(new Phrase($"{ulke_}: {sporcu.ulkeler.EUlkeAdi}", fontNormal));
                }

                Paragraph mevki = new Paragraph(new Phrase($"{mevki_}: {mevkiAdi}", fontNormal));
                Paragraph boy = new Paragraph(new Phrase($"{boy_}: {sporcu.Boy} cm", fontNormal));
                Paragraph kilo = new Paragraph(new Phrase($"{kilo_}: {sporcu.Kilo} kg", fontNormal));
                Paragraph yas = new Paragraph(new Phrase($"{yas_}: {sporcu.Yas}", fontNormal));

                Paragraph pHeading2 = new Paragraph(new Phrase(antStats_, fontNormal));
                pHeading2.Alignment = Element.ALIGN_CENTER;
                pHeading2.PaddingTop = 5;

                //Div oluşturma 
                PdfDiv divUstBilgi = new PdfDiv();
                divUstBilgi.Width = 500;
                divUstBilgi.Height = 100;

                PdfDiv divResim = new PdfDiv();
                divResim.Float = PdfDiv.FloatType.LEFT;
                divResim.Width = 250;
                divResim.Height = 250;

                PdfDiv divBilgiler = new PdfDiv();
                divBilgiler.Float = PdfDiv.FloatType.RIGHT;
                divBilgiler.Width = 256;
                divBilgiler.Height = 250;
                divBilgiler.TextAlignment = Element.ALIGN_CENTER;

                PdfDiv divPadding = new PdfDiv();
                divPadding.Height = 1f;
                divPadding.PaddingBottom = 5f;

                PdfDiv divIstatistik = new PdfDiv();
                divIstatistik.Width = 1000;
                divIstatistik.Height = 250;
                divIstatistik.Float = PdfDiv.FloatType.LEFT;

                float[] widths = new float[] { 80f, 80f, 80f, 80f, 80f, 80f };
                PdfPTable table = new PdfPTable(6);
                table.PaddingTop = 10f;
                table.TotalWidth = 585f;
                table.LockedWidth = true;
                table.SetWidths(widths);
                
                table.AddCell(new Phrase($"{antTuru_}", fontNormal));
                table.AddCell(new Phrase($"{antSayisi_}", fontNormal));
                table.AddCell(new Phrase($"{atis_}", fontNormal));
                table.AddCell(new Phrase($"{basarili_}", fontNormal));
                table.AddCell(new Phrase($"{sure_}", fontNormal));
                table.AddCell(new Phrase($"{tarih_}", fontNormal));
                foreach (var antrenman in antrenmanlar)
                {
                    if(systemLanguage == "English")
                        table.AddCell(new Phrase(antrenman.EAntrenmanTurleri, fontNormal));
                    else if(systemLanguage == "Turkish")
                        table.AddCell(new Phrase(antrenman.AntrenmanTurleri, fontNormal));
                    table.AddCell(new Phrase(antrenman.AntrenmanSayisi + $". {antrenman_}"));
                    table.AddCell(new Phrase(antrenman.AtisSayisi.ToString()));
                    table.AddCell(new Phrase(antrenman.BasariliAtis.ToString()));
                    table.AddCell(new Phrase(antrenman.AntrenmanSuresi.ToString() + $" {sure2_}"));
                    table.AddCell(new Phrase(antrenman.Tarih.ToString()));
                }

                divIstatistik.AddElement(table);


                divUstBilgi.AddElement(pHeading);

                divResim.AddElement(Image.GetInstance(bm, System.Drawing.Imaging.ImageFormat.Png));

                divBilgiler.AddElement(ulke);
                divBilgiler.AddElement(mevki);
                divBilgiler.AddElement(boy);
                divBilgiler.AddElement(kilo);
                divBilgiler.AddElement(yas);


                pdfDoc.Open();
                pdfDoc.Add(divUstBilgi);
                pdfDoc.Add(divResim);
                pdfDoc.Add(divBilgiler);
                pdfDoc.Add(pHeading2);
                pdfDoc.Add(divPadding);
                pdfDoc.Add(table);
                pdfDoc.Close();
                InfService.ShowMessage("Dosya kaydedildi", "File saved");
            }

           
        }


    }
}
