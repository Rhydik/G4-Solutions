using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.DTO;

namespace PresentationLayer1.Forms
{
    public partial class frmIntäktsbudgeteringLäggTillProdukt : Form
    {
        string kund;
        public frmIntäktsbudgeteringLäggTillProdukt(ProduktDTO produkten, string kundNamn)
        {
            InitializeComponent();
            kund = kundNamn;
        }

        public void Load()
        {
            lblKund.Text = kund;
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
