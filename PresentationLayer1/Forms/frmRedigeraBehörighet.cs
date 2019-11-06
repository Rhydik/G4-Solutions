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
    public partial class frmRedigeraBehörighet : Form
    {
        BusinessManager businessManager = new BusinessManager();
        BindingSource bindingSource = new BindingSource();
        BehörighetDTO behörighet = new BehörighetDTO();
        private List<VisaBehörighetDTO> visaBehörighet;
        public frmRedigeraBehörighet(BehörighetDTO behörighetDTO)
        {
            InitializeComponent();
            behörighet = behörighetDTO;
            visaBehörighet = businessManager.GetBehörighet(behörighetDTO.Personnummer);
            dgvBehörighet.DataSource = visaBehörighet;
            Load();
        }

        private void Load()
        {
            lblNamn.Text = behörighet.Namn;
            lblPnr.Text = behörighet.Personnummer;
            dgvBehörighet.DataSource = visaBehörighet;
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTillsätt_Click(object sender, EventArgs e)
        {
            var tempBehör = cmbBehörighet.Text;
            var tempPersnr = behörighet.Personnummer;
            businessManager.AddBehörighet(tempBehör, tempPersnr);
            visaBehörighet = businessManager.GetBehörighet(behörighet.Personnummer);
            dgvBehörighet.DataSource = visaBehörighet;
            dgvBehörighet.Update();
        }

        private void btnTaBortBehörighet_Click(object sender, EventArgs e)
        {
            var tempBehör = cmbBehörighet.Text;
            var tempPersnr = behörighet.Personnummer;
            businessManager.RemoveBehörighet(tempBehör, tempPersnr);
            visaBehörighet = businessManager.GetBehörighet(behörighet.Personnummer);
            dgvBehörighet.DataSource = visaBehörighet;
            dgvBehörighet.Update();
        }

    }
}
