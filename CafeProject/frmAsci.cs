using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;

namespace CafeProject
{
    public partial class frmAsci : Form
    {
        DbProcess db = new DbProcess();

        public frmAsci()
        {
            InitializeComponent();
        }

        private void frmAsci_Load(object sender, EventArgs e)
        {
            
            SqlCommand cm = new SqlCommand("asd",db.dbConnect());
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
         
            
        }

        }


          
    }

