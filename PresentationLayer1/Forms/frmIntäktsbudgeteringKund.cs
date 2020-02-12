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

        private bool IsLåst { get; set; } = false;
        public frmIntäktsbudgeteringKund()
        {
            InitializeComponent();
            Hide();
            HideFromUser();
            btnLåsBudget.Show();

            CheckLås();
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

        private void CheckLås()
        {
            //string message = businessManager.ReadFile("IntäktsBudgetLog.txt");


            if (businessManager.GetIntäktsLås())
            {
                IsLåst = true; 
            }

            else { IsLåst = false; }
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

            if (IsLåst)
            {
                btnLåsBudget.Hide();
                btnLäggTillProdukt.Hide();
                btnTaBortProdukt.Hide();
            }
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
            dgvIntäktsbudgeteringKund.Columns["IntäktsbudgetID"].Visible = false;
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

        private void HideFromUser()
        {
            if (Globals.CurrentPersonal == null) return;

            if (Globals.CurrentPersonal.Behörighet.Equals("Försäljning- och marknadsavdelningschef"))
            {

                btnLåsBudget.Show();
                
            }
            else
            {
                btnLåsBudget.Hide();
            }

        }

        private void btnLåsBudget_Click(object sender, EventArgs e)
        {
            if (IsLåst)
            {
                MessageBox.Show("Budget är redan låst");
            }

            else if (MessageBox.Show("Är du säker på att du vill låsa budgeten?", "Lås budget", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Budget är låst");
                IsLåst = true;
                businessManager.SetIntäktsLås(IsLåst);
                btnLåsBudget.Hide();
            }
            
        }
    }
}
