﻿using BusinessLayer;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace PresentationLayer1.Forms
{
    public partial class frmIntäktsbudgeteringProdukt : Form
    {
        private BusinessManager businessManager = new BusinessManager();
        private List<ProduktDTO> produkter;
        private List<IntäktsbudgetProduktDTO> kunder;
        private bool IsLåst { get; set; } = false;
        public frmIntäktsbudgeteringProdukt()
        {
            InitializeComponent(); 
            Hide();
            HideFromUser();

            CheckLås();
            produkter = businessManager.GetAllProdukter();
            dgvIntäktsbudgeteringProdukt.DataSource = produkter;
            ucSökFältProdukt.SetGridView(dgvIntäktsbudgeteringProdukt);
            ucSökFältProdukt.Load();
        }

        private void Hide()
        {
            lblTim.Hide();
            lblTillägg.Hide();
            lblBudget.Hide();
            lblAvtal.Hide();
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
        private void CheckLås()
        {
            string message = businessManager.ReadFile("IntäktsBudgetLog.txt");

            if (String.Equals(message, "Budget låst"))
            {
                IsLåst = true;
            }

            else { IsLåst = false; }
        }
        private void Show()
        {
            lblTim.Show();
            lblTillägg.Show();
            lblBudget.Show();
            lblAvtal.Show();
            btnLäggTillKund.Show();
            btnTaBortKund.Show();
            btnVäljNyProdukt.Show();
            btnVäljProdukt.Hide();

            if (IsLåst)
            {
                btnLåsBudget.Hide();
                btnLäggTillKund.Hide();
                btnTaBortKund.Hide();
            }
        }

        private void Update()
        {
            decimal sumAvtal = GetSum(businessManager.GetAllProduktKunder(lblValdProduktID.Text), "Avtal");
            decimal sumTillägg = GetSum(businessManager.GetAllProduktKunder(lblValdProduktID.Text), "Tillägg");
            decimal sumBudget = GetSum(businessManager.GetAllProduktKunder(lblValdProduktID.Text), "Budget");
            decimal sumTim = GetSum(businessManager.GetAllProduktKunder(lblValdProduktID.Text), "Tim");
            lblAvtal.Text = sumAvtal.ToString();
            lblTillägg.Text = sumTillägg.ToString();
            lblBudget.Text = sumBudget.ToString();
            lblTim.Text = sumTim.ToString();
            kunder = businessManager.GetAllProduktKunder(lblValdProduktID.Text);
            dgvIntäktsbudgeteringProdukt.DataSource = kunder;
        }

        private void btnVäljNyProdukt_Click(object sender, EventArgs e)
        {
            lblValdProdukt.Text = "Ej vald";
            lblValdProduktID.Text = "Ej vald";
            produkter = businessManager.GetAllProdukter();
            dgvIntäktsbudgeteringProdukt.DataSource = produkter;
            ucSökFältProdukt.Rensa();
            Hide();
        }

        private void btnLäggTillKund_Click(object sender, EventArgs e)
        {
            Forms.frmIntäktsbudgeteringLäggTillKund frmIntäktsbudgeteringLäggTillKund = new frmIntäktsbudgeteringLäggTillKund(lblValdProduktID.Text, lblValdProdukt.Text);
            frmIntäktsbudgeteringLäggTillKund.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                produkter = businessManager.GetProduktWithoutIntäkt();
                dgvIntäktsbudgeteringProdukt.DataSource = produkter;
            }
            else
            {
                produkter = businessManager.GetAllProdukter();
                dgvIntäktsbudgeteringProdukt.DataSource = produkter;
            }
        }

        private void btnExportera_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            string filename = save.FileName; 

            save.DefaultExt = ".xls";
            if (save.ShowDialog() == DialogResult.OK)
            {
                businessManager.Exportera(dgvIntäktsbudgeteringProdukt, save.FileName);
                MessageBox.Show(filename + " är sparad på " + save.FileName + ".");
            }
        }
        private decimal GetSum(List<IntäktsbudgetProduktDTO> produkts, string sak)
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

        private void btnTaBortKund_Click(object sender, EventArgs e)
        {
            var kunden = (IntäktsbudgetProduktDTO)dgvIntäktsbudgeteringProdukt.CurrentRow.DataBoundItem;
            businessManager.RemoveProduktKund(kunden, lblValdProduktID.Text);
            Update();
        }

        public void RefreshData()
        {
            kunder = businessManager.GetAllProduktKunder(lblValdProduktID.Text);

            dgvIntäktsbudgeteringProdukt.DataSource = kunder;
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

            var result = MessageBox.Show("Är du säker på att du vill låsa budgeten?", "Lås budget", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Budget är låst");
                businessManager.LogFile("Budget låst", "IntäktsbudgetLog.txt");
                IsLåst = true;
                btnLåsBudget.Hide();
            }
        }
    }
}
