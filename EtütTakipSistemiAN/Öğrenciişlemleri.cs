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
    public partial class Öğrenciişlemleri : Form
    {
        public Öğrenciişlemleri()
        {
            InitializeComponent();
        }
       
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        static string conString = (@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");
        SqlConnection baglanti = new SqlConnection(conString);

        private void Öğrenciişlemleri_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from yeniKayıt";
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

        private void picClose1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from yeniKayıt where ad=@ad and soyad=@soyad";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@ad", textBoxİsim.Text);
            komut.Parameters.AddWithValue("@soyad", textBoxSoyisim.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        void KayıtSil(string numara)
        {
            string sql = "DELETE FROM yeniKayıt WHERE tcNo=@yeni";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@yeni", numara);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                string numara = Convert.ToString(drow.Cells[4].Value);
                KayıtSil(numara);
                lblmesaj.Visible = true;
                lblmesaj.ForeColor = Color.Green;
                lblmesaj.Text = "Başarıyla Silindi";
            }
            kayitGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÖğretmenEkle öğretmenEkle = new ÖğretmenEkle();
            öğretmenEkle.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Öğrenciişlemleri ögris = new Öğrenciişlemleri();
            ögris.Show();
            this.Hide();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            YöneticiMain main = new YöneticiMain();
            main.Show();
            this.Hide();
        }

        private void picMinimize1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            YöneticiGiris yöneticidön = new YöneticiGiris();
            yöneticidön.Show();
            this.Hide();
        }

        private void buttonEtütSilme_Click(object sender, EventArgs e)
        {
            EtütSilme etütSilme = new EtütSilme();
            etütSilme.Show();
            this.Hide();
        }

        private void btnDersTakvimi_Click(object sender, EventArgs e)
        {
            DersTakvimiYönetici dersTakvimiYönetici = new DersTakvimiYönetici();
            dersTakvimiYönetici.Show();
            this.Hide();
        }
    }
}
