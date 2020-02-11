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

            HideFromUser();
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
                using (var frmRedigeraKonto = new frmRedigeraKonto((SchablonDTO)gvSchablonkostnad.CurrentRow.DataBoundItem))
                {
                    if (frmRedigeraKonto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        Update();
                }
                

            }
            else
            {
                MessageBox.Show("Du måste välja en Schablon");
            }

            
        }

        private void Update()
        {
            schablons = businessManager.GetAllSchablon();
            gvSchablonkostnad.DataSource = schablons.OrderBy(o => o.Konto).ToList();
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
                bindingSource.DataSource = businessManager.GetSchablonById(int.Parse(tbKonto.Text));
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
            MessageBox.Show("Avkastning är nu ", tbAvkastningskrav.Text);
            Update();
        }

        private void gvSchablonkostnad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void HideFromUser()
        {
            if (Globals.CurrentPersonal == null) return;

            if (Globals.CurrentPersonal.Behörighet.Equals("Systemansvarig"))
            {
                btnRegistreraNyttKonto.Show();
                btnRedigeraKonto.Show();
                btnLäggTillSchablon.Show();
            }
            else
            {
                btnRegistreraNyttKonto.Hide();
                btnRedigeraKonto.Hide();
                btnLäggTillSchablon.Hide();
                lblAvkastningskrav.Hide();
                tbAvkastningskrav.Hide();
                button1.Hide();
            }
            
        }

        private void btnRensa_Click_1(object sender, EventArgs e)
        {
            tbKonto.Clear();
            tbKontobenämning.Clear();
        }

        private void btnLäggTillSchablon_Click(object sender, EventArgs e)
        {
            frmRegistreraNySchablon frmRegistreraNySchablon = new frmRegistreraNySchablon((SchablonDTO)gvSchablonkostnad.CurrentRow.DataBoundItem);
            frmRegistreraNySchablon.Show();
        }

        public void RefreshData()
        {
            schablons = businessManager.GetAllSchablon();

            gvSchablonkostnad.DataSource = schablons;
        }
    }
}
