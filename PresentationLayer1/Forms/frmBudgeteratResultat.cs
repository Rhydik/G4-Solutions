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
        public List<ProduktDTO> ProduktDTOer; //för export funktionen, /Marcus

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
            businessManager.GetProduktKostnaderAvdelning(1);

            produkter = businessManager.GetAllProdukter();

            foreach (var produkt in produkter)
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

                btnExportera.Text = "Exportera markerad produkt";
            }
            if (cmbKategori.Text == "Produktgrupp")
            {
                CalculateProduktGrupp();

                btnExportera.Text = "Exportera markerad produktgrupp";
            }
            if (cmbKategori.Text == "Produktionsavdelning")
            {
                CalculateProduktKategori();

                btnExportera.Text = "Exportera markerad produktionsavdelning";
            }
            if (cmbKategori.Text == "Kontoret")
            {
                CalculateKontor();
                btnExportera.Text = "Exportera valt kontor";
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
            decimal resultat = decimal.Parse(lblBudgeteradeIntäkter.Text) - decimal.Parse(lblBudgetKostnader.Text);
            lblResultat.Text = resultat.ToString("0.00");
        }
        public void CalculateProduktGrupp()
        {
            dgvBudgeteratResultat.ClearSelection();
            ProduktgruppDTO produktgruppDTO = new ProduktgruppDTO();
            dgvBudgeteratResultat.Rows[1].ReadOnly = true;
            dgvBudgeteratResultat.Rows[2].ReadOnly = true;

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
            if (avdelningDTO.AvdelningsID == 2 || avdelningDTO.AvdelningsID == 3)
            {
                lblBudgeteradeIntäkter.Text = "0";
                lblBudgetKostnader.Text = "0";

                return;
            }
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


        private void copyAlltoClipboard()
        {
            dgvBudgeteratResultat.SelectAll();
            DataObject dataObj = dgvBudgeteratResultat.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        //public void ExpProdukt()
        //{
        //    List<T> ExpProdList = new List<T>();
        //}

        /// <summary>
        /// ExportMetoden tar i nuläget hand om bara ProduktDTO klassen, och exporterar allt sådant.
        /// Jag märker nu i efterhand att man säkert vill ha en "custom" klass för vad ni ska exportera.
        /// Så förslagsvis skapar ni en sådan, och skickar in i ExportMetoden. 
        /// Filtrera ut allt först ur er lista så allt ni vill ha är kvar, och skicka in i metoden nedan
        /// </summary>
        public void ExportMetoden()  //Marcus                         
        {
            List<ProduktDTO> ProduktDTOer = new List<ProduktDTO>();

            SaveFileDialog save = new SaveFileDialog();
            string filename = save.FileName;

            save.DefaultExt = ".xls";
            if (save.ShowDialog() == DialogResult.OK)
            {
                List<ProduktDTO> FörberedaProduktDTOer = businessManager.FörberedaExportProduktDTO(ProduktDTOer);

                shadowGridBudget.DataSource = FörberedaProduktDTOer;
                /*
                 shadowGridBudget är en osynlig datagridview som 
                 används för att sammanställa alla värden och sedan skriva ut excel blad
                */

                businessManager.Exportera(shadowGridBudget, save.FileName);
                MessageBox.Show(filename + " är sparad på " + save.FileName + ".");
            }
        }

        private void btnExportera_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();

            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel är ej korrekt installerat!");
                return;
            }


            ProduktDTO produkter = new ProduktDTO();
            produkter = (ProduktDTO)dgvBudgeteratResultat.CurrentRow.DataBoundItem;
            string prodnamn = produkter.Namn;
            string prodgrupp = produkter.Produktgrupp;
            string prodkat = produkter.Produktkategori;
            string prodavd = produkter.Avdelning;
            decimal prodintäkter = businessManager.GetProduktIntäkter(produkter);
            decimal prodKostnader = produktDict[produkter.ProduktID];
            decimal resultat = decimal.Parse(lblBudgeteradeIntäkter.Text) - decimal.Parse(lblBudgetKostnader.Text);

            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


            xlWorkSheet.Cells[1, 1] = "Produkt";
            xlWorkSheet.Cells[1, 2] = "Budgeterade Intäkter";
            xlWorkSheet.Cells[1, 3] = "Budgeterade Kostnader";
            xlWorkSheet.Cells[1, 4] = "Budgeterat Resultat";
            xlWorkSheet.Cells[1, 5] = " - ";
            xlWorkSheet.Cells[1, 6] = "Produktgrupp";
            xlWorkSheet.Cells[1, 7] = "Produktkategori";
            xlWorkSheet.Cells[1, 8] = "Avdelning";
            xlWorkSheet.Cells[2, 1] = prodnamn;
            xlWorkSheet.Cells[2, 2] = prodintäkter;
            xlWorkSheet.Cells[2, 3] = prodKostnader;
            xlWorkSheet.Cells[2, 4] = resultat;
            xlWorkSheet.Cells[2, 6] = prodgrupp;
            xlWorkSheet.Cells[2, 7] = prodkat;
            xlWorkSheet.Cells[2, 8] = prodavd;
            xlWorkSheet.Columns.AutoFit();

            xlWorkBook.SaveAs("d:\\Budgeterat_Resultat_Excel_G4Solutions.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Excelfil skapad, du hittar den d:\\Budgeterat_Resultat_Excel_G4Solutions.xls");
        }

        private void btnExporteraAllt(object sender, EventArgs e)
        {
            ExportMetoden();


            //copyAlltoClipboard();

            //Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //if (xlApp == null)
            //{
            //    MessageBox.Show("Excel är ej korrekt installerat!");
            //    return;
            //}

            //dgvBudgeteratResultat.Rows[0].Selected = true;

            //ProduktDTO produkter = new ProduktDTO();
            //produkter = (ProduktDTO)dgvBudgeteratResultat.CurrentRow.DataBoundItem;

            //string prodnamn = produkter.Namn;
            //string prodgrupp = produkter.Produktgrupp;
            //string prodkat = produkter.Produktkategori;
            //string prodavd = produkter.Avdelning;
            //decimal prodintäkter = businessManager.GetProduktIntäkter(produkter);
            //decimal prodKostnader = produktDict[produkter.ProduktID];
            //decimal resultat = decimal.Parse(lblBudgeteradeIntäkter.Text) - decimal.Parse(lblBudgetKostnader.Text);

            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //int col1 = 1;

            //xlWorkSheet.Cells[1, 1] = "Produkt";
            //xlWorkSheet.Cells[1, 2] = "Budgeterade Intäkter";
            //xlWorkSheet.Cells[1, 3] = "Budgeterade Kostnader";
            //xlWorkSheet.Cells[1, 4] = "Budgeterat Resultat";
            //xlWorkSheet.Cells[1, 5] = " - ";
            //xlWorkSheet.Cells[1, 6] = "Produktgrupp";
            //xlWorkSheet.Cells[1, 7] = "Produktkategori";
            //xlWorkSheet.Cells[1, 8] = "Avdelning";

            //int totprod = 0;
            //totprod = dgvBudgeteratResultat.Rows.Count;

            //dgvBudgeteratResultat.Rows[0].Selected = true;

            //foreach (DataGridViewRow row in dgvBudgeteratResultat.Rows)
            //{
            //    //string hej;
            //    //string prod4;

            //    //hej = row.Cells["namn"].Value.ToString();
            //    //prod4 = row.Cells["produktgrupp"].Value.ToString();



            //    //Console.WriteLine("pPpPp  " + hej + "  PpPpP");
            //    //Console.WriteLine("pPpPp  " + prod4 + "  PpPpP");

            //    //decimal intäktprod = 0;
            //    //decimal kostnadprod = 0;

            //        decimal prodintäkter2 = businessManager.GetProduktIntäkter(produkter);
            //        decimal prodKostnader2 = produktDict[produkter.ProduktID];
            //        decimal resultatprod2 = prodintäkter2 - prodKostnader2;
            //        Console.WriteLine("KEBAB " + produkter.Namn + " KEBAB"); ;


            //        xlWorkSheet.Cells[col1, 1] = row.Cells["namn"].Value;
            //        xlWorkSheet.Cells[col1, 2] = prodintäkter2;
            //        xlWorkSheet.Cells[col1, 3] = prodKostnader2;
            //        xlWorkSheet.Cells[col1, 4] = resultatprod2;
            //        xlWorkSheet.Cells[col1, 6] = row.Cells["produktgrupp"].Value;
            //        xlWorkSheet.Cells[col1, 7] = row.Cells["produktkategori"].Value;
            //        xlWorkSheet.Cells[col1, 8] = row.Cells["avdelning"].Value;

            //    col1 = col1 + 1;


            //    int plus = 0;
            //    plus = plus + 1;
            //    dgvBudgeteratResultat.Rows[plus].Selected = true;
            //}


            //xlWorkSheet.Columns.AutoFit();

            //xlWorkBook.SaveAs("d:\\Budgeterat_Resultat_Excel_G4Solutions.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //Marshal.ReleaseComObject(xlWorkSheet);
            //Marshal.ReleaseComObject(xlWorkBook);
            //Marshal.ReleaseComObject(xlApp);

            //MessageBox.Show("Excelfil skapad, du hittar den d:\\Budgeterat_Resultat_Excel_G4Solutions.xls");

        }


} }        
