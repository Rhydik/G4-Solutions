using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;
using DataLayer.DTO;

namespace PresentationLayer1.Forms
{
    public partial class frmBudgeteratResultat : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<ProduktDTO> produkter;
        private List<ProduktgruppDTO> produktgrupp;
        private List<AvdelningDTO> produktAvdelning;
        public frmBudgeteratResultat()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
               produkter = businessManager.GetAllProdukter();
               dgvBudgeteratResultat.DataSource = produkter;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.Text == "Produkt")
            {
                produkter = businessManager.GetAllProdukter();
                dgvBudgeteratResultat.DataSource = produkter;
            }
            if (cmbKategori.Text == "Produktgrupp")
            {
                produktgrupp = businessManager.GetProduktByGrupp();
                dgvBudgeteratResultat.DataSource = produktgrupp;
            }
            if (cmbKategori.Text == "Produktionsavdelning")
            {
                produktAvdelning = businessManager.GetProduktByAvdelning();
                dgvBudgeteratResultat.DataSource = produktAvdelning;
            }
        }

        private void dgvBudgeteratResultat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProduktDTO produkt = new ProduktDTO();
            produkt = (ProduktDTO)dgvBudgeteratResultat.CurrentRow.DataBoundItem;
            string intäkter = businessManager.GetProduktIntäkter(produkt);
        }
    }
}
