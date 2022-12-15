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

namespace EtütTakipSistemiAN
{
    public partial class EtütEkleme : Form
    {
        public EtütEkleme()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");
        private void EtütEkleme_Load(object sender, EventArgs e)
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
                comboBoxÖgretmen.Items.Add(dr["ögretmenAdSoyad"]);
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

        private void buttonDersEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand tekrar = new SqlCommand("select count(saat) from etüt where durum='Dolu' and tarih=@saat and ögretmenAdSoyad=@ögr" , baglanti);
                tekrar.Parameters.AddWithValue("@saat", dateTimePicker1.Text);
                tekrar.Parameters.AddWithValue("@ögr", comboBoxÖgretmen.Text);
                int sonuc = (int)tekrar.ExecuteScalar();
                if (sonuc == 0)
                {
                    if (textBoxTc.Text != "" && comboBoxDersAdı.Text != ""
                     && comboBoxÖgretmen.Text != "" && comboBoxSaat.Text != "" &&
                    dateTimePicker1.Text != "" && comboBoxDurum.Text != "")
                    {

                        string kayit = "insert into etüt(dersAdı,tcNo,ögretmenAdSoyad, tarih,saat,durum) values (@dersad,@tc,@adsoyad,@tarih,@saat,@durum)";
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        komut.Parameters.AddWithValue("@dersad", comboBoxDersAdı.Text);
                        komut.Parameters.AddWithValue("@tc", textBoxTc.Text);
                        komut.Parameters.AddWithValue("@adsoyad", comboBoxÖgretmen.Text);
                        komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
                        komut.Parameters.AddWithValue("@saat", comboBoxSaat.Text);
                        komut.Parameters.AddWithValue("@durum", comboBoxDurum.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        kayitGetir();
                        lblMesaj.Visible = true;
                        lblMesaj.ForeColor = Color.Green;
                        lblMesaj.Text = "Başarıyla Kaydedildi";
                    }
                    else
                    {
                        lblMesaj.Visible = true;
                        lblMesaj.ForeColor = Color.Red;
                        lblMesaj.Text = "Bilgileri Kontrol Ediniz";
                    }
                }
                if (sonuc > 0)
                {
                    lblMesaj.Visible = true;
                    lblMesaj.ForeColor = Color.Red;
                    lblMesaj.Text =  dateTimePicker1.Text + "Tarihi O Saatte Dolu.";
                }
                baglanti.Close();
            }
            catch (SqlException)
            {
                lblMesaj.Visible = true;
                lblMesaj.ForeColor = Color.Red;
                lblMesaj.Text = "Kayıt İşlemi Başarısız";
            }
        }

        private void textBoxTc_Enter(object sender, EventArgs e)
        {
            textBoxTc.Text = "";
            textBoxTc.ForeColor = Color.Black;
            textBoxTc.MaxLength = 11;
        }

        private void comboBoxDersAdı_Enter(object sender, EventArgs e)
        {
            comboBoxDersAdı.Text = "";
            comboBoxDersAdı.ForeColor = Color.Black;
        }

        private void comboBoxÖgretmen_Enter(object sender, EventArgs e)
        {
            comboBoxÖgretmen.Text = "";
            comboBoxÖgretmen.ForeColor = Color.Black;
        }

        private void comboBoxSaat_Enter(object sender, EventArgs e)
        {
            comboBoxSaat.Text = "";
            comboBoxSaat.ForeColor = Color.Black;
        }

        private void comboBoxDurum_Enter(object sender, EventArgs e)
        {
            comboBoxDurum.Text = "";
            comboBoxDurum.ForeColor = Color.Black;
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT dersAdı,ögretmenAdSoyad,tarih,saat,durum from etüt where ögretmenAdSoyad=@ögr and saat=@saat and tarih=@tarih";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@ögr", comboBoxAraÖgretmen.Text);
            komut.Parameters.AddWithValue("@saat", comboBoxAraSaat.Text);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker2.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÖdevTakip ödevtakip = new ÖdevTakip();
            ödevtakip.Show();
            this.Hide();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            MainPage anasayfa = new MainPage();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DersTakvmi derstavimi = new DersTakvmi();
            derstavimi.Show();
            this.Hide();
        }

        private void comboBoxAraSaat_Enter(object sender, EventArgs e)
        {
            comboBoxAraSaat.Text = "";
            comboBoxAraSaat.ForeColor = Color.Black;
        }

        private void comboBoxAraÖgretmen_Enter(object sender, EventArgs e)
        {
            comboBoxAraÖgretmen.Text = "";
            comboBoxAraÖgretmen.ForeColor = Color.Black;
        }
    }
    }

