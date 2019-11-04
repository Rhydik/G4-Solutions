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
    public partial class ucSökFältProdukter : UserControl
    {
        private BusinessManager businessManager;
        private List<ProduktDTO> produkter;
        private DataGridView dataGridView;
        public ucSökFältProdukter()
        {
            InitializeComponent();
            Load();
        }
        public void SetGridView(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }
        private void Load()
        {

            businessManager = new BusinessManager();

            var kategori = businessManager.GetProduktByKategori();
            cmbProduktkategori.DataSource = kategori;
            cmbProduktkategori.Items.Insert(-1, "Alla");
            cmbProduktkategori.ValueMember = "Namn";
            cmbProduktkategori.DisplayMember = "Namn";
            cmbProduktkategori.SelectedIndex = -1;

            var grupp = businessManager.GetProduktByGrupp();
            cmbProduktgrupp.DataSource = grupp;
            cmbProduktgrupp.Items.Insert(-1, "Alla");
            cmbProduktgrupp.ValueMember = "Namn";
            cmbProduktgrupp.DisplayMember = "Namn";
            cmbProduktgrupp.SelectedIndex = -1;

            cmbAvdelning.Items.Insert(-1, "Alla");
            cmbAvdelning.Items.Insert(0, "Utvecklings- och förvaltningsavdelning");
            cmbAvdelning.Items.Insert(1, "Driftavdelning");
            cmbAvdelning.SelectedIndex = -1;
        }
        private void tbProduktID_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView == null) return;

            dataGridView.DataSource = businessManager.GetProdukterBySearch(tbProduktID.Text, tbNamn.Text, cmbProduktkategori.SelectedText, cmbProduktgrupp.SelectedText, cmbAvdelning.SelectedText);
        
            //if (tbProduktID.TextLength == 0)
            //{
            //    dataGridView.DataSource = businessManager.GetAllProdukter();
            //}
            //else
            //{
            //    dataGridView.DataSource = businessManager.GetProdukterBySearch(tbProduktID.Text, tbNamn.Text, cmbProduktkategori.SelectedText, cmbProduktgrupp.SelectedText, cmbAvdelning.SelectedText);
            //}
        }
        
        private void tbNamn_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView == null) return;

            dataGridView.DataSource = businessManager.GetProdukterBySearch(tbProduktID.Text, tbNamn.Text, cmbProduktkategori.SelectedText, cmbProduktgrupp.SelectedText, cmbAvdelning.SelectedText);

            //if (tbNamn.TextLength == 0)
            //{
            //    kunds = businessManager.GetAllKunder();
            //    dataGridView.DataSource = kunds;
            //}
            //else
            //{
            //    kunds = businessManager.GetKunderByNamn(tbNamn.Text);
            //    dataGridView.DataSource = kunds;
            //}
        }
        
        private void cmbProduktkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView == null) return;


            if (cmbProduktkategori.Text == "Alla")
            {
                dataGridView.DataSource = businessManager.GetAllKunder();
            }
            else
            {
                dataGridView.DataSource = businessManager.GetProdukterBySearch(tbProduktID.Text, tbNamn.Text, cmbProduktkategori.SelectedText, cmbProduktgrupp.SelectedText, cmbAvdelning.SelectedText);
            }
        }

        private void cmbProduktgrupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView == null) return;


            if (cmbProduktgrupp.Text == "Alla")
            {
                dataGridView.DataSource = businessManager.GetAllKunder();
            }
            else
            {
                dataGridView.DataSource = businessManager.GetProdukterBySearch(tbProduktID.Text, tbNamn.Text, cmbProduktkategori.SelectedText, cmbProduktgrupp.SelectedText, cmbAvdelning.SelectedText);
            }
        }
        private void cmbAvdelning_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView == null) return;


            if (cmbProduktkategori.Text == "Alla")
            {
                dataGridView.DataSource = businessManager.GetAllKunder();
            }
            else
            {
                dataGridView.DataSource = businessManager.GetProdukterBySearch(tbProduktID.Text, tbNamn.Text, cmbProduktkategori.SelectedText, cmbProduktgrupp.SelectedText, cmbAvdelning.SelectedText);
            }
        }
        private void btnRensa_Click(object sender, EventArgs e)
        {
            tbProduktID.Clear();
            tbNamn.Clear();
            cmbProduktgrupp.SelectedItem = "Alla";
            cmbProduktkategori.SelectedItem = "Alla";
            cmbAvdelning.SelectedItem = "Alla";
        }
    }
}
