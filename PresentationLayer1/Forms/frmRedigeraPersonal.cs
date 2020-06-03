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
    public partial class frmRedigeraPersonal : Form
    {
        BusinessManager businessManager = new BusinessManager();
        PersonalDTO personal = new PersonalDTO();
        List<PlaceringsDTO> personalPlacering = new List<PlaceringsDTO>();
        public frmRedigeraPersonal(PersonalDTO personalen)
        {
            InitializeComponent();
            personal = personalen;
            Load();
        }

        private void Load()
        {
            tbNamn.Text = personal.Namn;
            tbPersNr.Text = personal.PersonNr;
            tbLösenord.Text = personal.Lösenord;
            tbÅrsarbete.Text = personal.Årsarbete.ToString();
            tbSysselsättningsgrad.Text = personal.Sysselsättningsgrad.ToString();
            tbVakansavdrag.Text = personal.Vakansavdrag.ToString();
            tbMånadslön.Text = personal.Månadslön.ToString();
            personalPlacering = businessManager.getPersonalFördelning(personal);
            dgvAvdelning.DataSource = personalPlacering;
        }

        public void btnTaBortPersonal_Click(object sender, EventArgs e)
        {
            businessManager.RemovePersonal(personal);
            MessageBox.Show("Personal borttagen");
        }

        private void btnAvbrytPersonal_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            Forms.frmPersonal frmPersonal = new frmPersonal();
            frmPersonal.Show();
        }

        private void btnSparaPersonal_Click(object sender, EventArgs e)
        {
            personal.PersonNr = tbPersNr.Text;
            personal.Namn = tbNamn.Text;
            personal.Sysselsättningsgrad = int.Parse(tbSysselsättningsgrad.Text);
            personal.Månadslön = int.Parse(tbMånadslön.Text);
            personal.Vakansavdrag = int.Parse(tbVakansavdrag.Text);

            double s = int.Parse(tbSysselsättningsgrad.Text);
            double v = int.Parse(tbVakansavdrag.Text);

            Console.WriteLine("s: " + s);
            Console.WriteLine("v: " + v);

            personal.Årsarbete = s - v;
            Console.WriteLine("års " + personal.Årsarbete);

            MessageBox.Show("Personal uppdaterad!");
            businessManager.UpdatePersonal(personal);
        }
    }
}
