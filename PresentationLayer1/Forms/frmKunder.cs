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

            kunder = businessManager.GetAllKunder();

            dataGridView.DataSource = kunder;
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
            kunder = businessManager.GetAllKunder();

            dataGridView.DataSource = kunder;
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            int? id = null; 
            string kund = txtKund.Text;
            string kundKategori = comboBox1.Text;

            if (txtKundID.Text.Length != 0)
            {
                id = Int32.Parse(txtKundID.Text); 
            }

            if (comboBox1.Text == "Välj kundkategori")
            {
                kundKategori = "";
            }

            var data = businessManager.GetKunderBySearch(id, kund, kundKategori);

            dataGridView.DataSource = data;
        }
        private void btnExportera_Click(object sender, EventArgs e)
        {
        }

        private void Exportera<T>(List<T> data)
        {
            
        } 
    }
}
