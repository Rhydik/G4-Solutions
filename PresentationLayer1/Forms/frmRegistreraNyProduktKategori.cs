﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer1.Forms
{
    public partial class frmRegistreraNyProduktKategori : Form
    {
        BusinessLayer.BusinessManager businessManager;
        public frmRegistreraNyProduktKategori()
        {
            businessManager = new BusinessLayer.BusinessManager();
            InitializeComponent();
        }

        private void tbNyProduktKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSparaNyProduktKategori_Click(object sender, EventArgs e)
        {
            string ProduktKategoriNamn = tbNyProduktKategori.Text;
            businessManager.AddProduktKategori(ProduktKategoriNamn);
            if (System.Windows.Forms.Application.OpenForms["frmRegistreraNyProdukt"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmRegistreraNyProdukt"] as frmRegistreraNyProdukt).RefreshProduktKategori();
            }
            MessageBox.Show(ProduktKategoriNamn + " sparad!", "Sparad", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
