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

namespace PresentationLayer1.Forms
{
    public partial class frmPrognostiseringIntäkter : Form
    {
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

        }

        private void Update()
        {

        }

        public static void LäggTillSpel(LästFilPrognos m)   //lagrar spel objekten (m) i vektorn vecSpel //denna metod kallas i metoden "matainLästFil".
        {
            LästFilPrognos[] temp = new LästFilPrognos[vektor.Length + 1];
            for (int i = 0; i < vektor.Length; i++)
            {
                temp[i] = vektor[i];
            }

            temp[vektor.Length] = m;
            vektor = temp;

        }

        public void SparaFilMetod()                      // sparar information från vektorn in i en textfil.
        {
            

            using (StreamWriter utfil = new StreamWriter("IntäktProduktKund.txt")) //här skriver den till dokumentet utefter den definierade "myDocPath" in i MyDocuments.
            {
                for (int i = 0; i < vektor.Length; i++) //bara en for loop som går igenom vecktorn och skriver ut spel efter spel
                {
                    LästFilPrognos m = vektor[i];
                    utfil.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", m.ProduktID, m.Produkt, m.KundID, m.Kund, m.Datum, m.Belopp);

                }

                utfil.Close();

            }

        }

        public void LaddaRegister()    //laddar in data från textfil, vi skrev lite extra kod för att få textfilen i dokument istället för i source > repos > projekt
        {

           

            StreamReader infil = new StreamReader("IntäktProduktKund.txt");

            while (true)
            {
                string line = infil.ReadLine();
                if (line == null) break;
                string[] LästRad = line.Split('\t');

                LästFilPrognos m = new LästFilPrognos();

                m.ProduktID = LästRad[0];
                m.Produkt = LästRad[1];
                m.KundID = LästRad[2];
                m.Kund = LästRad[3];
                m.Datum = LästRad[4];
                m.Belopp = LästRad[5];

                LäggTillSpel(m);
            }

            infil.Close();

        }


        public void TaBortSpel(int index) // Metoden som tar bort ett facks objekt från listan. 
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

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
