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

namespace PresentationLayer1.Forms
{
    public partial class frmRegistreraNyAktivitet : Form
    {
        BusinessManager businessManager = new BusinessManager();

        public frmRegistreraNyAktivitet()
        {
            InitializeComponent();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            var namn = tbBenämning.Text;
            var avdelning = cmbAvdelning.Text;
            var aktivitetID = businessManager.SkapaID(namn, avdelning);
          
            if (businessManager.CheckAvdelning(cmbAvdelning.Text) == true)
            {
                businessManager.AddAktivitet(aktivitetID, namn, avdelning);
            }
            else
            {
                businessManager.CreateAvdelning(avdelning);
                businessManager.AddAktivitet(aktivitetID, namn, avdelning);
            }

            this.Visible = !this.Visible;
        }

        private void btnSparaAvdelning_Click(object sender, EventArgs e)
        {
            var avdelning = cmbAvdelning.Text;

            businessManager.AddAvdelning(avdelning);
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }
    }
}
