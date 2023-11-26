using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.Ayarlar
{
    public partial class FrmAntrenmanGorsel : Form
    {
        public AntrenmanTurleri antrenmanTuru;
        public FrmAntrenmanGorsel()
        {
            InitializeComponent();
        }

        OpenFileDialog fileDialogResim;
        string fileName = string.Empty;
        Stream stream = null;
        string path = string.Empty;
        private void btnResim_Click(object sender, EventArgs e)
        {
            fileDialogResim = new OpenFileDialog();
            fileDialogResim.Filter = "Resim Dosyaları (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
            if (fileDialogResim.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialogResim.FileName;
                Bitmap bitmapImage = new Bitmap(file);
                int width = bitmapImage.Width;
                int height = bitmapImage.Height;
                if (width == 64 && height == 64)
                {
                    path = InfService.GetCurrentDirectory();
                    stream = fileDialogResim.OpenFile();
                    fileName = Path.GetFileName(fileDialogResim.FileName);
                    if (systemLanguage == "Turkish")
                        btnResim.Text = $"{fileName} seçildi";
                    else if (systemLanguage == "English")
                        btnResim.Text = $"{fileName} selected";
                    btnResim.TextAlign = ContentAlignment.MiddleRight;
                    pictureBox1.ImageLocation = fileDialogResim.FileName;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    InfService.ShowMessage("Lütfen 64 piksek boyutunda resim seçiniz.", "Please select a 64px image.");
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Resimler existResim;
            var vurusBicimi = Context._context.VurusBicimleri.FirstOrDefault(vb => vb.Id == antrenmanTuru.VurusBicimiId);
            try
            {
                if (File.Exists($@"{path}\{fileName}"))
                {
                    existResim = Context._context.Resimler.First(r => r.Path == fileName);
                    vurusBicimi.ResimId = existResim.Id;
                    Context._context.SaveChanges();
                }
                else
                {
                    FileStream fileStream = new FileStream($@"{path}\{fileName}", FileMode.Create);
                    stream.CopyTo(fileStream);
                    fileStream.FlushAsync();
                    Resimler resim = new Resimler()
                    {
                        Path = fileName
                    };
                    Context._context.Resimler.Add(resim);
                    Context._context.SaveChanges();
                    vurusBicimi.ResimId = resim.Id;
                    Context._context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //todo log!
                throw ex;
            }
            InfService.ShowMessage("İşlem başarılı.", "Process successful");
            this.Close();
        }
        string systemLanguage = "";
        private void FrmAntrenmanGorsel_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
        }
    }
}
