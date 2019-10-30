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
    public partial class frmProdukter : Form
    {
        BusinessManager businessManager;
        private List<ProduktDTO> produkter;
        private List<ProduktDTO> produkterupdated;

        public frmProdukter()
        {
            InitializeComponent();
            businessManager = new BusinessManager();

            produkter = businessManager.GetAllProdukter();

            dgvProdukter.DataSource = produkter;

            var kategori = businessManager.GetProduktByKategori();
            cmbProduktKategori.DataSource = kategori;
            cmbProduktKategori.ValueMember = "Namn";
            cmbProduktKategori.DisplayMember = "Namn";
            cmbProduktKategori.SelectedIndex = -1;

            var grupp = businessManager.GetProduktByGrupp();
            cmbProduktgrupp.DataSource = grupp;
            cmbProduktgrupp.ValueMember = "Namn";
            cmbProduktgrupp.DisplayMember = "Namn";
            cmbProduktgrupp.SelectedIndex = -1;

            cmbVäljAvdelning.Items.Insert(0, "Utvecklings- och förvaltningsavdelning");
            cmbVäljAvdelning.Items.Insert(1, "Driftavdelning");
            cmbVäljAvdelning.SelectedIndex = -1;

        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmKunder frmKunder = new frmKunder();
            frmKunder.Show();
        }

        private void btnProdukter_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            Forms.frmProdukter frmProdukter = new frmProdukter();
        }

        private void btnRegistreraNyProdukt_Click(object sender, EventArgs e)
        {
            Forms.frmRegistreraNyProdukt frmAddNewProdukt = new frmRegistreraNyProdukt();

            frmAddNewProdukt.Show();
        }

        private void dgvProdukter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProdukter_Load(object sender, EventArgs e)
        {

        }

        private void btnRedigeraProdukt_Click(object sender, EventArgs e)
        {
            Forms.frmRedigeraProdukt frmRedigeraProdukt= new Forms.frmRedigeraProdukt((ProduktDTO)dgvProdukter.CurrentRow.DataBoundItem);
            frmRedigeraProdukt.Show();
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            RefreshProdukter();
        }

        public void RefreshProdukter()
        {
            produkterupdated = businessManager.GetAllProdukter();
            dgvProdukter.DataSource = produkterupdated;

            cmbProduktKategori.SelectedIndex = -1;
            cmbProduktgrupp.SelectedIndex = -1;
            cmbVäljAvdelning.SelectedIndex = -1;

            tbProduktID.Text = "";
            tbProdukt.Text = "";
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            string produktID = tbProduktID.Text;
            string namn = tbProdukt.Text;

            var kategori = cmbProduktKategori.GetItemText(cmbProduktKategori.SelectedItem);

            var grupp = cmbProduktgrupp.GetItemText(cmbProduktgrupp.SelectedItem);

            var avdelning = cmbVäljAvdelning.GetItemText(cmbVäljAvdelning.SelectedItem);

            if (tbProduktID.Text.Length != 0)
            {
                produktID = tbProduktID.Text;
            }

            var data = businessManager.GetProdukterBySearch(produktID, namn, kategori, grupp, avdelning);

            dgvProdukter.DataSource = data;
        }

    }
}

