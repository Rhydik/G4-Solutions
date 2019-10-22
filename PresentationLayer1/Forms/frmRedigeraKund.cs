using DataLayer.DTO;
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
        private KundDTO kund;

        public frmRedigeraKund(KundDTO kund)
        {
            InitializeComponent();
            businessManager = new BusinessLayer.BusinessManager();
            this.kund = kund;
            Load();
        }

        public new void Load()
        {
            tbKundID2.Text = kund.KundID;
            tbKund2.Text = kund.Namn;
            cmbKundkategori.Text = kund.KundKategori;

            var kategori = businessManager.GetAllKundKategori();
            cmbKundkategori.DataSource = kategori;
            cmbKundkategori.ValueMember = "Namn";
            cmbKundkategori.DisplayMember = "Namn";
        }

        public void btnTaBortKund_Click(object sender, EventArgs e)
        {
            businessManager.RemoveKund(kund.KundID);
        }

        private void btnAvbrytKund2_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            //frmKunder frmKunder = new frmKunder();
            //frmKunder.Show();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            //frmKunder frmKunder = new frmKunder();
            //frmKunder.Show();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            var kundId = tbKundID2.Text;
            var kundNamn = tbKund2.Text;
            var kundKategori = cmbKundkategori.Text;

            businessManager.UpdateKund(kund, kundId, kundNamn, kundKategori);
        }

    }
}
