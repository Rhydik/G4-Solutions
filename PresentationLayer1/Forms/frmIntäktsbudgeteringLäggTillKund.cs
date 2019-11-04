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
    public partial class frmIntäktsbudgeteringLäggTillKund : Form
    {
        public frmIntäktsbudgeteringLäggTillKund(string produktId, string produktnamn)
        {
            InitializeComponent();
            var produktID = produktId;
            var produktNamn = produktnamn;
            lblIntäktProdukt.Text = produktNamn;
        }

        private void frmIntäktsbudgeteringLäggTillKund_Load(object sender, EventArgs e)
        {

        }

        private void tbTimmar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTimmar_Click(object sender, EventArgs e)
        {

        }
    }
}
