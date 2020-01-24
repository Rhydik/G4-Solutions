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
using System.IO;
using System.Globalization;
using System.Threading;

namespace PresentationLayer1.Forms
{
    public partial class frmPrognostiseringIntäkter : Form
    {

        private BusinessManager businessManager = new BusinessManager();
        public List<LästFilPrognos> prognoser = new List<LästFilPrognos>();

        public LästFilPrognos transfer { get; set; }
        
        public frmPrognostiseringIntäkter()
        {
            //prognoser = businessManager.GetAllPrognoser();
           

            InitializeComponent();
            LaddaRegister();




            dgvPrognostiseringIntäkter.DataSource = prognoser;
           
            dgvPrognostiseringIntäkter.Columns["ProduktID"].Visible = false;
            dgvPrognostiseringIntäkter.Columns["KundID"].Visible = false;
            dgvPrognostiseringIntäkter.Columns["Kund"].Visible = false;
            dgvPrognostiseringIntäkter.Columns["Datum"].Visible = false;
            this.FormClosing += frmPrognostiseringIntäkter_FormClosing; //för att få saker att sparas när man stänger fönstret
            cmbMånad.Items.AddRange(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames);
            cmbMånad.Items.Add("Alla Månader");


            RäknaUtBudgetPrognos();
        }


        private void frmPrognostiseringIntäkter_FormClosing(Object sender, FormClosingEventArgs e) //för att få saker att sparas när man stänger fönstret
        {
            SparaFilMetod();
        }

        private void UpdateUi()
        {

            //prognoser.Clear();
            //LaddaRegister();

            //dgvPrognostiseringIntäkter.DataSource = null;

            //dgvPrognostiseringIntäkter.DataSource = prognoser;
            //dgvPrognostiseringIntäkter.Refresh();

        }



        public void SparaFilMetod()
        {
            using (StreamWriter utfil = new StreamWriter("IntäktProduktKund.txt"))
            {
                for (int i = 0; i < prognoser.Count; i++) //bara en for loop som går igenom vecktorn och skriver ut line för line
                {
                    LästFilPrognos m = prognoser[i];
                    utfil.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}", m.ProduktID, m.Produkt, m.KundID, m.Kund, m.Datum, m.Budget, m.UtfallMån, m.UtfallAcc, m.Månad, m.Upparbetat, m.Trend, m.FöregPrognos, m.Prognos, m.PrognosBudget);
                }
                utfil.Close();
            }
        }

        public void LaddaRegister()    //laddar in data från textfil
        {

            StreamReader infil = new StreamReader("IntäktProduktKund.txt");

            while (true)
            {
                string line = infil.ReadLine();

                if (line == null) break;
                List<string> LästRad = new List<string>(line.Split('\t'));

                LästFilPrognos m = new LästFilPrognos();

                m.ProduktID = LästRad[0];
                m.Produkt = LästRad[1];           //visas
                m.KundID = LästRad[2];
                m.Kund = LästRad[3];
                m.Datum = LästRad[4];
                m.Budget = decimal.Parse(LästRad[5]);            //visas
                m.UtfallMån = decimal.Parse(LästRad[6]);         //visas 
                m.UtfallAcc = decimal.Parse(LästRad[7]);         //visas
                m.Månad = LästRad[8];
                m.Upparbetat = decimal.Parse(LästRad[9]);        //visas
                m.Trend = decimal.Parse(LästRad[10]);            //visas
                m.FöregPrognos = decimal.Parse(LästRad[11]);     //visas
                m.Prognos = decimal.Parse(LästRad[12]);          //visas
                m.PrognosBudget = decimal.Parse(LästRad[13]);    //visas


                prognoser.Add(m);

            }


            infil.Close();
        }



        private void lblKategori_Click(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e) //månad
        {



        }

        private void btnSchablonkostnad_Click(object sender, EventArgs e)
        {

        }

