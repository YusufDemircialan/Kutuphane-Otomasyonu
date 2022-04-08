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
    public partial class PatronGiriş : Form
    {
        public PatronGiriş()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        

       
        public static string PatronAd = string.Empty;

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
            SqlCommand komut = new SqlCommand("select * from PatronBilgi where kullanici_adi ='" + guna2TextBox1.Text + "' and sifre = '" + guna2TextBox2.Text + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {
                timer1.Enabled = true;
                timer1.Start();
                guna2GradientButton1.Enabled = false;

                PatronAd = reader[0].ToString();
                //MessageBox.Show("Giriş Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label2.Visible = true;
                label2.ForeColor = Color.Green;
                label2.Text = "Giriş Basarılı.\nGiris İslemi Yapılıyor Lütfen Bekleyiniz...";


            }
            else
            {
                //MessageBox.Show("Hatalı giriş yaptınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label2.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = "Kullanıcı Adı veya Sifre Hatalı!!!\nTekrar Deneyiniz...";
                
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
                PatronPanel ptrnpanel = new PatronPanel();
                ptrnpanel.Show();
            }
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                guna2GradientButton2.PerformClick();
            }
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2GradientButton2.PerformClick();
            }
        }
    }
}
