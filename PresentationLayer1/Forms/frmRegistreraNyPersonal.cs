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
            var månadslön = 0;
            var vakansavdrag = 0;
            var sysselsättningsgrad = 0;

                var personNr = tbPersonnummer.Text;
                var namn = tbNamn.Text;
                månadslön = int.Parse(tbMånadslön.Text);
                sysselsättningsgrad = int.Parse(tbSysselsättningsgrad.Text);
                vakansavdrag = int.Parse(tbVakansavdrag.Text);
                var lösenord = tbLösenord.Text;
                var roll = cbRoll.SelectedItem.ToString();



                if (!String.IsNullOrEmpty(personNr) && !String.IsNullOrEmpty(lösenord) && !String.IsNullOrEmpty(namn) && !String.IsNullOrEmpty(månadslön.ToString()) )
                {

                    if (PlaceringOk == true)
                    {
                        businessManager.AddPersonal(sysselsättningsgrad, namn, personNr, vakansavdrag, lösenord, månadslön, roll);

                        foreach (var avdelning in avdelnings)
                        {
                            businessManager.SetPlacering(avdelning.Avdelning, personNr, avdelning.Fördelning);
                        }

                        MessageBox.Show("Ny Personal tillagd!", "Klart", MessageBoxButtons.OK);
                     if (DialogResult == DialogResult.OK)
                    {
                        this.Visible = !this.Visible;
                        frmPersonal frmPersonal = new frmPersonal();
                        frmPersonal.Show();
                    }





                }
                    else
                    {
                        MessageBox.Show("Placering överbelaggd");
                    }

                }
                else
                {
                    MessageBox.Show("Namn, Personnummer och lösenord får inte vara blankt.", "Fel",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }


        private void tbVakansavdrag_TextChanged(object sender, EventArgs e)
        {
            int syss = 0;
            int vaka = 0;
            int annars = 0;

            if (int.TryParse(tbSysselsättningsgrad.Text, out annars) && int.TryParse(tbVakansavdrag.Text, out annars))
            {
                syss = int.Parse(tbSysselsättningsgrad.Text);
                vaka = int.Parse(tbVakansavdrag.Text);

                årsarbete = syss - vaka;

                tbÅrsarbetare.Text = årsarbete.ToString();

            }

            if (årsarbete < 0)
            {
                MessageBox.Show("Årsarbetare kan ej vara minus.", "Fel",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvPlacering_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var placerat = 0;

            decimal räknaprocent;
            decimal räkna2;
            decimal färdigräknat;

            //för att kunna mata in 0-100% oavsett årsarbetare.

            räknaprocent = placerat / 100m;
            färdigräknat = räknaprocent * årsarbete;





            foreach (var item in avdelnings)
            {
                placerat += item.Fördelning;
            }
            if (101 > placerat && årsarbete >= 0)
            {
                lblÖverbelaggd.Visible = false;
                PlaceringOk = true;
            }
            else
            {
                lblÖverbelaggd.Visible = true;
                PlaceringOk = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbSysselsättningsgrad_TextChanged(object sender, EventArgs e)
        {


        }

        private void tbVakansavdrag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (tbVakansavdrag.Text.StartsWith("1"))
            {
                tbVakansavdrag.MaxLength = 3;
            }
            else
            {
                tbVakansavdrag.MaxLength = 2;
            }



        }

        private void tbLösenord_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbSysselsättningsgrad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (tbSysselsättningsgrad.Text.StartsWith("1"))
            {
                tbSysselsättningsgrad.MaxLength = 3;
            }
            else
            {
                tbSysselsättningsgrad.MaxLength = 2;
            }
        }

        private void tbMånadslön_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMånadslön_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbMånadslön.MaxLength = 7;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
