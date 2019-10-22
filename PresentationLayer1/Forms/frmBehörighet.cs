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

namespace PresentationLayer1.Forms
{
    public partial class frmBehörighet : Form
    {
        BusinessManager businessManager = new BusinessManager();
        BindingSource bindingSource = new BindingSource();
        public List<BehörighetDTO> behörighets;

        public frmBehörighet()
        {
            InitializeComponent();

            behörighets = businessManager.GetAllBehörighet();
            dgvBehörighet.DataSource = behörighets;
        }

        private void btnRedigeraBehörighet_Click(object sender, EventArgs e)
        {
            //this.Visible = !this.Visible;
            frmRedigeraBehörighet frmRedigeraBehörighet = new frmRedigeraBehörighet((BehörighetDTO)dgvBehörighet.CurrentRow.DataBoundItem);
            frmRedigeraBehörighet.Show();
        }

        private void tbPersonNr_TextChanged(object sender, EventArgs e)
        {
            if (tbPersonNr.TextLength == 0)
            {
                behörighets = businessManager.GetAllBehörighet();
                dgvBehörighet.DataSource = behörighets;
            }
            else
            {
                behörighets = businessManager.GetBehörighetByPersnr(tbPersonNr.Text);
                dgvBehörighet.DataSource = behörighets;
            }
        }

        private void tbNamn_TextChanged(object sender, EventArgs e)
        {
            if (tbNamn.TextLength == 0)
            {
                behörighets = businessManager.GetAllBehörighet();
                dgvBehörighet.DataSource = behörighets;
            }
            else
            {
                behörighets = businessManager.GetBehörighetByNamn(tbNamn.Text);
                dgvBehörighet.DataSource = behörighets;
            }
        }
    }
}
