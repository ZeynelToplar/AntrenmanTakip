using AntrenmanTakip.Formlar.Ayarlar;
using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
using IndustrialNetworks.ModbusCore.ASCII;
using IndustrialNetworks.ModbusCore.Comm;
using IndustrialNetworks.ModbusCore.DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.AntrenmanFormlari
{
    public partial class FrmKaleciAntrenman : Form
    {
        private IModbusMaster objIModbusMaster = null;
        private byte slaveAddress = 3;
        private uint startAddress = 4096; // start address : D0.
        private ushort numberOfPoints = 1; // Reads 10 registers.
        private byte[] d0 = Int.ToByteArray(0);
        public string port = "";

        private Form1 _frm1;
        private FrmAyarlar _frmAyarlar;

        string systemLanguage = "";
        int topKonum = 0;
        int topGelisSekli = 0;
        Sporcular sporcu;
        public FrmKaleciAntrenman()
        {
            InitializeComponent();
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
        private void FrmKaleciAntrenman_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            Kullanicilar authenticateUser = DbService.GetUser(Context.kullanici.Id);
            if (authenticateUser.YetkiId == 0)
            {
                //List<Sporcular> sporcular = (from s in Context._context.Sporcular
                //                             join m in Context._context.Mevkiler on s.MevkiId equals m.Id
                //                             where m.Id == 2
                //                             select new Sporcular
                //                             {
                //                                 Adi = s.Adi,
                //                                 Soyadi = s.Soyadi,
                //                                 Yas = s.Yas,
                //                                 Boy = s.Boy,
                //                                 Kilo = s.Kilo,
                //                                 Mevkiler = m
                //                             }).ToList();
                var sporcular = Context._context.Sporcular.Include(s => s.Mevkiler).Where(m => m.MevkiId == 2).ToList();
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
                                 select new Sporcular
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

        private void btnHavadan_Click(object sender, EventArgs e)
        {
            btnYerden.BackColor = SystemColors.GradientInactiveCaption;
            btnFalsolu.BackColor = SystemColors.GradientInactiveCaption;
            btnHavadan.BackColor = Color.LightGreen;
            topGelisSekli = 2;
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
            lblAntrenmanTuru.Text = lblAntrenmanTuru.Text.Substring(0, lblAntrenmanTuru.Text.IndexOf("-"));
            if (systemLanguage == "Turkish")
                lblAntrenmanTuru.Text += "- FALSOLU - ";
            else
                lblAntrenmanTuru.Text += "- CURVEBALL - ";
        }

        private void btnAntrenmanBaslat_Click(object sender, EventArgs e)
        {
            if (topKonum != 0 && topGelisSekli != 0 && sporcu != null)
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
                    txtBasariliAtis.Text = basariliAtis;
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
                        label1.Text = "Please select the player you want to train";
                        lblAntrenmanTuru.Text = "No training type selected.";
                    }
                }
            }
            else
            {
                if(systemLanguage == "Turkish")
                    MessageBox.Show("Lütfen Antrenman türünü ve sporcuyu seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if(systemLanguage == "English")
                    MessageBox.Show("Please select Training type and player!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AntrenmanEkle(string basariliAtis)
        {
            int basariliAtis_; 
            basariliAtis_ = 10 - Convert.ToInt32(basariliAtis);
            KaleciAntrenmanTurleri kAntrenamTuru = Context._context.KaleciAntrenmanTurleri.FirstOrDefault(a => a.TopKonumId == topKonum && a.TopGelisSekliId == topGelisSekli);
            var antrenman_ = Context._context.Antrenmanlar.Where(a => a.KAntrenmanTuruId == kAntrenamTuru.Id && a.SporcuId == sporcuId).OrderByDescending(a => a.AntrenmanSayisi).FirstOrDefault();
            if (antrenman_ != null)
            {
                Antrenmanlar antrenman = new Antrenmanlar()
                {
                    SporcuId = sporcuId,
                    KAntrenmanTuruId = kAntrenamTuru.Id,
                    AtisSayisi = 10,
                    BasariliAtis = basariliAtis_,
                    AntrenmanSuresi = sure,
                    AntrenmanSayisi = antrenman_.AntrenmanSayisi + 1,
                    Tarih = DateTime.Now
                };
                Context._context.Antrenmanlar.Add(antrenman);
                Context._context.SaveChanges();
            }
            else
            {
                Antrenmanlar antrenman = new Antrenmanlar()
                {
                    SporcuId = sporcuId,
                    KAntrenmanTuruId = kAntrenamTuru.Id,
                    AtisSayisi = 10,
                    BasariliAtis = basariliAtis_,
                    AntrenmanSuresi = sure,
                    AntrenmanSayisi = 1,
                    Tarih = DateTime.Now
                };
                Context._context.Antrenmanlar.Add(antrenman);
                Context._context.SaveChanges();
            }
            
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm1 = new Form1();
            _frm1.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if(_frmAyarlar == null || _frmAyarlar.IsDisposed)
            {
                this.Close();
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
                        txtBasariliAtis.Text += string.Format("{0}, ", item);
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

        private void txtBasariliAtis_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblZaman_Click(object sender, EventArgs e)
        {

        }

        private void TumButonlariPasifYap()
        {
            btnKarsidan.BackColor = SystemColors.GradientInactiveCaption;
            btnSol.BackColor = SystemColors.GradientInactiveCaption;
            btnSag.BackColor = SystemColors.GradientInactiveCaption;
            btnHavadan.BackColor = Color.DimGray;
            btnYerden.BackColor = Color.DimGray;
            btnFalsolu.BackColor = Color.DimGray;
            btnHavadan.Enabled = false;
            btnYerden.Enabled = false;
            btnFalsolu.Enabled = false;
        }
    }
}
