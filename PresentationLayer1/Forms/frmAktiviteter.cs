using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using DataLayer.DTO;

namespace PresentationLayer1.Forms
{
    public partial class frmAktiviteter : Form
    {
        BindingSource bindingSource = new BindingSource();
        BusinessManager businessManager = new BusinessManager();
        private List<AktivitetDTO> aktiviteter;

        public frmAktiviteter()
        {
            InitializeComponent();

            aktiviteter = businessManager.GetAllAktiviteter();
            dgvAktiviteter.DataSource = aktiviteter;

            HideFromUser();
        }

        private void tbAktivitetsID_TextChanged(object sender, EventArgs e)
        {
            if (tbAktivitetsID.TextLength == 0)
            {
                bindingSource.DataSource = businessManager.GetAllAktiviteter();
                dgvAktiviteter.DataSource = bindingSource.DataSource;
            }
            else
            {
                bindingSource.DataSource = businessManager.GetAktivitetById(tbAktivitetsID.Text);
                dgvAktiviteter.DataSource = bindingSource.DataSource;
            }
        }

        private void tbBenämning_TextChanged(object sender, EventArgs e)
        {
            if (tbBenämning.TextLength == 0)
            {
                bindingSource.DataSource = businessManager.GetAllAktiviteter();
                dgvAktiviteter.DataSource = bindingSource.DataSource;
            }
            else
            {
                bindingSource.DataSource = businessManager.GetAktivitetByNamn(tbBenämning.Text);
                dgvAktiviteter.DataSource = bindingSource.DataSource;
            }
        }

        private void cmbVäljAvdelning_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVäljAvdelning.Text == "Alla")
            {
                bindingSource.DataSource = businessManager.GetAllAktiviteter();
                dgvAktiviteter.DataSource = bindingSource.DataSource;
            }
            else
            {
                bindingSource.DataSource = businessManager.GetAktivitetByAvdelning(cmbVäljAvdelning.Text);
                dgvAktiviteter.DataSource = bindingSource.DataSource;
            }
        }

        private void btnRedigeraAktivitet_Click(object sender, EventArgs e)
        {
            frmRedigeraAktivitet frmRedigeraAktivitet = new frmRedigeraAktivitet((AktivitetDTO)dgvAktiviteter.CurrentRow.DataBoundItem);
            frmRedigeraAktivitet.Show();
        }

        private void btnRegistreraNyAktivitet_Click(object sender, EventArgs e)
        {
            frmRegistreraNyAktivitet frmRegistreraNyAktivitet = new frmRegistreraNyAktivitet();
            frmRegistreraNyAktivitet.Show();
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmKunder frmKunder = new frmKunder();
            frmKunder.Show();
        }
        private void HideFromUser()
        {
            if (Globals.CurrentPersonal == null) return;

            if (Globals.CurrentPersonal.Behörighet.Equals("Basanvändare"))
            {

                btnRedigeraAktivitet.Hide();
                btnRegistreraNyAktivitet.Hide();
            }
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            tbAktivitetsID.Clear();
            tbBenämning.Clear();
        }
    }
}
