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
using System.Windows.Forms.DataVisualization.Charting;

namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    public partial class FrmGrafikler : Form
    {
        public int antrenmanTuruId;
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        string systemLanguage = DbService.GetApplicationLanguage();
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            var antrenmanlar = Context._context.Antrenmanlar.Where(a => a.SporcuId == Context.sporcu.Id && a.AntrenamTuruId == antrenmanTuruId).ToList();
           
            chart1.Titles.Add("Antrenman İstatistikleri");
            foreach (var item in antrenmanlar)
            {
                if(systemLanguage == "Turkish")
                {
                    chart1.Series["Başarılı"].Points.AddXY(item.AntrenmanSayisi + ". Antrenman", item.BasariliAtis);
                    chart1.Series["Başarısız"].Points.AddXY(item.AntrenmanSayisi + ". Antrenman", item.AtisSayisi - item.BasariliAtis);
                }
               else if(systemLanguage == "English")
                {
                    chart1.Series["Succesfull"].Points.AddXY(item.AntrenmanSayisi + ". Practice", item.BasariliAtis);
                    chart1.Series["Unsuccesfull"].Points.AddXY(item.AntrenmanSayisi + ". Practice", item.AtisSayisi - item.BasariliAtis);
                }
            }
        }
    }
}
