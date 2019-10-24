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
    public partial class frmRegistreraNyKund : Form
    {
        BusinessLayer.BusinessManager businessManager;
        public frmRegistreraNyKund()
        {
            InitializeComponent();
            businessManager = new BusinessLayer.BusinessManager();

            var kategori = businessManager.GetAllKundKategori();
            cmbKundkategori.DataSource = kategori;
            cmbKundkategori.ValueMember = "Namn";
            cmbKundkategori.DisplayMember = "Namn";
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            var kundId = tbKundID.Text;
            var kundNamn = tbKundNamn.Text;
            var kundKategori = cmbKundkategori.Text;

            string id = businessManager.SkapaID(kundId, kundKategori);

            businessManager.AddKund(id, kundNamn, kundKategori);

            MessageBox.Show(kundNamn + " sparad.", "Spara kund", MessageBoxButtons.OK);

            Form frmKunder = new Form();
            frmKunder.Hide();

            this.Visible = !this.Visible;
        }

        private void btnSkapaNyKundkategori_Click(object sender, EventArgs e)
        {
            var kundKategori = cmbKundkategori.Text;

            businessManager.AddKundKategori(kundKategori);

            MessageBox.Show(kundKategori + " sparad.", "Spara kundkategori", MessageBoxButtons.OK);
        }
     
    }
}
