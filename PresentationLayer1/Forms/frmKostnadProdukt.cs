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
using DataLayer.DTO;
using BusinessLayer;

namespace PresentationLayer1.Forms
{
    public partial class frmKostnadProdukt : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<ProduktDTO> produkts;
        private List<BudgetKontoDTO> kontos;
        private List<DirektkostnadProduktDTO> DKPDTO;

        public bool IsLåst { get; private set; }

        public frmKostnadProdukt()
        {
            InitializeComponent();
            Load();
            CheckLås();
            HideFromUser();
            HideAfterLock();
        }

        public void Load()
        {
            produkts = businessManager.GetAllProdukter();
            foreach (var item in produkts)
            {
                cmbVäljProdukt.Items.Add(item.Namn);
            }
            kontos = businessManager.GetAllKonton();
            foreach (var item in kontos)
            {
                cmbVäljKonto.Items.Add(item.Benämning);
            }
            Update();
        }
        private void CheckLås()
        {
            if (Globals.CurrentPersonal.Behörighet.Equals("Driftavdelningschef") && businessManager.GetDriftLås())
            {
                IsLåst = true;
            }

            else if (Globals.CurrentPersonal.Behörighet.Equals("Utvecklingsavdelningsschef") && businessManager.GetUtvFörvLås())
            {
                IsLåst = true;
            }

            else if (Globals.CurrentPersonal.Behörighet.Equals("Administrativaavdelningschef") && businessManager.GetAffoLås())
            {
                IsLåst = true;
            }
            else { IsLåst = false; }
        }


        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            var prod = cmbVäljProdukt.SelectedItem.ToString();
            var konto = cmbVäljKonto.SelectedItem.ToString();
            var belopp = tbBelopp.Text;

            businessManager.AddDirektkostnadProdukt(prod, konto, belopp);
            Update();
        }

        public void Update()
        {
            DKPDTO = businessManager.GetAllDirektKostnadProdukt();
            dgvNedre.DataSource = DKPDTO;
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            var direktkostnad = (DirektkostnadProduktDTO)dgvNedre.CurrentRow.DataBoundItem;
            businessManager.RemoveDirektKostnadProdukt(direktkostnad);
            Update();
        }
        private void HideFromUser()
        {
            if (Globals.CurrentPersonal.Behörighet.Equals("Driftavdelningschef") || Globals.CurrentPersonal.Behörighet.Equals("Utvecklingsavdelningsschef") || Globals.CurrentPersonal.Behörighet.Equals("Administrativaavdelningschef"))
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
                if (Globals.CurrentPersonal.Behörighet.Equals("Driftavdelningschef"))
                {
                    businessManager.SetDriftLås(true);
                }
                else if (Globals.CurrentPersonal.Behörighet.Equals("Utvecklingsavdelningsschef"))
                {
                    businessManager.SetUtvFörvLås(true);
                }
                else if (Globals.CurrentPersonal.Behörighet.Equals("Administrativaavdelningschef"))
                {
                    businessManager.SetAffoLås(true);
                }
                IsLåst = true;
                HideAfterLock();
            }
        }
        private void HideAfterLock()
        {
            if (IsLåst)
            {
                label1.Hide();
                tbBelopp.Hide();
                btnLäggTill.Hide();
                btnLåsBudget.Hide();
                btnTaBort.Hide();
            }
        }
    }
}
