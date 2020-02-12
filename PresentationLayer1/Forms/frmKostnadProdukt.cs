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
        public frmKostnadProdukt()
        {
            InitializeComponent();
            Load();
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
    }
}
