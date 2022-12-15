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
    public partial class EtütSilme : Form
    {
        public EtütSilme()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");
        private void EtütSilme_Load(object sender, EventArgs e)
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
                cmbBoxOgrtAdı.Items.Add(dr["ögretmenAdSoyad"]);
             
            }
            baglanti.Close();
        }
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT etütId,dersAdı,ögretmenAdSoyad,tarih,saat,durum from etüt";
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT etütId,dersAdı,ögretmenAdSoyad,tarih,saat,durum from etüt where ögretmenAdSoyad=@ögr and tarih=@tarih";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@ögr", cmbBoxOgrtAdı.Text);
            
            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(numara);
                lblmesaj.Visible = true;
                lblmesaj.ForeColor = Color.Green;
                lblmesaj.Text = "Başarıyla Silindi";
            }
            kayitGetir();
        }
        void KayıtSil(int numara)
        {
            string sql = "DELETE FROM etüt WHERE etütId=@etüt";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@etüt", numara);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

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
            YöneticiGiris yöneticidön = new YöneticiGiris();
            yöneticidön.Show();
            this.Hide();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            YöneticiMain main = new YöneticiMain();
            main.Show();
            this.Hide();
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

        private void buttonEtütSilme_Click(object sender, EventArgs e)
        {
            EtütSilme etütSilme = new EtütSilme();
            etütSilme.Show();
            this.Hide();
        }

        private void cmbBoxOgrtAdı_Enter(object sender, EventArgs e)
        {
            cmbBoxOgrtAdı.Text = "";
            cmbBoxOgrtAdı.ForeColor = Color.Black;
        }

        private void btnDersTakvimi_Click(object sender, EventArgs e)
        {
            DersTakvimiYönetici dersTakvimiYönetici = new DersTakvimiYönetici();
            dersTakvimiYönetici.Show();
            this.Hide();
        }
    }
}
