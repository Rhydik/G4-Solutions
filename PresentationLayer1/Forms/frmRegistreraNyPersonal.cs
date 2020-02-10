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
using DataLayer.DTO;
using BusinessLayer;

namespace PresentationLayer1.Forms
{
    public partial class frmRegistreraNyPersonal : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<PlaceringsDTO> avdelnings;
        int årsarbete;
        public frmRegistreraNyPersonal()
        {
            InitializeComponent();
            avdelnings = businessManager.GetAllAvdelningarFördelning();
            dgvPlacering.DataSource = avdelnings;
            dgvPlacering.CellValueChanged += DgvPlacering_CellValueChanged;
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmPersonal frmPersonal = new frmPersonal();
            frmPersonal.Show();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            var personNr = tbPersonnummer.Text;
            var namn = tbNamn.Text;
            var månadslön = int.Parse(tbMånadslön.Text);
            var sysselsättningsgrad = int.Parse(tbSysselsättningsgrad.Text);
            var vakansavdrag = int.Parse(tbVakansavdrag.Text);
            var lösenord = tbLösenord.Text;
            var årsarbetare = tbÅrsarbetare.Text;
            MessageBox.Show("Personal sparad!");

            businessManager.AddPersonal(sysselsättningsgrad, namn, personNr, vakansavdrag, lösenord, månadslön, årsarbetare);
        }

        private void DgvPlacering_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Lägg i kod för att spara alla värden här.
            var drift = avdelnings.Where(x => x.Avdelning == "Driftavdelning").FirstOrDefault();
            var driftint = drift.Fördelning;

            var fom = avdelnings.Where(x => x.Avdelning == "Försäljnings - och marknadsavdelningen").FirstOrDefault();
            var fomint = fom.Fördelning;

            var adm = avdelnings.Where(x => x.Avdelning == "Administrativa avdelningen").FirstOrDefault();
            var admint = adm.Fördelning;

            var utvförv = avdelnings.Where(x => x.Avdelning == "Utv/Förv").FirstOrDefault();
            var utvförvint = utvförv.Fördelning;


        }

        private void tbVakansavdrag_TextChanged(object sender, EventArgs e)
        {
            årsarbete = int.Parse(tbSysselsättningsgrad.Text) - int.Parse(tbVakansavdrag.Text);
            tbÅrsarbetare.Text = årsarbete.ToString();
        }
    }
}
