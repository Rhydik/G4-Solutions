using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using DataLayer.DTO;

namespace PresentationLayer1
{
    public partial class frmRegistreraNySchablon : Form
    {
        BusinessManager businessManager = new BusinessManager();
        SchablonDTO schablon;
        public frmRegistreraNySchablon(SchablonDTO schablonen)
        {
            InitializeComponent();
            schablon = schablonen;
            Load();
        }

        private void Load()
        {
            lblValtKonto.Text = schablon.Konto.ToString();
            tbSchablonkostnad.Text = schablon.Belopp.ToString();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSchablonkostnad"] != null)
            {
                (Application.OpenForms["frmSchablonkostnad"] as Forms.frmSchablonkostnad).RefreshData();
            }
            Close();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            var kostnad = tbSchablonkostnad.Text;
            businessManager.AddSchablon(kostnad, schablon);
            MessageBox.Show("Schablonkostnad tillagd!");
        }
    }
}
