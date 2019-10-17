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
            var aktvitetsId = tbAktivitetsID.Text;
            var namn = tbBenämning.Text;
            var avdelning = cmbAvdelning.Text;

            businessManager.AddAktivitet(aktvitetsId, namn, avdelning);
        }
    }
}
