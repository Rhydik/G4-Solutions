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
using BusinessLayer;
using DataLayer;

namespace PresentationLayer1.Forms
{
    public partial class frmIntäktsbudgeteringLäggTillProdukt : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<ProduktDTO> produkts;
        string kund;
        string kundID;
        public frmIntäktsbudgeteringLäggTillProdukt(string kundNamn, string kundId)
        {
            InitializeComponent();
            kund = kundNamn;
            kundID = kundId;
            lblKunden.Text = kund;
            Load();
            produkts = businessManager.GetAllProdukter();
            dgvProdukter.DataSource = produkts;
        }

        public void Load()
        {
            lblKunden.Text = kund;
        }

        private void btnSpara_Click_1(object sender, EventArgs e)
        {
            var produkt = (ProduktDTO)dgvProdukter.CurrentRow.DataBoundItem;
            Intäktsbudget intäktsbudget = new Intäktsbudget();
            var avtal = decimal.Parse(tbAvtal.Text);
            var tillägg = decimal.Parse(tbTilägg.Text);
            var gradT = bool.Parse(cmbGradT.Text = cmbGradT.Text == "Säker" ? "true" : "False"); ;
            var gradA = bool.Parse(cmbGradA.Text = cmbGradA.Text == "Säker" ? "true" : "False"); ;
            var budget = decimal.Parse(tbTilägg.Text);
            var tim = int.Parse(tbTimmar.Text);
            var kommentar = rtbKommentar.Text;
            businessManager.AddKundProdukt(produkt, avtal, tillägg, gradT, gradA, budget, tim, kommentar, kundID);
            MessageBox.Show("Produkt tillagd!");
        }

        private void btnAvbryt_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
