using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Kütüphane
{
    public partial class YöneticiGiriş : Form
    {
         
        public YöneticiGiriş()
        {
            InitializeComponent();
            
        }

        Baglanti bgl = new Baglanti();
        public static string YöneticiAd = string.Empty;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            
        }


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hide();
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            label2.Visible = false;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AdminBilgi where kullanici_adi ='" + guna2TextBox1.Text + "' and sifre = '" + guna2TextBox2.Text + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {
                YöneticiAd = reader[1].ToString();
                timer1.Enabled = true;
                timer1.Start();
                guna2GradientButton1.Enabled = false;


                label2.Visible = true;
                label2.ForeColor = Color.Green;
                label2.Text = "Giriş Başarılı.\nGiriş İşlemi Yapılıyor Lütfen Bekleyiniz...";
                //MessageBox.Show("Giriş Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            else
            {
                label2.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = "Kullanıcı Adı veya Sifre Hatalı!!!\nTekrar Deneyiniz...";
                //MessageBox.Show("Hatalı giriş yaptınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                guna2TextBox1.Clear();
                guna2TextBox2.Clear();
            }

            baglanti.Close();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.panel1.Width += 4;
            if (panel1.Width >= 800)
            {
                timer1.Stop();
                Hide();
                YöneticiPanel yntpanel = new YöneticiPanel();
                yntpanel.Show();
            }
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                guna2GradientButton2.PerformClick();
            }
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2GradientButton2.PerformClick();
            }
        }
    }
}
