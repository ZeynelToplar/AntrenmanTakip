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
        public FrmRaporlama()
        {
            InitializeComponent();
        }

        private void FrmRaporlama_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
