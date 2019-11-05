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
    public partial class ucSökFältKund : UserControl
    {
        private BusinessManager businessManager = new BusinessManager();
        private List<KundDTO> kunds;
        private DataGridView dataGridView;

        public ucSökFältKund()
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
            cmbKundkategori.SelectedIndex = -1;
        }
        private void tbKundID_TextChanged(object sender, EventArgs e)
        {
            Search();

            //if (dataGridView == null) return;
            //
            //string kategori = cmbKundkategori.Text;
            //
            //if (cmbKundkategori.Text.Equals("Alla"))
            //{
            //    kategori = "";
            //}
            //
            //if (tbKundID.TextLength == 0)
            //{
            //    dataGridView.DataSource = businessManager.GetAllKunder();
            //}
            //else
            //{
            //    dataGridView.DataSource = businessManager.GetKunderBySearch(tbKundID.Text, tbNamn.Text, kategori);
            //}
        }

        private void tbNamn_TextChanged(object sender, EventArgs e)
        {
            Search();

            //if (dataGridView == null) return;
            //
            //string kategori = cmbKundkategori.Text;
            //
            //if (cmbKundkategori.Text.Equals("Alla"))
            //{
            //    kategori = "";
            //}
            //
            //if (tbNamn.TextLength == 0)
            //{
            //    dataGridView.DataSource = businessManager.GetAllKunder();
            //}
            //else
            //{
            //    dataGridView.DataSource = businessManager.GetKunderBySearch(tbKundID.Text, tbNamn.Text, kategori);
            //}
        }

        private void cmbKundkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();

            //if (dataGridView == null) return;
            //
            //string kategori = cmbKundkategori.Text;
            //
            //if (cmbKundkategori.Text.Equals("Alla"))
            //{
            //    kategori = ""; 
            //    kunds = businessManager.GetAllKunder();
            //    dataGridView.DataSource = kunds;
            //}
            //
            //else
            //{
            //    dataGridView.DataSource = businessManager.GetKunderBySearch(tbKundID.Text, tbNamn.Text, kategori);
            //}
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            tbNamn.Clear();
            tbKundID.Clear();
            cmbKundkategori.SelectedIndex = -1;
        }

        private void Search()
        {
            if (dataGridView == null) return;

            dataGridView.DataSource = businessManager.GetKunderBySearch(tbKundID.Text, tbNamn.Text, cmbKundkategori.Text);
        }
    }
}
