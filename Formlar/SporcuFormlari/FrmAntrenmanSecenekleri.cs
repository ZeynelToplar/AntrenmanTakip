using AntrenmanTakip.Formlar.Ayarlar;
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

namespace AntrenmanTakip.Formlar.SporcuFormlari
{
    public partial class FrmAntrenmanSecenekleri : Form
    {
        private FrmSporcular _frmSporcular;
        private FrmTumAntrenmanlar _frmTumAntrenmanlar;
        private FrmSagAntrenman _frmSagAntrenmanlar;
        private FrmSolAntrenman _frmSolAntrenman;
        private FrmKarsidanAntrenmanlar _frmKarsidanAntrenmanlar;
        private FrmAyarlar _frmAyarlar;
        public FrmAntrenmanSecenekleri()
        {
            InitializeComponent();
        }
        int id;
        private void btnTumGor_Click(object sender, EventArgs e)
        {
            if (_frmTumAntrenmanlar == null || _frmTumAntrenmanlar.IsDisposed)
            {
                _frmTumAntrenmanlar = new FrmTumAntrenmanlar();
                _frmTumAntrenmanlar.id = Context.sporcu.Id;
                _frmTumAntrenmanlar.Show();
                this.Close();
            }
        }

        private void lblTumGor_Click(object sender, EventArgs e)
        {
            btnTumGor_Click(sender, e);
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            if (_frmSagAntrenmanlar == null || _frmSagAntrenmanlar.IsDisposed)
            {
                _frmSagAntrenmanlar = new FrmSagAntrenman();
                _frmSagAntrenmanlar.id = id;
                _frmSagAntrenmanlar.Show();
                this.Close();
            }
        }

        private void lblSag_Click(object sender, EventArgs e)
        {
            btnSag_Click(sender, e);
        }

        private void btnKarsidan_Click(object sender, EventArgs e)
        {
            if (_frmKarsidanAntrenmanlar == null || _frmKarsidanAntrenmanlar.IsDisposed)
            {
                _frmKarsidanAntrenmanlar = new FrmKarsidanAntrenmanlar();
                _frmKarsidanAntrenmanlar.id = id;
                _frmKarsidanAntrenmanlar.Show();
                this.Close();
            }
        }

        private void lblKarsidan_Click(object sender, EventArgs e)
        {
            btnKarsidan_Click(sender, e);
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            if (_frmSolAntrenman == null || _frmSolAntrenman.IsDisposed)
            {
                _frmSolAntrenman = new FrmSolAntrenman();
                _frmSolAntrenman.id = id;
                _frmSolAntrenman.Show();
                this.Close();
            }
        }

        private void lblSol_Click(object sender, EventArgs e)
        {
            btnSol_Click(sender, e);
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmSporcular = new FrmSporcular();
            _frmSporcular.Show();
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

        private void FrmAntrenmanSecenekleri_Load(object sender, EventArgs e)
        {

        }
    }
}
