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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        DbProcess db = new DbProcess("CafeProject");
        SqlDataReader dr = null;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKulAdi.Text=="" || txtSifre.Text=="")
            {
                MessageBox.Show("Lütfen kullanıcı adını veya şifreyi boş bırakmayınız");
            }
            else 
            {
             kulKontrol(txtKulAdi.Text,DbProcess.md5Encrypt(txtSifre.Text));
            }
           
        }

        public void kulKontrol(string kulAdi, string sifre)
        {
            SqlCommand com = new SqlCommand("kulGiris", db.dbConnect());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@kulAdi", SqlDbType.VarChar, 50).Value = kulAdi;
            com.Parameters.Add("@sifre", SqlDbType.VarChar, 50).Value = sifre;
            db.dbConnect();
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı! Hoşgeldiniz " + dr["kulAdi"].ToString());
                int id = Convert.ToInt32(dr["id"]);
               
                frmAdminPaneli f = new frmAdminPaneli(id);
                f.Show();
                this.Hide(); 
                
            }
            else 
            {
                MessageBox.Show("Yönetici girişi başarılı olamadı! Lütfen tekrar deneyiniz");
            }
        }
    }
}
