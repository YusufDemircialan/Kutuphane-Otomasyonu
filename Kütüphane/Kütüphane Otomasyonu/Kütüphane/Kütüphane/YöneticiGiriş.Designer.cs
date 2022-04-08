
namespace Kütüphane
{
    partial class YöneticiGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiGiriş));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yönetici Giriş";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            this.guna2ImageButton1.TabIndex = 11;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(30, 30);
            this.guna2TextBox1.Location = new System.Drawing.Point(300, 175);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Kullanıcı Adı";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 30);
            this.guna2TextBox1.TabIndex = 0;
            this.guna2TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2TextBox1_KeyDown);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 10;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox2.IconLeft")));
            this.guna2TextBox2.IconLeftSize = new System.Drawing.Size(30, 30);
            this.guna2TextBox2.Location = new System.Drawing.Point(300, 224);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '*';
            this.guna2TextBox2.PlaceholderText = " Şifre";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(200, 30);
            this.guna2TextBox2.TabIndex = 1;
            this.guna2TextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2TextBox2_KeyDown);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(96)))), ((int)(((byte)(195)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(96)))), ((int)(((byte)(195)))));
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.HoverState.Image")));
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2GradientButton1.Location = new System.Drawing.Point(12, 12);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(99, 43);
            this.guna2GradientButton1.TabIndex = 14;
            this.guna2GradientButton1.Text = "Geri";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(96)))), ((int)(((byte)(195)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(96)))), ((int)(((byte)(195)))));
            this.guna2GradientButton2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton2.HoverState.Image")));
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton2.Image")));
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2GradientButton2.Location = new System.Drawing.Point(350, 270);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(100, 45);
            this.guna2GradientButton2.TabIndex = 15;
            this.guna2GradientButton2.Text = "Giriş";
            this.guna2GradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(96)))), ((int)(((byte)(195)))));
            this.panel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.panel1.Location = new System.Drawing.Point(0, 435);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(1, 15);
            this.panel1.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(297, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 22;
            // 
            // YöneticiGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YöneticiGiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

