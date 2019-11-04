using BusinessLayer;
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
    public partial class frmIntäktsbudgeteringProdukt : Form
    {
        private BusinessManager businessManager = new BusinessManager();
        private List<ProduktDTO> produkter;
        private List<IntäktsbudgetProduktDTO> kunder;

        public frmIntäktsbudgeteringProdukt()
        {
            InitializeComponent(); 
            Hide();
            produkter = businessManager.GetAllProdukter();
            dgvIntäktsbudgeteringProdukt.DataSource = produkter;
        }

        private void Hide()
        {
            btnLäggTillKund.Hide();
            btnTaBortKund.Hide();
            btnVäljNyProdukt.Hide();
            btnVäljProdukt.Show();
        }

        private void btnVäljProdukt_Click(object sender, EventArgs e)
        {
            ProduktDTO produkten = ((ProduktDTO)dgvIntäktsbudgeteringProdukt.CurrentRow.DataBoundItem);
            btnVäljProdukt.Hide();
            lblValdProdukt.Text = produkten.Namn;
            lblValdProduktID.Text = produkten.ProduktID;
            Show();
            Update();
        }

        private void Show()
        {
            btnLäggTillKund.Show();
            btnTaBortKund.Show();
            btnVäljNyProdukt.Show();
            btnVäljProdukt.Hide();
        }

        private void Update()
        {
            kunder = businessManager.GetAllProduktKunder(lblValdProduktID.Text);
            dgvIntäktsbudgeteringProdukt.DataSource = kunder;
        }

        private void btnVäljNyProdukt_Click(object sender, EventArgs e)
        {
            lblValdProdukt.Text = "Ej vald";
            lblValdProduktID.Text = "Ej vald";
            produkter = businessManager.GetAllProdukter();
            dgvIntäktsbudgeteringProdukt.DataSource = produkter;
            Hide();
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            tbProdukt.Clear();
            tbProduktID.Clear();
        }

        private void btnLäggTillKund_Click(object sender, EventArgs e)
        {
            Forms.frmIntäktsbudgeteringLäggTillKund frmIntäktsbudgeteringLäggTillKund = new frmIntäktsbudgeteringLäggTillKund(lblValdProduktID.Text, lblValdProdukt.Text);
            frmIntäktsbudgeteringLäggTillKund.Show();
        }
    }
}
