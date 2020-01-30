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
            dgvNedre.DataSource = produkts;
            allaProdukter = businessManager.GetKostnadsbudgetProdukt();
            GömKolumner();


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
                GömKolumner();
            }
            else if (cmbAvdelning.Text == "Driftavdelning")
            {
                List<KostnadsbudgetProduktDTO> utvaldAvdelning = new List<KostnadsbudgetProduktDTO>(allaProdukter.Where(p => p.Avdelning_AvdelningID == 2));
                dgvNedre.DataSource = utvaldAvdelning;
                GömKolumner();
            }
        }

        public void GömKolumner() //Ui
        {
            dgvNedre.Columns["ProduktID"].Visible = false;
            dgvNedre.Columns["Avdelning_AvdelningID"].Visible = false;

        }
    }
}
