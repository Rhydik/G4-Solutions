using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;
using System.IO;

namespace PresentationLayer1.Forms
{
    public partial class frmPrognostiseringIntäkter : Form
    {
        

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

            if (businessManager.GetProgLås())
            {
                Lås();
            }

            InitializeComponent();
            LaddaRegister();
            dgvPrognostiseringIntäkter.DataSource = prognoser;
            dgvPrognostiseringIntäkter.Columns["ProduktID"].Visible = false; //gömmer onödiga fält
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
            businessManager.SparaFilMetod(prognoser);
        }



        public void LaddaRegister()    //laddar in data från textfil
        {
            prognoser = businessManager.LaddaRegister(); 
            dgvPrognostiseringIntäkter.DataSource = prognoser;
        }

        public void låsPrognostisering()
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill låsa Prognostiseringen?", "Varning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Lås();
                businessManager.SetProgLås(true);
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        public void RäknaUtBudgetPrognos()
        {
            LästFilPrognos totalPrognos = new LästFilPrognos();
            totalPrognos = businessManager.RäknaUtBudgetPrognos(prognoser);


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

            transfer = totalPrognos;
            businessManager.SparaFilMetod(prognoser);
        }

        private void btnExportera_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            string filename = save.FileName;

            save.DefaultExt = ".xls";
            if (save.ShowDialog() == DialogResult.OK)
            {
                List<LästFilPrognos> Förberedaprognoser = businessManager.FörberedaExport(transfer, prognoser);
                
                shadowDataGridView.DataSource = Förberedaprognoser;
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

        private void Lås()
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
        private void ucMeny_Enter(object sender, EventArgs e)
        {
            businessManager.SparaFilMetod(prognoser);
        }
    }
}
