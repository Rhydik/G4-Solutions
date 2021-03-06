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
    public partial class frmPersonal : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<PersonalDTO> personal;

        public frmPersonal()
        {
            InitializeComponent();

            personal = businessManager.GetAllPersonal();
            gvPersonal.DataSource = personal;
            gvPersonal.Columns["PersonalID"].Visible = false;
            gvPersonal.Columns["Lösenord"].Visible = false;
            HideFromUser();
        }

        private void tbPersonnummer_TextChanged(object sender, EventArgs e)
        {
            if (tbPersonnummer.TextLength == 0)
            {
                personal = businessManager.GetAllPersonal();
                gvPersonal.DataSource = personal;
            }
            else
            {
                personal = businessManager.GetPersonalByPersNr(tbPersonnummer.Text);
                gvPersonal.DataSource = personal;
            }
        }

        private void tbPersonal_TextChanged(object sender, EventArgs e)
        {
            if (tbPersonal.TextLength == 0)
            {
                personal = businessManager.GetAllPersonal();
                gvPersonal.DataSource = personal;
            }
            else
            {
                personal = businessManager.GetPersonalByNamn(tbPersonal.Text);
                gvPersonal.DataSource = personal;
            }
        }

        private void btnRedigeraPersonal_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            Forms.frmRedigeraPersonal frmRedigeraPersonal = new Forms.frmRedigeraPersonal((PersonalDTO)gvPersonal.CurrentRow.DataBoundItem);
            frmRedigeraPersonal.Show();
        }

        private void btnRegistreraNyPersonal_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            Forms.frmRegistreraNyPersonal frmRegistreraNyPersonal = new Forms.frmRegistreraNyPersonal();
            frmRegistreraNyPersonal.Show();
        }

        private void gvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HideFromUser()
        {
            if (Globals.CurrentPersonal == null) return;

            if (Globals.CurrentPersonal.Behörighet.Equals("Systemansvarig"))
            {

                btnRedigeraPersonal.Show();
                btnRegistreraNyPersonal.Show();
            }
            else
            {
                btnRedigeraPersonal.Hide();
                btnRegistreraNyPersonal.Hide();
                this.gvPersonal.Columns["Månadslön"].Visible = false;
                this.gvPersonal.Columns["Vakansavdrag"].Visible = false;
                this.gvPersonal.Columns["Sysselsättningsgrad"].Visible = false;
                this.gvPersonal.Columns["Årsarbete"].Visible = false;
            }
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            tbPersonal.Clear();
            tbPersonnummer.Clear();
        }
    }
}
