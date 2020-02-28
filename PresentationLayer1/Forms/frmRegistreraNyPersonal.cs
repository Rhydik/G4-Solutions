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
        private List<RollDTO> rolls;
        private bool PlaceringOk = true;
        int årsarbete;
        public frmRegistreraNyPersonal()
        {
            InitializeComponent();
            lblÖverbelaggd.Visible = false;
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
            var roll = cbRoll.SelectedItem.ToString();
            var årsarbetare = decimal.Parse(tbÅrsarbetare.Text);
            

            if (PlaceringOk == true)
            {
                businessManager.AddPersonal(sysselsättningsgrad, namn, personNr, vakansavdrag, lösenord, månadslön, årsarbetare, roll);

                foreach (var avdelning in avdelnings)
                {
                    businessManager.SetPlacering(avdelning.Avdelning, personNr, avdelning.Fördelning);
                }
                MessageBox.Show("Personal sparad!");
            }
            else
            {
                MessageBox.Show("Placering överbelaggd");
            }
        }

        private void DgvPlacering_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var placerat = 0;
            foreach (var item in avdelnings)
            {
                placerat += item.Fördelning;
            }
            if (placerat > int.Parse(tbÅrsarbetare.Text))
            {
                lblÖverbelaggd.Visible = true;
                PlaceringOk = false;
            }
            else
            {
                lblÖverbelaggd.Visible = false;
                PlaceringOk = true;
            }
        }

        private void tbVakansavdrag_TextChanged(object sender, EventArgs e)
        {
            årsarbete = int.Parse(tbSysselsättningsgrad.Text) - int.Parse(tbVakansavdrag.Text);
            tbÅrsarbetare.Text = årsarbete.ToString();
        }
    }
}
