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
    public partial class aracekle : Form
    {
        public aracekle()
        {
            InitializeComponent();
        }

        private void aracekle_Load(object sender, EventArgs e)
        {
          
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Gurkan\\SQLEXPRESS;Initial Catalog=AracBakımDB;Integrated Security=True");



        private void AEbutton1_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(AEtextBox1.Text) || string.IsNullOrWhiteSpace(AEtextBox2.Text) ||
                string.IsNullOrWhiteSpace(AEtextBox3.Text) || string.IsNullOrWhiteSpace(AEtextBox4.Text) ||
                string.IsNullOrWhiteSpace(AEtextBox5.Text) || string.IsNullOrWhiteSpace(AEtextBox6.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
            else
            {
                string mail = AEtextBox3.Text;
                string plaka = AEtextBox6.Text;
                int yil;
                string telefon = AEtextBox2.Text;
                if (!IsNumeric(telefon)) 
                {
                    MessageBox.Show("Telefon alanına sadece sayısal değerler giriniz.");
                    return;
                }

                SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM AracEkleTbl WHERE Telefon = @telefon OR Mail = @mail OR Plaka = @plaka", baglanti);
                kontrolKomut.Parameters.AddWithValue("@telefon", telefon);
                kontrolKomut.Parameters.AddWithValue("@mail", mail);
                kontrolKomut.Parameters.AddWithValue("@plaka", plaka);

                baglanti.Open();
                int kayitSayisi = (int)kontrolKomut.ExecuteScalar();
                baglanti.Close();

                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Bu telefon, mail veya plaka bilgisiyle zaten bir kayıt bulunmaktadır.");
                }
                else
                {


                    if (!int.TryParse(AEtextBox5.Text, out yil))
                    {
                        MessageBox.Show("Yıl alanına sadece sayısal değerler giriniz.");
                        return;
                    }
             

                    if (!mail.Contains("@"))
                    {
                        MessageBox.Show("Geçerli bir e-posta adresi giriniz.");
                        return;
                    }
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO AracEkleTbl(AdSoyad, Telefon, Mail, MarkaModel, Yıl, Plaka) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
                    komut.Parameters.AddWithValue("@p1", AEtextBox1.Text);
                    komut.Parameters.AddWithValue("@p2", telefon); 
                    komut.Parameters.AddWithValue("@p3", mail);
                    komut.Parameters.AddWithValue("@p4", AEtextBox4.Text);
                    komut.Parameters.AddWithValue("@p5", yil);
                    komut.Parameters.AddWithValue("@p6", plaka);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    AEtextBox1.Text = "";
                    AEtextBox2.Text = "";
                    AEtextBox3.Text = "";
                    AEtextBox4.Text = "";
                    AEtextBox5.Text = "";
                    AEtextBox6.Text = "";
                    MessageBox.Show("Kayıt Başarıyla Yapılmıştır.");

                }
            }


        }
        private bool IsNumeric(string input)
        {
            return input.All(char.IsDigit);
        }

        private void AEbutton3_Click(object sender, EventArgs e)
        {
            anasayfa anaSayfaForm = new anasayfa(); // AracEkle formunu oluştur
            anaSayfaForm.Show(); // AracEkle formunu göster
            this.Hide(); // AnaSayfa formunu gizle
        }

        private void AEbutton2_Click(object sender, EventArgs e)
        {
            AEtextBox1.Text = "";
            AEtextBox2.Text = "";
            AEtextBox3.Text = "";
            AEtextBox4.Text = "";
            AEtextBox5.Text = "";
            AEtextBox6.Text = "";
        }

        private void AEtextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AEtextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
