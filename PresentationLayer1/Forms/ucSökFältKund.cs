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

        public ucSökFältKund()
        {
            InitializeComponent(); 
            kunds = businessManager.GetAllKunder();
            //dgvIntäktsbudgeteringKund.DataSource = kunds;
            cmbKundkategori.SelectedItem = "Alla";
        }
        private void tbKundID_TextChanged(object sender, EventArgs e)
        {
            if (tbKundID.TextLength == 0)
            {
                kunds = businessManager.GetAllKunder();
                //dgvIntäktsbudgeteringKund.DataSource = kunds;
            }
            else
            {
                kunds = businessManager.GetKunderByID(tbKundID.Text);
                //dgvIntäktsbudgeteringKund.DataSource = kunds;
            }
        }

        private void tbNamn_TextChanged(object sender, EventArgs e)
        {
            if (tbNamn.TextLength == 0)
            {
                kunds = businessManager.GetAllKunder();
                //dgvIntäktsbudgeteringKund.DataSource = kunds;
            }
            else
            {
                kunds = businessManager.GetKunderByNamn(tbNamn.Text);
                //dgvIntäktsbudgeteringKund.DataSource = kunds;
            }
        }

        private void cmbKundkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKundkategori.Text == "Alla")
            {
                kunds = businessManager.GetAllKunder();
                //dgvIntäktsbudgeteringKund.DataSource = kunds;
            }
            else
            {
                kunds = businessManager.GetKunderByKategori(cmbKundkategori.Text);
                //dgvIntäktsbudgeteringKund.DataSource = kunds;
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
