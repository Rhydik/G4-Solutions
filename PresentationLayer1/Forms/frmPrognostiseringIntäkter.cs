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

namespace PresentationLayer1.Forms
{
    public partial class frmPrognostiseringIntäkter : Form
    {
        private BusinessManager businessManager = new BusinessManager();
        //BindingSource bindingSource = new BindingSource();
        //BusinessManager businessManager = new BusinessManager();
        //private List<PrognosDTO> prognoser;
        public static LästFilPrognos[] vektor = new LästFilPrognos[0];
        public frmPrognostiseringIntäkter()
        {
            //prognoser = businessManager.GetAllPrognoser();

            InitializeComponent();
            LaddaRegister();
            List<LästFilPrognos> convert = vektor.Cast<LästFilPrognos>().ToList();
            dgvPrognostiseringIntäkter.DataSource = convert;

            dgvPrognostiseringIntäkter.Columns["ProduktID"].Visible = false;
            dgvPrognostiseringIntäkter.Columns["KundID"].Visible = false;
            dgvPrognostiseringIntäkter.Columns["Kund"].Visible = false;
            dgvPrognostiseringIntäkter.Columns["Datum"].Visible = false;
            dgvPrognostiseringIntäkter.Columns["Månad"].Visible = false;

            //dgvPrognostiseringIntäkter.Columns.Add("Column", "Upparbetat");
            //dgvPrognostiseringIntäkter.Columns.Add("Column", "Trend");
            //dgvPrognostiseringIntäkter.Columns.Add("Column", "Prognos");
            //dgvPrognostiseringIntäkter.Columns.Add("Column", "Prognos-Budget");
            //dgvPrognostiseringIntäkter.Columns.Add("Column", "Budget");
            //dgvPrognostiseringIntäkter.Columns.Add("Column", "Utfall mån");
            //dgvPrognostiseringIntäkter.Columns.Add("Column", "Utfall Acc");


            this.FormClosing += frmPrognostiseringIntäkter_FormClosing; //för att få saker att sparas när man stänger fönstret

            cmbMånad.Items.AddRange(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames);
        }


        private void frmPrognostiseringIntäkter_FormClosing(Object sender, FormClosingEventArgs e) //för att få saker att sparas när man stänger fönstret
        {
            SparaFilMetod();
        }

        private void Update()
        {

        }

        public static void LäggTillIndex(LästFilPrognos m)   //lagrar objekten (m) i vektorn  //denna metod kallas i metoden "matainLästFil".
        {
            LästFilPrognos[] temp = new LästFilPrognos[vektor.Length + 1];
            for (int i = 0; i < vektor.Length; i++)
            {
                temp[i] = vektor[i];
            }
            temp[vektor.Length] = m;
            vektor = temp;
        }

        public void SparaFilMetod() 
        {
            using (StreamWriter utfil = new StreamWriter("IntäktProduktKund.txt")) 
            {
                for (int i = 0; i < vektor.Length; i++) //bara en for loop som går igenom vecktorn och skriver ut line för line
                {
                    LästFilPrognos m = vektor[i];
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
                string[] LästRad = line.Split('\t');

                LästFilPrognos m = new LästFilPrognos();



                m.ProduktID = LästRad[0];
                m.Produkt = LästRad[1];           //visas
                m.KundID = LästRad[2];
                m.Kund = LästRad[3];
                m.Datum = LästRad[4];
                m.Budget = LästRad[5];            //visas
                m.UtfallMån = LästRad[6];         //visas 
                m.UtfallAcc = LästRad[7];         //visas
                m.Månad = LästRad[8];
                m.Upparbetat = LästRad[9];        //visas
                m.Trend = LästRad[10];            //visas
                m.FöregPrognos = LästRad[11];     //visas
                m.Prognos = LästRad[12];          //visas
                m.PrognosBudget = LästRad[13];    //visas

                LäggTillIndex(m);
            }
            infil.Close();
        }


        public void TaBortIndex(int index) // Metoden som tar bort ett facks objekt från listan
        {
            LästFilPrognos[] temp = new LästFilPrognos[vektor.Length - 1];

            for (int i = 0; i < index; i++)
            {
                temp[i] = vektor[i];
            }
            for (int i = index + 1; i < vektor.Length; i++)
            {
                temp[i - 1] = vektor[i];
            }
            vektor = temp;
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

        private void frmPrognostiseringIntäkter_Load_1(object sender, EventArgs e)
        {

        }

        private void RäknaUtBudgetPrognos()
        {
            foreach (DataGridViewRow row in dgvPrognostiseringIntäkter.Rows)
            {
                decimal.TryParse(row.Cells["Budget"]?.Value?.ToString(), out decimal Grade1);
                decimal.TryParse(row.Cells["Prognos"]?.Value?.ToString(), out decimal Grade2);

                //if(Grade2 )

                var resultat = (Grade1 + Grade2);
                row.Cells["PrognosBudget"].Value = resultat;

                MessageBox.Show(resultat.ToString());

            }
        }

        private void btnExportera_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            string filename = save.FileName;

            save.DefaultExt = ".xls";
            if (save.ShowDialog() == DialogResult.OK)
            {
                businessManager.Exportera(dgvPrognostiseringIntäkter, save.FileName);
                MessageBox.Show(filename + " är sparad på " + save.FileName + ".");
            }
        }
    }
}
