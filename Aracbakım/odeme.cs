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

namespace Aracbakım
{
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
        }

        private void odeme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aracBakımDBDataSet14.RandevuOdeme' table. You can move, or remove it, as needed.
            this.randevuOdemeTableAdapter.Fill(this.aracBakımDBDataSet14.RandevuOdeme);






        }
        SqlConnection baglanti = new SqlConnection("Data Source=Gurkan\\SQLEXPRESS;Initial Catalog=AracBakımDB;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            anasayfa anaSayfaForm = new anasayfa(); // AracEkle formunu oluştur
            anaSayfaForm.Show(); // AracEkle formunu göster
            this.Hide(); // AnaSayfa formunu gizle
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OtextBox3.Text))
            {
                MessageBox.Show("Ödeme yapılmamıştır.(Ödeme Yaparken Bilgilerin Uyuştuğuna ve Ödeme Miktarının Boş Olmamasına Dikkat Ediniz)");
            }
            else
            {
                if (int.TryParse(OtextBox3.Text, out int odemeMiktari))
                {
                    baglanti.Open();

                    SqlCommand komutgüncelle = new SqlCommand("update RandevuOdeme set Odeme1=@p1 where RanTelefon1=@p2", baglanti);

                    komutgüncelle.Parameters.AddWithValue("@p1", odemeMiktari);
                    komutgüncelle.Parameters.AddWithValue("@p2", OtextBox2.Text);
                    komutgüncelle.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ödeme Başarıyla Yapılmıştır.");
                    this.randevuOdemeTableAdapter.Fill(this.aracBakımDBDataSet14.RandevuOdeme);
                }
                else
                {
                    MessageBox.Show("Hatalı ödeme miktarı! Lütfen sadece sayısal bir değer giriniz.");
                }
            }



        }

        private void OdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OtextBox1.Text = OdataGridView1.CurrentRow.Cells[0].Value.ToString();
            OtextBox2.Text = OdataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OtextBox3.Text = "";
        }

        private void OtextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OtextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OtextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
