using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aracbakım
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aracekle aracEkleForm = new aracekle(); // AracEkle formunu oluştur
            aracEkleForm.Show(); // AracEkle formunu göster
            this.Hide(); // AnaSayfa formunu gizle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aracbilgileri aracBilgileriForm = new aracbilgileri(); 
            aracBilgileriForm.Show(); 
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            randevu randevuForm = new randevu();
            randevuForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            odeme odemeForm = new odeme();
            odemeForm.Show();
            this.Hide();
        }
    }
}
