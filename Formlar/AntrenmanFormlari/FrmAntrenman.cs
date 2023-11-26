using AntrenmanTakip.Formlar.Ayarlar;
using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using IndustrialNetworks.ModbusCore.ASCII;
using IndustrialNetworks.ModbusCore.DataTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IndustrialNetworks.ModbusCore.Comm;
using Newtonsoft.Json.Linq;


namespace AntrenmanTakip.Formlar.AntrenmanFormlari
{
    public partial class FrmAntrenman : Form
    {
        //PLC Haberleşme Ayarlari
        private IModbusMaster objIModbusMaster = null;
        private byte slaveAddress = 3;
        private uint startAddress = 4096; // start address : D0.
        private ushort numberOfPoints = 1; // Reads 10 registers.
        private byte[] d0 = Int.ToByteArray(0); //D0 Register'ına 0 değerini yazma
        public string port; // Port bilgisi
        //
        private Form1 _frm1;
        private FrmAyarlar _frmAyarlar;
        private FrmGiris _frmGiris;

        public int topKonum;
        public int topGelisSekli;
        public int vurusBicimi;
        Sporcular sporcu;

        Button btn;
        string systemLanguage = "";
        public FrmAntrenman()
        {
            InitializeComponent();
            this.TopMost = true;
        }


