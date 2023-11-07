using AntrenmanTakip.Formlar;
using AntrenmanTakip.Formlar.AntrenmanFormlari;
using AntrenmanTakip.Formlar.Ayarlar;
using AntrenmanTakip.Formlar.SporcuFormlari;
using AntrenmanTakip.Persistence.Services;
using System;
using System.Threading;
using System.Windows.Forms;

namespace AntrenmanTakip
{
    public partial class Form1 : Form
    {
        private FrmSporcular _frmSporcular;
        private FrmAntrenman _frmAntrenman;
        private FrmAyarlar _frmAyarlar;
        private FrmGiris _frmGiris;
        private FrmAntrenmanSecenek _frmAntrenmanSecenek;
        private FrmAntrenmanAyarlari _frmAntrenmanAyarlari;
        private FrmAntrenorSporcuİliski _frmAntrenorSporcuIliski;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAntrenman_Click(object sender, EventArgs e)
        {
            if (_frmAntrenmanSecenek == null || _frmAntrenmanSecenek.IsDisposed)
            {
                _frmAntrenmanSecenek = new FrmAntrenmanSecenek();
                _frmAntrenmanSecenek.Show();
            }
        }

        private void btnSporcular_Click(object sender, EventArgs e)
        {
            if (_frmSporcular == null || _frmSporcular.IsDisposed)
            {
                _frmSporcular = new FrmSporcular();
                _frmSporcular.Show();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            btnSporcular_Click(sender,e);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if(_frmAyarlar == null || _frmAyarlar.IsDisposed)
            {
                _frmAyarlar = new FrmAyarlar();
                _frmAyarlar.Show();
            }
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfService.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnAntrenman_Click(sender,e);
        }

        private void btnAntrenorler_Click(object sender, EventArgs e)
        {
            if(_frmAntrenorSporcuIliski == null || _frmAntrenorSporcuIliski.IsDisposed)
            {
                _frmAntrenorSporcuIliski = new FrmAntrenorSporcuİliski();
                _frmAntrenorSporcuIliski.Show();
            }
        }
    }
}
