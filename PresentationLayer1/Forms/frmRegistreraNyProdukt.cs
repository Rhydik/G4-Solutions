using BusinessLayer;
using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer1.Forms
{
    public partial class frmRegistreraNyProdukt : Form
    {
        BusinessManager businessManager;
        private List<ProduktDTO> produkter;
        private List<ProduktDTO> produktGruppUpdated;

        public frmRegistreraNyProdukt()
        {
            InitializeComponent();
            this.Text = "Registrera ny Produkt";
            businessManager = new BusinessManager();

            produkter = businessManager.GetAllProdukter();

            //Combobox, hämtas från Produktkategori

            var kategori = businessManager.GetProduktByKategori();
            comboBox1.DataSource = kategori;
            comboBox1.ValueMember = "Namn";
            comboBox1.DisplayMember = "Namn";

            //Combobox hämtas från Produktgrupp

            var grupp = businessManager.GetProduktByGrupp();
            comboBox2.DataSource = grupp;
            comboBox2.ValueMember = "Namn";
            comboBox2.DisplayMember = "Namn";

            comboBox3.Items.Insert(0, "Utvecklings- och förvaltningsavdelning");
            comboBox3.Items.Insert(1, "Driftavdelning");
            comboBox3.SelectedIndex = 0;
        }

        private void newProduktNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNewProdukt_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAddProdukt_Click(object sender, EventArgs e)
        {
            string namn = newProduktNametxt.Text;

            string delID = tbDelProduktID.Text;

            var kategori = comboBox1.GetItemText(comboBox1.SelectedItem);

            var grupp = comboBox2.GetItemText(comboBox2.SelectedItem);

            string produktID = businessManager.SkapaID(delID, grupp);

            var avdelning = comboBox3.GetItemText(comboBox3.SelectedItem);
            if (businessManager.CheckAvdelning(comboBox3.Text) == true)
            {
                businessManager.AddProdukt(produktID, namn, kategori, grupp, avdelning);
            }
            else
            {
                businessManager.CreateAvdelning(avdelning);
                businessManager.AddProdukt(produktID, namn, kategori, grupp, avdelning);
            }

            if (System.Windows.Forms.Application.OpenForms["frmProdukter"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmProdukter"] as frmProdukter).RefreshProdukter();
            }

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            newProduktNametxt.Clear();
            tbDelProduktID.Clear();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistreraNyProduktKategori_Click(object sender, EventArgs e)
        {
            Forms.frmRegistreraNyProduktKategori frmAddNewProduktKategori = new frmRegistreraNyProduktKategori();
            frmAddNewProduktKategori.TopMost = true;
            frmAddNewProduktKategori.Show();
        }

        private void btnRegistreraNyProduktGrupp_Click(object sender, EventArgs e)
        {
            Forms.frmRegistreraNyProduktGrupp frmAddNewProduktgrupp = new frmRegistreraNyProduktGrupp();
            frmAddNewProduktgrupp.TopMost = true;
            frmAddNewProduktgrupp.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void RefreshProduktGrupp()
        {
            var produktGruppUpdated = businessManager.GetProduktByGrupp();
            comboBox2.DataSource = produktGruppUpdated;
            comboBox2.ValueMember = "Namn";
            comboBox2.DisplayMember = "Namn";
        }

        public void RefreshProduktKategori()
        {
            var produktKategoriUpdated = businessManager.GetProduktByKategori();
            comboBox1.DataSource = produktKategoriUpdated;
            comboBox1.ValueMember = "Namn";
            comboBox1.DisplayMember = "Namn";
        }
    }
}
