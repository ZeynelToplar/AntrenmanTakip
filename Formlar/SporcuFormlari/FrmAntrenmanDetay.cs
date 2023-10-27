using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    public partial class FrmAntrenmanDetay : Form
    {
        public int antrenmanId = 0;
        public FrmAntrenmanDetay()
        {
            InitializeComponent();
        }

        string systemLanguage = "";
        private void FrmAntrenmanDetay_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            var sonuc = Context._context.AntrenmanBolge.Where(x => x.SporcuId == Context.sporcu.Id && x.AntrenmanTuruId == antrenmanId).ToList();
            var toplamSonuc = sonuc.Where(x => x.BasariliMi).Count();
            lblBolge1.Text = sonuc[0].Bolge.ToString();
            lblBolge2.Text = sonuc[1].Bolge.ToString();
            lblBolge3.Text = sonuc[2].Bolge.ToString();
            lblBolge4.Text = sonuc[3].Bolge.ToString();
            lblBolge5.Text = sonuc[4].Bolge.ToString();
            lblBolge6.Text = sonuc[5].Bolge.ToString();
            lblBolge7.Text = sonuc[6].Bolge.ToString();
            lblBolge8.Text = sonuc[7].Bolge.ToString();
            lblBolge9.Text = sonuc[8].Bolge.ToString();
            lblBolge10.Text = sonuc[9].Bolge.ToString();

            
            if(systemLanguage == "Turkish")
            {
                sonuc1.Text = sonuc[0].BasariliMi ? "Başarılı" : "Başarısız";
                sonuc2.Text = sonuc[1].BasariliMi ? "Başarılı" : "Başarısız";
                sonuc3.Text = sonuc[2].BasariliMi ? "Başarılı" : "Başarısız";
                sonuc4.Text = sonuc[3].BasariliMi ? "Başarılı" : "Başarısız";
                sonuc5.Text = sonuc[4].BasariliMi ? "Başarılı" : "Başarısız";
                sonuc6.Text = sonuc[5].BasariliMi ? "Başarılı" : "Başarısız";
                sonuc7.Text = sonuc[6].BasariliMi ? "Başarılı" : "Başarısız";
                sonuc8.Text = sonuc[7].BasariliMi ? "Başarılı" : "Başarısız";
                sonuc9.Text = sonuc[8].BasariliMi ? "Başarılı" : "Başarısız";
                sonuc10.Text = sonuc[9].BasariliMi ? "Başarılı" : "Başarısız";
            }
            else if(systemLanguage == "English")
            {
                sonuc1.Text = sonuc[0].BasariliMi ? "Successful" : "Unsuccessful";
                sonuc2.Text = sonuc[1].BasariliMi ? "Successful" : "Unsuccessful";
                sonuc3.Text = sonuc[2].BasariliMi ? "Successful" : "Unsuccessful";
                sonuc4.Text = sonuc[3].BasariliMi ? "Successful" : "Unsuccessful";
                sonuc5.Text = sonuc[4].BasariliMi ? "Successful" : "Unsuccessful";
                sonuc6.Text = sonuc[5].BasariliMi ? "Successful" : "Unsuccessful";
                sonuc7.Text = sonuc[6].BasariliMi ? "Successful" : "Unsuccessful";
                sonuc8.Text = sonuc[7].BasariliMi ? "Successful" : "Unsuccessful";
                sonuc9.Text = sonuc[8].BasariliMi ? "Successful" : "Unsuccessful";
                sonuc10.Text = sonuc[9].BasariliMi ? "Successful" : "Unsuccessful";
            }

            var basarisizAtis = 10 - toplamSonuc;
            if(systemLanguage == "Turkish")
                lblGenelSonuc.Text = $"Toplam başarılı atış sayısı : {toplamSonuc}\n Toplam başarısız atış sayısı : {basarisizAtis}";
            else if(systemLanguage == "English")
                lblGenelSonuc.Text = $"Total number of successful shots : {toplamSonuc}\n Total number of unsuccessful shots : {basarisizAtis}";
        }
    }
}
