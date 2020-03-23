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
using DataLayer.DTO;
using BusinessLayer;

namespace PresentationLayer1.Forms
{
    public partial class frmKostnadsbudgetering : Form
    {
        /// <summary>
        /// ToDo:
        ///- Updatera själva logiken i Kalkyleringsmetoden så den gör detta rätt.
        ///- Lägg till så att vyn ändras när man klickar på knapparna Placering, DirektaKostnaderProdukt, DirektaKostnaderAktivitet
        ///- Lägg till exportering av båda(????) gridviewsen i en excelfil (??), samma kod då som i Prognostisering
        ///
        /// övrigt
        ///- kolla in i Lås och Sparaknappen...
        /// </summary>

        BusinessManager businessManager = new BusinessManager();
        private List<KonstnadsbudgetPersonalDTO> personals;
        private List<KostnadsbudgetProduktDTO> produkts;
        private List<BudgetKontoDTO> konton;
        public List<KostnadsbudgetProduktDTO> allaProdukter;
        private List<AvdelningDTO> avdelnings;
        private List<PersonalProduktDTO> personalProdukts;

        public bool IsLåst { get; private set; }

        public frmKostnadsbudgetering()
        {
            InitializeComponent();
            Load();
            CheckLås();
            HideFromUser();
            HideAfterLock();
        }

        private void Load()
        {
            personals = businessManager.GetKostnadsbudgetPersonal();
            businessManager.Kalkylering(personals); //Updatera logiken i kalkylering() så det funkar som det ska
            dgvÖvre.DataSource = personals;
            produkts = businessManager.GetKostnadsbudgetProdukt();
            foreach (var prod in produkts)
            {
                cbProdukt.Items.Add(prod.Produkt);
            }
            allaProdukter = businessManager.GetKostnadsbudgetProdukt();
            dgvNedre.DataSource = businessManager.GetAllPersonalProdukt();
            avdelnings = businessManager.GetAllAvdelningar();
            foreach (var item in avdelnings)
            {
                cmbAvdelning.Items.Add(item.Namn);
            }

            GömKolumnerFörAvdelningar();


    }
        private void CheckLås()
        {
            if (Globals.CurrentPersonal.Behörighet.Equals("Driftavdelningschef") && businessManager.GetDriftLås())
            {
                IsLåst = true;
            }

            else if (Globals.CurrentPersonal.Behörighet.Equals("Utvecklingsavdelningsschef") && businessManager.GetUtvFörvLås())
            {
                IsLåst = true;
            }

            else if (Globals.CurrentPersonal.Behörighet.Equals("Administrativaavdelningschef") && businessManager.GetAffoLås())
            {
                IsLåst = true;
            } else { IsLåst = false; }
        }

        private void buttonVäljAvdelning_Click(object sender, EventArgs e)
        {
            var avdelning = cmbAvdelning.Text;
            personals = businessManager.GetPersonalByAvdelning(avdelning);
            businessManager.Kalkylering(personals);
            dgvÖvre.DataSource = personals;
        }

        public void GömKolumnerFörAvdelningar() //Ui
        {
            //dgvNedre.Columns["ProduktID"].Visible = false;
            //dgvNedre.Columns["Avdelning_AvdelningID"].Visible = false;

        }

        private void btnDirektaKostnaderProdukt_Click(object sender, EventArgs e)
        {
            LaddaDirektaKostnaderUI();
        }

        private void btnPlacering_Click(object sender, EventArgs e)
        {
            dgvNedre.Visible = true;
            cmbAvdelning.Visible = true;
            buttonVäljAvdelning.Visible = true;
            lblAvdelning.Visible = true;
            Load();
        }

        public void LaddaDirektaKostnaderUI()
        {
            konton = businessManager.GetAllKonton();
            dgvÖvre.DataSource = konton;
            dgvÖvre.Columns["KontoID"].Visible = false;
            cmbAvdelning.Visible = false;
            buttonVäljAvdelning.Visible = false;
            lblAvdelning.Visible = false;
        }

        private void btnDirektaKostnaderAktivitet_Click(object sender, EventArgs e)
        {
            LaddaDirektaKostnaderUI();
        }

