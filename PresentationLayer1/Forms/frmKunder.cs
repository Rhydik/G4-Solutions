using BusinessLayer;
using DataLayer.DTO;
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
    public partial class frmKunder : Form
    {
        BusinessManager businessManager;
        private List<KundDTO> kunder; 


        public frmKunder()
        {
            InitializeComponent();
            businessManager = new BusinessManager();

            kunder = businessManager.GetAllKunder();

            dataGridView.DataSource = kunder; 
            //dataGridView.CellBeginEdit += dgv_CellBeginEdit;
            //dataGridView.CellValidating += dgv_CellValidating;
            //dataGridView.CellEndEdit += dgv_CellEndEdit;
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            frmKunder frmKunder = new frmKunder();
            Hide();
            frmKunder.Show();
        }

        private void btnProdukter_Click(object sender, EventArgs e)
        {
            Forms.frmProdukter frmProdukter = new Forms.frmProdukter();
            Hide();
            frmProdukter.Show();
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            kunder = businessManager.GetAllKunder();

            dataGridView.DataSource = kunder;
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            int? id = null; 
            string kund = txtKund.Text;
            string kundKategori = comboBox1.Text;

            if (txtKundID.Text.Length != 0)
            {
                id = Int32.Parse(txtKundID.Text); 
            }

            if (comboBox1.Text == "Välj kundkategori")
            {
                kundKategori = "";
            }

            var data = businessManager.GetKunderBySearch(id, kund, kundKategori);

            dataGridView.DataSource = data;
        }

        private void btnRegistreraNyKund_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            Forms.frmRegistreraNyKund frmRegistreraNyKund = new Forms.frmRegistreraNyKund();
            frmRegistreraNyKund.Show();
        }
        //private void dgv_CellBeginEdit(Object sender, DataGridViewCellCancelEventArgs e)
        //{
        //    //Here we save a current value of cell to some variable, that later we can compare with a new value
        //    //For example using of dgv.Tag property
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        this.dataGridView.Tag = this.dataGridView.CurrentCell.Value;
        //        //Or cast sender to DataGridView variable-> than this handler can be used in another datagridview
        //    }
        //}
        //
        //private void dgv_CellValidating(Object sender, DataGridViewCellValidatingEventArgs e)
        //{
        //    //Here you can add all kind of checks for new value
        //    //For exapmle simple compare with old value and check for be more than 0
        //    if (dataGridView.Tag == dataGridView.CurrentCell.Value)
        //        e.Cancel = true;    //Cancel changes of current cell
        //                            //For example used Integer check
        //
        //    ;
        //    int iTemp;
        //    //if (dataGridView.CurrentCell.Value.GetType() == iTemp == > 0)
        //    //{
        //    //    //value is ok
        //    //}
        //    else
        //    {
        //        e.Cancel = true;
        //    }
        //}
        //
        //private void dgv_CellEndEdit(Object sender, DataGridViewCellEventArgs e)
        //{
        //    //Because CellEndEdit event occurs after CellValidating event(if not cancelled)
        //    //Here you can update new value to database
        //}
    }
}
