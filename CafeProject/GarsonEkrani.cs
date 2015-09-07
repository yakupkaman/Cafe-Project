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
      
        int gelenID=10;//Garson id 
        public GarsonEkrani()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            gr.Show(); //Button'a týkladýðýmýz zaman garson güncelleme ekranýna geçmesini saðlýyoruz

            this.Hide();
        }

        public void DataGetir()
        {
            SqlCommand cm = new SqlCommand("SP_MasaBilgler", db.baglan());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@id", SqlDbType.Int).Value = gelenID;
            cm.ExecuteNonQuery();


            SqlDataReader rd = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            db.DbKapat();
        }
        private void GarsonEkrani_Load(object sender, EventArgs e)
        {
            
            DataGetir();
            renklendir();
        }

        public void renklendir() 
        { 
        
         try
            {
 
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    Application.DoEvents();
 
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
 
                    //durum sutunundaki degere göre satir rengi degistiriyoruz.
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)==0)//Masa Dolu
                    {
                        
                        // Masa dolu olanlar OrangeRed rengini veriyoruz.
                        rowColor.BackColor = Color.Pink;
                        //yazi rengi beyaz oluyor.
                        rowColor.ForeColor = Color.White;
                    }
                    else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)==1)//Ödeme Yapýlmýs masa avaliable
                    {
                        rowColor.BackColor = Color.Blue;
                        rowColor.ForeColor = Color.White;
                    }
                    else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)== 2)//Aþcýya sipariþ verildi
                    {
                        rowColor.BackColor = Color.OrangeRed;
                        rowColor.ForeColor = Color.White;
                    }
 
                    //satir rengini degistiriyoruz.

                dataGridView1.Rows[i].DefaultCellStyle = rowColor;
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            String refKodu = Convert.ToString(dataGridView1.CurrentRow.Cells["refKodu"].Value);
            if (refKodu!="")
            {
                SqlCommand cmd = new SqlCommand("SP_SiparisBilgileri", db.baglan());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@refKodu", SqlDbType.Int).Value = refKodu;
                cmd.ExecuteNonQuery();
                SqlDataReader rdd = cmd.ExecuteReader();
                if (rdd.Read())
                {
                    textBox1.Text = rdd["adi"].ToString();
                    label6.Visible = true;
                    label6.Text = rdd["toplamTutar"].ToString();
                }
                db.DbKapat();
                SqlCommand cm = new SqlCommand("SP_OdemeTur", db.baglan());
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@refKodu", SqlDbType.Int).Value = refKodu;
                cm.ExecuteNonQuery();
                SqlDataReader rd = cm.ExecuteReader();

                if (rd.Read())
                { 
                    String odeme = rd["odemeTur"].ToString();
                   if (odeme.Equals(""))
                              {
                label2.Visible = true;
                label2.Text = "KREDÝ KARTI";
                
                             }
                    else
                         {
                label2.Visible = true;
                label2.Text = "NAKÝT";
                          }

            db.DbKapat();
            }
                
                
              }
        

           
        }


        
    }
}
