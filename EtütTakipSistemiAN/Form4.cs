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
using System.Data.SqlClient;
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EtütTakipSistemiAN
{
    public partial class ÖğretmenGiris : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public ÖğretmenGiris()
        {
            InitializeComponent();
            Init_Data();
        }
      
      

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM ögretmen where ögretmenEposta=@user AND ögretmenSifre=@pass";
            con = new SqlConnection(@"Data Source = AYLINMERCAN\USERS; Initial Catalog = etütsistemi; Integrated Security = True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBoxEposta.Text);
            cmd.Parameters.AddWithValue("@pass", textBoxSifre.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ÖğretmenMain ögretmensayfa = new ÖğretmenMain();
                ögretmensayfa.Show();
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
                    textBoxEposta.Text = Properties.Settings.Default.Eposta;
                    chkBeniHatirla.Checked = true;
                    Save_Data();
                }
                else
                {
                    textBoxEposta.Text = Properties.Settings.Default.Eposta;
                }
            }
        }

        private void Save_Data()
        {
            if (chkBeniHatirla.Checked)
            {
                Properties.Settings.Default.Eposta = textBoxEposta.Text.Trim();
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

        private void textBoxEposta_Enter(object sender, EventArgs e)
        {
            textBoxEposta.Text = "";
            textBoxEposta.ForeColor = Color.Black;
        }

        private void textBoxSifre_Enter(object sender, EventArgs e)
        {
            textBoxSifre.Text = "";
            textBoxSifre.ForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login anasayfa = new Login();
            anasayfa.Visible = true;
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {

                System.Windows.Forms.Application.Exit();
            }

        private void picMinimize_Click(object sender, EventArgs e)
        {
               WindowState = FormWindowState.Minimized;
        }

     
        private void picClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picClose, "Kapat");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Geri");
        }

        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picMinimize, "Küçült");
        }

        private void picEyeHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picEyeHide, "Şifreyi Gizle");
        }

        private void picShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picShow, "Şifreyi Göster");
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            textBoxSifre.UseSystemPasswordChar = false;
            picShow.Visible = false;
            picEyeHide.Visible = true;
        }

        private void picEyeHide_Click(object sender, EventArgs e)
        {
            textBoxSifre.UseSystemPasswordChar = true;
            picShow.Visible = true;
            picEyeHide.Visible = false;
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {
            SifreUnuttumÖgretmen sifreunutsayfa = new SifreUnuttumÖgretmen();
            sifreunutsayfa.Show();
            
        }
    }
    }


