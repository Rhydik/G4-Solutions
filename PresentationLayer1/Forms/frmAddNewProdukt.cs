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

            //Combobox hämtas från avdelningar
            var avd = businessManager.GetProduktByAvdelning();
            comboBox3.DataSource = avd;
            comboBox3.ValueMember = "Namn";
            comboBox3.DisplayMember = "Namn";

            //Combobox från kund

            var kund = businessManager.GetAllKunder();
            comboBox4.DataSource = kund;
            comboBox4.ValueMember = "Namn";
            comboBox4.DisplayMember = "Namn";
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


            string kod = newProduktkodtxt.Text;
            string namn = newProduktNametxt.Text;
            Console.WriteLine(kod);
            Console.WriteLine(namn);

            var valkategori = comboBox1.GetItemText(comboBox1.SelectedItem);
            Console.WriteLine(valkategori);

            var valgrupp = comboBox2.GetItemText(comboBox2.SelectedItem);
            Console.WriteLine(valgrupp);

            var valavd = comboBox3.GetItemText(comboBox3.SelectedItem);
            Console.WriteLine(valavd);

            var valkund = comboBox4.GetItemText(comboBox4.SelectedItem);
            Console.WriteLine(valkund);






            //finns inte än, missat att lägga in avdelning till produkt




            //businessManager.AddProdukt(kod, namn, valkategori, valgrupp);



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
