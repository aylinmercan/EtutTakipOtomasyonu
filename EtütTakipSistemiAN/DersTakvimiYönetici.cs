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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EtütTakipSistemiAN
{
    public partial class DersTakvimiYönetici : Form
    {
        public DersTakvimiYönetici()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");

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

        private void btnDersTakvimi_Click(object sender, EventArgs e)
        {
            DersTakvimiYönetici dersTakvimiYönetici = new DersTakvimiYönetici();
            dersTakvimiYönetici.Show();
            this.Hide();

        }
        private void DersTakvimiYönetici_Load(object sender, EventArgs e)
        {
            kayitGetir();
            dataGridView1.DataSource = yenile();
        }
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT Pazartesi,Salı,Carsamba,Persembe,Cuma,Cumartesi,Pazar from dersTakvimi";
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

        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select Pazartesi, Salı, Carsamba, Persembe, Cuma , Cumartesi, Pazar, dersTakvimId from dersTakvimi", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        private void btnDeğiştir_Click(object sender, EventArgs e)
        {
            string pzrt, sali, crsb, prsb, cuma, cmrts, pazar , dersTakvimiID;
            pzrt = dataGridView1.CurrentRow.Cells["Pazartesi"].Value.ToString();
            sali = dataGridView1.CurrentRow.Cells["Salı"].Value.ToString();
            crsb = dataGridView1.CurrentRow.Cells["Carsamba"].Value.ToString();
            prsb = dataGridView1.CurrentRow.Cells["Persembe"].Value.ToString();
            cuma = dataGridView1.CurrentRow.Cells["Cuma"].Value.ToString();
            cmrts = dataGridView1.CurrentRow.Cells["Cumartesi"].Value.ToString();
            pazar = dataGridView1.CurrentRow.Cells["Pazar"].Value.ToString();
            dersTakvimiID = dataGridView1.CurrentRow.Cells["dersTakvimId"].Value.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update dersTakvimi set Pazartesi='"+pzrt+"', Salı='"+sali+"', Carsamba='"+crsb+"', Persembe='"+prsb+"', Cuma='"+cuma+"' , Cumartesi='"+cmrts+"', Pazar='"+pazar+"' where dersTakvimId= '" +dersTakvimiID+"'", baglanti );
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataGridView1.DataSource = yenile();
            lblmesaj.Visible = true;
            lblmesaj.ForeColor = Color.Green;
            lblmesaj.Text = "Güncelleme Başarılı.";
        }   
    }
}

