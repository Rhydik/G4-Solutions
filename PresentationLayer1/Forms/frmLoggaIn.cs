using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer1
{
    public partial class frmLoggaIn : Form
    {
        BusinessLayer.BusinessManager businessManager;

        public frmLoggaIn()
        {
            InitializeComponent();
            businessManager = new BusinessLayer.BusinessManager();
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            string användarnamn = txtAnvändarnamn.Text;
            string lösenord = txtLösenord.Text;
            if (businessManager.Login(användarnamn, lösenord) != null)
            {
                Globals.CurrentPersonal = businessManager.Login(användarnamn, lösenord);
                this.Visible = !this.Visible;
                frmHemmeny frmHemmeny = new frmHemmeny();
                frmHemmeny.Show();
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn eller lösenord, var god försök igen");
                txtLösenord.Clear();
            }
        }

        private void btnAvbrytLoggaIn_Click(object sender, EventArgs e)
        {
            txtAnvändarnamn.Clear();
            txtLösenord.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            frmHemmeny frmHemmeny = new frmHemmeny();
            frmHemmeny.Show();
        }
    }
}
