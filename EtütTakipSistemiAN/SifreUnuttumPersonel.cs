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
    public partial class SifreUnuttumPersonel : Form
    {
        public SifreUnuttumPersonel()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection(@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBoxTC_Click(object sender, EventArgs e)
        {
            textBoxTC.Text = "";
            textBoxTC.ForeColor = Color.Black;
            textBoxTC.MaxLength = 11;
        }

        private void btnSifreAl_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                string sorgu = "Select personelSifre From personel where personelEposta=@user and personeltcNo=@tc";
                cmd = new SqlCommand(sorgu, baglanti);

                cmd.Parameters.AddWithValue("@user", textBoxEposta.Text);
                cmd.Parameters.AddWithValue("@tc", textBoxTC.Text);


                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string sifre;
                    sifre = dr.GetValue(0).ToString();
                    string mesaj = sifre;
                    MessageBox.Show("Şifreniz: " + mesaj);

                }
                else
                {
                    MessageBox.Show("Bilgilerinizi Kontrol Ediniz");
                }
                baglanti.Close();
            }
        }

        private void textBoxTC_Enter(object sender, EventArgs e)
        {
            textBoxTC.Text = "";
            textBoxTC.ForeColor = Color.Black;
            textBoxTC.MaxLength = 11;
        }
    }
}
