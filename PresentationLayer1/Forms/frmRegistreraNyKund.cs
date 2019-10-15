using System;
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
    public partial class frmRegistreraNyKund : Form
    {
        BusinessLayer.BusinessManager businessManager;
        public frmRegistreraNyKund()
        {
            InitializeComponent();
            businessManager = new BusinessLayer.BusinessManager();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmKunder frmKunder = new frmKunder();
            frmKunder.Show();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            var kundId = tbKundID.Text;
            var kundNamn = tbKundNamn.Text;
            var kundKategori = cmbKundkategori.Text;

            businessManager.AddKund(kundId, kundNamn, kundKategori);
        }

        private void btnSkapaNyKundkategori_Click(object sender, EventArgs e)
        {
            // Fråga på kundmöte om vi ska ha med det här
        }

     
    }
}
