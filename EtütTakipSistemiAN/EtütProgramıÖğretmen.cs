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
    public partial class EtütProgramıÖğretmen : Form
    {
        public EtütProgramıÖğretmen()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");
      
        private void picMinimize1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ÖğretmenGiris öğretmenMain= new ÖğretmenGiris();
            öğretmenMain.Show();
            this.Hide();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT dersAdı,ögretmenAdSoyad,tarih,saat,durum from etüt where ögretmenAdSoyad=@ögr  and tarih=@tarih";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@ögr", comboBoxAraÖgretmen.Text);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker2.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void EtütProgramıÖğretmen_Load(object sender, EventArgs e)
        {
            kayitGetir();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = (@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM ögretmen";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxAraÖgretmen.Items.Add(dr["ögretmenAdSoyad"]);
            }
            baglanti.Close();
        }
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT dersAdı,ögretmenAdSoyad,tarih,saat,durum from etüt";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }

        private void comboBoxAraÖgretmen_Enter(object sender, EventArgs e)
        {
            comboBoxAraÖgretmen.Text = "";
            comboBoxAraÖgretmen.ForeColor = Color.Black;
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            ÖğretmenMain main = new ÖğretmenMain();
            main.Show();
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
    }
}
