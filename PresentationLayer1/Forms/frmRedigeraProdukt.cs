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
    public partial class frmRedigeraProdukt : Form
    {
        BusinessLayer.BusinessManager businessManager;
        public ProduktDTO produkten { get; set; }

        public frmRedigeraProdukt(ProduktDTO produkt)
        {
            InitializeComponent();
            businessManager = new BusinessLayer.BusinessManager();
            this.produkten = produkt;
            Load();
        }

        public void Load()
        {
            tbProduktID.Text = produkten.ProduktID;
            tbProduktNamn.Text = produkten.Namn;
            cmbProduktkategori.Text = produkten.Produktkategori;

            var produktkategori = businessManager.GetAllProdukter();
            cmbProduktkategori.DataSource = produktkategori;
            cmbProduktkategori.ValueMember = "Namn";
            cmbProduktkategori.DisplayMember = "Namn";

            var grupp = businessManager.GetProduktByGrupp();
            cmbProduktgrupp.DataSource = grupp;
            cmbProduktgrupp.ValueMember = "Namn";
            cmbProduktgrupp.DisplayMember = "Namn";

            cmbAvdelning.Items.Insert(0, "Utvecklings- och förvaltningsavdelning");
            cmbAvdelning.Items.Insert(1, "Driftavdelning");
            cmbAvdelning.SelectedIndex = 0;
        }

        public void btnTaBortProdukt_Click(object sender, EventArgs e)
        {
            businessManager.RemoveProdukt(produkten);
        }

        private void btnAvbrytProdukt_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmKunder frmKunder = new frmKunder();
            frmKunder.Show();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmKunder frmKunder = new frmKunder();
            frmKunder.Show();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            var ProduktID = tbProduktID.Text;
            var ProduktNamn = tbProduktNamn.Text;

            var Produktkategori = cmbProduktkategori.GetItemText(cmbProduktkategori.SelectedItem);

            var Produktgrupp = cmbProduktgrupp.GetItemText(cmbProduktgrupp.SelectedItem);

            var Produktavdelning = cmbAvdelning.GetItemText(cmbAvdelning.SelectedItem);

            businessManager.UpdateProdukt(produkten, ProduktID, ProduktNamn, Produktkategori, Produktgrupp, Produktavdelning);
        }

        private void tbProduktID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaBortProdukt_Click_1(object sender, EventArgs e)
        {
            businessManager.RemoveProdukt(produkten);
        }

        private void cmbProduktgrupp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProduktkategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAvdelning_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbProduktNamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAvbryt_Click_1(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmProdukter frmProdukter = new frmProdukter();
            frmProdukter.Show();
        }
    }
}
