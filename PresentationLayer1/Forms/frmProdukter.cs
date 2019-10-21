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

        public frmProdukter()
        {
            InitializeComponent();
            businessManager = new BusinessManager();

            produkter = businessManager.GetAllProdukter();

            dgvProdukter.DataSource = produkter;
           

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
            //this.Visible = !this.Visible;
            Forms.frmAddNewProdukt frmAddNewProdukt = new frmAddNewProdukt();

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
            if (dgvProdukt.CurrentRow.DataBoundItem != null)
            {
                this.Visible = !this.Visible;
                Forms.frmRedigeraProdukt frmRedigeraProdukt= new Forms.frmRedigeraProdukt((ProduktDTO)dgvProdukt.CurrentRow.DataBoundItem);
                frmRedigeraProdukt.Show();
            }
            else
            {
                MessageBox.Show("Du måste välja en kund");
            }
        }
    }
}
