using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrenmanTakip.Formlar.Ayarlar
{
    public partial class frmCokluVeriEkleme : Form
    {
        public frmCokluVeriEkleme()
        {
            InitializeComponent();
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası |*.xls";
            fileDialog.Title = "Kayıtları Seçiniz";

            if(fileDialog.ShowDialog() == DialogResult.OK ) 
            {
                OleDbConnection baglan;
                baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileDialog.FileName + "; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                baglan.Open();
                OleDbDataAdapter adapter= new OleDbDataAdapter("Select * from [Sayfa1$]", baglan);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gridViewKayitlar.DataSource = dt;
                baglan.Close();
            }
        }

        DbAntrenmanTakipEntities db = new DbAntrenmanTakipEntities();

        //private void btnKaydet_Click(object sender, EventArgs e)
        //{
        //    Cursor.Current = Cursors.WaitCursor;

        //    int satir = gridViewKayitlar.Rows.Count;
        //    if (satir > 0)
        //    {
        //        for (int i = 0; i < satir; i++)
        //        {
        //            string kayit = gridViewKayitlar.Rows[i].Cells[""]
        //        }
        //    }


        //    Cursor.Current = Cursors.Default;
        //}

        private void gridViewKayitlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
