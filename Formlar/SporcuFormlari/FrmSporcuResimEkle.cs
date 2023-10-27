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

namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    public partial class FrmSporcuResimEkle : Form
    {
        public int sporcuId;
        public FrmSporcuResimEkle()
        {
            InitializeComponent();
        }

        OpenFileDialog fileDialogResim;
        string fileName = string.Empty;
        Stream stream = null;
        string path = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            fileDialogResim = new OpenFileDialog();
            fileDialogResim.Filter = "Resim Dosyaları (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
            if (fileDialogResim.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialogResim.FileName;
                Bitmap bitmapImage = new Bitmap(file);
                int width = bitmapImage.Width;
                int height = bitmapImage.Height;
                    path = InfService.GetCurrentDirectory();
                    stream = fileDialogResim.OpenFile();
                    fileName = Path.GetFileName(fileDialogResim.FileName);
                    btnResim.Text = $"{fileName} seçildi";
                    btnResim.TextAlign = ContentAlignment.MiddleRight;
                    pictureBox1.ImageLocation = fileDialogResim.FileName;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        string systemLanguage = "";
        private void FrmSporcuResimEkle_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var sporcu = Context._context.Sporcular.First(s => s.Id == sporcuId);
            Resimler resim = new Resimler()
            {
                Path = fileName
            };
            Context._context.Resimler.Add(resim);
            Context._context.SaveChanges();
            sporcu.ResimId = resim.Id;
            Context._context.SaveChanges();
            try
            {
                FileStream fileStream = new FileStream($@"{path}\{fileName}", FileMode.Create);

                stream.CopyTo(fileStream);
                fileStream.FlushAsync();
            }
            catch (Exception ex)
            {
                //todo log!
                throw ex;
            }
            if(systemLanguage == "Turkish")
                MessageBox.Show("İşlem başarılı.");
            else
                MessageBox.Show("Transaction successful");
            this.Close();
        }
    }
}
