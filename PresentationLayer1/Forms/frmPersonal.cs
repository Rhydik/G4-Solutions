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
    public partial class frmPersonal : Form
    {
        BusinessManager businessManager = new BusinessManager();
        private List<Personal> personal;

        public frmPersonal()
        {
            InitializeComponent();
            personal = businessManager.GetAllPersonal();

            gvPersonal.DataSource = personal;
        }
    }
}
