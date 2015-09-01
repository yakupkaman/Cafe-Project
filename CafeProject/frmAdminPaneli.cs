using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeProject
{
    public partial class frmAdminPaneli : Form
    {
        public frmAdminPaneli()
        {
            InitializeComponent();
        }
        int idAdmin = -1;
        public frmAdminPaneli(int id)
        {
            idAdmin = id;
        }
        private void frmAdminPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
