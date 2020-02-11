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
    public partial class frmRegistreraNyttKonto : Form
    {
        BusinessLayer.BusinessManager businessManager;

        private List<SchablonDTO> schablons;


        public frmRegistreraNyttKonto()
        {
            InitializeComponent(); 
            businessManager = new BusinessLayer.BusinessManager();
            schablons = businessManager.GetAllSchablon();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKonto.Text))
            {
                MessageBox.Show("Ange ett konto nummer");
            }
            if (string.IsNullOrEmpty(tbKontobenämning.Text))
            {
                MessageBox.Show("Ange en benämning");
            }

            else
            {
                try
                {
                    var result = schablons.SingleOrDefault(o => o.Konto == int.Parse(tbKonto.Text));

                    if (result != null)
                    {
                        MessageBox.Show("Det kontoID existerar redan");
                    }
                    else
                    {

                        var konto = int.Parse(tbKonto.Text);
                        var benämning = tbKontobenämning.Text;


                        businessManager.CreateKonto(konto, benämning);


                        DialogResult resultat = MessageBox.Show(tbKontobenämning.Text + " Skapat.", "Skapat", MessageBoxButtons.OK);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Visible = !this.Visible;


                    }
                }

                catch
                {
                    MessageBox.Show("Kontrollera uppgfiter");
                }

            }

        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Visible = !this.Visible;
        }
    }
}
