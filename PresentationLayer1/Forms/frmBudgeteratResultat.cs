using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;
using DataLayer.DTO;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel; 

namespace PresentationLayer1.Forms
{
    public partial class frmBudgeteratResultat : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<ProduktDTO> produkter;
        private List<ProduktgruppDTO> produktgrupp;
        private List<AvdelningDTO> produktAvdelning;
        private List<KontorDTO> kontor;
        private Dictionary<string, decimal> produktDict = new Dictionary<string, decimal>();
        private Dictionary<string, List<decimal>> produktgruppDict = new Dictionary<string, List<decimal>>();
        private Dictionary<string, List<decimal>> produktAvdelningDict = new Dictionary<string, List<decimal>>();

        public frmBudgeteratResultat()
        {
            Thread t = new Thread(new ThreadStart(Load)) { IsBackground = true };
            t.Start();
            InitializeComponent();
            t.Join();

            cmbKategori.SelectedItem = "Produkt";
        }

        private void Load()
        {
            produkter = businessManager.GetAllProdukter();

            foreach(var produkt in produkter)
            {
                decimal beräkning = businessManager.GetProduktKostnader(produkt.ProduktID);

                produktDict.Add(produkt.ProduktID, beräkning);

                if (!produktgruppDict.ContainsKey(produkt.Produktgrupp))
                {
                    var list = new List<decimal>();
                    list.Add(beräkning);
                    produktgruppDict.Add(produkt.Produktgrupp, list);
                }
                else
                {
                    produktgruppDict[produkt.Produktgrupp].Add(beräkning);
                }

                if (!produktAvdelningDict.ContainsKey(produkt.Avdelning))
                {
                    var list = new List<decimal>();
                    list.Add(beräkning);
                    produktAvdelningDict.Add(produkt.Avdelning, list);
                }
                else
                {
                    produktAvdelningDict[produkt.Avdelning].Add(beräkning);
                }
            }

            dgvBudgeteratResultat.DataSource = produkter;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.Text == "Produkt")
            {
                produkter = businessManager.GetAllProdukter();
                dgvBudgeteratResultat.DataSource = produkter;
                Show();
            }
            if (cmbKategori.Text == "Produktgrupp")
            {
                produktgrupp = businessManager.GetProduktByGrupp();
                dgvBudgeteratResultat.DataSource = produktgrupp;
                Hide();
            }
            if (cmbKategori.Text == "Produktionsavdelning")
            {
                produktAvdelning = businessManager.GetProduktByAvdelning();
                dgvBudgeteratResultat.DataSource = produktAvdelning;
                Hide();
            }
            if (cmbKategori.Text == "Kontoret")
            {
                kontor = businessManager.GetKontor();
                dgvBudgeteratResultat.DataSource = kontor;
                Hide();
            }
        }

        private void dgvBudgeteratResultat_SelectionChanged(object sender, EventArgs e)
        {
            if (cmbKategori.Text == "Produkt")
            {
                CalculateProdukt();
            }
            if (cmbKategori.Text == "Produktgrupp")
            {
                CalculateProduktGrupp();
            }
            if (cmbKategori.Text == "Produktionsavdelning")
            {
                CalculateProduktKategori();
            }
            if (cmbKategori.Text == "Kontoret")
            {
                CalculateKontor();
            }
        }
        public void CalculateProdukt()
        {
            dgvBudgeteratResultat.ClearSelection();
            ProduktDTO produkt = new ProduktDTO();
            produkt = (ProduktDTO)dgvBudgeteratResultat.CurrentRow.DataBoundItem;
            decimal prodintäkter = businessManager.GetProduktIntäkter(produkt);
            decimal prodKostnader = produktDict[produkt.ProduktID];
            lblBudgeteradeIntäkter.Text = prodintäkter.ToString("0.00");
            lblBudgetKostnader.Text = prodKostnader.ToString("0.00");
            var resultat = decimal.Parse(lblBudgeteradeIntäkter.Text) - decimal.Parse(lblBudgetKostnader.Text);
            lblResultat.Text = resultat.ToString("0.00");
        }
        public void CalculateProduktGrupp()
        {
            dgvBudgeteratResultat.ClearSelection();
            ProduktgruppDTO produktgruppDTO = new ProduktgruppDTO();
            produktgruppDTO = (ProduktgruppDTO)dgvBudgeteratResultat.CurrentRow.DataBoundItem;

            decimal gruppintäkter = businessManager.GetGruppIntäkter(produktgruppDTO);
            decimal gruppKostnader = produktgruppDict[produktgruppDTO.Namn].Sum();

            lblBudgeteradeIntäkter.Text = gruppintäkter.ToString("0.00");
            lblBudgetKostnader.Text = gruppKostnader.ToString("0.00");
            var resultat = decimal.Parse(lblBudgeteradeIntäkter.Text) - decimal.Parse(lblBudgetKostnader.Text);
            lblResultat.Text = resultat.ToString();
        }
        public void CalculateProduktKategori()
        {
            dgvBudgeteratResultat.ClearSelection();
            AvdelningDTO avdelningDTO = new AvdelningDTO();
            avdelningDTO = (AvdelningDTO)dgvBudgeteratResultat.CurrentRow.DataBoundItem;
            decimal avdelningIntäkter = businessManager.GetAvdelningIntäkter(avdelningDTO);
            decimal avdelningKostnader = produktAvdelningDict[avdelningDTO.Namn].Sum();
            lblBudgeteradeIntäkter.Text = avdelningIntäkter.ToString("0.00");
            lblBudgetKostnader.Text = avdelningKostnader.ToString("0.00");
            var resultat = decimal.Parse(lblBudgeteradeIntäkter.Text) - decimal.Parse(lblBudgetKostnader.Text);
            lblResultat.Text = resultat.ToString();
        }
        public void CalculateKontor()
        {
            dgvBudgeteratResultat.ClearSelection();
            decimal kontorIntäkter = businessManager.GetKontorIntäkter();
            decimal kontorKostnader = produktDict.Sum(x => x.Value);
            lblBudgeteradeIntäkter.Text = kontorIntäkter.ToString("0.00");
            lblBudgetKostnader.Text = kontorKostnader.ToString("0.00");
            var resultat = decimal.Parse(lblBudgeteradeIntäkter.Text) - decimal.Parse(lblBudgetKostnader.Text);
            lblResultat.Text = resultat.ToString();
        }
        private void tbSök_TextChanged(object sender, EventArgs e)
        {
                if (tbSök.TextLength == 0)
                {
                    produkter = businessManager.GetAllProdukter();
                    dgvBudgeteratResultat.DataSource = produkter;
                }
                else
                {
                    produkter = businessManager.GetProduktByNamn(tbSök.Text);
                    dgvBudgeteratResultat.DataSource = produkter;
                }
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            tbSök.Clear();
        }

        private void Hide()
        {
            lblSök.Hide();
            tbSök.Hide();
            btnRensa.Hide();
        }

        private void Show()
        {
            lblSök.Show();
            tbSök.Show();
            btnRensa.Show();
        }

        private void btnExportera_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel är ej korrekt installerat!");
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


            xlWorkSheet.Cells[1, 1] = "Budgeterade Intäkter";
            xlWorkSheet.Cells[1, 2] = "Budgeterade Kostnader";
            xlWorkSheet.Cells[1, 3] = "Budgeterat Resultat";
            xlWorkSheet.Cells[2, 1] = lblBudgeteradeIntäkter.Text;
            xlWorkSheet.Cells[2, 2] = lblBudgetKostnader.Text;
            xlWorkSheet.Cells[2, 3] = lblResultat.Text;
            xlWorkSheet.Columns.AutoFit();


            xlWorkBook.SaveAs("d:\\Budgeterat_Resultat_Excel_G4Solutions.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Excelfil skapad, du hittar den d:\\Budgeterat_Resultat_Excel_G4Solutions.xls");

        }
    }
}
