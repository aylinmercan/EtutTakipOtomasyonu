namespace EtütTakipSistemiAN
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.txtUyeName = new System.Windows.Forms.TextBox();
            this.txtUyeSoyad = new System.Windows.Forms.TextBox();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.labelForgot = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.picError = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.picEyeHide = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chkBeniHatirla = new System.Windows.Forms.CheckBox();
            this.YöneticiGiriş = new System.Windows.Forms.Label();
            this.ÖğretmenGiriş = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.picEye = new System.Windows.Forms.PictureBox();
            this.picGizle = new System.Windows.Forms.PictureBox();
            this.picBoxSifreGizle = new System.Windows.Forms.PictureBox();
            this.picBoxSifreGöster = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.ComboBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGizle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSifreGizle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSifreGöster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üye Girişi";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxUsername.Location = new System.Drawing.Point(147, 290);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(252, 28);
            this.txtBoxUsername.TabIndex = 2;
            this.txtBoxUsername.Text = "E-posta";
            this.txtBoxUsername.Enter += new System.EventHandler(this.txtBoxUsername_Enter);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxPassword.Location = new System.Drawing.Point(147, 358);
            this.txtBoxPassword.MaxLength = 50;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxPassword.Size = new System.Drawing.Size(252, 28);
            this.txtBoxPassword.TabIndex = 3;
            this.txtBoxPassword.Text = "Şifre";
            this.txtBoxPassword.UseSystemPasswordChar = true;
            this.txtBoxPassword.Click += new System.EventHandler(this.txtBoxPassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(156, 522);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(206, 43);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "        Giriş Yap";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(657, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yeni Kayıt";
            // 
            // txtPosta
            // 
            this.txtPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.txtPosta.ForeColor = System.Drawing.Color.Gray;
            this.txtPosta.Location = new System.Drawing.Point(664, 346);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(163, 28);
            this.txtPosta.TabIndex = 9;
            this.txtPosta.Text = "E-Posta";
            this.txtPosta.Enter += new System.EventHandler(this.txtPosta_Enter);
            // 
            // txtUyeName
            // 
            this.txtUyeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.txtUyeName.ForeColor = System.Drawing.Color.Gray;
            this.txtUyeName.Location = new System.Drawing.Point(664, 290);
            this.txtUyeName.Name = "txtUyeName";
            this.txtUyeName.Size = new System.Drawing.Size(163, 28);
            this.txtUyeName.TabIndex = 7;
            this.txtUyeName.Text = "Ad";
            this.txtUyeName.Enter += new System.EventHandler(this.txtUyeName_Enter);
            // 
            // txtUyeSoyad
            // 
            this.txtUyeSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.txtUyeSoyad.ForeColor = System.Drawing.Color.Gray;
            this.txtUyeSoyad.Location = new System.Drawing.Point(885, 291);
            this.txtUyeSoyad.Name = "txtUyeSoyad";
            this.txtUyeSoyad.Size = new System.Drawing.Size(163, 28);
            this.txtUyeSoyad.TabIndex = 8;
            this.txtUyeSoyad.Text = "Soyad";
            this.txtUyeSoyad.Enter += new System.EventHandler(this.txtUyeSoyad_Enter);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnKayıtOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKayıtOl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKayıtOl.Image = ((System.Drawing.Image)(resources.GetObject("btnKayıtOl.Image")));
            this.btnKayıtOl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıtOl.Location = new System.Drawing.Point(664, 545);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(203, 36);
            this.btnKayıtOl.TabIndex = 15;
            this.btnKayıtOl.Text = "        Kayıt Ol";
            this.btnKayıtOl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(539, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 409);
            this.panel1.TabIndex = 1;
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1171, 2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(26, 36);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 7;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(1126, 2);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(26, 36);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 7;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseHover += new System.EventHandler(this.picMinimize_MouseHover);
            // 
            // labelForgot
            // 
            this.labelForgot.AutoSize = true;
            this.labelForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelForgot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelForgot.Location = new System.Drawing.Point(195, 476);
            this.labelForgot.Name = "labelForgot";
            this.labelForgot.Size = new System.Drawing.Size(130, 20);
            this.labelForgot.TabIndex = 5;
            this.labelForgot.Text = "Şifremi Unuttum";
            this.labelForgot.Click += new System.EventHandler(this.labelForgot_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(143, 429);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(278, 24);
            this.labelError.TabIndex = 2;
            this.labelError.Text = "Geçersiz Kullanıcı Adı veya Şifre";
            this.labelError.Visible = false;
            // 
            // picError
            // 
            this.picError.Image = ((System.Drawing.Image)(resources.GetObject("picError.Image")));
            this.picError.Location = new System.Drawing.Point(111, 429);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(24, 24);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError.TabIndex = 3;
            this.picError.TabStop = false;
            this.picError.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(108, 362);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // picShow
            // 
            this.picShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShow.Image = ((System.Drawing.Image)(resources.GetObject("picShow.Image")));
            this.picShow.Location = new System.Drawing.Point(395, 358);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(33, 28);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 3;
            this.picShow.TabStop = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            this.picShow.MouseHover += new System.EventHandler(this.picShow_MouseHover);
            // 
            // picEyeHide
            // 
            this.picEyeHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEyeHide.Image = ((System.Drawing.Image)(resources.GetObject("picEyeHide.Image")));
            this.picEyeHide.Location = new System.Drawing.Point(395, 358);
            this.picEyeHide.Name = "picEyeHide";
            this.picEyeHide.Size = new System.Drawing.Size(33, 28);
            this.picEyeHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeHide.TabIndex = 3;
            this.picEyeHide.TabStop = false;
            this.picEyeHide.Click += new System.EventHandler(this.picEyeHide_Click);
            this.picEyeHide.MouseHover += new System.EventHandler(this.picEyeHide_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(405, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(246, 258);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // chkBeniHatirla
            // 
            this.chkBeniHatirla.AutoSize = true;
            this.chkBeniHatirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkBeniHatirla.ForeColor = System.Drawing.Color.White;
            this.chkBeniHatirla.Location = new System.Drawing.Point(147, 392);
            this.chkBeniHatirla.Name = "chkBeniHatirla";
            this.chkBeniHatirla.Size = new System.Drawing.Size(120, 24);
            this.chkBeniHatirla.TabIndex = 4;
            this.chkBeniHatirla.Text = "Beni Hatırla";
            this.chkBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // YöneticiGiriş
            // 
            this.YöneticiGiriş.AutoSize = true;
            this.YöneticiGiriş.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YöneticiGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.YöneticiGiriş.ForeColor = System.Drawing.Color.White;
            this.YöneticiGiriş.Location = new System.Drawing.Point(873, 638);
            this.YöneticiGiriş.Name = "YöneticiGiriş";
            this.YöneticiGiriş.Size = new System.Drawing.Size(274, 20);
            this.YöneticiGiriş.TabIndex = 12;
            this.YöneticiGiriş.Text = "Yönetici Giriş Sayfası İçin Tıklayınız";
            this.YöneticiGiriş.Click += new System.EventHandler(this.YöneticiGiriş_Click);
            // 
            // ÖğretmenGiriş
            // 
            this.ÖğretmenGiriş.AutoSize = true;
            this.ÖğretmenGiriş.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ÖğretmenGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ÖğretmenGiriş.ForeColor = System.Drawing.Color.White;
            this.ÖğretmenGiriş.Location = new System.Drawing.Point(873, 679);
            this.ÖğretmenGiriş.Name = "ÖğretmenGiriş";
            this.ÖğretmenGiriş.Size = new System.Drawing.Size(289, 20);
            this.ÖğretmenGiriş.TabIndex = 13;
            this.ÖğretmenGiriş.Text = "Öğretmen Giriş Sayfası İçin Tıklayınız";
            this.ÖğretmenGiriş.Click += new System.EventHandler(this.ÖğretmenGiriş_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(824, 679);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(823, 623);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(820, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - - - - - - - - - - - - - - - - - - - -";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSifre.ForeColor = System.Drawing.Color.Gray;
            this.txtSifre.Location = new System.Drawing.Point(660, 459);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(167, 24);
            this.txtSifre.TabIndex = 13;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSifreTekrar.ForeColor = System.Drawing.Color.Gray;
            this.txtSifreTekrar.Location = new System.Drawing.Point(885, 459);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(167, 24);
            this.txtSifreTekrar.TabIndex = 14;
            this.txtSifreTekrar.Text = "Şifre";
            this.txtSifreTekrar.UseSystemPasswordChar = true;
            this.txtSifreTekrar.Click += new System.EventHandler(this.txtSifreTekrar_Click);
            // 
            // picEye
            // 
            this.picEye.Image = ((System.Drawing.Image)(resources.GetObject("picEye.Image")));
            this.picEye.Location = new System.Drawing.Point(823, 459);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(30, 24);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEye.TabIndex = 17;
            this.picEye.TabStop = false;
            this.picEye.Click += new System.EventHandler(this.picEye_Click);
            // 
            // picGizle
            // 
            this.picGizle.Image = ((System.Drawing.Image)(resources.GetObject("picGizle.Image")));
            this.picGizle.Location = new System.Drawing.Point(823, 459);
            this.picGizle.Name = "picGizle";
            this.picGizle.Size = new System.Drawing.Size(30, 24);
            this.picGizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGizle.TabIndex = 18;
            this.picGizle.TabStop = false;
            this.picGizle.Click += new System.EventHandler(this.picGizle_Click);
            // 
            // picBoxSifreGizle
            // 
            this.picBoxSifreGizle.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSifreGizle.Image")));
            this.picBoxSifreGizle.Location = new System.Drawing.Point(1045, 459);
            this.picBoxSifreGizle.Name = "picBoxSifreGizle";
            this.picBoxSifreGizle.Size = new System.Drawing.Size(30, 24);
            this.picBoxSifreGizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSifreGizle.TabIndex = 19;
            this.picBoxSifreGizle.TabStop = false;
            this.picBoxSifreGizle.Click += new System.EventHandler(this.picBoxSifreGizle_Click);
            // 
            // picBoxSifreGöster
            // 
            this.picBoxSifreGöster.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSifreGöster.Image")));
            this.picBoxSifreGöster.Location = new System.Drawing.Point(1045, 459);
            this.picBoxSifreGöster.Name = "picBoxSifreGöster";
            this.picBoxSifreGöster.Size = new System.Drawing.Size(30, 24);
            this.picBoxSifreGöster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSifreGöster.TabIndex = 20;
            this.picBoxSifreGöster.TabStop = false;
            this.picBoxSifreGöster.Click += new System.EventHandler(this.picBoxSifreGöster_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(617, 459);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(848, 459);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(48, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.txtTelNo.ForeColor = System.Drawing.Color.Gray;
            this.txtTelNo.Location = new System.Drawing.Point(664, 406);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(167, 28);
            this.txtTelNo.TabIndex = 11;
            this.txtTelNo.Text = "Telefon No";
            this.txtTelNo.Click += new System.EventHandler(this.txtTelNo_Click);
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.txtTC.ForeColor = System.Drawing.Color.Gray;
            this.txtTC.Location = new System.Drawing.Point(885, 406);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(163, 28);
            this.txtTC.TabIndex = 12;
            this.txtTC.Text = "TC No";
            this.txtTC.Click += new System.EventHandler(this.txtTC_Click);
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.txtClass.ForeColor = System.Drawing.Color.Gray;
            this.txtClass.FormattingEnabled = true;
            this.txtClass.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "C1",
            "C2"});
            this.txtClass.Location = new System.Drawing.Point(885, 346);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(163, 30);
            this.txtClass.TabIndex = 10;
            this.txtClass.Text = "Sınıfınız";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(660, 507);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(58, 22);
            this.lblMesaj.TabIndex = 1;
            this.lblMesaj.Text = "label4";
            this.lblMesaj.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(36)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.picBoxSifreGöster);
            this.Controls.Add(this.picBoxSifreGizle);
            this.Controls.Add(this.picEye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ÖğretmenGiriş);
            this.Controls.Add(this.YöneticiGiriş);
            this.Controls.Add(this.chkBeniHatirla);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.picEyeHide);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelForgot);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.txtUyeSoyad);
            this.Controls.Add(this.txtUyeName);
            this.Controls.Add(this.txtPosta);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picError);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picGizle);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGizle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSifreGizle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSifreGöster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.TextBox txtUyeName;
        private System.Windows.Forms.TextBox txtUyeSoyad;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Label labelForgot;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.PictureBox picEyeHide;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox chkBeniHatirla;
        private System.Windows.Forms.Label YöneticiGiriş;
        private System.Windows.Forms.Label ÖğretmenGiriş;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.PictureBox picEye;
        private System.Windows.Forms.PictureBox picGizle;
        private System.Windows.Forms.PictureBox picBoxSifreGizle;
        private System.Windows.Forms.PictureBox picBoxSifreGöster;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.ComboBox txtClass;
        private System.Windows.Forms.Label lblMesaj;
    }
}

