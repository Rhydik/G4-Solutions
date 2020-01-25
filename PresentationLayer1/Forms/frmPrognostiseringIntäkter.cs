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
        /*
            TODO

       - dubbelkolla algoritmen för UtfallAcc + Upparbetat / 12mån , så att detta räknar rätt

       - stoppa in alla stora funktioner i repositories/backend

            Klart-ish

       + Lås funktionen är färdig men borde nog använda sig av "public LåsID Boolean" etc...

      + kolla med patrik ifall det spelar roll att Å,Ä,Ö inte visas rätt i datagridviewen..
        */

        private BusinessManager businessManager = new BusinessManager();
        public List<LästFilPrognos> prognoser = new List<LästFilPrognos>(); //listan populeras av textfilen,används också i gridviewen

        public LästFilPrognos transfer { get; set; }
        /*
          detta "transfer" objekt används för att överföra LästFilPrognos objektet från
          RäknaUtBudgetPrognos:en , och sedan överföra till en lista för en grid i metoden för export av excel blad.
        */

        public frmPrognostiseringIntäkter()
        {
            //prognoser = businessManager.GetAllPrognoser();
            InitializeComponent();
            LaddaRegister();
            dgvPrognostiseringIntäkter.DataSource = prognoser;
            dgvPrognostiseringIntäkter.Columns["ProduktID"].Visible = false; //gömmer de fält som inte behövs
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

        public void SparaFilMetod()
        {
            using (StreamWriter utfil = new StreamWriter("IntäktProduktKund.txt"))
            {
                for (int i = 0; i < prognoser.Count; i++) //bara en for loop som går igenom listan och skriver ut rad för rad
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
                m.Produkt = LästRad[1];           
                m.KundID = LästRad[2];
                m.Kund = LästRad[3];
                m.Datum = LästRad[4];
                m.Budget = decimal.Parse(LästRad[5]);            
                m.UtfallMån = decimal.Parse(LästRad[6]);       
                m.UtfallAcc = decimal.Parse(LästRad[7]);         
                m.Månad = LästRad[8];
                m.Upparbetat = decimal.Parse(LästRad[9]);        
                m.Trend = decimal.Parse(LästRad[10]);           
                m.FöregPrognos = decimal.Parse(LästRad[11]);     
                m.Prognos = decimal.Parse(LästRad[12]);          
                m.PrognosBudget = decimal.Parse(LästRad[13]);   

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
        }

        private void dgvPrognostiseringIntäkter_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmPrognostiseringIntäkter_Load_1(object sender, EventArgs e)
        {
        }
        public void låsPrognostisering()
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill låsa Prognostiseringen?", "Varning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dgvPrognostiseringIntäkter.ReadOnly = true;  //logiken här låser alla grids för redigering, och gör dem utgråade
                dataGridView1.ReadOnly = true;
                dgvPrognostiseringIntäkter.DefaultCellStyle.BackColor = SystemColors.Control;
                dgvPrognostiseringIntäkter.DefaultCellStyle.ForeColor = SystemColors.GrayText;
                dgvPrognostiseringIntäkter.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgvPrognostiseringIntäkter.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText;
                dataGridView1.DefaultCellStyle.BackColor = SystemColors.Control;
                dataGridView1.DefaultCellStyle.ForeColor = SystemColors.GrayText;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText;
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        public void RäknaUtBudgetPrognos()
        {
            LästFilPrognos totalPrognos = new LästFilPrognos();
            foreach (var item in prognoser) //sammanräkning av alla attribut i ett objekt.  Objektet för det "totala" visas i datagridview1 sedan.
            {
                decimal resultatBudget;
                resultatBudget = item.Budget;
                totalPrognos.Budget = totalPrognos.Budget + resultatBudget;

                decimal resultatPrognos;
                resultatPrognos = item.Prognos;
                totalPrognos.Prognos = totalPrognos.Prognos + resultatPrognos;

                decimal resultatUtfallAcc;
                resultatUtfallAcc = item.UtfallAcc;
                totalPrognos.UtfallAcc = totalPrognos.UtfallAcc + resultatUtfallAcc;

                decimal resultatUtfallMån;
                resultatUtfallMån = item.UtfallMån;
                totalPrognos.UtfallMån = totalPrognos.UtfallMån + resultatUtfallMån;

                decimal resultatUpparbetat;
                resultatUpparbetat = item.Upparbetat;
                totalPrognos.Upparbetat = totalPrognos.Upparbetat + resultatUpparbetat;

                decimal resultatTrend;
                resultatTrend = item.Trend;
                totalPrognos.Trend = totalPrognos.Trend + resultatTrend;

                decimal resultatFöregPrognos;
                resultatFöregPrognos = item.FöregPrognos;
                totalPrognos.FöregPrognos = totalPrognos.FöregPrognos + resultatFöregPrognos;

                decimal resultatPrognosBudget;
                resultatPrognosBudget = item.PrognosBudget;
                totalPrognos.PrognosBudget = totalPrognos.PrognosBudget + resultatPrognosBudget;
            }

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

            foreach (var item in prognoser)
            {
                int dela;
                decimal total;

                total = totalPrognos.Upparbetat + totalPrognos.UtfallAcc;
                dela = int.Parse(DateTime.Now.Month.ToString()) * 12;
                var trend = (total / dela);
                trend = Math.Round(trend, 2);
            }

            totalPrognos.Produkt = "Totalt";
            totalPrognos.Kund = "";
            totalPrognos.KundID = "";
            totalPrognos.Månad = "";
            totalPrognos.Datum = "";
            totalPrognos.ProduktID = "";

            dataGridView1.DataSource = totalPrognos; //datagridview 1 är en grid som visar summorna av diverse kolumner
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
                LästFilPrognos ls = new LästFilPrognos(); //ett nytt objekt skapas för att lägga till "totalt" sist i listan
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
                                        /*
                                         shadowdatagrid är en osynlig datagridview som 
                                         används för att sammanställa alla värden och sedan skriva ut excel blad
                                        */

                businessManager.Exportera(shadowDataGridView, save.FileName);
                MessageBox.Show(filename + " är sparad på " + save.FileName + ".");
            }
        }

        private void btnLås_Click(object sender, EventArgs e)
        {
            låsPrognostisering();
        }

        private void button1_Click(object sender, EventArgs e)  //knappen "räkna ut"
        {
            RäknaUtBudgetPrognos();
        }

        private void button2_Click(object sender, EventArgs e) //knappen för att välja månad
        {
            if (cmbMånad.Text != null) //logik för att visa resultat utifrån vald månad helt enkelt
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
