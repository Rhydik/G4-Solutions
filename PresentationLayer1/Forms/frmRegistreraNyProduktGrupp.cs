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
    public partial class frmRegistreraNyProduktGrupp : Form
    {
        BusinessLayer.BusinessManager businessManager;
        public frmRegistreraNyProduktGrupp()
        {
            businessManager = new BusinessLayer.BusinessManager();
            InitializeComponent();

        }

        private void tbNyProduktGrupp_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSparaNyProduktGrupp_Click(object sender, EventArgs e)
        {
            string ProduktGruppNamn = tbNyProduktGrupp.Text;
            businessManager.AddProduktGrupp(ProduktGruppNamn);
            if (System.Windows.Forms.Application.OpenForms["frmRegistreraNyProdukt"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmRegistreraNyProdukt"] as frmRegistreraNyProdukt).RefreshProduktGrupp();
            }
            MessageBox.Show(ProduktGruppNamn + " sparad!", "Sparad", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