        private void frmPrognostiseringIntäkter_Load(object sender, EventArgs e)
        {

        }

        private void dgvPrognostiseringIntäkter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // dgvPrognostiseringIntäkter.changed
        }

        private void dgvPrognostiseringIntäkter_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvPrognostiseringIntäkter.Columns[e.ColumnIndex].Name == "Budget")
            //{
            //    RäknaUtBudgetPrognos();
            //}
        }

        private void frmPrognostiseringIntäkter_Load_1(object sender, EventArgs e)
        {

        }

        public void RäknaUtBudgetPrognos()
        {

            //UpdateUi();

            LästFilPrognos totalPrognos = new LästFilPrognos();


            foreach (var item in prognoser)
            {
                decimal resultat1;
                resultat1 = item.Budget;
                totalPrognos.Budget = totalPrognos.Budget + resultat1;

                decimal resultat2;
                resultat2 = item.Prognos;
                totalPrognos.Prognos = totalPrognos.Prognos + resultat2;

                decimal resultat3;
                resultat3 = item.UtfallAcc;
                totalPrognos.UtfallAcc = totalPrognos.UtfallAcc + resultat3;

                decimal resultat4;
                resultat4 = item.UtfallMån;
                totalPrognos.UtfallMån = totalPrognos.UtfallMån + resultat4;

                decimal resultat5;
                resultat5 = item.Upparbetat;
                totalPrognos.Upparbetat = totalPrognos.Upparbetat + resultat5;

                decimal resultat6;
                resultat6 = item.Trend;
                totalPrognos.Trend = totalPrognos.Trend + resultat6;

                decimal resultat7;
                resultat7 = item.FöregPrognos;
                totalPrognos.FöregPrognos = totalPrognos.FöregPrognos + resultat7;


                decimal resultat8;
                resultat8 = item.FöregPrognos;
                totalPrognos.FöregPrognos = totalPrognos.FöregPrognos + resultat8;
            }


            //foreach (DataGridViewRow row in dgvPrognostiseringIntäkter.Rows)
            //{

            //    decimal.TryParse(row.Cells["Budget"]?.Value?.ToString(), out decimal Grade1);
            //    decimal.TryParse(row.Cells["Prognos"]?.Value?.ToString(), out decimal Grade2);
            //    decimal.TryParse(row.Cells["UtfallAcc"]?.Value?.ToString(), out decimal Grade3);
            //    decimal.TryParse(row.Cells["UtfallMån"]?.Value?.ToString(), out decimal Grade4);
            //    decimal.TryParse(row.Cells["Upparbetat"]?.Value?.ToString(), out decimal Grade5);
            //    decimal.TryParse(row.Cells["Trend"]?.Value?.ToString(), out decimal Grade6);
            //    decimal.TryParse(row.Cells["FöregPrognos"]?.Value?.ToString(), out decimal Grade7);
            //    decimal.TryParse(row.Cells["PrognosBudget"]?.Value?.ToString(), out decimal Grade8);

            //    var resultat1 = (Grade1);
            //    row.Cells["Budget"].Value = resultat1;
            //    totalPrognos.Budget = totalPrognos.Budget + resultat1;

            //    var resultat2 = (Grade2);
            //    row.Cells["Prognos"].Value = resultat2;
            //    totalPrognos.Prognos = totalPrognos.Prognos + resultat2;

            //    var resultat3 = (Grade3);
            //    row.Cells["UtfallAcc"].Value = resultat3;
            //    totalPrognos.UtfallAcc = totalPrognos.UtfallAcc + resultat3;

            //    var resultat4 = (Grade4);
            //    row.Cells["UtfallMån"].Value = resultat4;
            //    totalPrognos.UtfallMån = totalPrognos.UtfallMån + resultat4;

            //    var resultat5 = (Grade5);
            //    row.Cells["Upparbetat"].Value = resultat5;
            //    totalPrognos.Upparbetat = totalPrognos.Upparbetat + resultat5;

            //    var resultat6 = (Grade6);
            //    row.Cells["Trend"].Value = resultat6;
            //    totalPrognos.Trend = totalPrognos.Trend + resultat6;

            //    var resultat7 = (Grade7);
            //    row.Cells["FöregPrognos"].Value = resultat7;
            //    totalPrognos.FöregPrognos = totalPrognos.FöregPrognos + resultat7;

            //    var resultat8 = (Grade8);
            //    row.Cells["PrognosBudget"].Value = resultat8;
            //    totalPrognos.PrognosBudget = totalPrognos.PrognosBudget + resultat8;
            //}


            //foreach (DataGridViewRow row in dgvPrognostiseringIntäkter.Rows)
            //{
            //    decimal.TryParse(row.Cells["UtfallAcc"]?.Value?.ToString(), out decimal Grade10);
            //    decimal.TryParse(row.Cells["Upparbetat"]?.Value?.ToString(), out decimal Grade20);


            //    dela = int.Parse(DateTime.Now.Month.ToString()) * 12;
            //    total = Grade10 + Grade20;

            //    var trend = (total/dela);
            //    trend = Math.Round(trend, 2);
            //    row.Cells["Trend"].Value = trend;
            //}
            totalPrognos.Produkt = "Totalt";
            totalPrognos.Kund = "";
            totalPrognos.KundID = "";
            totalPrognos.Månad = "";
            totalPrognos.Datum = "";
            totalPrognos.ProduktID = "";

            dataGridView1.DataSource = totalPrognos;

            dgvPrognostiseringIntäkter.DataSource = null;
            dgvPrognostiseringIntäkter.DataSource = prognoser;
          
            dataGridView1.DataSource = new List<LästFilPrognos> { totalPrognos };

            dataGridView1.Columns["ProduktID"].Visible = false;
            dataGridView1.Columns["Produkt"].Visible = false;
            dataGridView1.Columns["KundID"].Visible = false;
            dataGridView1.Columns["Kund"].Visible = false;
            dataGridView1.Columns["Datum"].Visible = false;
            dataGridView1.Columns["Månad"].Visible = false;

            
            transfer = totalPrognos;
        }



        private void btnExportera_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            string filename = save.FileName;

            save.DefaultExt = ".xls";
            if (save.ShowDialog() == DialogResult.OK)
            {
                LästFilPrognos ls = new LästFilPrognos();

                ls.Budget = transfer.Budget;
                ls.Datum = transfer.Datum;
                ls.FöregPrognos = transfer.FöregPrognos;
                ls.Kund = transfer.Kund;
                ls.KundID = transfer.KundID;
                ls.Månad = transfer.Månad;
                ls.Produkt = transfer.Produkt;
                ls.ProduktID = transfer.ProduktID;
                ls.Prognos = transfer.Prognos;
                ls.PrognosBudget = transfer.PrognosBudget;
                ls.Trend = transfer.Trend;
                ls.Upparbetat = transfer.Upparbetat;
                ls.UtfallAcc = transfer.UtfallAcc;
                ls.UtfallMån = transfer.UtfallMån;
                prognoser.Add(transfer);


                shadowDataGridView.DataSource = prognoser;

 
                //businessManager.Exportera(dgvPrognostiseringIntäkter, save.FileName);
                businessManager.Exportera(shadowDataGridView, save.FileName);
                MessageBox.Show(filename + " är sparad på " + save.FileName + ".");
            }
        }

        private void btnLås_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RäknaUtBudgetPrognos();

      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbMånad.Text != null)
            {
                List<LästFilPrognos> utvaldMånad = new List<LästFilPrognos>(prognoser.Where(p => p.Månad == cmbMånad.Text));

                dgvPrognostiseringIntäkter.DataSource = utvaldMånad;
            }
            if (cmbMånad.Text == "Alla Månader")
            {
                dgvPrognostiseringIntäkter.DataSource = prognoser;

            }

        }
    }
}
