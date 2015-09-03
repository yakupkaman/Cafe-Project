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
    public partial class frmAyarlar : Form
    {
        DbProcess db = new DbProcess("CafeProject");
        SqlDataReader dr = null;
        public void kullaniciGetir()
        {
            db.dbConnect();
            SqlDataReader reader = db.getData("select * from kullanicilar");
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["kulAdi"].ToString());

            }
            db.dbClose();
        }
        public void sifreDegistir()
        {
            SqlCommand com = new SqlCommand("sifreDegistirme", db.dbConnect());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@sifre", SqlDbType.Int).Value = textBox1.Text.ToString();
            com.Parameters.Add("@kulAdi", SqlDbType.VarChar, 50).Value = comboBox1.Text.ToString();

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Şifresini Değiştirmek İstediğiniz Kullanıcı Adını Seçiniz !!!");
            }
            else
            {
                db.dbConnect();
                dr = com.ExecuteReader();

                MessageBox.Show("Şifre Değiştirme İşlemi Başarılı !!!");

            }
        }
        private void logoGetir()
        {
            db.dbConnect();
            SqlDataReader reader = db.getData("select logo from sirket");
            while (reader.Read())
            {

                pictureBox1.ImageLocation = reader["logo"].ToString();

            }
            db.dbClose();
        }
        private void logoDegistir()
        {
            db.dbConnect();
            SqlDataReader reader = db.getData("update sirket set logo='" + textBox3.Text.ToString() + "'");

            db.dbClose();
        }
        private void sirketBilgileriGetir()
        {
            db.dbConnect();
            SqlCommand com = new SqlCommand("select * from sirket", db.dbConnect());

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = dr["sirketAdi"].ToString();
                label7.Text = dr["telefon"].ToString();
                label8.Text = dr["fax"].ToString();
                label10.Text = dr["aciklama"].ToString();
            }
            db.dbClose();
        }
        public frmAyarlar()
        {
            InitializeComponent();
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            kullaniciGetir();
            logoGetir();
            sirketBilgileriGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                sifreDegistir();
            }
            else
            {
                MessageBox.Show("Girmiş Olduğunuz Şifreler Aynı Değildir !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Lütfen Bir Url Giriniz !!!");
            }

            else
            {
                logoDegistir();
                logoGetir();
            }
        }
    }
}
