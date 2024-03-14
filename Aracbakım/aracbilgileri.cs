using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aracbakım
{
    public partial class aracbilgileri : Form
    {
        public aracbilgileri()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=Gurkan\\SQLEXPRESS;Initial Catalog=AracBakımDB;Integrated Security=True");

        private void aracbilgileri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aracBakımDBDataSet10.AracEkleTbl' table. You can move, or remove it, as needed.
            this.aracEkleTblTableAdapter.Fill(this.aracBakımDBDataSet10.AracEkleTbl);




        }

        private void MBbutton3_Click(object sender, EventArgs e)
        {
            anasayfa anaSayfaForm = new anasayfa(); // AracEkle formunu oluştur
            anaSayfaForm.Show(); // AracEkle formunu göster
            this.Hide(); // AnaSayfa formunu gizle
        }

       

        private void MBbutton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MBtextBox1.Text) || string.IsNullOrEmpty(MBtextBox2.Text) || string.IsNullOrEmpty(MBtextBox3.Text) ||
                string.IsNullOrEmpty(MBtextBox4.Text) || string.IsNullOrEmpty(MBtextBox5.Text) || string.IsNullOrEmpty(MBtextBox6.Text))
            {
                MessageBox.Show("Boş alanlar bulunmaktadır. Lütfen tüm alanları doldurunuz.");
            }
            else
            {



                baglanti.Open();

                SqlCommand komutgüncelle = new SqlCommand("update AracEkleTbl set AdSoyad=@p2, Telefon=@p3, Mail=@p4, MarkaModel=@p5, Yıl=@p6 where Plaka=@p1 ", baglanti);

                komutgüncelle.Parameters.AddWithValue("@p2", MBtextBox1.Text);
                komutgüncelle.Parameters.AddWithValue("@p3", MBtextBox2.Text);
                komutgüncelle.Parameters.AddWithValue("@p4", MBtextBox3.Text);
                komutgüncelle.Parameters.AddWithValue("@p5", MBtextBox4.Text);
                komutgüncelle.Parameters.AddWithValue("@p6", MBtextBox5.Text);
                komutgüncelle.Parameters.AddWithValue("@p1", MBtextBox6.Text);

                komutgüncelle.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Listeniz Güncellenmiştir.");
                this.aracEkleTblTableAdapter.Fill(this.aracBakımDBDataSet10.AracEkleTbl);

            }

        }
        private void MBdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MBtextBox1.Text = MBdataGridView1.CurrentRow.Cells[0].Value.ToString();
            MBtextBox2.Text = MBdataGridView1.CurrentRow.Cells[1].Value.ToString();
            MBtextBox3.Text = MBdataGridView1.CurrentRow.Cells[2].Value.ToString();
            MBtextBox4.Text = MBdataGridView1.CurrentRow.Cells[3].Value.ToString();
            MBtextBox5.Text = MBdataGridView1.CurrentRow.Cells[4].Value.ToString();
            MBtextBox6.Text = MBdataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void MBbutton4_Click(object sender, EventArgs e)
        {
            string baglantiStr = "Data Source=Gurkan\\SQLEXPRESS;Initial Catalog=AracBakımDB;Integrated Security=True";

            if (radioButton1.Checked)
            {
                if (string.IsNullOrEmpty(MBtextBox7.Text))
                {
                    // Hiç yazı girilmeden butona tıklanırsa tüm veritabanı listesi çağrılsın
                    string sorgu = "select * from AracEkleTbl";
                    using (SqlConnection baglanti = new SqlConnection(baglantiStr))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        MBdataGridView1.DataSource = ds.Tables[0];
                    }
                }
                else
                {
                    // AdSoyad değeri girildiyse ilgili kısım gelsin
                    string sorgu = "select * from AracEkleTbl where AdSoyad='" + MBtextBox7.Text + "'";
                    using (SqlConnection baglanti = new SqlConnection(baglantiStr))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        MBdataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }

            if (radioButton3.Checked)
            {
                if (string.IsNullOrEmpty(MBtextBox7.Text))
                {
                    
                    string sorgu = "select * from AracEkleTbl";
                    using (SqlConnection baglanti = new SqlConnection(baglantiStr))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        MBdataGridView1.DataSource = ds.Tables[0];
                    }
                }
                else
                {
                    
                    string sorgu = "select * from AracEkleTbl where Plaka='" + MBtextBox7.Text + "'";
                    using (SqlConnection baglanti = new SqlConnection(baglantiStr))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        MBdataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }


        }

        private void MBbutton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MBtextBox1.Text) || string.IsNullOrWhiteSpace(MBtextBox2.Text) || string.IsNullOrWhiteSpace(MBtextBox3.Text) ||
               string.IsNullOrWhiteSpace(MBtextBox4.Text) || string.IsNullOrWhiteSpace(MBtextBox5.Text) || string.IsNullOrWhiteSpace(MBtextBox6.Text))
            {
                MessageBox.Show("Lütfen Müşteri Bilgilerini Silerken Boş Alan Bırakmayınız.");
                this.aracEkleTblTableAdapter.Fill(this.aracBakımDBDataSet10.AracEkleTbl);

            }
            else
            {
                baglanti.Open();
                SqlCommand komutSil = new SqlCommand("delete from AracEkleTbl where  Plaka = @p1", baglanti);
                komutSil.Parameters.AddWithValue("@p1", MBtextBox6.Text);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                MBtextBox1.Text = "";
                MBtextBox2.Text = "";
                MBtextBox3.Text = "";
                MBtextBox4.Text = "";
                MBtextBox5.Text = "";
                MBtextBox6.Text = "";
                MessageBox.Show("Müşteri Başarıyla Silinmiştir.");
                this.aracEkleTblTableAdapter.Fill(this.aracBakımDBDataSet10.AracEkleTbl);
            }

        }

        private void MBtextBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void MBtextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MBtextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MBtextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }

}
