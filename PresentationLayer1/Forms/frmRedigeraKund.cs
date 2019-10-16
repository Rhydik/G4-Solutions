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
    public partial class frmRedigeraKund : Form
    {
        BusinessLayer.BusinessManager businessManager;
        public DataLayer.Kund kunden { get; set; }

        public frmRedigeraKund(DataLayer.Kund kund)
        {
            InitializeComponent();
            businessManager = new BusinessLayer.BusinessManager();
            this.kunden = kund;
        }

        public void load()
        {
            tbKundID2.Text = kunden.KundID.ToString();
            tbKund2.Text = kunden.Namn;
            lblKundkategori.Text = kunden.KundKategori.ToString();
        }

        public void btnTaBortKund_Click(object sender, EventArgs e)
        {
            businessManager.RemoveKund(kunden.KundID);
        }

        private void btnAvbrytKund2_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmKunder frmKunder = new frmKunder();
            frmKunder.Show();
        }

        private void btnSparaKund_Click(object sender, EventArgs e)
        {
            var kundId = tbKundID2.Text;
            var kundNamn = tbKund2.Text;
            var kundKategori = lblKundkategori.Text;

            businessManager.UpdateKund(kundId, kundNamn, kundKategori);
        }
    }
}
