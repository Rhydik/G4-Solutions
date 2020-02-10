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
            HideAllOpenForms();
            frmPrognostiseringIntäkter frmPrognostiseringIntäkter = new frmPrognostiseringIntäkter();
            Hide();
            frmPrognostiseringIntäkter.Show();
        }

        private void btnBudgeteratResultat_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();
            frmBudgeteratResultat frmBudgeteratResultat = new frmBudgeteratResultat();
            frmBudgeteratResultat.Show();
        }

        private void btnKostnadsbudgetering_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();
            frmKostnadsbudgetering frmKostnadsbudgetering = new frmKostnadsbudgetering();
            frmKostnadsbudgetering.Show();
        }

        private void btnKostnadProdukt_Click(object sender, EventArgs e)
        {
            {
                HideAllOpenForms();
                frmKostnadProdukt frmKostnadProdukt = new frmKostnadProdukt();
                frmKostnadProdukt.Show();
            }
        }

        private void btnKostnadAktivitet_Click(object sender, EventArgs e)
        {
            {
                HideAllOpenForms();
                frmKostnadAktivitet frmKostnadAktivitet = new frmKostnadAktivitet();
                frmKostnadAktivitet.Show();
            }
        }

        private void btnKostnadsbudgetering2_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();
            frmKostnadsbudgeteringAktivitet frmKostnadsbudgeteringAktivitet = new frmKostnadsbudgeteringAktivitet();
            frmKostnadsbudgeteringAktivitet.Show();
        }
    }
}
