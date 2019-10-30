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
    public partial class frmPrognostiseringIntäkter : Form
    {
        BindingSource bindingSource = new BindingSource();
        BusinessManager businessManager = new BusinessManager();
        private List<PrognosDTO> prognoser;
        public frmPrognostiseringIntäkter()
        {
            prognoser = businessManager.GetAllPrognoser();

            InitializeComponent();
            dgvPrognostiseringIntäkter.DataSource = prognoser.OrderBy(o => o.PrognosID).ToList(); ;
        }

        private void Update()
        {
            prognoser = businessManager.GetAllPrognoser();
            dgvPrognostiseringIntäkter.DataSource = prognoser.OrderBy(o => o.PrognosID).ToList();
        }

        private void lblKategori_Click(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSchablonkostnad_Click(object sender, EventArgs e)
        {

        }

        private void frmPrognostiseringIntäkter_Load(object sender, EventArgs e)
        {

        }

        private void dgvPrognostiseringIntäkter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
