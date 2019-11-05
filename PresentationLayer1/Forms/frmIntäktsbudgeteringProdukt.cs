using BusinessLayer;
using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PresentationLayer1.Forms
{
    public partial class frmIntäktsbudgeteringProdukt : Form
    {
        private BusinessManager businessManager = new BusinessManager();
        private List<ProduktDTO> produkter;
        private List<IntäktsbudgetProduktDTO> kunder;

        public frmIntäktsbudgeteringProdukt()
        {
            InitializeComponent(); 
            Hide();
            produkter = businessManager.GetAllProdukter();
            dgvIntäktsbudgeteringProdukt.DataSource = produkter;
            ucSökFältProdukt.SetGridView(dgvIntäktsbudgeteringProdukt);
            ucSökFältProdukt.Load();
        }

        private void Hide()
        {
            btnLäggTillKund.Hide();
            btnTaBortKund.Hide();
            btnVäljNyProdukt.Hide();
            btnVäljProdukt.Show();
        }

        private void btnVäljProdukt_Click(object sender, EventArgs e)
        {
            ProduktDTO produkten = ((ProduktDTO)dgvIntäktsbudgeteringProdukt.CurrentRow.DataBoundItem);
            btnVäljProdukt.Hide();
            lblValdProdukt.Text = produkten.Namn;
            lblValdProduktID.Text = produkten.ProduktID;
            Show();
            Update();
        }

        private void Show()
        {
            btnLäggTillKund.Show();
            btnTaBortKund.Show();
            btnVäljNyProdukt.Show();
            btnVäljProdukt.Hide();
        }

        private void Update()
        {
            kunder = businessManager.GetAllProduktKunder(lblValdProduktID.Text);
            dgvIntäktsbudgeteringProdukt.DataSource = kunder;
        }

        private void btnVäljNyProdukt_Click(object sender, EventArgs e)
        {
            lblValdProdukt.Text = "Ej vald";
            lblValdProduktID.Text = "Ej vald";
            produkter = businessManager.GetAllProdukter();
            dgvIntäktsbudgeteringProdukt.DataSource = produkter;
            ucSökFältProdukt.Rensa();
            Hide();
        }

        private void btnLäggTillKund_Click(object sender, EventArgs e)
        {
            Forms.frmIntäktsbudgeteringLäggTillKund frmIntäktsbudgeteringLäggTillKund = new frmIntäktsbudgeteringLäggTillKund(lblValdProduktID.Text, lblValdProdukt.Text);
            frmIntäktsbudgeteringLäggTillKund.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                produkter = businessManager.GetProduktWithoutIntäkt();
                dgvIntäktsbudgeteringProdukt.DataSource = produkter;
            }
            else
            {
                produkter = businessManager.GetAllProdukter();
                dgvIntäktsbudgeteringProdukt.DataSource = produkter;
            }
        }

        private void btnExportera_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (int x = 1; x < dgvIntäktsbudgeteringProdukt.Columns.Count + 1; x++)
            {
                xlWorkSheet.Cells[1, x] = dgvIntäktsbudgeteringProdukt.Columns[x - 1].HeaderText;
            }

            for (int i = 0; i < dgvIntäktsbudgeteringProdukt.Rows.Count; i++)
            {
                for (int j = 0; j < dgvIntäktsbudgeteringProdukt.Columns.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, j + 1] = dgvIntäktsbudgeteringProdukt.Rows[i].Cells[j].Value.ToString();
                }
            }

            xlWorkBook.SaveAs("csharp.net-informations4.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
