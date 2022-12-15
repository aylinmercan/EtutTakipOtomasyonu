﻿using System;
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
    public partial class ÖdevTakip : Form
    {
        public ÖdevTakip()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login anasayfa = new Login();
            anasayfa.Show();
            this.Hide();
        }

        private void picClose1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void picMinimize1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            MainPage anasayfa = new MainPage();
            anasayfa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÖdevTakip ödevtakip = new ÖdevTakip();
            ödevtakip.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DersTakvmi derstavimi = new DersTakvmi();
            derstavimi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EtütEkleme etütekleme = new EtütEkleme();
            etütekleme.Show();
            this.Hide();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from ödevEkle where  ödevDersAdı=@ödevAd";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
 
            komut.Parameters.AddWithValue("@ödevAd", cmbDersAra.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void ÖdevTakip_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT ödevÖgrtAdSoyad,ödevDersAdı,ödevAdı,ödevBaslangıc,ödevBitis from ödevEkle";
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
    }
}
