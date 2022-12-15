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
using System.Data.Sql;
using System.Reflection.Emit;
using EtütTakipSistemiAN.etütsistemiDataSetTableAdapters;

namespace EtütTakipSistemiAN
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
      
        private void picClose1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void picMinimize1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login anasayfa = new Login();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EtütEkleme etüt = new EtütEkleme();
            etüt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DersTakvmi dersTakvmi = new DersTakvmi();
            dersTakvmi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÖdevTakip ödevTakip = new ÖdevTakip();
            ödevTakip.Show();
            this.Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
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
