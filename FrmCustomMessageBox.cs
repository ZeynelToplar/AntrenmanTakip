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

namespace AntrenmanTakip
{
    public partial class FrmCustomMessageBox : Form
    {
        public FrmCustomMessageBox()
        {
            InitializeComponent();
        }

        DialogResult result = DialogResult.OK;
        public static DialogResult Show(string text)
        {
            FrmCustomMessageBox messageBox = new FrmCustomMessageBox();

            messageBox.lblText.Text = text;

            messageBox.ShowDialog();

            return messageBox.result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
