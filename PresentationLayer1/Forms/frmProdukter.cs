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

            dataGridView2.DataSource = produkter;

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
            Hide();
        }
    }
}
