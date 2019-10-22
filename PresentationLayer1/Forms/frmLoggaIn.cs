using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer1
{
    public partial class frmLoggaIn : Form
    {

        BusinessManager businessManager;

        public frmLoggaIn()
        {
            Thread t = new Thread(new ThreadStart(Load)) { IsBackground = true };
            t.Start();

            InitializeComponent();
        }

        public void Load()
        {
            businessManager = new BusinessManager();
            var aktiviter = businessManager.GetAllKunder();
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

        private void frmLoggaIn_Load(object sender, EventArgs e)
        {

        }
    }
}
