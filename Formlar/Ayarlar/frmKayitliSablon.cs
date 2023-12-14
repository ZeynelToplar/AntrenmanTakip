using AntrenmanTakip.Persistence;
using AntrenmanTakip.Persistence.Services;
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

namespace AntrenmanTakip.Formlar.Ayarlar
{
    public partial class frmKayitliSablon : Form
    {
        private FrmTekliVeriEkleme _frmTekliVeriEkleme;
        public List<TopKonumlari> topKonumlari;
        public List<TopGelisSekilleri> topGelisSekilleri;
        public List<VurusBicimleri> vurusBicimleri;
        public frmKayitliSablon()
        {
            InitializeComponent();
        }
        string systemLanguage = "";

        private static List<KayitSablonu> GetRecords()
        {
            return Context._context.KayitSablonu.Include(x => x.TopKonumlari).Include(x => x.TopGelisSekilleri).Include(x => x.VurusBicimleri).ToList();
        }
        private void frmKayitliSablon_Load(object sender, EventArgs e)
        {
            systemLanguage = DbService.GetApplicationLanguage();
            var values = GetRecords();

            foreach (var item in values)
            {
                if (systemLanguage == "Turkish")
                {
                    gridViewSablonlar.Rows.Add(new object[]
                    {
                        item.ID,
                        item.TK,
                        item.TGS,
                        item.VB,
                        $"{item.TopKonumlari.Adi} - {item.TopGelisSekilleri.Adi} - {item.VurusBicimleri.Adi}",
                        $"{item.VK1}",
                        $"{item.VK2}",
                        $"{item.VK3}",
                        $"{item.VK4}",
                        $"{item.VK5}",
                        $"{item.VK6}",
                        $"{item.VK7}",
                        $"{item.VK8}",
                        $"{item.VK9}",
                        $"{item.VK10}",
                    });
                }
                else if (systemLanguage == "English")
                {
                    gridViewSablonlar.Rows.Add(new object[]
                    {
                        item.ID,
                        item.TK,
                        item.TGS,
                        item.VB,
                        $"{item.TopKonumlari.EAdi} - {item.TopGelisSekilleri.EAdi} - {item.VurusBicimleri.EAdi}",
                        $"{item.VK1}",
                        $"{item.VK2}",
                        $"{item.VK3}",
                        $"{item.VK4}",
                        $"{item.VK5}",
                        $"{item.VK6}",
                        $"{item.VK7}",
                        $"{item.VK8}",
                        $"{item.VK9}",
                        $"{item.VK10}",
                    });
                }
            }
        }

        

        int ID,tgs_,tk_,vb_,vk1_,vk2_,vk3_,vk4_,vk5_,vk6_,vk7_,vk8_,vk9_,vk10_;

        private void frmKayitliSablon_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnAktar_Click(sender, e);
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            
            if(_frmTekliVeriEkleme == null || _frmTekliVeriEkleme.IsDisposed)
            {
                _frmTekliVeriEkleme = new FrmTekliVeriEkleme();
                _frmTekliVeriEkleme.Show();
                _frmTekliVeriEkleme.cmbTopKonumlari.Invoke(new Action(() => _frmTekliVeriEkleme.cmbTopKonumlari.DataSource = topKonumlari));
                _frmTekliVeriEkleme.cmbTopGelisSekli.Invoke(new Action(() => _frmTekliVeriEkleme.cmbTopGelisSekli.DataSource = topGelisSekilleri));
                _frmTekliVeriEkleme.cmbVurusBicimleri.Invoke(new Action(() => _frmTekliVeriEkleme.cmbVurusBicimleri.DataSource = vurusBicimleri));
                _frmTekliVeriEkleme.comboBox1.SelectedIndex = (vk1_ - 1);
                _frmTekliVeriEkleme.comboBox2.SelectedIndex = vk2_ - 1;
                _frmTekliVeriEkleme.comboBox3.SelectedIndex = vk3_ - 1;
                _frmTekliVeriEkleme.comboBox4.SelectedIndex = vk4_ - 1;
                _frmTekliVeriEkleme.comboBox5.SelectedIndex = vk5_ - 1;
                _frmTekliVeriEkleme.comboBox6.SelectedIndex = vk6_ - 1;
                _frmTekliVeriEkleme.comboBox7.SelectedIndex = vk7_ - 1;
                _frmTekliVeriEkleme.comboBox8.SelectedIndex = vk8_ - 1;
                _frmTekliVeriEkleme.comboBox9.SelectedIndex = vk9_ - 1;
                _frmTekliVeriEkleme.comboBox10.SelectedIndex = vk10_ - 1;
                _frmTekliVeriEkleme.cmbTopKonumlari.SelectedIndex = tk_ - 1;
                _frmTekliVeriEkleme.cmbTopGelisSekli.SelectedIndex = tgs_ - 1;
                _frmTekliVeriEkleme.cmbVurusBicimleri.SelectedIndex = vb_ - 1;
                this.Close();
                
            }
        }

        private void gridViewSablonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = gridViewSablonlar.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gridViewSablonlar.Rows[selectedrowindex];
            lblSecilenAntrenmanTuru.Text = Convert.ToString(selectedRow.Cells["AntrenmanTuru"].Value);
            ID = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            tgs_ = Convert.ToInt32(selectedRow.Cells["tgsId"].Value);
            tk_ = Convert.ToInt32(selectedRow.Cells["tkId"].Value);
            vb_ = Convert.ToInt32(selectedRow.Cells["vbId"].Value);
            vk1_ = Convert.ToInt32(selectedRow.Cells["vk1"].Value);
            vk2_ = Convert.ToInt32(selectedRow.Cells["vk2"].Value);
            vk3_ = Convert.ToInt32(selectedRow.Cells["vk3"].Value);
            vk4_ = Convert.ToInt32(selectedRow.Cells["vk4"].Value);
            vk5_ = Convert.ToInt32(selectedRow.Cells["vk5"].Value);
            vk6_ = Convert.ToInt32(selectedRow.Cells["vk6"].Value);
            vk7_ = Convert.ToInt32(selectedRow.Cells["vk7"].Value);
            vk8_ = Convert.ToInt32(selectedRow.Cells["vk8"].Value);
            vk9_ = Convert.ToInt32(selectedRow.Cells["vk9"].Value);
            vk10_ = Convert.ToInt32(selectedRow.Cells["vk10"].Value);
            lblSecilenKoseler.Text = $"{vk1_}-{vk2_}-{vk3_}-{vk4_}-{vk5_}-{vk6_}-{vk7_}-{vk8_}-{vk9_}-{vk10_}";
        }
    }
}
