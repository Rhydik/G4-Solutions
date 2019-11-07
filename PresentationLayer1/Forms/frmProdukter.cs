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

            HideFromUser();

            ucSökFältProdukt.SetGridView(this.dgvProdukter);
            ucSökFältProdukt.Load();
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmKunder frmKunder = new frmKunder();
            frmKunder.Show();
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



        public void RefreshProdukter()
        {
            produkterupdated = businessManager.GetAllProdukter();
            dgvProdukter.DataSource = produkterupdated;

            ucSökFältProdukt.Rensa();
        }
        private void HideFromUser()
        {
            if (Globals.CurrentPersonal == null) return;

            if (Globals.CurrentPersonal.Behörighet.Equals("Marknadsavdelningsschef") || Globals.CurrentPersonal.Behörighet.Equals("Försäljningsavdelningschef")|| Globals.CurrentPersonal.Behörighet.Equals("Driftavdelningschef")|| Globals.CurrentPersonal.Behörighet.Equals("Utvecklingsavdelningsschef")|| Globals.CurrentPersonal.Behörighet.Equals("Kundavdelningschef"))
            {

                btnRegistreraNyProdukt.Show();
                btnRedigeraProdukt.Hide();
            }
            else if (Globals.CurrentPersonal.Behörighet.Equals("Systemansvarig"))
            {
                btnRedigeraProdukt.Show();
                btnRegistreraNyProdukt.Show();
            }
            else
            {
                btnRegistreraNyProdukt.Hide();
                btnRedigeraProdukt.Hide();
            }
        }

    }
}

