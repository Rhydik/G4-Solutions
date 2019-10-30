using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer1.Forms
{
    public partial class ucMeny : UserControl
    {
        public ucMeny()
        {
            InitializeComponent();
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            frmKunder frmKunder = new frmKunder();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();

            frmKunder.Show();
        }

        private void btnProdukter_Click(object sender, EventArgs e)
        {
            Forms.frmProdukter frmProdukter = new Forms.frmProdukter();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmProdukter.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Forms.frmPersonal frmPersonal = new Forms.frmPersonal();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmPersonal.Show();
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            Forms.frmAktiviteter frmAktiviteter = new Forms.frmAktiviteter();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmAktiviteter.Show();
        }

        private void btnSchablonkostnad_Click(object sender, EventArgs e)
        {
            Forms.frmSchablonkostnad frmSchablonkostnad = new Forms.frmSchablonkostnad();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmSchablonkostnad.Show();
        }

        private void btnBehörighet_Click(object sender, EventArgs e)
        {
            Forms.frmBehörighet frmbehörighet = new Forms.frmBehörighet();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmbehörighet.Show();
        }

        private void btnIntäktsbudgeteringKund_Click(object sender, EventArgs e)
        {
            Forms.frmIntäktsbudgeteringKund frmIntäktsbudgeteringKund = new Forms.frmIntäktsbudgeteringKund();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmIntäktsbudgeteringKund.Show();
        }
    }
}
