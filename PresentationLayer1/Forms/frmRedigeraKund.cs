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
        public KundDTO kunden { get; set; }

        public frmRedigeraKund(KundDTO kund)
        {
            InitializeComponent();
            businessManager = new BusinessLayer.BusinessManager();
            this.kunden = kund;
            Load();
        }

        public void Load()
        {
            tbKundID2.Text = kunden.KundID;
            tbKund2.Text = kunden.Namn;
            cmbKundkategori2.Text = kunden.KundKategori;

            var kategori = businessManager.GetAllKundKategori();
            cmbKundkategori2.DataSource = kategori;
            cmbKundkategori2.ValueMember = "Namn";
            cmbKundkategori2.DisplayMember = "Namn";
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
            var kundKategori = cmbKundkategori2.Text;

            businessManager.UpdateKund(kunden, kundId, kundNamn, kundKategori);
        }
    }
}
