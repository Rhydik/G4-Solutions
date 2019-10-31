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
        }
        public ucSökFältKund(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;

            dataGridView.DataSource = businessManager.GetAllKunder();
            cmbKundkategori.SelectedItem = "Alla";
        }
        private void tbKundID_TextChanged(object sender, EventArgs e)
        {
            if (tbKundID.TextLength == 0)
            {
                kunds = businessManager.GetAllKunder();
                dataGridView.DataSource = kunds;
            }
            else
            {
                kunds = businessManager.GetKunderByID(tbKundID.Text);
                dataGridView.DataSource = kunds;
            }
        }

        private void tbNamn_TextChanged(object sender, EventArgs e)
        {
            if (tbNamn.TextLength == 0)
            {
                kunds = businessManager.GetAllKunder();
                dataGridView.DataSource = kunds;
            }
            else
            {
                kunds = businessManager.GetKunderByNamn(tbNamn.Text);
                dataGridView.DataSource = kunds;
            }
        }

        private void cmbKundkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKundkategori.Text == "Alla")
            {
                kunds = businessManager.GetAllKunder();
                dataGridView.DataSource = kunds;
            }
            else
            {
                kunds = businessManager.GetKunderByKategori(cmbKundkategori.Text);
                dataGridView.DataSource = kunds;
            }
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            tbNamn.Clear();
            tbKundID.Clear();
            cmbKundkategori.SelectedItem = "Alla";
        }
    }
}
