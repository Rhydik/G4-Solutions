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
using DataLayer;
using BusinessLayer;

namespace PresentationLayer1.Forms
{
    public partial class frmIntäktsbudgeteringLäggTillKund : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<KundDTO> kunder;
        string produktID;
        string produktNamn;
        public frmIntäktsbudgeteringLäggTillKund(string produktId, string produktnamn)
        {
            InitializeComponent();
            produktID = produktId;
            produktNamn = produktnamn;
            lblIntäktProdukt.Text = produktNamn;
            kunder = businessManager.GetAllKunder();
            dgv.DataSource = kunder;
            ucSökFältKund.SetGridView(dgv);
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            var kund = (KundDTO)dgv.CurrentRow.DataBoundItem;
            var avtal = decimal.Parse(tbAvtal.Text);
            var tillägg = decimal.Parse(tbTillägg.Text);
            var gradT = bool.Parse(cmbGradT.Text = cmbGradT.Text == "Säker" ? "true" : "False"); ;
            var gradA = bool.Parse(cmbGradA.Text = cmbGradA.Text == "Säker" ? "true" : "False"); ;
            var budget = decimal.Parse(tbBudget.Text);
            var tim = int.Parse(tbTimmar.Text);
            var kommentar = rtbKommentar.Text;
            businessManager.AddProduktKund(kund, avtal, tillägg, gradT, gradA, budget, tim, kommentar, produktID);
            MessageBox.Show("Kunden tillagd!");
        }
    }
}
