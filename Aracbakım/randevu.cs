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

namespace Aracbakım
{
    public partial class randevu : Form
    {
        public randevu()
        {
            InitializeComponent();
        }


        private void randevu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aracBakımDBDataSet15.RandevuOdeme' table. You can move, or remove it, as needed.
            this.randevuOdemeTableAdapter.Fill(this.aracBakımDBDataSet15.RandevuOdeme);



        }
        SqlConnection baglanti = new SqlConnection("Data Source=Gurkan\\SQLEXPRESS;Initial Catalog=AracBakımDB;Integrated Security=True");

        private void Rbutton3_Click(object sender, EventArgs e)
        {
            anasayfa anaSayfaForm = new anasayfa(); // AracEkle formunu oluştur
            anaSayfaForm.Show(); // AracEkle formunu göster
            this.Hide(); // AnaSayfa formunu gizle
        }

        private void Rbutton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RtextBox1.Text) || string.IsNullOrWhiteSpace(RtextBox3.Text))
            {
                MessageBox.Show("Lütfen Ad Soyad ve Telefon bilgilerini eksiksiz giriniz.");
                this.randevuOdemeTableAdapter.Fill(this.aracBakımDBDataSet15.RandevuOdeme);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into RandevuOdeme(RanAdSoyad1, RanTelefon1, Tarih1) values (@p1, @p2, @p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", RtextBox1.Text);
                komut.Parameters.AddWithValue("@p2", RtextBox3.Text);
                komut.Parameters.AddWithValue("@p3", RdateTimePicker1.Value.ToString("yyyy-MM-dd"));
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu Başarıyla Alınmıştır.");
                baglanti.Close();
                this.randevuOdemeTableAdapter.Fill(this.aracBakımDBDataSet15.RandevuOdeme);
            }


        }

        private void Rbutton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RtextBox1.Text) || string.IsNullOrWhiteSpace(RtextBox3.Text))
            {
                MessageBox.Show("Randevu Bilgilerini Silerken Boş Alan Bırakmayınız.");
                this.randevuOdemeTableAdapter.Fill(this.aracBakımDBDataSet15.RandevuOdeme);

            }
   
            else
            {
                baglanti.Open();
                SqlCommand komutSil = new SqlCommand("delete from RandevuOdeme where  RanTelefon1 = @p1", baglanti);
                komutSil.Parameters.AddWithValue("@p1", RtextBox3.Text);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                RtextBox1.Text = "";
                RtextBox3.Text = "";
                RtextBox1.ReadOnly = false;
                RtextBox3.ReadOnly = false;
                RdateTimePicker1.Enabled = true;
                MessageBox.Show("Randevu Başarıyla Silinmiştir.");
                this.randevuOdemeTableAdapter.Fill(this.aracBakımDBDataSet15.RandevuOdeme);
            }
        }

        private void RdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RdateTimePicker1.Enabled = false;
            RtextBox1.ReadOnly = true;
            RtextBox3.ReadOnly = true;
            RtextBox1.Text = RdataGridView1.CurrentRow.Cells[0].Value.ToString();
            RtextBox3.Text = RdataGridView1.CurrentRow.Cells[1].Value.ToString();
            RdateTimePicker1.Value = Convert.ToDateTime(RdataGridView1.CurrentRow.Cells[2].Value);

        }

        private void RtextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
