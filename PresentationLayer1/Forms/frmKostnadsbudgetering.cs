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
    public partial class frmKostnadsbudgetering : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<KonstnadsbudgetPersonalDTO> personals;
        private List<KostnadsbudgetProduktDTO> produkts;
        public frmKostnadsbudgetering()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            personals = businessManager.GetKostnadsbudgetPersonal();
            businessManager.Kalkylering(personals);
            dgvÖvre.DataSource = personals;
            produkts = businessManager.GetKostnadsbudgetProdukt();
            dgvNedre.DataSource = produkts;
        }
    }
}
