using DataLayer.DTO;
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
    public partial class frmRedigeraKund : Form
    {
        BusinessLayer.BusinessManager businessManager;
        private KundDTO kund;

        public frmRedigeraKund(KundDTO kund)
        {
            InitializeComponent();
            businessManager = new BusinessLayer.BusinessManager();
            this.kund = kund;
            Load();
        }

        public new void Load()
        {
            tbKundID2.Text = kund.KundID;
            tbKund2.Text = kund.Namn;

            var kategori = businessManager.GetAllKundKategori();
            cmbKundkategori.DataSource = kategori;
            cmbKundkategori.ValueMember = "Namn";
            cmbKundkategori.DisplayMember = "Namn";
            cmbKundkategori.SelectedIndex = cmbKundkategori.FindStringExact(kund.KundKategori);
        }

        public void btnTaBortKund_Click(object sender, EventArgs e)
        {

            DialogResult resultat = MessageBox.Show("Vill du ta bort " + kund.Namn + "?", "Borttagning av kund", MessageBoxButtons.YesNo);

            if (resultat == DialogResult.Yes)
            {
                businessManager.RemoveKund(kund.KundID);

                if (Application.OpenForms["frmKunder"] != null)
                {
                    (Application.OpenForms["frmKunder"] as frmKunder).RefreshData();
                }

                DialogResult tabortResultat = MessageBox.Show(kund.Namn + " borttagen", "Borttagning lyckad", MessageBoxButtons.OK);

                this.Visible = !this.Visible;
            }

        }

        private void btnAvbrytKund2_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            var kundId = tbKundID2.Text;
            var kundNamn = tbKund2.Text;
            var kundKategori = cmbKundkategori.Text;

            businessManager.UpdateKund(kund, kundId, kundNamn, kundKategori);

            if (Application.OpenForms["frmKunder"] != null)
            {
                (Application.OpenForms["frmKunder"] as frmKunder).RefreshData();
            }

            DialogResult resultat = MessageBox.Show(kund.Namn + " uppdaterad.", "Uppdatera kund", MessageBoxButtons.OK);

            this.Visible = !this.Visible;
        }

    }
}