        private void cbProdukt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblprodukt.Text = cbProdukt.SelectedItem.ToString();
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            KonstnadsbudgetPersonalDTO personal = (KonstnadsbudgetPersonalDTO)dgvÖvre.CurrentRow.DataBoundItem;
            var pers = personal.PersonalID;
            var produkt = cbProdukt.SelectedItem.ToString();
            decimal andel = decimal.Parse(tbAndel.Text);

            var pp = businessManager.GetAllPersonal();

            var query = (from x in pp
                         where x.PersonalID == pers
                         select x.Årsarbete).FirstOrDefault();



            //***********************************Behöver räknas för placeringen********************

            decimal räknaprocent;
            decimal räkna2;
            decimal r2;
            decimal n;
            decimal nyplaceringsandel;


            räkna2 = andel;
            räknaprocent = räkna2 / 100m;

            n = query;

            r2 = räknaprocent * n;

            nyplaceringsandel = r2;

            Console.WriteLine("OSOSOSOSOSOSOSOSOSOSOOSOS  " + nyplaceringsandel + "  OSOSOSOS");



            //**************************************************************************************


            Console.WriteLine("dd" + query + "dd");

            var fördeladandel = businessManager.GetFördeladAndel(pers);



                Console.WriteLine("*** fördeladandel= " + fördeladandel + "***");




            decimal nyandeltest = fördeladandel + nyplaceringsandel;      /* DENNA FÅR INTE VARA MINUS */   
            


                         Console.WriteLine("*** redan fördelat + ny input andel= " + nyandeltest + "***");


            Console.WriteLine("Årsarbetare: " + query);

            if (101 > andel && query >= nyandeltest && nyandeltest > 0)
            {
                businessManager.LäggTillPlaceringProdukt(pers, produkt, andel);
                Update();
                UpdatePersonal();
            }
            else
            {
                MessageBox.Show("Placeringen överstiger den anställdas tid.", "Fel");
            }
        }

        public void Update()
        {
            personalProdukts = businessManager.GetAllPersonalProdukt();
            personalProdukts.Reverse();
            dgvNedre.DataSource = personalProdukts;
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            PersonalProduktDTO perspro = (PersonalProduktDTO)dgvNedre.CurrentRow.DataBoundItem;
            var pers = perspro.Personal;
            decimal andel = perspro.Placeringsandel;
            var produkt = perspro.Produkt;

            businessManager.RemovePlaceringProdukt(pers, produkt, andel);
            Update();
            UpdatePersonal();
        }

        public void UpdatePersonal()
        {
            var avdelning = cmbAvdelning.Text;
            if (avdelning == "")
            {
                personals = businessManager.GetKostnadsbudgetPersonal();
                businessManager.Kalkylering(personals);
                dgvÖvre.DataSource = personals;
            }
            else
            {
                personals = businessManager.GetPersonalByAvdelning(avdelning);
                businessManager.Kalkylering(personals);
                dgvÖvre.DataSource = personals;
            }
        }
        private void HideFromUser()
        {
            if (Globals.CurrentPersonal.Behörighet.Equals("Driftavdelningschef") || Globals.CurrentPersonal.Behörighet.Equals("Utvecklingsavdelningsschef") || Globals.CurrentPersonal.Behörighet.Equals("Administrativaavdelningschef"))
            {

                btnLåsBudget.Show();

            }
            else
            {
                btnLåsBudget.Hide();
            }
        }
        private void btnLåsBudget_Click(object sender, EventArgs e)
        {

            if (IsLåst)
            {
                MessageBox.Show("Budget är redan låst");
            }

            else if (MessageBox.Show("Är du säker på att du vill låsa budgeten?", "Lås budget", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Globals.CurrentPersonal.Behörighet.Equals("Driftavdelningschef"))
                {
                    businessManager.SetDriftLås(true);
                }
                else if (Globals.CurrentPersonal.Behörighet.Equals("Utvecklingsavdelningsschef"))
                {
                    businessManager.SetUtvFörvLås(true);
                }
                else if (Globals.CurrentPersonal.Behörighet.Equals("Administrativaavdelningschef"))
                {
                    businessManager.SetAffoLås(true);
                }
                IsLåst = true;
                HideAfterLock();
            }
        }
        private void HideAfterLock()
        {
            if (IsLåst)
            {
                btnLäggTill.Hide();
                btnLåsBudget.Hide();
                btnTaBort.Hide();
            }
        }

        private void varning_Click(object sender, EventArgs e)
        {

        }
    }
}
