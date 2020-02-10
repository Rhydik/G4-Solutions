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
    public partial class frmKostnadsbudgeteringAktivitet : Form
    {
        BusinessManager businessManager = new BusinessManager();
        public frmKostnadsbudgeteringAktivitet()
        {
            InitializeComponent();
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            KonstnadsbudgetPersonalDTO personal = (KonstnadsbudgetPersonalDTO)dgvÖvre.CurrentRow.DataBoundItem;
            var pers = personal.PersonalID;
            var aktivitet = cbAktivitet.SelectedItem.ToString();
            var andel = tbAndel.Text;

            businessManager.LäggTillPlaceringAktivitet(pers, aktivitet, andel);
            Update();
        }
    }
}
