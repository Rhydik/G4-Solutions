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
using DataLayer.DTO;

namespace PresentationLayer1.Forms
{
    public partial class frmRedigeraAktivitet : Form
    {
        BusinessManager businessManager = new BusinessManager();
        AktivitetDTO aktivitet;

        public frmRedigeraAktivitet(AktivitetDTO aktivitetDTO)
        {
            InitializeComponent();
            aktivitet = aktivitetDTO;
            Load();
        }
        private void Load()
        {
            tbAktivitetsID.Text = aktivitet.AktivitetID;
            tbBenämning.Text = aktivitet.Namn;
        }

        private void btnTaBortAktivitet_Click(object sender, EventArgs e)
        {
            businessManager.RemoveAktivitet(aktivitet);

            this.Visible = !this.Visible;
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            var aktiId = tbAktivitetsID.Text;
            var aktinamn = tbBenämning.Text;
            var aktiAvdelning = cmbAvdelning.Text;
            businessManager.UpdateAktivitet(aktiId, aktinamn, aktiAvdelning);
            MessageBox.Show("Aktivitet uppdaterad!");
            this.Visible = !this.Visible;
        }
    }
}
