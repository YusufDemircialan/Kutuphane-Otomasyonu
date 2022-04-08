using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Kütüphane
{
    public partial class ÜyeŞifreDeğiştir : Form
    {
        public ÜyeŞifreDeğiştir()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        DataSet daset = new DataSet();
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
            ÜyePanel üyepnl = new ÜyePanel();
            üyepnl.Show();
        }

        public void üyeşifredeğiştir(string Password)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update ÜyeBilgi SET sifre = '" + Password + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
            {
                üyeşifredeğiştir(guna2TextBox1.Text);
                MessageBox.Show("Şifre başarıyla değiştirildi!", "Başarılı");
            }
            else if (guna2TextBox1.TextLength <= 4)
            {
                MessageBox.Show("Şifre en az 4 karakter içermelidir!.", "Geçersiz Şifre");
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir şifre giriniz!", "Geçersiz Şifre");
            }

        }
    }
}
