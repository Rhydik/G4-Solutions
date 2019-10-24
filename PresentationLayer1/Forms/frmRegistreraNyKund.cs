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
            var kundId = tbKundID.Text.ToUpper();
            var kundNamn = tbKundNamn.Text;
            var kundKategori = cmbKundkategori.Text;

            string id = businessManager.SkapaID(kundId, kundKategori);

            try
            {
                if (tbKundID.Text.Length == 4)
                {
                    businessManager.AddKund(id, kundNamn, kundKategori);

                    MessageBox.Show(kundNamn + " sparad.", "Spara kund", MessageBoxButtons.OK);

                    if (Application.OpenForms["frmKunder"] != null)
                    {
                        (Application.OpenForms["frmKunder"] as frmKunder).RefreshData();
                    }

                    tbKundID.Text = "";
                    tbKundNamn.Text = "";
                    cmbKundkategori.SelectedIndex = -1;

                } 
                else
                {
                    MessageBox.Show("KundID måste vara 4 tecken", "KundID för lång.", MessageBoxButtons.OK);
                }
            } 
            catch (Exception exception)
            {

            }
        }

        private void btnSkapaNyKundkategori_Click(object sender, EventArgs e)
        {
            var kundKategori = cmbKundkategori.Text;

            businessManager.AddKundKategori(kundKategori);

            MessageBox.Show(kundKategori + " sparad.", "Spara kundkategori", MessageBoxButtons.OK);
        }
     
    }
}
