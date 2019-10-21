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
    public partial class frmSchablonkostnad : Form
    {
        BindingSource bindingSource = new BindingSource();
        BusinessManager businessManager = new BusinessManager();
        private List<SchablonDTO> schablons;

        public frmSchablonkostnad()
        {
            InitializeComponent();

            schablons = businessManager.GetAllSchablon();
            gvSchablonkostnad.DataSource = schablons;
        }

        private void btnRegistreraNyttKonto_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmRegistreraNyttKonto frmRegistreraNyttKonto = new frmRegistreraNyttKonto();
            frmRegistreraNyttKonto.Show();
        }

        private void tbKonto_TextChanged(object sender, EventArgs e)
        {
            if (tbKonto.TextLength == 0)
            {
                bindingSource.DataSource = businessManager.GetAllSchablon();
                gvSchablonkostnad.DataSource = bindingSource.DataSource;
            }
            else
            {
                bindingSource.DataSource = businessManager.GetSchablonById(tbKonto.Text);
                gvSchablonkostnad.DataSource = bindingSource.DataSource;
            }
        }

        private void tbKontobenämning_TextChanged(object sender, EventArgs e)
        {
            if (tbKontobenämning.TextLength == 0)
            {
                bindingSource.DataSource = businessManager.GetAllSchablon();
                gvSchablonkostnad.DataSource = bindingSource.DataSource;
            }
            else
            {
                bindingSource.DataSource = businessManager.GetSchablonByBenämning(tbKontobenämning.Text);
                gvSchablonkostnad.DataSource = bindingSource.DataSource;
            }
        }
    }
}
