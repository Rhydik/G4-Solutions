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
            HideAllOpenForms();

            frmKunder frmKunder = new frmKunder();
            frmKunder.Show();
        }

        private void btnProdukter_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();

            frmProdukter frmProdukter = new frmProdukter();
            frmProdukter.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();

            frmPersonal frmPersonal = new frmPersonal();
            frmPersonal.Show();
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();

            frmAktiviteter frmAktiviteter = new frmAktiviteter();
            frmAktiviteter.Show();
        }

        private void btnSchablonkostnad_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();

            frmSchablonkostnad frmSchablonkostnad = new frmSchablonkostnad();
            frmSchablonkostnad.Show();
        }

        private void btnBehörighet_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();

            frmBehörighet frmbehörighet = new frmBehörighet();
            frmbehörighet.Show();
        }

        private void btnIntäktsbudgeteringKund_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();

            frmIntäktsbudgeteringKund frmIntäktsbudgeteringKund = new frmIntäktsbudgeteringKund();
            frmIntäktsbudgeteringKund.Show();
        }
        private void btnIntäktsbudgeteringProdukt_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();

            frmIntäktsbudgeteringProdukt frmIntäktsbudgeteringProdukt = new frmIntäktsbudgeteringProdukt();
            frmIntäktsbudgeteringProdukt.Show();
        }

        private void HideAllOpenForms()
        {
            var openForms = Application.OpenForms;

            foreach (var form in openForms)
            {
                (form as Form).Hide();
            }
        }

        private void btnPrognostiseringIntäkter_Click(object sender, EventArgs e)
        {
            Forms.frmPrognostiseringIntäkter frmPrognostiseringIntäkter = new Forms.frmPrognostiseringIntäkter();
            Hide();
            frmPrognostiseringIntäkter.Show();
        }
    }
}
