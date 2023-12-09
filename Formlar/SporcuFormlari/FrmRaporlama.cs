using AntrenmanTakip.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;
using Excel = Microsoft.Office.Interop.Excel;

namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    public partial class FrmRaporlama : Form
    {
        public int sporcuId = Context.sporcu.Id;
        public int antrenmanTuruId;

        private FrmGrafikler _frmGrafikler;

        public FrmRaporlama()
        {
            InitializeComponent();
        }

        private void FrmRaporlama_Load(object sender, EventArgs e)
        {
            cmbGrafikTuru.SelectedIndex = 0;
            cmbIstatistikTuru.SelectedIndex = 0;
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            if(_frmGrafikler == null || _frmGrafikler.IsDisposed)
            {
                _frmGrafikler = new FrmGrafikler();
                _frmGrafikler.antrenmanTuruId = antrenmanTuruId;
                _frmGrafikler.chartType = cmbGrafikTuru.SelectedIndex;
                _frmGrafikler.statisticType = cmbIstatistikTuru.SelectedIndex;
                _frmGrafikler.Show();
            }
        }
    }
}
