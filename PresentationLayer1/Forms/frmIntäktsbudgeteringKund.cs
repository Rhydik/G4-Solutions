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
            ucSökFältKund.SetGridView(this.dgvIntäktsbudgeteringKund);
        }

        private void Hide()
        {
            lblBudget.Hide();
            lblAvtal.Hide();
            lblTIllägg.Hide();
            lblTim.Hide();
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
            lblTim.Show();
            lblTIllägg.Show();
            lblAvtal.Show();
            lblBudget.Show();
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

        private void btnTaBortProdukt_Click(object sender, EventArgs e)
        {
            var produkten = (IntäktsbudgetKundDTO)dgvIntäktsbudgeteringKund.CurrentRow.DataBoundItem;
            businessManager.RemoveKundProdukt(produkten, lblValdKundID.Text);
            Update();
        }

        private void Update()
        {
            decimal sumAvtal = GetSum(businessManager.GetAllKundProdukter(lblValdKundID.Text), "Avtal");
            decimal sumTillägg = GetSum(businessManager.GetAllKundProdukter(lblValdKundID.Text), "Tillägg");
            decimal sumBudget = GetSum(businessManager.GetAllKundProdukter(lblValdKundID.Text), "Budget");
            decimal sumTim = GetSum(businessManager.GetAllKundProdukter(lblValdKundID.Text), "Tim");
            produkts = businessManager.GetAllKundProdukter(lblValdKundID.Text);
            lblAvtal.Text = sumAvtal.ToString();
            lblTIllägg.Text = sumTillägg.ToString();
            lblBudget.Text = sumBudget.ToString();
            lblTim.Text = sumTim.ToString();
            dgvIntäktsbudgeteringKund.DataSource = produkts;
        }

        private void btnLäggTillProdukt_Click(object sender, EventArgs e)
        {
            frmIntäktsbudgeteringLäggTillProdukt frmIntäktsbudgeteringLäggTillProdukt = new frmIntäktsbudgeteringLäggTillProdukt(lblValdKundNamn.Text, lblValdKundID.Text);
            frmIntäktsbudgeteringLäggTillProdukt.Show();
        }

        private void btnExportera_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            string filename = save.FileName;

            save.DefaultExt = ".xls";
            if (save.ShowDialog() == DialogResult.OK)
            {
                businessManager.Exportera(dgvIntäktsbudgeteringKund, save.FileName);
                MessageBox.Show(filename + " är sparad på " + save.FileName + ".");
            }
        }

        private decimal GetSum(List<IntäktsbudgetKundDTO> produkts, string sak)
        {
            decimal sum = 0;
            if (sak == "Avtal")
            {
                foreach (var item in produkts)
                {
                    sum = sum + item.Avtal;
                }
            }
            else if (sak == "Tillägg")
            {
                foreach (var item in produkts)
                {
                    sum = sum + item.Tillägg;
                }
            }
            else if (sak == "Budget")
            {
                foreach (var item in produkts)
                {
                    sum = sum + item.Budget;
                }
            }
            else if (sak == "Tim")
            {
                foreach (var item in produkts)
                {
                    sum = sum + item.Tim;
                }
            }
            return sum;
        }
        public void RefreshData()
        {
            produkts = businessManager.GetAllKundProdukter(lblValdKundID.Text);

            dgvIntäktsbudgeteringKund.DataSource = produkts;
        }
    }
}