        private void FrmAntrenman_Load(object sender, EventArgs e)
        {
            if (txtBasariliAtis.Text == "")
                btnKaydet.Enabled = false;
            //Veri Tabanı işlemleri
            systemLanguage = DbService.GetApplicationLanguage();
            Kullanicilar authenticateUser = DbService.GetUser(Context.kullanici.Id);
            if (authenticateUser.YetkiId == 0)
            {
                var sporcular = (from s in Context._context.Sporcular
                                 join m in Context._context.Mevkiler on s.MevkiId equals m.Id
                                 where m.Id != 2
                                 select new
                                 {
                                     Id = s.Id,
                                     Adi = s.Adi,
                                     Soyadi = s.Soyadi,
                                     Yas = s.Yas,
                                     Boy = s.Boy,
                                     Kilo = s.Kilo,
                                     Mevkiler = m
                                 }).ToList();
                //gridViewSporcular.DataSource = sporcular;
                if (systemLanguage == "Turkish")
                {
                    foreach (var sporcu in sporcular)
                    {
                        gridViewSporcular.Rows.Add(new object[]
                        {
                            sporcu.Id,
                            sporcu.Adi,
                            sporcu.Soyadi,
                            sporcu.Yas,
                            sporcu.Boy,
                            sporcu.Kilo,
                            sporcu.Mevkiler.Adi
                        });
                    }
                }
                else if (systemLanguage == "English")
                {
                    foreach (var sporcu in sporcular)
                    {
                        string mevki = "";
                        mevki = InfService.ConvertToEnglish(sporcu.Mevkiler.Adi);
                        gridViewSporcular.Rows.Add(new object[]
                        {
                            sporcu.Id,
                            sporcu.Adi,
                            sporcu.Soyadi,
                            sporcu.Yas,
                            sporcu.Boy,
                            sporcu.Kilo,
                            mevki
                        });
                    }
                }
            }
            else if (authenticateUser.YetkiId == 1)
            {
                var sporcular = (from ks in Context._context.KullaniciSporcular
                                 join s in Context._context.Sporcular on ks.SporcuId equals s.Id
                                 join me in Context._context.Mevkiler on s.MevkiId equals me.Id
                                 where ks.KullaniciId == authenticateUser.Id && me.Id != 2
                                 select new
                                 {
                                     Id = s.Id,
                                     Adi = s.Adi,
                                     Soyadi = s.Soyadi,
                                     Yas = s.Yas,
                                     Boy = s.Boy,
                                     Kilo = s.Kilo,
                                     Mevkiler = s.Mevkiler,
                                 }).ToList();
                //gridViewSporcular.DataSource = sporcular;
                foreach (var sporcu in sporcular)
                {
                    if (systemLanguage == "Turkish")
                    {
                        gridViewSporcular.Rows.Add(new object[]
                        {
                            sporcu.Id,
                            sporcu.Adi,
                            sporcu.Soyadi,
                            sporcu.Yas,
                            sporcu.Boy,
                            sporcu.Kilo,
                            sporcu.Mevkiler.Adi
                         });
                    }
                    else if (systemLanguage == "English")
                    {
                        string mevki = "";
                        mevki = InfService.ConvertToEnglish(sporcu.Mevkiler.Adi);
                        gridViewSporcular.Rows.Add(new object[]
                        {
                            sporcu.Id,
                            sporcu.Adi,
                            sporcu.Soyadi,
                            sporcu.Yas,
                            sporcu.Boy,
                            sporcu.Kilo,
                            mevki
                         });
                    }

                }
            }
            btnYerden.Enabled = false;
            btnHavadan.Enabled = false;
            btnFalsolu.Enabled = false;
            //Vuruş Biçimleri butonlarını yükle
            int x = 30, y = 47;
            int sayac = 0;
            var vb = (from vb_ in Context._context.VurusBicimleri
                      join r in Context._context.Resimler on vb_.ResimId equals r.Id
                      select new
                      {
                          Adi = vb_.Adi,
                          EAdi = vb_.EAdi,
                          Resimler = r
                      }).ToList();
            for (int i = 1; i <= vb.Count; i++)
            {

                var btnName = CharacterRegularity(vb[i - 1].Adi.ToString());
                btn = new Button();
                btn.Name = $"btn{btnName}";
                if (systemLanguage == "Turkish")
                    btn.Text = vb[i - 1].Adi;
                else if (systemLanguage == "English")
                    btn.Text = vb[i - 1].EAdi;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Image = Image.FromFile($@"{GetCurrentDirectory()}\{vb[i - 1].Resimler.Path}");
                btn.Size = new Size(169, 104);
                btn.Location = new Point(x, y);
                btn.BackColor = Color.DimGray;
                btn.Font = new Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                btn.Enabled = false;
                btn.IsAccessible = true;
                btn.TabIndex = sayac;
                btn.Click += Btn_Click;
                panel1.Controls.Add(btn);
                x += btn.Width + 5;
                if (i % 3 == 0)
                {
                    x = 30;
                    y += btn.Height + 5;
                }
                sayac++;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var panel1 = this.Controls.Find("panel1", true) as Control[];
            Control secilenButton = sender as Control;
            List<Control> digerButonlar = new List<Control>();
            for (int i = 0; i < panel1[0].Controls.Count; i++)
            {
                var item = panel1[0].Controls[i];
                if (item.Name == secilenButton.Name)
                    continue;

                digerButonlar.Add(item);
            }
            //RenkDegistirVurusBicimleri(secilenButton, digerButonlar);
            lblAntrenmanTuru.Text = lblAntrenmanTuru.Text.Substring(0, lblAntrenmanTuru.Text.LastIndexOf("-"));
            lblAntrenmanTuru.Text += $"- {button.Text}";
            var vurusBicimleri = (from vb_ in Context._context.VurusBicimleri
                                  join r in Context._context.Resimler on vb_.ResimId equals r.Id
                                  select new
                                  {
                                      Id = vb_.Id,
                                      Adi = vb_.Adi,
                                      EAdi = vb_.EAdi,
                                      Resimler = r
                                  }).ToList();
            foreach (var vb in vurusBicimleri)
            {
                if (systemLanguage == "Turkish")
                {
                    if (button.Text == vb.Adi)
                    {
                        vurusBicimi = vb.Id;
                        break;
                    }
                }
                else if (systemLanguage == "English")
                {
                    if (button.Text == vb.EAdi)
                    {
                        vurusBicimi = vb.Id;
                        break;
                    }
                }
            }
        }

        //public list<vurusbicimleri> getvurusbicimleri()
        //{

        //    return (from vb in context._context.vurusbicimleri
        //            join r in context._context.resimler on vb.resimıd equals r.ıd select new 
        //            {
        //                adi = vb.adi,
        //                eadi= vb.eadi,
        //                resimler = r
        //            }).tolist();
        //}
        private string GetCurrentDirectory()
        {
            string currentDirectory = Environment.CurrentDirectory;
            currentDirectory = currentDirectory.Substring(0, currentDirectory.IndexOf("\\bin"));
            string path = Path.Combine(currentDirectory + @"\Resources");
            return path;
        }
        private string CharacterRegularity(string text)
        {
            text = text.Replace(" ", "");
            text = text.Replace("Ğ", "G");
            text = text.Replace("ğ", "g");
            text = text.Replace("Ç", "C");
            text = text.Replace("ç", "c");
            text = text.Replace("İ", "I");
            text = text.Replace("ı", "i");
            text = text.Replace("Ö", "O");
            text = text.Replace("ö", "o");
            text = text.Replace("Ş", "S");
            text = text.Replace("ş", "s");
            text = text.Replace("Ü", "U");
            text = text.Replace("ü", "u");
            return text;
        }

        private void btnKarsidan_Click(object sender, EventArgs e)
        {
            btnSol.BackColor = SystemColors.GradientInactiveCaption;
            btnSag.BackColor = SystemColors.GradientInactiveCaption;
            btnKarsidan.BackColor = Color.LightGreen;
            TopGelisButonAktifEt();
            topKonum = 1;
            lblAntrenmanTuru.Visible = true;
            lblAntrenmanTuru.Text = "";
            if (systemLanguage == "Turkish")
                lblAntrenmanTuru.Text = "KARŞIDAN - ";
            else
                lblAntrenmanTuru.Text = "ACROSS - ";
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            btnKarsidan.BackColor = SystemColors.GradientInactiveCaption;
            btnSag.BackColor = SystemColors.GradientInactiveCaption;
            btnSol.BackColor = Color.LightGreen;
            TopGelisButonAktifEt();
            topKonum = 3;
            lblAntrenmanTuru.Visible = true;
            lblAntrenmanTuru.Text = "";
            if (systemLanguage == "Turkish")
                lblAntrenmanTuru.Text = "SOLDAN - ";
            else
                lblAntrenmanTuru.Text = "LEFT - ";
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            btnKarsidan.BackColor = SystemColors.GradientInactiveCaption;
            btnSol.BackColor = SystemColors.GradientInactiveCaption;
            btnSag.BackColor = Color.LightGreen;
            TopGelisButonAktifEt();
            topKonum = 2;
            lblAntrenmanTuru.Visible = true;
            lblAntrenmanTuru.Text = "";
            if (systemLanguage == "Turkish")
                lblAntrenmanTuru.Text = "SAĞDAN - ";
            else
                lblAntrenmanTuru.Text = "RIGHT - ";
        }

        private void btnHavadan_Click(object sender, EventArgs e)
        {
            btnYerden.BackColor = SystemColors.GradientInactiveCaption;
            btnFalsolu.BackColor = SystemColors.GradientInactiveCaption;
            btnHavadan.BackColor = Color.LightGreen;
            topGelisSekli = 2;
            HavadanButonClick();
            lblAntrenmanTuru.Text = lblAntrenmanTuru.Text.Substring(0, lblAntrenmanTuru.Text.IndexOf("-"));
            if (systemLanguage == "Turkish")
                lblAntrenmanTuru.Text += "- HAVADAN - ";
            else
                lblAntrenmanTuru.Text += "- FROM THE AIR - ";
        }

        private void btnYerden_Click(object sender, EventArgs e)
        {
            btnFalsolu.BackColor = SystemColors.GradientInactiveCaption;
            btnHavadan.BackColor = SystemColors.GradientInactiveCaption;
            btnYerden.BackColor = Color.LightGreen;
            topGelisSekli = 1;
            YerdenButonClick();
            lblAntrenmanTuru.Text = lblAntrenmanTuru.Text.Substring(0, lblAntrenmanTuru.Text.IndexOf("-"));
            if (systemLanguage == "Turkish")
                lblAntrenmanTuru.Text += "- YERDEN - ";
            else
                lblAntrenmanTuru.Text += "- FROM THE GROUND - ";
        }

        private void btnFalsolu_Click(object sender, EventArgs e)
        {
            btnHavadan.BackColor = SystemColors.GradientInactiveCaption;
            btnYerden.BackColor = SystemColors.GradientInactiveCaption;
            btnFalsolu.BackColor = Color.LightGreen;
            topGelisSekli = 3;
            FalsoluButonClick();
            lblAntrenmanTuru.Text = lblAntrenmanTuru.Text.Substring(0, lblAntrenmanTuru.Text.IndexOf("-"));
            if (systemLanguage == "Turkish")
                lblAntrenmanTuru.Text += "- FALSOLU - ";
            else
                lblAntrenmanTuru.Text += "- CURVEBALL - ";
        }

        private void TopGelisButonAktifEt()
        {
            btnYerden.Enabled = true;
            btnHavadan.Enabled = true;
            btnFalsolu.Enabled = true;

            btnYerden.Cursor = Cursors.Hand;
            btnHavadan.Cursor = Cursors.Hand;
            btnFalsolu.Cursor = Cursors.Hand;

            btnYerden.BackColor = SystemColors.GradientInactiveCaption;
            btnHavadan.BackColor = SystemColors.GradientInactiveCaption;
            btnFalsolu.BackColor = SystemColors.GradientInactiveCaption;
        }
        private void HavadanButonClick()
        {
            var havadan = Context._context.View_VurusBicimleri.Where(vb => vb.Id == 2).Select(x => new
            {
                x.Adi,
                x.EAdi
            }).ToList();
            var yerden = Context._context.View_VurusBicimleri.Where(vb => vb.Id == 1).Select(x => new { x.Adi, x.EAdi }).ToList();
            var falsolu = Context._context.View_VurusBicimleri.Where(vb => vb.Id == 3).Select(x => new
            {
                x.Adi,
                x.EAdi
            }).ToList();
            var panel1 = this.Controls.Find("panel1", true) as Control[];
            if (systemLanguage == "Turkish")
            {
                for (int i = 0; i < havadan.Count; i++)
                {
                    for (int j = 0; j < panel1[0].Controls.Count; j++)
                    {
                        var item = panel1[0].Controls[j];
                        if (item.Text == havadan[i].Adi)
                            HavadanVurusBicimiAktifEt(item);
                    }
                }
                for (int k = 0; k < yerden.Count; k++)
                {
                    for (int z = 0; z < panel1[0].Controls.Count; z++)
                    {
                        var item = panel1[0].Controls[z];
                        if (item.Text == yerden[k].Adi)
                            YerdenVurusBicimButonPasifYap(item);
                    }
                }
                var excFalsolu = falsolu.Except(havadan).ToList();
                for (int a = 0; a < excFalsolu.Count; a++)
                {
                    for (int b = 0; b < panel1[0].Controls.Count; b++)
                    {
                        var item = panel1[0].Controls[b];
                        if (item.Text == excFalsolu[a].Adi)
                            FalsoluVurusBicimiPasifYap(item);
                    }
                }
            }
            else if (systemLanguage == "English")
            {
                for (int i = 0; i < havadan.Count; i++)
                {
                    for (int j = 0; j < panel1[0].Controls.Count; j++)
                    {
                        var item = panel1[0].Controls[j];
                        if (item.Text == havadan[i].EAdi)
                            HavadanVurusBicimiAktifEt(item);
                    }
                }
                for (int k = 0; k < yerden.Count; k++)
                {
                    for (int z = 0; z < panel1[0].Controls.Count; z++)
                    {
                        var item = panel1[0].Controls[z];
                        if (item.Text == yerden[k].EAdi)
                            YerdenVurusBicimButonPasifYap(item);
                    }
                }
                var excFalsolu = falsolu.Except(havadan).ToList();
                for (int a = 0; a < excFalsolu.Count; a++)
                {
                    for (int b = 0; b < panel1[0].Controls.Count; b++)
                    {
                        var item = panel1[0].Controls[b];
                        if (item.Text == excFalsolu[a].EAdi)
                            FalsoluVurusBicimiPasifYap(item);
                    }
                }
            }
        }
        private void YerdenButonClick()
        {
            var havadan = Context._context.View_VurusBicimleri.Where(vb => vb.Id == 2).Select(x => new
            {
                x.Adi,
                x.EAdi
            }).ToList();
            var yerden = Context._context.View_VurusBicimleri.Where(vb => vb.Id == 1).Select(x => new { x.Adi, x.EAdi }).ToList();
            var falsolu = Context._context.View_VurusBicimleri.Where(vb => vb.Id == 3).Select(x => new
            {
                x.Adi
                ,
                x.EAdi
            }).ToList();
            var panel1 = this.Controls.Find("panel1", true) as Control[];
            if (systemLanguage == "Turkish")
            {
                for (int i = 0; i < yerden.Count; i++)
                {
                    for (int j = 0; j < panel1[0].Controls.Count; j++)
                    {
                        var item = panel1[0].Controls[j];
                        if (item.Text == yerden[i].Adi)
                            HavadanVurusBicimiAktifEt(item);
                    }
                }
                for (int k = 0; k < havadan.Count; k++)
                {
                    for (int z = 0; z < panel1[0].Controls.Count; z++)
                    {
                        var item = panel1[0].Controls[z];
                        if (item.Text == havadan[k].Adi)
                            YerdenVurusBicimButonPasifYap(item);
                    }
                }
                for (int a = 0; a < falsolu.Count; a++)
                {
                    for (int b = 0; b < panel1[0].Controls.Count; b++)
                    {
                        var item = panel1[0].Controls[b];
                        if (item.Text == falsolu[a].Adi)
                            FalsoluVurusBicimiPasifYap(item);
                    }
                }
            }
            else if (systemLanguage == "English")
            {
                for (int i = 0; i < yerden.Count; i++)
                {
                    for (int j = 0; j < panel1[0].Controls.Count; j++)
                    {
                        var item = panel1[0].Controls[j];
                        if (item.Text == yerden[i].EAdi)
                            HavadanVurusBicimiAktifEt(item);
                    }
                }
                for (int k = 0; k < havadan.Count; k++)
                {
                    for (int z = 0; z < panel1[0].Controls.Count; z++)
                    {
                        var item = panel1[0].Controls[z];
                        if (item.Text == havadan[k].EAdi)
                            YerdenVurusBicimButonPasifYap(item);
                    }
                }
                for (int a = 0; a < falsolu.Count; a++)
                {
                    for (int b = 0; b < panel1[0].Controls.Count; b++)
                    {
                        var item = panel1[0].Controls[b];
                        if (item.Text == falsolu[a].EAdi)
                            FalsoluVurusBicimiPasifYap(item);
                    }
                }
            }

        }
        private void FalsoluButonClick()
        {
            var havadan = Context._context.View_VurusBicimleri.Where(vb => vb.Id == 2).Select(x => new
            {
                x.Adi,
                x.EAdi
            }).ToList();
            var yerden = Context._context.View_VurusBicimleri.Where(vb => vb.Id == 1).Select(x => new { x.Adi, x.EAdi }).ToList();
            var falsolu = Context._context.View_VurusBicimleri.Where(vb => vb.Id == 3).Select(x => new { x.Adi, x.EAdi }).ToList();
            var panel1 = this.Controls.Find("panel1", true) as Control[];
            if (systemLanguage == "Turkish")
            {
                for (int i = 0; i < falsolu.Count; i++)
                {
                    for (int j = 0; j < panel1[0].Controls.Count; j++)
                    {
                        var item = panel1[0].Controls[j];
                        if (item.Text == falsolu[i].Adi)
                            FalsoluVurusBicimiAktifEt(item);
                    }
                }
                for (int k = 0; k < yerden.Count; k++)
                {
                    for (int z = 0; z < panel1[0].Controls.Count; z++)
                    {
                        var item = panel1[0].Controls[z];
                        if (item.Text == yerden[k].Adi)
                            YerdenVurusBicimButonPasifYap(item);
                    }
                }
                var excHavadan = havadan.Except(falsolu).ToList();
                for (int a = 0; a < excHavadan.Count; a++)
                {
                    for (int b = 0; b < panel1[0].Controls.Count; b++)
                    {
                        var item = panel1[0].Controls[b];
                        if (item.Text == excHavadan[a].Adi)
                            HavadanVurusBicimiPasifYap(item);
                    }
                }
            }
            else if (systemLanguage == "English")
            {
                for (int i = 0; i < falsolu.Count; i++)
                {
                    for (int j = 0; j < panel1[0].Controls.Count; j++)
                    {
                        var item = panel1[0].Controls[j];
                        if (item.Text == falsolu[i].EAdi)
                            FalsoluVurusBicimiAktifEt(item);
                    }
                }
                for (int k = 0; k < yerden.Count; k++)
                {
                    for (int z = 0; z < panel1[0].Controls.Count; z++)
                    {
                        var item = panel1[0].Controls[z];
                        if (item.Text == yerden[k].EAdi)
                            YerdenVurusBicimButonPasifYap(item);
                    }
                }
                var excHavadan = havadan.Except(falsolu).ToList();
                for (int a = 0; a < excHavadan.Count; a++)
                {
                    for (int b = 0; b < panel1[0].Controls.Count; b++)
                    {
                        var item = panel1[0].Controls[b];
                        if (item.Text == excHavadan[a].EAdi)
                            HavadanVurusBicimiPasifYap(item);
                    }
                }
            }

        }
        private void YerdenVurusBicimButonAktifEt(Control button)
        {
            button.Enabled = true;
            button.Cursor = Cursors.Hand;
            button.BackColor = SystemColors.GradientInactiveCaption;
        }
        private void YerdenVurusBicimButonPasifYap(Control button)
        {
            button.Enabled = false;
            button.Cursor = Cursors.Default;
            button.BackColor = Color.DimGray;
        }
        private void FalsoluVurusBicimiAktifEt(Control button)
        {
            button.Enabled = true;
            button.Cursor = Cursors.Hand;
            button.BackColor = SystemColors.GradientInactiveCaption;
        }
        private void FalsoluVurusBicimiPasifYap(Control button)
        {
            button.Enabled = false;
            button.Cursor = Cursors.Default;
            button.BackColor = Color.DimGray;
        }
        private void HavadanVurusBicimiAktifEt(Control button)
        {
            button.Enabled = true;
            button.Cursor = Cursors.Hand;
            button.BackColor = SystemColors.GradientInactiveCaption;
        }
        private void HavadanVurusBicimiPasifYap(Control button)
        {
            button.Enabled = false;
            button.Cursor = Cursors.Default;
            button.BackColor = Color.DimGray;
        }
        private int sayac = 1;
        private int sayacSaniye = 0, sayacDakika = 0;
        int sure = 0;
        private void timerAntrenman_Tick(object sender, EventArgs e)
        {
            sure++;
            sayacSaniye++;
            if (sayacSaniye <= 60)
            {
                if (sayacSaniye == 60)
                {
                    sayacDakika++;
                    sayacSaniye = 0;
                }
                if (sayacSaniye < 10)
                    lblZaman.Text = $"0{sayacDakika}:0{sayacSaniye}";
                else
                    lblZaman.Text = $"0{sayacDakika}:{sayacSaniye}";
            }
        }

        private void btnAntrenmanBaslat_Click(object sender, EventArgs e)
        {
            if (topKonum != 0 && topGelisSekli != 0 && vurusBicimi != 0 && sporcu != null)
            {
                sayac++;
                if (sayac % 2 == 0)
                {
                    //PLC ile bağlantı kurma
                    try
                    {
                        objIModbusMaster = new ModbusASCIIMaster(port, 9600, 7, System.IO.Ports.StopBits.One, System.IO.Ports.Parity.Even);
                        objIModbusMaster.Connection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //
                    timerAntrenman.Enabled = true;
                    timerAntrenman.Start();
                    if (systemLanguage == "Turkish")
                        btnAntrenmanBaslat.Text = "Antrenman Bitir";
                    else
                        btnAntrenmanBaslat.Text = "Finish The Training";
                    btnAntrenmanBaslat.Image = Properties.Resources.bitir48px;
                    btnAntrenmanBaslat.ImageAlign = ContentAlignment.MiddleLeft;
                    btnAntrenmanBaslat.BackColor = Color.Red;
                    btnAntrenmanBaslat.Cursor = Cursors.Hand;


                }
                else
                {
                    //PLC'den veri çekme operasyonuna start verme

                    try
                    {
                        ModbusScan.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //
                    txtBasariliAtis.Text += basariliAtis;
                    btnKaydet.Enabled = true;
                    if (systemLanguage == "Turkish")
                        btnAntrenmanBaslat.Text = "Antrenman Başlat";
                    else
                        btnAntrenmanBaslat.Text = "Start The Training";
                    btnAntrenmanBaslat.BackColor = Color.ForestGreen;
                    btnAntrenmanBaslat.Image = Properties.Resources.baslat4_48px;
                    btnAntrenmanBaslat.ImageAlign = ContentAlignment.MiddleLeft;
                    timerAntrenman.Stop();
                    sayacSaniye = 0;
                    sayacDakika = 0;
                    timerAntrenman.Enabled = false;
                    TumButonlariPasifYap();
                    sporcu = null;
                    if (systemLanguage == "Turkish")
                    {
                        label1.Text = "Lütfen antrenman yaptırmak istediğiniz sporcuyu seçiniz";
                        lblAntrenmanTuru.Text = "Antrenman türü seçilmedi.";
                    }
                    else if (systemLanguage == "English")
                    {
                        label1.Text = "Please select the player you want to practice";
                        lblAntrenmanTuru.Text = "No practice type selected";
                    }
                }
            }
            else
            {
                InfService.ShowMessage("Lütfen Antrenman türünü ve sporcuyu seçiniz!", "Please select Training type and player!");
            }
        }

        private void TumButonlariPasifYap()
        {
            btnKarsidan.BackColor = SystemColors.GradientInactiveCaption;
            btnSol.BackColor = SystemColors.GradientInactiveCaption;
            btnSag.BackColor = SystemColors.GradientInactiveCaption;

            btnHavadan.BackColor = Color.DimGray;
            btnYerden.BackColor = Color.DimGray;
            btnFalsolu.BackColor = Color.DimGray;
            var panel1 = this.Controls.Find("panel1", true);
            for (int i = 0; i < panel1[0].Controls.Count; i++)
            {
                panel1[0].Controls[i].BackColor = Color.DimGray;
                panel1[0].Controls[i].Enabled = false;

            }
            btnHavadan.Enabled = false;
            btnYerden.Enabled = false;
            btnFalsolu.Enabled = false;
        }
        int sporcuId = 0;
        private void gridViewSporcular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = gridViewSporcular.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gridViewSporcular.Rows[selectedrowindex];
            sporcuId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            sporcu = new Sporcular()
            {
                Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                Adi = Convert.ToString(selectedRow.Cells["Ad"].Value),
                Soyadi = Convert.ToString(selectedRow.Cells["Soyad"].Value),
                Yas = Convert.ToInt32(selectedRow.Cells["Yas"].Value),
                Boy = Convert.ToInt32(selectedRow.Cells["Boy"].Value),
                Kilo = Convert.ToInt32(selectedRow.Cells["Kilo"].Value)
            };
            if (systemLanguage == "Turkish")
                label1.Text = $"Seçtiğiniz Oyuncu : {sporcu.Adi} {sporcu.Soyadi}";
            else if (systemLanguage == "English")
                label1.Text = $"Selected player : {sporcu.Adi} {sporcu.Soyadi}";
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        string basariliAtis = "";
        private void ModbusScan_Tick(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = objIModbusMaster.ReadHoldingRegisters(slaveAddress, startAddress, numberOfPoints);
                txtBasariliAtis.Text = String.Empty;
                if (bytes != null)
                {
                    ushort[] result = Word.ToArray(bytes);
                    foreach (ushort item in result)
                    {
                        txtBasariliAtis.Text += string.Format("{0} ", item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AntrenmanEkle(txtBasariliAtis.Text);
            txtBasariliAtis.Text = "";
            try
            {
                objIModbusMaster.WriteSingleRegister(slaveAddress, 4096, d0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AntrenmanEkle(string basariliAtis)
        {
            AntrenmanTurleri antrenamTuru = Context._context.AntrenmanTurleri.FirstOrDefault(a => a.TopKonumId == topKonum && a.TopGelisSekliId == topGelisSekli && a.VurusBicimiId == vurusBicimi);
            var antrenman_ = Context._context.Antrenmanlar.Where(a => a.AntrenamTuruId == antrenamTuru.Id && a.SporcuId == sporcuId).OrderByDescending(a => a.AntrenmanSayisi).FirstOrDefault();
            if (antrenman_ != null)
            {
                Antrenmanlar antrenman = new Antrenmanlar()
                {
                    SporcuId = sporcuId,
                    AntrenamTuruId = antrenamTuru.Id,
                    AtisSayisi = 10,
                    BasariliAtis = Convert.ToInt32(basariliAtis),
                    AntrenmanSuresi = sure,
                    AntrenmanSayisi = antrenman_.AntrenmanSayisi + 1,
                    Tarih = DateTime.Now,
                };
                Context._context.Antrenmanlar.Add(antrenman);
            }
            else
            {
                Antrenmanlar antrenman = new Antrenmanlar()
                {
                    SporcuId = sporcuId,
                    AntrenamTuruId = antrenamTuru.Id,
                    AtisSayisi = 10,
                    BasariliAtis = Convert.ToInt32(basariliAtis),
                    AntrenmanSuresi = sure,
                    AntrenmanSayisi = 1,
                    Tarih = DateTime.Now
                };
                Context._context.Antrenmanlar.Add(antrenman);
            }
            Context._context.SaveChanges();
            InfService.ShowMessage("Antrenman kaydı eklendi.", "Training log added.");
        }
    }
}
