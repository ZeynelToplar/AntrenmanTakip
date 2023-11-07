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

        public static DialogResult Show(string text)
        {
            FrmCustomMessageBox messageBox = new FrmCustomMessageBox();

            messageBox.lblText.Text = text;

            messageBox.ShowDialog();

            return messageBox.DialogResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
