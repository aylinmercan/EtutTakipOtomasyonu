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

namespace EtütTakipSistemiAN
{
    public partial class ÖğretmenMain : Form
    {
        public ÖğretmenMain()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ÖğretmenGiris anasayfa = new ÖğretmenGiris();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DersProgramı ders = new DersProgramı();
            ders.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EtütProgramıÖğretmen etüt = new EtütProgramıÖğretmen();
            etüt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÖdevEkleme ödev = new ÖdevEkleme();
            ödev.Show();
            this.Hide();
        }

        private void picMinimize1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ÖğretmenMain_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = (@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");
            SqlCommand komut = new SqlCommand();
            SqlCommand ogretmenS = new SqlCommand();
            SqlDataReader dr;
            baglanti.Open();
            komut.CommandText = "SELECT count(ad) FROM yeniKayıt ";
            ogretmenS.CommandText = "Select count(ögretmenId) from ögretmen";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            var deger = komut.ExecuteScalar();
            label3.Text = deger.ToString();
            ogretmenS.Connection = baglanti;
            ogretmenS.CommandType = CommandType.Text;
            var sayi = ogretmenS.ExecuteScalar();
            label6.Text = sayi.ToString();
            baglanti.Close();
        }
    }
}
