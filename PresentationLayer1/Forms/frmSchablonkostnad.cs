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
            gvSchablonkostnad.DataSource = schablons.OrderBy(o => o.KontoID).ToList(); ;
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            frmKunder frmKunder = new frmKunder();
            Hide();
            frmKunder.Show();
        }

        private void btnProdukter_Click(object sender, EventArgs e)
        {
            Forms.frmProdukter frmProdukter = new Forms.frmProdukter();
            Hide();
            frmProdukter.Show();
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            tbKonto.Text = "";
            tbKontobenämning.Text = "";

            schablons = businessManager.GetAllSchablon();

            gvSchablonkostnad.DataSource = schablons;
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            string Konto = null;
            string Benämning = tbKontobenämning.Text;

            if (tbKonto.Text.Length != 0)
            {
                Konto = tbKonto.Text;

            }

            if (tbKontobenämning.Text.Length != 0)
            {
                Benämning = tbKontobenämning.Text;

            }

            var data = businessManager.GetSchablonByBenämning(Benämning);

            gvSchablonkostnad.DataSource = data;
        }


        private void btnRegistreraNyttKonto_Click(object sender, EventArgs e)
        {
            using(var frmRegistreraNyttKonto = new frmRegistreraNyttKonto())
                {
                    if (frmRegistreraNyttKonto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        Update();
                }
        }

        private void btnRedigeraKonto_Click(object sender, EventArgs e)
        {

            if (gvSchablonkostnad.CurrentRow.DataBoundItem != null)
            {
                
                using(var frmRedigeraKonto = new frmRedigeraKonto((SchablonDTO)gvSchablonkostnad.CurrentRow.DataBoundItem))
                {
                    if (frmRedigeraKonto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        Update();
                }
                

            }
            else
            {
                MessageBox.Show("Du måste välja en kund");
            }

            
        }

        private void Update()
        {
            schablons = businessManager.GetAllSchablon();
            gvSchablonkostnad.DataSource = schablons.OrderBy(o => o.KontoID).ToList();
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

        private void button1_Click(object sender, EventArgs e)
        {
            businessManager.CreateAvkastning(int.Parse(tbAvkastningskrav.Text));
            Update();
        }
    }
}
