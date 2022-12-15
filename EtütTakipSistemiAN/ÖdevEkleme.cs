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
    public partial class ÖdevEkleme : Form
    {
        public ÖdevEkleme()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");

        private void ÖdevEkleme_Load(object sender, EventArgs e)
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
                cmbÖgrtAdı.Items.Add(dr["ögretmenAdSoyad"]);
                cmbÖgrtAra.Items.Add(dr["ögretmenAdSoyad"]);

            }
            baglanti.Close();
        }
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from ödevEkle";
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
            string kayit = "SELECT * from ödevEkle where ödevÖgrtAdSoyad=@ögrt and ödevDersAdı=@ödevAd";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@ögrt", cmbÖgrtAra.Text);
            komut.Parameters.AddWithValue("@ödevAd", cmbDersAra.Text);
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
                
            }
            kayitGetir();
        }
        void KayıtSil(int numara)
        {
            string sql = "DELETE FROM ödevEkle WHERE ödevId=@ödev";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@ödev", numara);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOdev_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDersAdı.Text != "" && cmbÖgrtAdı.Text != "" && txtÖdev.Text != "")
                {


                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                        string kayit = "insert into ödevEkle(ödevÖgrtAdSoyad,ödevDersAdı,ödevAdı, ödevBaslangıc, ödevBitis) values (@ögrtAd, @dersAdı, @ödevAdi, @ödevBasla, @ödevBitir)";
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        komut.Parameters.AddWithValue("@ögrtAd", cmbÖgrtAdı.Text);
                        komut.Parameters.AddWithValue("@dersAdı", cmbDersAdı.Text);
                        komut.Parameters.AddWithValue("@ödevAdi", txtÖdev.Text);
                        komut.Parameters.AddWithValue("@ödevBasla", dateTimePicker1.Text);
                        komut.Parameters.AddWithValue("@ödevBitir", dateTimePicker2.Text);

                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        lblMesaj.Visible = true;
                        lblMesaj.ForeColor = Color.Green;
                        lblMesaj.Text = "Ödev Eklendi";
                        kayitGetir();
                    }

                    else
                    {
                        lblMesaj.Visible = true;
                        lblMesaj.ForeColor = Color.Red;
                        lblMesaj.Text = "Lütfen Bilgileri Kontrol Ediniz.";
                    }

                }
                else
                {
                    lblMesaj.Visible = true;
                    lblMesaj.ForeColor = Color.Red;
                    lblMesaj.Text = "Lütfen Bilgileri Kontrol Ediniz.";
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
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
            ÖğretmenGiris ögrtdön = new ÖğretmenGiris();
            ögrtdön.Show();
            this.Hide();
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            ÖğretmenMain main = new ÖğretmenMain();
            main.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DersProgramı ders = new DersProgramı();
            ders.Show();
            this.Hide();
        }

        private void cmbÖgrtAdı_Enter(object sender, EventArgs e)
        {
            cmbÖgrtAdı.Text = "";
            cmbÖgrtAdı.ForeColor = Color.Black;
        }

        private void cmbDersAdı_Enter(object sender, EventArgs e)
        {
            cmbDersAdı.Text = "";
            cmbDersAdı.ForeColor = Color.Black;
        }

        private void txtÖdev_Enter(object sender, EventArgs e)
        {
            txtÖdev.Text = "";
            txtÖdev.ForeColor = Color.Black;
        }

        private void cmbÖgrtAra_Enter(object sender, EventArgs e)
        {
            cmbÖgrtAra.Text = "";
            cmbÖgrtAra.ForeColor = Color.Black;
        }

        private void cmbDersAra_Enter(object sender, EventArgs e)
        {
            cmbDersAra.Text = "";
            cmbDersAra.ForeColor = Color.Black;
        }

     
    }
    }

