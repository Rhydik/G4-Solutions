using DataLayer;
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
    public partial class frmRedigeraKonto : Form
    {
        BusinessLayer.BusinessManager businessManager;
        private SchablonDTO schablon;

        public frmRedigeraKonto(SchablonDTO schablon)
        {
            InitializeComponent();
            businessManager = new BusinessLayer.BusinessManager();
            this.schablon = schablon;
            Load();
        }

        public new void Load()
        {
            tbKonto.Text = schablon.Konto;
            tbKontobenämning.Text = schablon.Kontobenämning;
        }

        private void btnTaBortAktivitet_Click_1(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Vill du ta bort " + schablon.Kontobenämning + "?", "Borttagning av kund", MessageBoxButtons.YesNo);

            if (resultat == DialogResult.Yes)
            {
                businessManager.RemoveKonto(schablon);

                DialogResult tabortResultat = MessageBox.Show(schablon.Kontobenämning + " borttagen", "Borttagning lyckad", MessageBoxButtons.OK);

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Visible = !this.Visible;
            }
        }

        private void btnSpara_Click_1(object sender, EventArgs e)
        {
            var konto = tbKonto.Text;
            var benämning = tbKontobenämning.Text;

            businessManager.UpdateKonto(schablon, konto, benämning );


            DialogResult resultat = MessageBox.Show(schablon.Kontobenämning + " uppdaterad.", "Uppdatera Konto", MessageBoxButtons.OK);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Visible = !this.Visible;
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Visible = !this.Visible;

        }
    }
}
