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
    public partial class frmKostnadAktivitet : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<AktivitetDTO> aktivitets;
        private List<BudgetKontoDTO> kontos;
        private List<DirektkostnadAktivitetDTO> DKADTO;
        public bool IsLåst { get; private set; }

        public frmKostnadAktivitet()
        {
            InitializeComponent();
            CheckLås();
            Load();
            HideFromUser();
            HideAfterLock();
        }
        private void CheckLås()
        {
            if (Globals.CurrentPersonal.Behörighet.Equals("Driftavdelningschef") && businessManager.GetDriftLås())
            {
                IsLåst = true;
            }

            else { IsLåst = false; }

            if (Globals.CurrentPersonal.Behörighet.Equals("Utvecklingsavdelningsschef") && businessManager.GetUtvFörvLås())
            {
                IsLåst = true;
            }

            else { IsLåst = false; }


            if (Globals.CurrentPersonal.Behörighet.Equals("Administrativaavdelningschef") && businessManager.GetAffoLås())
            {
                IsLåst = true;
            }

            else { IsLåst = false; }
        }
        public void Load()
        {
            aktivitets = businessManager.GetAllAktiviteter();
            foreach (var item in aktivitets)
            {
                cmbVäljAktivitet.Items.Add(item.Namn);
            }
            kontos = businessManager.GetAllKonton();
            foreach (var item in kontos)
            {
                cmbVäljaKonto.Items.Add(item.Benämning);
            }
            DKADTO = businessManager.GetAllDirektKostnadAktivitet();
            dgvNedre.DataSource = DKADTO;
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            var akti = cmbVäljAktivitet.SelectedItem.ToString();
            var konto = cmbVäljaKonto.SelectedItem.ToString();
            var belopp = tbBelopp.Text;

            businessManager.AddDirektkostnadAktivitet(akti, konto, belopp);
            Update();
        }

        public void Update()
        {
            DKADTO = businessManager.GetAllDirektKostnadAktivitet();
            dgvNedre.DataSource = DKADTO;
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            var direktkostnad = (DirektkostnadAktivitetDTO)dgvNedre.CurrentRow.DataBoundItem;
            businessManager.RemoveDirektKostnadAktivitet(direktkostnad);
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
                HideAfterLock();
            }
        }

        private void HideAfterLock()
        {
            if(IsLåst)
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
