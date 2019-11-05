using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.DTO;

namespace PresentationLayer1.Forms
{
    public partial class ucSökFältProdukt : UserControl
    {
        private BusinessManager businessManager = new BusinessManager();
        private List<ProduktDTO> produkter;
        private DataGridView dataGridView;
        public ucSökFältProdukt()
        {
            InitializeComponent();
        }
        public void SetGridView(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }
        public void Load()
        {   
            var kategori = businessManager.GetProduktByKategori();
            
            cmbProduktkategori.DataSource = kategori;
            cmbProduktkategori.ValueMember = "Namn";
            cmbProduktkategori.DisplayMember = "Namn";
            cmbProduktkategori.SelectedIndex = -1;
            
            var grupp = businessManager.GetProduktByGrupp();
            cmbProduktgrupp.DataSource = grupp;
            cmbProduktgrupp.ValueMember = "Namn";
            cmbProduktgrupp.DisplayMember = "Namn";
            cmbProduktgrupp.SelectedIndex = -1;
            
            cmbAvdelning.Items.Insert(0, "Utvecklings- och förvaltningsavdelning");
            cmbAvdelning.Items.Insert(1, "Driftavdelning");
            cmbAvdelning.SelectedIndex = -1;
        }
        private void tbProduktID_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void tbNamn_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        
        private void cmbProduktkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbProduktgrupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void cmbAvdelning_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void btnRensa_Click(object sender, EventArgs e)
        {
            Rensa();
        }

        public void Rensa()
        {
            tbProduktID.Clear();
            tbNamn.Clear();
            cmbProduktgrupp.SelectedIndex = -1;
            cmbProduktkategori.SelectedIndex = -1;
            cmbAvdelning.SelectedIndex = -1;
        }
        private void Search()
        {
            if (dataGridView == null) return;

            string avdelning = cmbAvdelning.Text;
            string produktGrupp = cmbProduktgrupp.Text;
            string produktKategori = cmbProduktkategori.Text;

            dataGridView.DataSource = businessManager.GetProdukterBySearch(tbProduktID.Text, tbNamn.Text, produktKategori, produktGrupp, avdelning);
        }

    }
}
