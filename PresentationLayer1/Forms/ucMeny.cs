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
            frmProdukter frmProdukter = new frmProdukter();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmProdukter.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            frmPersonal frmPersonal = new frmPersonal();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmPersonal.Show();
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            frmAktiviteter frmAktiviteter = new frmAktiviteter();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmAktiviteter.Show();
        }

        private void btnSchablonkostnad_Click(object sender, EventArgs e)
        {
            frmSchablonkostnad frmSchablonkostnad = new frmSchablonkostnad();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmSchablonkostnad.Show();
        }

        private void btnBehörighet_Click(object sender, EventArgs e)
        {
            frmBehörighet frmbehörighet = new frmBehörighet();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmbehörighet.Show();
        }

        private void btnIntäktsbudgeteringKund_Click(object sender, EventArgs e)
        {
            frmIntäktsbudgeteringKund frmIntäktsbudgeteringKund = new frmIntäktsbudgeteringKund();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmIntäktsbudgeteringKund.Show();
        }
        private void btnIntäktsbudgeteringProdukt_Click(object sender, EventArgs e)
        {
            frmIntäktsbudgeteringProdukt frmIntäktsbudgeteringProdukt = new frmIntäktsbudgeteringProdukt();
            (Application.OpenForms["frmHemmeny"] as frmHemmeny).Hide();
            frmIntäktsbudgeteringProdukt.Show();
        }
    }
}
