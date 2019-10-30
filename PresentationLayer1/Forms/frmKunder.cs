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

        private void btnRensa_Click(object sender, EventArgs e)
        {
            tbKundID.Text = "";
            tbKund.Text = "";

            RefreshData();
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            string id = null; 
            string kund = tbKund.Text;
            string kundKategori = cmbKundkategori.Text;

            if (tbKundID.Text.Length != 0)
            {
                id = tbKundID.Text; 
            }

            var data = businessManager.GetKunderBySearch(id, kund, kundKategori);

            dgvKunder.DataSource = data;
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

            var kategori = businessManager.GetAllKundKategori();
            cmbKundkategori.DataSource = kategori;
            cmbKundkategori.ValueMember = "Namn";
            cmbKundkategori.DisplayMember = "Namn";
            cmbKundkategori.SelectedIndex = -1;
        }

        private void HideFromUser()
        {
            if (Globals.CurrentPersonal.Behörighet.Equals("Basanvändare"))
            {

                btnRegistreraNyKund.Hide();
                btnRedigeraKund.Hide();
            }
        }
    }
}
