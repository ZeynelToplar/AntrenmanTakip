using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using AntrenmanTakip.Persistence;

namespace AntrenmanTakip
{
    public partial class DenemeGrafik : Form
    {
        public DenemeGrafik()
        {
            InitializeComponent();
        }

        private void DenemeGrafik_Load(object sender, EventArgs e)
        {
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Aylar",
                Labels = new[] { "Oca", "Şub", "Mar", "Nis", "May", "Haz", "Tem", "Ağu", "Eyl", "Eki", "Kas", "Ara" }

            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Aylık Başarı Grafiği"
            });

            //cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Aylar",
            //    Labels = new[] { "1. Hafta", "2. Hafta", "3. Hafta", "4. Hafta", "5. Hafta" }

            //});
            //cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Haftalik Başarı Grafiği"
            //});

            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

            // init data

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            var values = Context._context.View_AylikBasariliAtis.FirstOrDefault(x => x.Id == 2 && x.AntrenamTuruId == 1);
            List<int> values2 = new List<int>();

            values2.Add((int)(values.OcakBasariliAtisSayisi));
            values2.Add((int)(values.SubatBasariliAtisSayisi));
            values2.Add((int)(values.MartBasariliAtisSayisi));
            values2.Add((int)(values.NisanBasariliAtisSayisi));
            values2.Add((int)(values.MayisBasariliAtisSayisi));
            values2.Add((int)(values.HaziranBasariliAtisSayisi));
            values2.Add((int)(values.TemmuzBasariliAtisSayisi));
            values2.Add((int)(values.AgustosBasariliAtisSayisi));
            values2.Add((int)(values.EylulBasariliAtisSayisi));
            values2.Add((int)(values.EkimBasariliAtisSayisi));
            values2.Add((int)(values.KasimBasariliAtisSayisi));
            values2.Add((int)(values.AralikBasariliAtisSayisi));

            //var values = Context._context.View_HaftalikBasariliAtis.FirstOrDefault(x => x.Id == 2 && x.AntrenamTuruId == 1);

            //values2.Add((int)(values.BirHaftaBasariliAtisSayisi));
            //values2.Add((int)(values.IkiHaftaBasariliAtisSayisi));
            //values2.Add((int)(values.UcHaftaBasariliAtisSayisi));
            //values2.Add((int)(values.DortHaftaBasariliAtisSayisi));
            //values2.Add((int)(values.BesHaftaBasariliAtisSayisi));

            series.Add(new ColumnSeries() { Title = "Toplam Basarili Atis Sayisi", Values = new ChartValues<int>(values2) });
            series.Add(new ColumnSeries() { Title = "Toplam Atis Sayisi", Values = new ChartValues<int>(new[] { 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, }) });
            cartesianChart1.Series = series;
        }
    }
}
