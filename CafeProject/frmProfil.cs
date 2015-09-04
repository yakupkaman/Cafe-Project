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
using System.Collections;


namespace CafeProject
{
    public partial class frmProfil : Form
    {
        DbProcess db = new DbProcess("CafeProject");

        public frmProfil()
        {
            InitializeComponent();
        }

        public void profilInsert(string adi, string soyadi, string telefon, string mail, string adres, string tcno, string notlar)
        {

            SqlCommand com = new SqlCommand("profilInsert", db.dbConnect());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@adi", SqlDbType.VarChar, 255).Value = adi;
            com.Parameters.Add("@soyadi", SqlDbType.VarChar, 255).Value = soyadi;
            com.Parameters.Add("@telefon", SqlDbType.VarChar, 255).Value = telefon;
            com.Parameters.Add("@mail", SqlDbType.VarChar, 255).Value = mail;
            com.Parameters.Add("@adres", SqlDbType.VarChar, 500).Value = adres;
            com.Parameters.Add("tcno", SqlDbType.VarChar, 11).Value = tcno;
            com.Parameters.Add("notlar", SqlDbType.VarChar, 500).Value = notlar;
            db.dbConnect();
            com.ExecuteNonQuery();
            db.dbClose();
            MessageBox.Show("Profil Kaydı Yapıldı");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            profilInsert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox6.Text);
        }


        ArrayList li = new ArrayList();
        public void idTut()
        {
            SqlCommand com = new SqlCommand("select * from profil", db.dbConnect());
            db.dbConnect();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                li.Add(Convert.ToInt32(dr["id"]));
                comboBox1.Items.Add(dr["adi"].ToString());
            }
            db.dbClose();
        }
        int id;
        private void button3_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(li[comboBox1.SelectedIndex]);
            frmProfilGuncelleme profilGuncelleme = new frmProfilGuncelleme(id);
            profilGuncelleme.Show();
            this.Hide();
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            idTut();
        }

    }
}
