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

namespace PresentationLayer1.Forms
{
    public partial class frmRedigeraPersonal : Form
    {
        BusinessManager businessManager = new BusinessManager();
        Personal personal = new Personal();
        public frmRedigeraPersonal(Personal personalen)
        {
            InitializeComponent();
            Load();
            personal = personalen;
        }

        public void Load()
        {
            tbNamn.Text = personal.Namn;
            tbPersNr.Text = personal.PersonNr;
            tbSysselsättningsgrad.Text = personal.Sysselsättningsgrad.ToString();
            tbVakansavdrag.Text = personal.Vakansavdrag.ToString();
        }

        public void btnTaBortPersonal_Click(object sender, EventArgs e)
        {
            businessManager.RemovePersonal(personal);
        }

        private void btnAvbrytPersonal_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            Forms.frmPersonal frmPersonal = new frmPersonal();
            frmPersonal.Show();
        }

        private void btnSparaPersonal_Click(object sender, EventArgs e)
        {
            personal.PersonNr = tbPersNr.Text;
            personal.Namn = tbNamn.Text;
            personal.Sysselsättningsgrad = int.Parse(tbSysselsättningsgrad.Text);
            personal.Vakansavdrag = int.Parse(tbVakansavdrag.Text);

            businessManager.UpdatePersonal(personal);
        }
    }
}
