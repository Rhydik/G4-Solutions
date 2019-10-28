using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;
using DataLayer.DTO;

namespace PresentationLayer1.Forms
{
    public partial class frmIntäktsbudgeteringKund : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<KundDTO> kunds;
        private List<IntäktsbudgetKundDTO> produkts;
        public frmIntäktsbudgeteringKund()
        {
            InitializeComponent();
            Hide();
            kunds = businessManager.GetAllKunder();
            dgvIntäktsbudgeteringKund.DataSource = kunds;
            
        }

        private void Hide()
        {
            btnLäggTillProdukt.Hide();
            btnTaBortProdukt.Hide();
            btnVäljNyKund.Hide();
            btnVäljKund.Show();
        }

        private void btnVäljKund_Click(object sender, EventArgs e)
        {
            KundDTO kunden = (KundDTO)dgvIntäktsbudgeteringKund.CurrentRow.DataBoundItem;
            dgvIntäktsbudgeteringKund.DataSource = null;
            lblValdKundID.Text = kunden.KundID;
            lblValdKundNamn.Text = kunden.Namn;
            Show();
            Update();
        }
        
        private void Show()
        {
            btnLäggTillProdukt.Show();
            btnTaBortProdukt.Show();
            btnVäljKund.Hide();
            btnVäljNyKund.Show();
        }

        private void btnVäljNyKund_Click(object sender, EventArgs e)
        {
            Hide();
            lblValdKundID.Text = "Ej vald";
            lblValdKundNamn.Text = "Ej vald";
            kunds = businessManager.GetAllKunder();
            dgvIntäktsbudgeteringKund.DataSource = kunds;
        }

        private void tbKundID_TextChanged(object sender, EventArgs e)
        {
            if (tbKundID.TextLength == 0)
            {
                kunds = businessManager.GetAllKunder();
                dgvIntäktsbudgeteringKund.DataSource = kunds;
            }
            else
            {
                kunds = businessManager.GetKunderByID(tbKundID.Text);
                dgvIntäktsbudgeteringKund.DataSource = kunds;
            }
        }

        private void tbNamn_TextChanged(object sender, EventArgs e)
        {
            if (tbNamn.TextLength == 0)
            {
                kunds = businessManager.GetAllKunder();
                dgvIntäktsbudgeteringKund.DataSource = kunds;
            }
            else
            {
                kunds = businessManager.GetKunderByNamn(tbNamn.Text);
                dgvIntäktsbudgeteringKund.DataSource = kunds;
            }
        }

        private void cmbKundkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKundkategori.Text == "Alla")
            {
                kunds = businessManager.GetAllKunder();
                dgvIntäktsbudgeteringKund.DataSource = kunds;
            }
            else
            {
                kunds = businessManager.GetKunderByKategori(cmbKundkategori.Text);
                dgvIntäktsbudgeteringKund.DataSource = kunds;
            }
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            tbNamn.Clear();
            tbKundID.Clear();
            cmbKundkategori.Text = "Alla";
        }

        private void btnTaBortProdukt_Click(object sender, EventArgs e)
        {
            ProduktDTO produkten = (ProduktDTO)dgvIntäktsbudgeteringKund.CurrentRow.DataBoundItem;
            //businessManager.RemoveKundProdukt(produkten);
            Update();
        }

        private void Update()
        {
            produkts = businessManager.GetAllKundProdukter(tbKundID.Text);
            dgvIntäktsbudgeteringKund.DataSource = produkts;
        }

        private void btnLäggTillProdukt_Click(object sender, EventArgs e)
        {
            frmIntäktsbudgeteringLäggTillProdukt frmIntäktsbudgeteringLäggTillProdukt = new frmIntäktsbudgeteringLäggTillProdukt(lblValdKundNamn.Text);
            frmIntäktsbudgeteringLäggTillProdukt.Show();
        }
    }
}
