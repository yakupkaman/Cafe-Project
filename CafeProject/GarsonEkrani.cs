using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeProject
{
    public partial class GarsonEkrani : Form
    {
        GarsonGuncellemeEkrani gr = new GarsonGuncellemeEkrani();
        DB db = new DB();
        public GarsonEkrani()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            gr.Show(); //Button'a tıkladığımız zaman garson güncelleme ekranına geçmesini sağlıyoruz

            this.Hide();
        }

        private void GarsonEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SP_Odemetur", db.baglan());
            bool odemeTuru=true;
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@odemeturu",SqlDbType.Bit).Value=odemeTuru;
            cm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            

            //SqlDataReader rd = db.DataGetir("select odemeturu from siparis ");
            //rd.Read();
            //String odemeturu = rd["odemeturu"].ToString();

            //if (odemeturu == "False")
            //{

            //    MessageBox.Show("kredi kartı");

            //}
            //else
            //{

            //    MessageBox.Show("nakit");
            //}

        db.DbKapat();

        }
    }
}
