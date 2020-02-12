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
        private List<AktivitetDTO> aktivitets;
        private List<KonstnadsbudgetPersonalDTO> personals;
        private List<AvdelningDTO> avdelnings;
        public frmKostnadsbudgeteringAktivitet()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            aktivitets = businessManager.GetAllAktiviteter();
            foreach (var item in aktivitets)
            {
                cbAktivitet.Items.Add(item.Namn);
            }
            personals = businessManager.GetKostnadsbudgetPersonal();
            businessManager.Kalkylering(personals); //Updatera logiken i kalkylering() så det funkar som det ska
            dgvÖvre.DataSource = personals;
            dgvNedre.DataSource = businessManager.GetAllPersonalAktivitet();
            avdelnings = businessManager.GetAllAvdelningar();
            foreach (var item in avdelnings)
            {
                cmbAvdelning.Items.Add(item.Namn);
            }
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

        public void Update()
        {
            // Behövs göras!
            dgvNedre.DataSource = businessManager.GetAllPersonalAktivitet();
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            PersonalAktivitetDTO perspro = (PersonalAktivitetDTO)dgvNedre.CurrentRow.DataBoundItem;
            var pers = perspro.Personal;
            var andel = perspro.Placeringsandel;
            var aktivitet = perspro.Aktivitet;

            businessManager.RemovePlaceringAktivitet(pers, aktivitet, andel);
            Update();
        }
    }
}
