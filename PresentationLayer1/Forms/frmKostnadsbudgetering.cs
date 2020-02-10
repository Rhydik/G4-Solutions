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
   
        public frmKostnadsbudgetering()
        {
            InitializeComponent();
            Load();
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

            GömKolumnerFörAvdelningar();


        }

        private void buttonVäljAvdelning_Click(object sender, EventArgs e)
        {
            if (cmbAvdelning.Text != null) 
            {
                dgvNedre.DataSource = produkts;
            }
            if (cmbAvdelning.Text == "Försäljnings- och marknadsavdelningen")
            {
                List<KostnadsbudgetProduktDTO> utvaldAvdelning = new List<KostnadsbudgetProduktDTO>(allaProdukter.Where(p => p.Avdelning_AvdelningID == 1));
                dgvNedre.DataSource = utvaldAvdelning;
                GömKolumnerFörAvdelningar();
            }
            else if (cmbAvdelning.Text == "Driftavdelning")
            {
                List<KostnadsbudgetProduktDTO> utvaldAvdelning = new List<KostnadsbudgetProduktDTO>(allaProdukter.Where(p => p.Avdelning_AvdelningID == 2));
                dgvNedre.DataSource = utvaldAvdelning;
                GömKolumnerFörAvdelningar();
            }
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
            var andel = tbAndel.Text;

            businessManager.LäggTillPlaceringProdukt(pers, produkt, andel);
            Update();
        }

        public void Update()
        {
            dgvNedre.DataSource = businessManager.GetAllPersonalProdukt();
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            PersonalProduktDTO perspro = (PersonalProduktDTO)dgvNedre.CurrentRow.DataBoundItem;
            var pers = perspro.Personal;
            var andel = perspro.Placeringsandel;
            var produkt = perspro.Produkt;

            businessManager.RemovePlaceringProdukt(pers, produkt, andel);
            Update();
        }
    }
}
