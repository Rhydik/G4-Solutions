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

            var produktkategori = businessManager.GetProduktByKategori();
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

        private void btnTaBortProdukt_Click_1(object sender, EventArgs e)
        {
            businessManager.RemoveProdukt(produkten);
            MessageBox.Show("Produkten borttagen!");
        }

        private void btnAvbryt_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpara_Click_1(object sender, EventArgs e)
        {
            var ProduktID = tbProduktID.Text;
            var ProduktNamn = tbProduktNamn.Text;

            var Produktkategori = cmbProduktkategori.Text;

            var Produktgrupp = cmbProduktgrupp.Text;

            var Produktavdelning = cmbAvdelning.Text;

            businessManager.UpdateProdukt(produkten, ProduktID, ProduktNamn, Produktkategori, Produktgrupp, Produktavdelning);
        }

        private void btnSkapaNyProdukGrupp_Click(object sender, EventArgs e)
        {
            frmRegistreraNyProduktGrupp frmRegistreraNyProduktGrupp = new frmRegistreraNyProduktGrupp();
            frmRegistreraNyProduktGrupp.Show();
        }

        private void btnSkapaNyProduktKategori_Click(object sender, EventArgs e)
        {
            frmRegistreraNyProduktKategori frmRegistreraNyProduktkategori = new frmRegistreraNyProduktKategori();
            frmRegistreraNyProduktkategori.Show();
        }
    }
}
