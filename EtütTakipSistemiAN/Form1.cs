
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data.Sql;


namespace EtütTakipSistemiAN
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            Init_Data();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");
        //close fotoğrafına tıklandığında ekranı kapat
        private void picClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        //minimize fotoğrafına tıklandığında ekranı küçült
        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        // fare close fotoğrafının üstüne gelince Kapat yazısını göster
        private void picClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picClose, "Kapat");
        }
        // fare minimize fotoğrafının üstüne gelince Küçült yazısını göster
        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picMinimize, "Küçült");
        }
        // fare EyeHide fotoğrafının üstüne gelince Şifreyi Gizle yazısını göster
        private void picEyeHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picEyeHide, "Şifreyi Gizle");
        }
        // fare Show fotoğrafının üstüne gelince Şifreyi Göster yazısını göster
        private void picShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picShow, "Şifreyi Göster");
        }
        // fare Show fotoğrafının üstüne tıklandığında Show fotoğrafını göster EyeHide fotoğrafını gizle
        private void picShow_Click(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = false;
            picShow.Visible = false;
            picEyeHide.Visible = true;
        }

        private void picEyeHide_Click(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
            picShow.Visible = true;
            picEyeHide.Visible = false;
        }
      
      
       
       
      
       
        private void txtUyeSoyad_Enter(object sender, EventArgs e)
        {
            txtUyeSoyad.Text = "";
            txtUyeSoyad.ForeColor = Color.Black;
        }

        private void txtUyeName_Enter(object sender, EventArgs e)
        {
            txtUyeName.Text = "";
            txtUyeName.ForeColor = Color.Black;
        }

        private void txtPosta_Enter(object sender, EventArgs e)
        {
            txtPosta.Text = "";
            txtPosta.ForeColor = Color.Black;
        }

        private void txtClass_Enter(object sender, EventArgs e)
        {
            txtClass.Text = "";
            txtClass.ForeColor = Color.Black;
        }

        private void txtBoxUsername_Enter(object sender, EventArgs e)
        {
            txtBoxUsername.Text = "";
            txtBoxUsername.ForeColor = Color.Black;
        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            txtBoxPassword.ForeColor = Color.Black;
            txtBoxPassword.Text = "";
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSifre.Text == txtSifreTekrar.Text && txtPosta.Text != "" && txtUyeName.Text != ""
                     && txtUyeSoyad.Text != "" && txtClass.Text != "" && txtSifre.Text != "" && txtTC.Text != "" &&
                     txtTelNo.Text != "")
                        {


                            if (baglanti.State == ConnectionState.Closed)
                            {
                                baglanti.Open();
                                string kayit = "insert into yeniKayıt(ad,soyad,eposta,telNo, tcNo,sınıf,sifre,sifretekrar) values (@ad,@soyad,@eposta,@telefon,@tcno,@sınıf,@sifre,@sifretekrar)";
                                SqlCommand komut = new SqlCommand(kayit, baglanti);
                                komut.Parameters.AddWithValue("@ad", txtUyeName.Text);
                                komut.Parameters.AddWithValue("@soyad", txtUyeSoyad.Text);
                                komut.Parameters.AddWithValue("@eposta", txtPosta.Text);
                                komut.Parameters.AddWithValue("@sınıf", txtClass.Text);
                                komut.Parameters.AddWithValue("@telefon", txtTelNo.Text);
                                komut.Parameters.AddWithValue("@tcno", txtTC.Text);
                                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
                                komut.Parameters.AddWithValue("@sifretekrar", txtSifreTekrar.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                lblMesaj.Visible = true;
                                lblMesaj.ForeColor = Color.Orange;
                                lblMesaj.Text = "Kayıt İşlemi Geçekleştirildi";
                            }
                        
                            else
                        {
                        lblMesaj.Visible = true;
                        lblMesaj.ForeColor = Color.Red;
                        lblMesaj.Text = "Lütfen Bilgileri Kontrol Ediniz.";
                    }
            
                    }
                else {
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string sorgu = "SELECT * FROM yeniKayıt where eposta=@user AND sifre=@pass";
            con = new SqlConnection(@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", txtBoxUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txtBoxPassword.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MainPage ögrencisayfa = new MainPage();
                ögrencisayfa.Show();
                this.Hide();
                Save_Data();

            }
            else
            {
                labelError.Visible = true;
                picError.Visible = true;
            }
            con.Close();

        }

        private void Init_Data() // beni hatırla tuşu için
        {
            if (Properties.Settings.Default.Eposta != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    txtBoxUsername.Text = Properties.Settings.Default.Eposta;
                    chkBeniHatirla.Checked = true;
                    Save_Data();
                }
                else
                {
                    txtBoxUsername.Text = Properties.Settings.Default.Eposta;
                }
            }
        }

        private void Save_Data()
        {
            if (chkBeniHatirla.Checked)
            {
                Properties.Settings.Default.Eposta = txtBoxUsername.Text.Trim();
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Eposta = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false;
            picEye.Visible = false;
            picGizle.Visible = true;
        }

        private void picGizle_Click(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            picEye.Visible = true;
            picGizle.Visible = false;
        }

        private void picBoxSifreGöster_Click(object sender, EventArgs e)
        {
            txtSifreTekrar.UseSystemPasswordChar = false;
            picBoxSifreGöster.Visible = false;
            picBoxSifreGizle.Visible = true;
        }

        private void picBoxSifreGizle_Click(object sender, EventArgs e)
        {
            txtSifreTekrar.UseSystemPasswordChar = true;
            picBoxSifreGöster.Visible = true;
            picBoxSifreGizle.Visible= false;
        }

        private void YöneticiGiriş_Click(object sender, EventArgs e)
        {
            YöneticiGiris formyönetici = new YöneticiGiris();
            formyönetici.Show();
            this.Hide();
        }

        private void ÖğretmenGiriş_Click(object sender, EventArgs e)
        {
            ÖğretmenGiris formögretmen = new ÖğretmenGiris();
            formögretmen.Show();
            this.Hide();
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {
            Sifremi_Unuttum sifrem = new Sifremi_Unuttum();
            sifrem.Show();
            this.Show();
        }

        private void txtTelNo_Click(object sender, EventArgs e)
        {
            txtTelNo.Text = "";
            txtTelNo.ForeColor = Color.Black;
            txtTelNo.MaxLength = 11;
            
        }

        private void txtTC_Click(object sender, EventArgs e)
        {
            txtTC.Text = "";
            txtTC.ForeColor = Color.Black;
            txtTC.MaxLength = 11;
        }

        private void txtBoxPassword_Click(object sender, EventArgs e)
        {
            txtBoxPassword.ForeColor = Color.Black;
            txtBoxPassword.Text = "";
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.ForeColor = Color.Black;
            txtSifre.Text = "";
        }

        private void txtSifreTekrar_Click(object sender, EventArgs e)
        {
            txtSifreTekrar.ForeColor = Color.Black;
            txtSifreTekrar.Text = "";
        }
    }
}
            
    
    
    

