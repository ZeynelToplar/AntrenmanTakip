using AntrenmanTakip.Formlar.Ayarlar;
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

namespace AntrenmanTakip.Formlar.AntrenmanFormlari
{
    public partial class FrmAntrenmanSecenek : Form
    {
        private FrmAntrenman _frmAntrenman;
        private FrmKaleciAntrenman _frmKaleciAntrenman;
        private Form1 _frm1;
        private FrmAyarlar _frmAyarlar;
        public FrmAntrenmanSecenek()
        {
            InitializeComponent();
        }
        string systemLanguage = "";
        private void btnİlerle_Click(object sender, EventArgs e)
        {
            int secilenAntrenman = cmbAntrenmanTuru.SelectedIndex;
            if (secilenAntrenman == 0)
            {
                InfService.ShowMessage("Lütfen antrenman türünü seçiniz!", "Please select the type of training!");
            }
            else if (secilenAntrenman == 2)
            {
                this.Close();
                _frmKaleciAntrenman = new FrmKaleciAntrenman();
                _frmKaleciAntrenman.port = Global.Port;
                _frmKaleciAntrenman.Show();
            }
            else if (secilenAntrenman == 1)
            {
                this.Close();
                _frmAntrenman = new FrmAntrenman();
                _frmAntrenman.port = Global.Port;
                _frmAntrenman.Show();
            }
        }

        private void FrmAntrenmanSecenek_Load(object sender, EventArgs e)
        {
            cmbAntrenmanTuru.SelectedIndex = 0;
            systemLanguage = DbService.GetApplicationLanguage();
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
    }
}
