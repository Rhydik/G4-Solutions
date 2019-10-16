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
    public partial class frmRegistreraNyPersonal : Form
    {
        BusinessManager businessManager = new BusinessManager();
        public frmRegistreraNyPersonal()
        {
            InitializeComponent();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmPersonal frmPersonal = new frmPersonal();
            frmPersonal.Show();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();

            personal.PersonNr = tbPersonnummer.Text;
            personal.Namn = tbNamn.Text;
            personal.Månadslön = int.Parse(tbMånadslön.Text);
            personal.Sysselsättningsgrad = int.Parse(tbSysselsättningsgrad.Text);
            personal.Vakansavdrag = int.Parse(tbVakansavdrag.Text);
            personal.Lösenord = tbLösenord.Text;

            businessManager.AddPersonal(personal);
        }
    }
}
