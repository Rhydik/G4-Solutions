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

namespace PresentationLayer1
{
    public partial class frmKunder : Form
    {
        BusinessManager businessManager;
        private List<KundDTO> kunder; 
        public frmKunder()
        {
            InitializeComponent();
            businessManager = new BusinessManager();

            RefreshData();

            HideFromUser();
            ucSökFältKund.SetGridView(this.dgvKunder);
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            frmKunder frmKunder = new frmKunder();
            Hide();
            frmKunder.Show();
        }

        private void btnProdukter_Click(object sender, EventArgs e)
        {
            Forms.frmProdukter frmProdukter = new Forms.frmProdukter();
            Hide();
            frmProdukter.Show();
        }
        private void btnRegistreraNyKund_Click(object sender, EventArgs e)
        {
            Forms.frmRegistreraNyKund frmRegistreraNyKund = new Forms.frmRegistreraNyKund();
            frmRegistreraNyKund.Show();
        }

        private void btnRedigeraKund_Click(object sender, EventArgs e)
        {
            if (dgvKunder.CurrentRow.DataBoundItem != null)
            {
                Forms.frmRedigeraKund frmRedigeraKund = new Forms.frmRedigeraKund((KundDTO)dgvKunder.CurrentRow.DataBoundItem);
                frmRedigeraKund.Show();
            }
            else
            {
                MessageBox.Show("Du måste välja en kund");
            }
        }
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            kunder = businessManager.GetAllKunder();

            dgvKunder.DataSource = kunder;
        }

        public void RefreshData()
        {
            kunder = businessManager.GetAllKunder();

            dgvKunder.DataSource = kunder;
        }

        private void HideFromUser()
        {
            if (Globals.CurrentPersonal == null) return;

            if (Globals.CurrentPersonal.Behörighet.Equals("Försäljning- och marknadsavdelningschef"))
            {

                btnRegistreraNyKund.Show();
                btnRedigeraKund.Hide();
            }
            else if (Globals.CurrentPersonal.Behörighet.Equals("Systemansvarig"))
            {
                btnRedigeraKund.Show();
                btnRegistreraNyKund.Show();
            }
            else
            {
                btnRegistreraNyKund.Hide();
                btnRedigeraKund.Hide();
            }
        }
    }
}
