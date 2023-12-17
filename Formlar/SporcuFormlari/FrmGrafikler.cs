using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Rectangle = System.Drawing.Rectangle;

namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    public partial class FrmGrafikler : Form
    {
        public int antrenmanTuruId;
        public int chartType;
        public int statisticType;
        public int year;
        public int month;
        public DateTime baslangic, bitis;
        public int sira1, sira2;
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        string systemLanguage = "";
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            
            systemLanguage = DbService.GetApplicationLanguage();
            #region eski grafik kodlari
            // var antrenmanlar = Context._context.Antrenmanlar.Where(a => a.SporcuId == Context.sporcu.Id && a.AntrenamTuruId == antrenmanTuruId).ToList();
            //if(systemLanguage == "Turkish")
            //     chart1.Titles.Add("Antrenman İstatistikleri");
            //else if(systemLanguage == "English")
            //     chart1.Titles.Add("Training Statistics");
            // foreach (var item in antrenmanlar)
            // {
            //     if(systemLanguage == "Turkish")
            //     {
            //         chart1.Series["Başarılı"].Points.AddXY(item.AntrenmanSayisi + ". Antrenman", item.BasariliAtis);
            //         chart1.Series["Başarısız"].Points.AddXY(item.AntrenmanSayisi + ". Antrenman", item.AtisSayisi - item.BasariliAtis);
            //     }
            //    else if(systemLanguage == "English")
            //     {
            //         chart1.Series["Succesfull"].Points.AddXY(item.AntrenmanSayisi + ". Practice", item.BasariliAtis);
            //         chart1.Series["Unsuccesfull"].Points.AddXY(item.AntrenmanSayisi + ". Practice", item.AtisSayisi - item.BasariliAtis);
            //     }
            // }

            #endregion

            if(chartType == 0 && statisticType == 0)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Aylık Çizgi Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Monthly Line Success Chart";
                LineChartWithMonth();
            }
            else if (chartType == 0 && statisticType == 1)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Haftalık Çizgi Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Weekly Line Success Chart";
                LineChartWithWeek();
            }
            else if (chartType == 1 && statisticType == 0)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Aylık Sütun Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Monthly Column Success Chart";
                ColumnChartWithMonth();
            }
            else if (chartType == 1 && statisticType == 1)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Haftalık Sütun Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Weekly Column Success Chart";
                ColumnChartWithWeek();
            }
            else if (chartType == 2 && statisticType == 0)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Aylık Satır Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Monthly Row Success Chart";
                RowChartWithMonth();
            }
            else if (chartType == 2 && statisticType == 1)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Haftalık Satır Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Weekly Row Success Chart";
                RowChartWithWeek();
            }
            else if (chartType == 0 && statisticType == 2)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Zaman Aralığına Göre Çizgi Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Line Success Chart by Time Range";
                LineChartWithByRange();
            }
            else if (chartType == 1 && statisticType == 2)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Zaman Aralığına Göre Sütun Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Column Success Chart by Time Range";
                ColumnChartWithByRange();
            }
            else if (chartType == 2 && statisticType == 2)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Zaman Aralığına Göre Satır Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Row Success Chart by Time Range";
                RowChartWithByRange();
            }
            else if (chartType == 0 && statisticType == 3)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Sıralı Çizgi Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Sequential Line Success Chart";
                LineChartWithOrder();
            }
            else if (chartType == 1 && statisticType == 3)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Sıralı Sütun Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Sequential Column Success Chart";
                ColumnChartWithOrder();
            }
            else if (chartType == 2 && statisticType == 3)
            {
                if (systemLanguage == "Turkish")
                    this.Text = "Sıralı Sütun Başarı Grafiği";
                else if (systemLanguage == "English")
                    this.Text = "Sequential Row Success Chart";
                RowChartWithOrder();
            }
        }

        private void ChartNamingWithMonth()
        {
            if(systemLanguage == "Turkish")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Aylar",
                    Labels = new List<string>() { "Oca", "Şub", "Mar", "Nis", "May", "Haz", "Tem", "Ağu", "Eyl", "Eki", "Kas", "Ara" }

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Aylık Başarı Grafiği"
                });
            }
            else if(systemLanguage == "English")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Month",
                    Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Monthly Success Chart"
                });
            }
        }
        private void ChartNamingWithWeek()
        {
            if(systemLanguage == "Turkish")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Haftalar",
                    Labels = new[] { "1. Hafta", "2. Hafta", "3. Hafta", "4. Hafta", "5. Hafta" }

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Haftalık Başarı Grafiği"
                });
            }
            else if(systemLanguage == "English")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Weeks",
                    Labels = new[] { "1. Week", "2. Week", "3. Week", "4. Week", "5. Week" }

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Weekly Success Chart"
                });
            }
        }
        private List<int> GetMonthlySuccessRecords()
        {
            var records = Context._context.View_AylikBasariliAtis.FirstOrDefault(x => x.Id == Context.sporcu.Id && x.AntrenamTuruId == antrenmanTuruId && x.Yil == year);
            List<int> values = new List<int>();
            if (records == null)
            {
                
                values = null;
            }
            else
            {
                values.Add((int)(records.OcakBasariliAtisSayisi));
                values.Add((int)(records.SubatBasariliAtisSayisi));
                values.Add((int)(records.MartBasariliAtisSayisi));
                values.Add((int)(records.NisanBasariliAtisSayisi));
                values.Add((int)(records.MayisBasariliAtisSayisi));
                values.Add((int)(records.HaziranBasariliAtisSayisi));
                values.Add((int)(records.TemmuzBasariliAtisSayisi));
                values.Add((int)(records.AgustosBasariliAtisSayisi));
                values.Add((int)(records.EylulBasariliAtisSayisi));
                values.Add((int)(records.EkimBasariliAtisSayisi));
                values.Add((int)(records.KasimBasariliAtisSayisi));
                values.Add((int)(records.AralikBasariliAtisSayisi));
            }
            return values;
        }
        private List<int> GetMonthlyRecords()
        {
            var records = Context._context.View_AylikAtis.FirstOrDefault(x => x.Id == Context.sporcu.Id && x.AntrenamTuruId == antrenmanTuruId && x.Yil == year);
            List<int> values = new List<int>();
            if(records == null)
            {
                values = null;
            }
            else
            {
                values.Add((int)(records.OcakAtisSayisi));
                values.Add((int)(records.SubatAtisSayisi));
                values.Add((int)(records.MartAtisSayisi));
                values.Add((int)(records.NisanAtisSayisi));
                values.Add((int)(records.MayisAtisSayisi));
                values.Add((int)(records.HaziranAtisSayisi));
                values.Add((int)(records.TemmuzAtisSayisi));
                values.Add((int)(records.AgustosAtisSayisi));
                values.Add((int)(records.EylulAtisSayisi));
                values.Add((int)(records.EkimAtisSayisi));
                values.Add((int)(records.KasimAtisSayisi));
                values.Add((int)(records.AralikAtisSayisi));
            }
            
            return values;
        }
        private List<int> GetWeeklySuccessRecords()
        {
            var records = Context._context.View_HaftalikBasariliAtis.FirstOrDefault(x => x.Id == Context.sporcu.Id && x.AntrenamTuruId == antrenmanTuruId && x.Ay == month && x.Yil == year);
            List<int> values = new List<int>();
            if(records == null)
            {
                values = null;
            }
            else
            {
                values.Add((int)(records.BirHaftaBasariliAtisSayisi));
                values.Add((int)(records.IkiHaftaBasariliAtisSayisi));
                values.Add((int)(records.UcHaftaBasariliAtisSayisi));
                values.Add((int)(records.DortHaftaBasariliAtisSayisi));
                values.Add((int)(records.BesHaftaBasariliAtisSayisi));
            }
            
            return values;
        }
        private List<int> GetWeeklyRecords()
        {
            var records = Context._context.View_HaftalikAtis.FirstOrDefault(x => x.Id == Context.sporcu.Id && x.AntrenamTuruId == antrenmanTuruId && x.Ay == month && x.Yil == year);
            List<int> values = new List<int>();
            if(records == null)
            {
                values = null;
            }
            else
            {
                values.Add((int)(records.BirHaftaAtisSayisi));
                values.Add((int)(records.IkiHaftaAtisSayisi));
                values.Add((int)(records.UcHaftaAtisSayisi));
                values.Add((int)(records.DortHaftaAtisSayisi));
                values.Add((int)(records.BesHaftaAtisSayisi));
            }
            
            return values;
        }
        private List<Antrenmanlar> GetOrderRecords()
        {
            return Context._context.Antrenmanlar
                .Where(a => a.SporcuId == Context.sporcu.Id && a.AntrenamTuruId == antrenmanTuruId && a.AntrenmanSayisi >= sira1 && a.AntrenmanSayisi <= sira2)
                .OrderBy(a => a.AntrenmanSayisi).ToList();
        }
        private (string, string) SeriesTitleConverted()
        {
            string titleBasarili = "", titleToplam = "";
            if (systemLanguage == "Turkish")
            {
                titleBasarili = "Toplam Başarılı Atış Sayısı";
                titleToplam = "Toplam Atış Sayısı";
            }
            else if (systemLanguage == "English")
            {
                titleBasarili = "Total Number of Successful Shots";
                titleToplam = "Total Number of Shots";
            }
            return (titleBasarili, titleToplam);
        }

        public void LineChartWithMonth()
        {
            ChartNamingWithMonth();

            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

            // init data

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            List<int> values = GetMonthlySuccessRecords();
            List<int> values2 = GetMonthlyRecords();
            if(values == null || values2 == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();

                series.Add(new LineSeries() { Title = titleBasarili, Values = new ChartValues<int>(values) });
                series.Add(new LineSeries() { Title = titleToplam, Values = new ChartValues<int>(values2) });
                cartesianChart1.Series = series;
            }
        }
        public void LineChartWithWeek()
        {
            ChartNamingWithWeek();
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

            //init data
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            List<int> values = GetWeeklySuccessRecords();
            List<int> values2 = GetWeeklyRecords();

            if (values == null || values2 == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();
                series.Add(new LineSeries() { Title = titleBasarili, Values = new ChartValues<int>(values) });
                series.Add(new LineSeries() { Title = titleToplam, Values = new ChartValues<int>(values2) });
                cartesianChart1.Series = series;
            } 
        }
        public void ColumnChartWithWeek()
        {
            ChartNamingWithWeek();
            cartesianChart1.LegendLocation = LegendLocation.Right;

            //init data
            cartesianChart1.Series.Clear();

            SeriesCollection series = new SeriesCollection();

            List<int> values = GetWeeklySuccessRecords();
            List<int> values2 = GetWeeklyRecords();
            if (values == null || values2 == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();
                series.Add(new ColumnSeries() { Title = titleToplam, Values = new ChartValues<int>(values2) });
                series.Add(new ColumnSeries() { Title = titleBasarili, Values = new ChartValues<int>(values) });
                cartesianChart1.Series = series;
            }        }
        public void ColumnChartWithMonth()
        {
            ChartNamingWithMonth();
            cartesianChart1.LegendLocation = LegendLocation.Right;

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            var values = GetMonthlySuccessRecords();
            var values2 = GetMonthlyRecords();

            if (values == null || values2 == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();
                series.Add(new ColumnSeries() { Title = titleToplam, Values = new ChartValues<int>(values2) });
                series.Add(new ColumnSeries() { Title = titleBasarili, Values = new ChartValues<int>(values) });
                cartesianChart1.Series = series;
            }
        }
        public void RowChartWithWeek()
        {
            //ChartNamingWithWeek();
            if (systemLanguage == "Turkish")
            {
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Haftalar",
                    Labels = new[] { "1. Hafta", "2. Hafta", "3. Hafta", "4. Hafta", "5. Hafta" }

                });
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Haftalık Başarı Grafiği"
                });
            }
            else if (systemLanguage == "English")
            {
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Weeks",
                    Labels = new[] { "1. Week", "2. Week", "3. Week", "4. Week", "5. Week" }

                });
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Weekly Success Chart"
                });
            }
            cartesianChart1.LegendLocation = LegendLocation.Right;

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            var values = GetWeeklySuccessRecords();
            var values2 = GetWeeklyRecords();


            if (values == null || values2 == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();
                series.Add(new RowSeries() { Title = titleToplam, Values = new ChartValues<int>(values2) });
                series.Add(new RowSeries() { Title = titleBasarili, Values = new ChartValues<int>(values) });
                cartesianChart1.Series = series;
            }
        }
        public void RowChartWithMonth()
        {
            //ChartNamingWithMonth();
            if (systemLanguage == "Turkish")
            {
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Aylar",
                    Labels = new[] { "Oca", "Şub", "Mar", "Nis", "May", "Haz", "Tem", "Ağu", "Eyl", "Eki", "Kas", "Ara" }

                });
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Aylık Başarı Grafiği"
                });
            }
            else if (systemLanguage == "English")
            {
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Month",
                    Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }

                });
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Monthly Success Chart"
                });
            }
            cartesianChart1.LegendLocation = LegendLocation.Right;

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            var values = GetMonthlySuccessRecords();
            var values2 = GetMonthlyRecords();

            if (values == null || values2 == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();
                series.Add(new RowSeries() { Title = titleToplam, Values = new ChartValues<int>(values2) });
                series.Add(new RowSeries() { Title = titleBasarili, Values = new ChartValues<int>(values) });
                cartesianChart1.Series = series;
            }
        }
        public void LineChartWithByRange()
        {
            var values = (from antrenman in Context._context.Antrenmanlar
                          where antrenman.SporcuId == Context.sporcu.Id
                                && antrenman.AntrenamTuruId == antrenmanTuruId
                                && antrenman.Tarih >= baslangic
                                && antrenman.Tarih <= bitis
                          group antrenman by new { antrenman.Tarih, antrenman.SporcuId } into g
                          orderby g.Key.Tarih
                          select new
                          {
                              Tarih = g.Key.Tarih,
                              AtisSayisi = g.Sum(a => a.AtisSayisi),
                              BasariliAtis = g.Sum(a => a.BasariliAtis),
                              SporcuId = g.Key.SporcuId
                          }).ToList();
            List<string> tarihler = new List<string>();
            foreach (var item in values)
            {
                tarihler.Add(item.Tarih.ToShortDateString());
            }
            if (systemLanguage == "Turkish")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Tarihler",
                    Labels = tarihler

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Zamana Göre Başarı Grafiği"
                });
            }
            else if (systemLanguage == "English")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Dates",
                    Labels = tarihler

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Time Interval Success Chart"
                });
            }
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

            // init data

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            if (values == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();

                List<int> basariliAtis = new List<int>();
                List<int> toplamAtis = new List<int>();
                foreach (var item in values)
                {
                    basariliAtis.Add(item.BasariliAtis);
                }
                foreach (var item in values)
                {
                    toplamAtis.Add(item.AtisSayisi);
                }

                series.Add(new LineSeries() { Title = titleBasarili, Values = new ChartValues<int>(basariliAtis) });
                series.Add(new LineSeries() { Title = titleToplam, Values = new ChartValues<int>(toplamAtis) });
                cartesianChart1.Series = series;
            }
        }
        public void ColumnChartWithByRange()
        {
            var values = (from antrenman in Context._context.Antrenmanlar
                          where antrenman.SporcuId == Context.sporcu.Id
                                && antrenman.AntrenamTuruId == antrenmanTuruId
                                && antrenman.Tarih >= baslangic
                                && antrenman.Tarih <= bitis
                          group antrenman by new { antrenman.Tarih, antrenman.SporcuId } into g
                          orderby g.Key.Tarih
                          select new
                          {
                              Tarih = g.Key.Tarih,
                              AtisSayisi = g.Sum(a => a.AtisSayisi),
                              BasariliAtis = g.Sum(a => a.BasariliAtis),
                              SporcuId = g.Key.SporcuId
                          }).ToList();
            List<string> tarihler = new List<string>();
            foreach (var item in values)
            {
                tarihler.Add(item.Tarih.ToShortDateString());
            }
            if (systemLanguage == "Turkish")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Tarihler",
                    Labels = tarihler

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Zamana Göre Başarı Grafiği"
                });
            }
            else if (systemLanguage == "English")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Dates",
                    Labels = tarihler

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Time Interval Success Chart"
                });
            }
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

            // init data

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            if (values == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();

                List<int> basariliAtis = new List<int>();
                List<int> toplamAtis = new List<int>();
                foreach (var item in values)
                {
                    basariliAtis.Add(item.BasariliAtis);
                }
                foreach (var item in values)
                {
                    toplamAtis.Add(item.AtisSayisi);
                }

                series.Add(new ColumnSeries() { Title = titleBasarili, Values = new ChartValues<int>(basariliAtis) });
                series.Add(new ColumnSeries() { Title = titleToplam, Values = new ChartValues<int>(toplamAtis) });
                cartesianChart1.Series = series;
            }
        }
        public void RowChartWithByRange()
        {
            var values = (from antrenman in Context._context.Antrenmanlar
                          where antrenman.SporcuId == Context.sporcu.Id
                                && antrenman.AntrenamTuruId == antrenmanTuruId
                                && antrenman.Tarih >= baslangic
                                && antrenman.Tarih <= bitis
                          group antrenman by new { antrenman.Tarih, antrenman.SporcuId } into g
                          orderby g.Key.Tarih
                          select new
                          {
                              Tarih = g.Key.Tarih,
                              AtisSayisi = g.Sum(a => a.AtisSayisi),
                              BasariliAtis = g.Sum(a => a.BasariliAtis),
                              SporcuId = g.Key.SporcuId
                          }).ToList();
            List<string> tarihler = new List<string>();
            foreach (var item in values)
            {
                tarihler.Add(item.Tarih.ToShortDateString());
            }
            if(systemLanguage == "Turkish")
            {
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Tarihler",
                    Labels = tarihler

                });
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Zamana Göre Başarı Grafiği"
                });
            }
            else if (systemLanguage == "English")
            {
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Dates",
                    Labels = tarihler

                });
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Time Interval Success Chart"
                });
            }

            // init data

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            if (values == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();

                List<int> basariliAtis = new List<int>();
                List<int> toplamAtis = new List<int>();
                foreach (var item in values)
                {
                    basariliAtis.Add(item.BasariliAtis);
                }
                foreach (var item in values)
                {
                    toplamAtis.Add(item.AtisSayisi);
                }

                series.Add(new RowSeries() { Title = titleToplam, Values = new ChartValues<int>(toplamAtis) });
                series.Add(new RowSeries() { Title = titleBasarili, Values = new ChartValues<int>(basariliAtis) });
                cartesianChart1.Series = series;
            }
        }
        public void LineChartWithOrder()
        {
            var values = GetOrderRecords();
            List<string> siralar = new List<string>();
            foreach (var item in values)
            {
                siralar.Add(item.AntrenmanSayisi.ToString() + ". Antrenman");
            }

           if(systemLanguage == "Turkish")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Sıralar",
                    Labels = siralar

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Sıralı Başarı Grafiği"
                });
            }
           else if (systemLanguage == "English")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Orders",
                    Labels = siralar

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Order Success Chart"
                });
            }
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

            // init data

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            if (values == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();

                List<int> basariliAtis = new List<int>();
                List<int> toplamAtis = new List<int>();
                foreach (var item in values)
                {
                    basariliAtis.Add(item.BasariliAtis);
                }
                foreach (var item in values)
                {
                    toplamAtis.Add(item.AtisSayisi);
                }

                series.Add(new LineSeries() { Title = titleBasarili, Values = new ChartValues<int>(basariliAtis) });
                series.Add(new LineSeries() { Title = titleToplam, Values = new ChartValues<int>(toplamAtis) });
                cartesianChart1.Series = series;
            }
        }
        public void ColumnChartWithOrder()
        {
            var values = GetOrderRecords();
            List<string> siralar = new List<string>();
            foreach (var item in values)
            {
                siralar.Add(item.AntrenmanSayisi.ToString() + ". Antrenman");
            }

            if (systemLanguage == "Turkish")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Sıralar",
                    Labels = siralar

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Sıralı Başarı Grafiği"
                });
            }
            else if (systemLanguage == "English")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Orders",
                    Labels = siralar

                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Order Success Chart"
                });
            }
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

            // init data

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            if (values == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();

                List<int> basariliAtis = new List<int>();
                List<int> toplamAtis = new List<int>();
                foreach (var item in values)
                {
                    basariliAtis.Add(item.BasariliAtis);
                }
                foreach (var item in values)
                {
                    toplamAtis.Add(item.AtisSayisi);
                }

                series.Add(new ColumnSeries() { Title = titleBasarili, Values = new ChartValues<int>(basariliAtis) });
                series.Add(new ColumnSeries() { Title = titleToplam, Values = new ChartValues<int>(toplamAtis) });
                cartesianChart1.Series = series;
            }
        }
        public void RowChartWithOrder()
        {
            var values = GetOrderRecords();
            List<string> siralar = new List<string>();
            foreach (var item in values)
            {
                siralar.Add(item.AntrenmanSayisi.ToString() + ". Antrenman");
            }

            if (systemLanguage == "Turkish")
            {
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Sıralar",
                    Labels = siralar

                });
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Sıralı Başarı Grafiği"
                });
            }
            else if (systemLanguage == "English")
            {
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Orders",
                    Labels = siralar

                });
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Order Success Chart"
                });
            }
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

            // init data

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            if (values == null)
            {
                InfService.ShowMessage("Antrenman kaydı bulunamadı.", "No training records found");
                this.Close();
            }
            else
            {
                var (titleBasarili, titleToplam) = SeriesTitleConverted();

                List<int> basariliAtis = new List<int>();
                List<int> toplamAtis = new List<int>();
                foreach (var item in values)
                {
                    basariliAtis.Add(item.BasariliAtis);
                }
                foreach (var item in values)
                {
                    toplamAtis.Add(item.AtisSayisi);
                }

                series.Add(new RowSeries() { Title = titleBasarili, Values = new ChartValues<int>(toplamAtis) });
                series.Add(new RowSeries() { Title = titleToplam, Values = new ChartValues<int>(basariliAtis) });
                cartesianChart1.Series = series;
            }
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveDialog = new System.Windows.Forms.SaveFileDialog();
            saveDialog.DefaultExt = ".PDF";
            saveDialog.Filter = "PDF Document | *PDF";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string pdfFilePath = saveDialog.FileName;

                // iTextSharp kullanarak PDF oluşturma
                using (PdfWriter writer = new PdfWriter(pdfFilePath))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        PageSize a4PageSize = PageSize.A4;
                        Document document = new Document(pdf, a4PageSize);

                        // PDF'e eklemek istediğiniz nesneleri ekleyin

                        // Örneğin, formdaki bir Chart nesnesinin görüntüsünü alın
                        Bitmap chartImage = new Bitmap(cartesianChart1.Width, cartesianChart1.Height);
                        cartesianChart1.DrawToBitmap(chartImage, new Rectangle(0, 0, cartesianChart1.Width, cartesianChart1.Height));

                        // Görüntüyü PDF dosyasına ekleyin
                        using (MemoryStream stream = new MemoryStream())
                        {
                            chartImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                            byte[] imageBytes = stream.ToArray();

                            ImageData imageData = ImageDataFactory.Create(imageBytes);
                            iText.Layout.Element.Image chartPdfImage = new iText.Layout.Element.Image(imageData);

                            // A4 sayfasına tam yerleşecek şekilde boyut ve pozisyon ayarları
                            float maxWidth = a4PageSize.GetWidth() - document.GetLeftMargin() - document.GetRightMargin();
                            float maxHeight = a4PageSize.GetHeight() - document.GetTopMargin() - document.GetBottomMargin();

                            // İlgili oranları belirleyin (örneğin, genişliği iki katına çıkartalım)
                            float widthRatio = 2.0f;
                            float heightRatio = 2.0f;

                            float scaledWidth = cartesianChart1.Width * widthRatio;
                            float scaledHeight = cartesianChart1.Height * heightRatio;

                            float xPosition = (maxWidth - scaledWidth) / 2 + document.GetLeftMargin();
                            float yPosition = (maxHeight - scaledHeight) / 2 + document.GetBottomMargin();

                            // Görüntüyü eklerken genişliği ve yüksekliği belirleyebilirsiniz
                            document.Add(chartPdfImage.SetWidth(scaledWidth).SetHeight(scaledHeight));
                            InfService.ShowMessage("PDF kaydedildi.", "PDF saved.");
                        }
                    }
                }
            }
        }
    }
}
