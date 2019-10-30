using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer1
{
    public partial class frmHemmeny : Form
    {
        public frmHemmeny()
        {
            InitializeComponent();
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            frmKunder frmKunder = new frmKunder();
            Hide();
            frmKunder.Show();
        }

        private void btnProdukter_Click(object sender, EventArgs e)
        {
            Forms.frmProdukter frmProdukter = new Forms.frmProdukter();
            Hide();
            frmProdukter.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Forms.frmPersonal frmPersonal = new Forms.frmPersonal();
            Hide();
            frmPersonal.Show();
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            Forms.frmAktiviteter frmAktiviteter = new Forms.frmAktiviteter();
                Hide();
            frmAktiviteter.Show();
        }

        private void btnSchablonkostnad_Click(object sender, EventArgs e)
        {
            Forms.frmSchablonkostnad frmSchablonkostnad = new Forms.frmSchablonkostnad();
            Hide();
            frmSchablonkostnad.Show();
        }

        private void btnBehörighet_Click(object sender, EventArgs e)
        {
            Forms.frmBehörighet frmbehörighet = new Forms.frmBehörighet();
            Hide();
            frmbehörighet.Show();
        }

        private void btnIntäktsbudgeteringKund_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            Forms.frmIntäktsbudgeteringKund frmIntäktsbudgeteringKund = new Forms.frmIntäktsbudgeteringKund();
            frmIntäktsbudgeteringKund.Show();
        }

        private void frmHemmeny_Load(object sender, EventArgs e)
        {

        }

        private void btnPrognostiseringIntäkter_Click(object sender, EventArgs e)
        {
            Forms.frmPrognostiseringIntäkter frmPrognostiseringIntäkter = new Forms.frmPrognostiseringIntäkter();
            Hide();
            frmPrognostiseringIntäkter.Show();
        }
    }
}
