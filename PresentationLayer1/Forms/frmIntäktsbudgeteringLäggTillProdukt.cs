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
            ucSökFältProdukt.SetGridView(dgvProdukter);
            ucSökFältProdukt.Load();
        }

        public void Load()
        {
            lblKunden.Text = kund;
        }

        private void btnSpara_Click_1(object sender, EventArgs e)
        {
            var tim = 0;
            var kommentar = " ";
            var produkt = (ProduktDTO)dgvProdukter.CurrentRow.DataBoundItem;
            var avtal = double.Parse(tbAvtal.Text);
            var tillägg = double.Parse(tbTilägg.Text);
            var gradT = bool.Parse(cmbGradT.Text = cmbGradT.Text == "Säker" ? "true" : "False"); ;
            var gradA = bool.Parse(cmbGradA.Text = cmbGradA.Text == "Säker" ? "true" : "False"); ;
            if (tbTimmar.Text.Length == 0)
            {
                tim = 0;
            }
            else
            {
                tim = int.Parse(tbTimmar.Text);
            }
            if (rtbKommentar.Text.Length == 0)
            {
                kommentar = " ";
            }
            else
            {
                kommentar = rtbKommentar.Text;
            }
            businessManager.AddKundProdukt(produkt, avtal, tillägg, gradT, gradA, tim, kommentar, kundID);
            MessageBox.Show("Produkt tillagd!");
        }

        private void btnAvbryt_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmIntäktsbudgeteringKund"] != null)
            {
                (Application.OpenForms["frmIntäktsbudgeteringKund"] as frmIntäktsbudgeteringKund).RefreshData(kundID);
            }
            Close();
        }


    }
}
