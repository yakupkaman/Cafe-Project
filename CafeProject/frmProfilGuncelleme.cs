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


namespace CafeProject
{
    public partial class frmProfilGuncelleme : Form
    {
        DbProcess db = new DbProcess("CafeProject");
        public frmProfilGuncelleme()
        {
            InitializeComponent();
        }
        int id = 0;
        public frmProfilGuncelleme(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public void idSelect()
        {
            SqlCommand com = new SqlCommand("select *from profil where id=@id", db.dbConnect());
            db.dbConnect();
            com.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd["adi"].ToString();
                textBox2.Text = rd["soyadi"].ToString();
                textBox3.Text = rd["telefon"].ToString();
                textBox4.Text = rd["mail"].ToString();
                textBox5.Text = rd["adres"].ToString();
                textBox6.Text = rd["tcno"].ToString();
                textBox7.Text = rd["notlar"].ToString();
            }
            db.dbClose();
        }

        private void frmProfilGuncelleme_Load(object sender, EventArgs e)
        {
            frmProfil profil = new frmProfil();
            idSelect();
        }

        public void profilUpdate(string adi, string soyadi, string telefon, string mail, string adres, string tcno, string notlar)
        {
            SqlCommand com1 = new SqlCommand("profilUpdate", db.dbConnect());
            com1.CommandType = CommandType.StoredProcedure;
            com1.Parameters.Add("@id", SqlDbType.Int).Value = id;
            com1.Parameters.Add("@adi", SqlDbType.VarChar, 255).Value = adi;
            com1.Parameters.Add("@soyadi", SqlDbType.VarChar, 255).Value = soyadi;
            com1.Parameters.Add("@telefon", SqlDbType.VarChar, 255).Value = telefon;
            com1.Parameters.Add("@mail", SqlDbType.VarChar, 255).Value = mail;
            com1.Parameters.Add("@adres", SqlDbType.VarChar, 500).Value = adres;
            com1.Parameters.Add("@tcno", SqlDbType.VarChar, 11).Value = tcno;
            com1.Parameters.Add("@notlar", SqlDbType.VarChar, 500).Value = notlar;
            db.dbConnect();
            com1.ExecuteNonQuery();
            db.dbClose();
            MessageBox.Show("Profil Bilgileri Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profilUpdate(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox6.Text);
        }

    }
}
