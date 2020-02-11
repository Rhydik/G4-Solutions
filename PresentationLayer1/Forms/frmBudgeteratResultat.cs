﻿using System;
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
    public partial class frmBudgeteratResultat : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<ProduktDTO> produkter;
        private List<ProduktgruppDTO> produktgrupp;
        private List<AvdelningDTO> produktAvdelning;
        private List<KontorDTO> kontor;
        public frmBudgeteratResultat()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            cmbKategori.SelectedItem = "Produkt";
            produkter = businessManager.GetAllProdukter();
            dgvBudgeteratResultat.DataSource = produkter;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.Text == "Produkt")
            {
                produkter = businessManager.GetAllProdukter();
                dgvBudgeteratResultat.DataSource = produkter;
                Show();
            }
            if (cmbKategori.Text == "Produktgrupp")
            {
                produktgrupp = businessManager.GetProduktByGrupp();
                dgvBudgeteratResultat.DataSource = produktgrupp;
                Hide();
            }
            if (cmbKategori.Text == "Produktionsavdelning")
            {
                produktAvdelning = businessManager.GetProduktByAvdelning();
                dgvBudgeteratResultat.DataSource = produktAvdelning;
                Hide();
            }
            if (cmbKategori.Text == "Kontoret")
            {
                kontor = businessManager.GetKontor();
                dgvBudgeteratResultat.DataSource = kontor;
                dgvBudgeteratResultat.ClearSelection();
                decimal avdelningIntäkter = businessManager.GetKontorIntäkter();
                lblBudgeteradeIntäkter.Text = avdelningIntäkter.ToString();
                var resultat = int.Parse(lblBudgeteradeIntäkter.Text) - int.Parse(lblBudgetKostnader.Text);
                lblResultat.Text = resultat.ToString();
                Hide();
            }
        }

        private async void dgvBudgeteratResultat_SelectionChanged(object sender, EventArgs e)
        {
            if (cmbKategori.Text == "Produkt")
            {
                CalculateProdukt();
            }
            if (cmbKategori.Text == "Produktgrupp")
            {
                CalculateProduktGrupp();
            }
            if (cmbKategori.Text == "Produktionsavdelning")
            {
                CalculateProduktKategori();
            }
            if (cmbKategori.Text == "Kontoret")
            {
                CalculateKontor();
            }
        }
        public void CalculateProdukt()
        {
            dgvBudgeteratResultat.ClearSelection();
            ProduktDTO produkt = new ProduktDTO();
            produkt = (ProduktDTO)dgvBudgeteratResultat.CurrentRow.DataBoundItem;
            decimal prodintäkter = businessManager.GetProduktIntäkter(produkt);
            decimal prodKostnader = businessManager.GetProduktKostnader(produkt.ProduktID);
            lblBudgeteradeIntäkter.Text = prodintäkter.ToString("0.00");
            lblBudgetKostnader.Text = prodKostnader.ToString("0.00");
            var resultat = decimal.Parse(lblBudgeteradeIntäkter.Text) - decimal.Parse(lblBudgetKostnader.Text);
            lblResultat.Text = resultat.ToString("0.00");
        }
        public void CalculateProduktGrupp()
        {
            decimal Gruppkostnader = 0;
            dgvBudgeteratResultat.ClearSelection();
            ProduktgruppDTO produktgruppDTO = new ProduktgruppDTO();
            produktgruppDTO = (ProduktgruppDTO)dgvBudgeteratResultat.CurrentRow.DataBoundItem;
            var produkter = businessManager.GetProduktByProduktGrupp(produktgruppDTO);
            decimal gruppintäkter = businessManager.GetGruppIntäkter(produktgruppDTO);
            foreach (var item in produkter)
            {
                Gruppkostnader += businessManager.GetProduktKostnader(item.ProduktID);
            }
            lblBudgeteradeIntäkter.Text = gruppintäkter.ToString();
            var resultat = decimal.Parse(lblBudgeteradeIntäkter.Text) - decimal.Parse(lblBudgetKostnader.Text);
            lblResultat.Text = resultat.ToString();
        }
        public void CalculateProduktKategori()
        {
            dgvBudgeteratResultat.ClearSelection();
            AvdelningDTO avdelningDTO = new AvdelningDTO();
            avdelningDTO = (AvdelningDTO)dgvBudgeteratResultat.CurrentRow.DataBoundItem;
            decimal avdelningIntäkter = businessManager.GetAvdelningIntäkter(avdelningDTO);
            lblBudgeteradeIntäkter.Text = avdelningIntäkter.ToString();
            var resultat = int.Parse(lblBudgeteradeIntäkter.Text) - int.Parse(lblBudgetKostnader.Text);
            lblResultat.Text = resultat.ToString();
        }
        public void CalculateKontor()
        {
            dgvBudgeteratResultat.ClearSelection();
            decimal avdelningIntäkter = businessManager.GetKontorIntäkter();
            lblBudgeteradeIntäkter.Text = avdelningIntäkter.ToString();
            var resultat = int.Parse(lblBudgeteradeIntäkter.Text) - int.Parse(lblBudgetKostnader.Text);
            lblResultat.Text = resultat.ToString();
        }
        private void tbSök_TextChanged(object sender, EventArgs e)
        {
                if (tbSök.TextLength == 0)
                {
                    produkter = businessManager.GetAllProdukter();
                    dgvBudgeteratResultat.DataSource = produkter;
                }
                else
                {
                    produkter = businessManager.GetProduktByNamn(tbSök.Text);
                    dgvBudgeteratResultat.DataSource = produkter;
                }
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            tbSök.Clear();
        }

        private void Hide()
        {
            lblSök.Hide();
            tbSök.Hide();
            btnRensa.Hide();
        }

        private void Show()
        {
            lblSök.Show();
            tbSök.Show();
            btnRensa.Show();
        }
    }
}
