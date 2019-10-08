using BusinessLayer;
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
        BindingSource bindingSource = new BindingSource();
        BusinessManager BusinessManager = new BusinessManager();

        public frmKunder()
        {
            InitializeComponent();
            //bindingSource.DataSource = BusinessManager.GetKunder();
            dataGridView1.DataSource = bindingSource.DataSource;
        }
    }
}
