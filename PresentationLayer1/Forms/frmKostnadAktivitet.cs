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
        public frmKostnadAktivitet()
        {
            InitializeComponent();
            Load();
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
    }
}
