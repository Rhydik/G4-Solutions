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
    public partial class frmKostnadsbudgeteringAktivitet : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<AktivitetDTO> aktivitets;
        private List<KonstnadsbudgetPersonalDTO> personals;
        private List<AvdelningDTO> avdelnings;

        public bool IsLåst { get; private set; }

        public frmKostnadsbudgeteringAktivitet()
        {
            InitializeComponent();
            Load();
            HideFromUser();
            CheckLås();
            HideAfterLock();
        }

        public void Load()
        {
            aktivitets = businessManager.GetAllAktiviteter();
            foreach (var item in aktivitets)
            {
                cbAktivitet.Items.Add(item.Namn);
            }
            personals = businessManager.GetKostnadsbudgetPersonal();
            businessManager.Kalkylering(personals); //Updatera logiken i kalkylering() så det funkar som det ska
            dgvÖvre.DataSource = personals;
            dgvNedre.DataSource = businessManager.GetAllPersonalAktivitet();
            avdelnings = businessManager.GetAllAvdelningar();
            foreach (var item in avdelnings)
            {
                cmbAvdelning.Items.Add(item.Namn);
            }
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
            }
            else { IsLåst = false; }
        }


        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            KonstnadsbudgetPersonalDTO personal = (KonstnadsbudgetPersonalDTO)dgvÖvre.CurrentRow.DataBoundItem;
            var pers = personal.PersonalID;
            var aktivitet = cbAktivitet.SelectedItem.ToString();
            decimal andel = decimal.Parse(tbAndel.Text);

           
            //Update();
            //UpdatePersonal();

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
                businessManager.LäggTillPlaceringAktivitet(pers, aktivitet, andel);
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
            dgvNedre.DataSource = businessManager.GetAllPersonalAktivitet();
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            PersonalAktivitetDTO perspro = (PersonalAktivitetDTO)dgvNedre.CurrentRow.DataBoundItem;
            var pers = perspro.Personal;
            var andel = perspro.Placeringsandel;
            var aktivitet = perspro.Aktivitet;

            businessManager.RemovePlaceringAktivitet(pers, aktivitet, andel);
            Update();
            UpdatePersonal();
        }

        private void buttonVäljAvdelning_Click(object sender, EventArgs e)
        {
            var avdelning = cmbAvdelning.Text;
            personals = businessManager.GetPersonalByAvdelning(avdelning);
            businessManager.Kalkylering(personals);
            dgvÖvre.DataSource = personals;
        }

        public void UpdatePersonal()
        {
            personals = businessManager.GetKostnadsbudgetPersonal();
            businessManager.Kalkylering(personals);
            dgvÖvre.DataSource = personals;
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
    }
}
