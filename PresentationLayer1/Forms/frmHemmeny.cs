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
    }
}
