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
    public partial class frmAddNewProdukt : Form
    {
        BusinessManager businessManager;
        private List<ProduktDTO> produkter;

        public frmAddNewProdukt()
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


            string produktID = newProduktkodtxt.Text;
            string namn = newProduktNametxt.Text;

            var kategori = comboBox1.GetItemText(comboBox1.SelectedItem);

            var grupp = comboBox2.GetItemText(comboBox2.SelectedItem);

            var avdelning = comboBox3.GetItemText(comboBox3.SelectedItem);

            businessManager.AddProdukt(produktID, namn, kategori, grupp, avdelning);

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
