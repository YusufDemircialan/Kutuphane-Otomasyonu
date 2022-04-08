
namespace Kütüphane
{
    partial class PatronYöneticiEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatronYöneticiEkle));
            this.txtYas = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboCinsiyet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoyadı = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAdı = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKullanıcıAdı = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYas
            // 
            this.txtYas.BorderRadius = 10;
            this.txtYas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYas.DefaultText = "";
            this.txtYas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYas.DisabledState.Parent = this.txtYas;
            this.txtYas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYas.FocusedState.Parent = this.txtYas;
            this.txtYas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYas.HoverState.Parent = this.txtYas;
            this.txtYas.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtYas.IconLeft")));
            this.txtYas.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtYas.Location = new System.Drawing.Point(444, 285);
            this.txtYas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtYas.Name = "txtYas";
            this.txtYas.PasswordChar = '\0';
            this.txtYas.PlaceholderText = "Yaş";
            this.txtYas.SelectedText = "";
            this.txtYas.ShadowDecoration.Parent = this.txtYas;
            this.txtYas.Size = new System.Drawing.Size(230, 30);
            this.txtYas.TabIndex = 7;
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.comboCinsiyet.BorderRadius = 10;
            this.comboCinsiyet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCinsiyet.FocusedColor = System.Drawing.Color.Empty;
            this.comboCinsiyet.FocusedState.Parent = this.comboCinsiyet;
            this.comboCinsiyet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.HoverState.Parent = this.comboCinsiyet;
            this.comboCinsiyet.ItemHeight = 30;
            this.comboCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboCinsiyet.ItemsAppearance.Parent = this.comboCinsiyet;
            this.comboCinsiyet.Location = new System.Drawing.Point(497, 207);
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.ShadowDecoration.Parent = this.comboCinsiyet;
            this.comboCinsiyet.Size = new System.Drawing.Size(177, 36);
            this.comboCinsiyet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cinsiyet";
            // 
            // txtTc
            // 
            this.txtTc.BorderRadius = 10;
            this.txtTc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTc.DefaultText = "";
            this.txtTc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTc.DisabledState.Parent = this.txtTc;
            this.txtTc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTc.FocusedState.Parent = this.txtTc;
            this.txtTc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTc.HoverState.Parent = this.txtTc;
            this.txtTc.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTc.IconLeft")));
            this.txtTc.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtTc.Location = new System.Drawing.Point(444, 249);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTc.Name = "txtTc";
            this.txtTc.PasswordChar = '\0';
            this.txtTc.PlaceholderText = "TC No";
            this.txtTc.SelectedText = "";
            this.txtTc.ShadowDecoration.Parent = this.txtTc;
            this.txtTc.Size = new System.Drawing.Size(230, 30);
            this.txtTc.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderRadius = 10;
            this.txtTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefon.DefaultText = "";
            this.txtTelefon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefon.DisabledState.Parent = this.txtTelefon;
            this.txtTelefon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefon.FocusedState.Parent = this.txtTelefon;
            this.txtTelefon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefon.HoverState.Parent = this.txtTelefon;
            this.txtTelefon.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTelefon.IconLeft")));
            this.txtTelefon.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtTelefon.Location = new System.Drawing.Point(444, 357);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PasswordChar = '\0';
            this.txtTelefon.PlaceholderText = "Telefon Numarası";
            this.txtTelefon.SelectedText = "";
            this.txtTelefon.ShadowDecoration.Parent = this.txtTelefon;
            this.txtTelefon.Size = new System.Drawing.Size(230, 30);
            this.txtTelefon.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtEmail.IconLeft")));
            this.txtEmail.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtEmail.Location = new System.Drawing.Point(444, 321);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "E-Mail";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(230, 30);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.BorderRadius = 10;
            this.txtSoyadı.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyadı.DefaultText = "";
            this.txtSoyadı.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoyadı.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoyadı.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyadı.DisabledState.Parent = this.txtSoyadı;
            this.txtSoyadı.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyadı.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoyadı.FocusedState.Parent = this.txtSoyadı;
            this.txtSoyadı.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyadı.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoyadı.HoverState.Parent = this.txtSoyadı;
            this.txtSoyadı.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSoyadı.IconLeft")));
            this.txtSoyadı.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtSoyadı.Location = new System.Drawing.Point(444, 171);
            this.txtSoyadı.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.PasswordChar = '\0';
            this.txtSoyadı.PlaceholderText = "Soyadı";
            this.txtSoyadı.SelectedText = "";
            this.txtSoyadı.ShadowDecoration.Parent = this.txtSoyadı;
            this.txtSoyadı.Size = new System.Drawing.Size(230, 30);
            this.txtSoyadı.TabIndex = 4;
            // 
            // txtAdı
            // 
            this.txtAdı.BorderRadius = 10;
            this.txtAdı.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdı.DefaultText = "";
            this.txtAdı.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdı.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdı.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdı.DisabledState.Parent = this.txtAdı;
            this.txtAdı.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdı.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdı.FocusedState.Parent = this.txtAdı;
            this.txtAdı.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdı.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdı.HoverState.Parent = this.txtAdı;
            this.txtAdı.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtAdı.IconLeft")));
            this.txtAdı.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtAdı.Location = new System.Drawing.Point(444, 135);
            this.txtAdı.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.PasswordChar = '\0';
            this.txtAdı.PlaceholderText = "Adı";
            this.txtAdı.SelectedText = "";
            this.txtAdı.ShadowDecoration.Parent = this.txtAdı;
            this.txtAdı.Size = new System.Drawing.Size(230, 30);
            this.txtAdı.TabIndex = 3;
            // 
            // TxtSifre
            // 
            this.TxtSifre.BorderRadius = 10;
            this.TxtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSifre.DefaultText = "";
            this.TxtSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSifre.DisabledState.Parent = this.TxtSifre;
            this.TxtSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSifre.FocusedState.Parent = this.TxtSifre;
            this.TxtSifre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSifre.HoverState.Parent = this.TxtSifre;
            this.TxtSifre.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtSifre.IconLeft")));
            this.TxtSifre.IconLeftSize = new System.Drawing.Size(25, 25);
            this.TxtSifre.Location = new System.Drawing.Point(444, 99);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '\0';
            this.TxtSifre.PlaceholderText = "Sifre";
            this.TxtSifre.SelectedText = "";
            this.TxtSifre.ShadowDecoration.Parent = this.TxtSifre;
            this.TxtSifre.Size = new System.Drawing.Size(230, 30);
            this.TxtSifre.TabIndex = 2;
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.BorderRadius = 10;
            this.txtKullanıcıAdı.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullanıcıAdı.DefaultText = "";
            this.txtKullanıcıAdı.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKullanıcıAdı.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKullanıcıAdı.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullanıcıAdı.DisabledState.Parent = this.txtKullanıcıAdı;
            this.txtKullanıcıAdı.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullanıcıAdı.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKullanıcıAdı.FocusedState.Parent = this.txtKullanıcıAdı;
            this.txtKullanıcıAdı.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullanıcıAdı.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKullanıcıAdı.HoverState.Parent = this.txtKullanıcıAdı;
            this.txtKullanıcıAdı.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtKullanıcıAdı.IconLeft")));
            this.txtKullanıcıAdı.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(444, 63);
            this.txtKullanıcıAdı.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.PasswordChar = '\0';
            this.txtKullanıcıAdı.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtKullanıcıAdı.PlaceholderText = "Kullanıcı Adı";
            this.txtKullanıcıAdı.SelectedText = "";
            this.txtKullanıcıAdı.ShadowDecoration.Parent = this.txtKullanıcıAdı;
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(230, 30);
            this.txtKullanıcıAdı.TabIndex = 1;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.Location = new System.Drawing.Point(763, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(25, 23);
            this.guna2ImageButton1.TabIndex = 42;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(35)))), ((int)(((byte)(135)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(113)))), ((int)(((byte)(33)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(113)))), ((int)(((byte)(33)))));
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(35)))), ((int)(((byte)(135)))));
            this.guna2GradientButton2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton2.HoverState.Image")));
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton2.Image")));
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2GradientButton2.Location = new System.Drawing.Point(12, 12);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(99, 43);
            this.guna2GradientButton2.TabIndex = 43;
            this.guna2GradientButton2.Text = "Geri";
            this.guna2GradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderRadius = 10;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.guna2GradientButton3.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.HoverState.Image")));
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.Image")));
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2GradientButton3.Location = new System.Drawing.Point(497, 393);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(177, 45);
            this.guna2GradientButton3.TabIndex = 44;
            this.guna2GradientButton3.Text = "Yönetici Ekle";
            this.guna2GradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(117, 63);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 314);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 45;
            this.guna2PictureBox1.TabStop = false;
            // 
            // PatronYöneticiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.comboCinsiyet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyadı);
            this.Controls.Add(this.txtAdı);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatronYöneticiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatronYöneticiEkle";
            this.Load += new System.EventHandler(this.PatronYöneticiEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtYas;
        private Guna.UI2.WinForms.Guna2ComboBox comboCinsiyet;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTc;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefon;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtSoyadı;
        private Guna.UI2.WinForms.Guna2TextBox txtAdı;
        private Guna.UI2.WinForms.Guna2TextBox TxtSifre;
        private Guna.UI2.WinForms.Guna2TextBox txtKullanıcıAdı;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}