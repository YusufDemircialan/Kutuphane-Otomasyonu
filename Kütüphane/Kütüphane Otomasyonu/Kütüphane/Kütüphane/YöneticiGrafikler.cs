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
    public partial class YöneticiGrafikler : Form
    {
        public YöneticiGrafikler()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

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
            YöneticiPanel yntpanel = new YöneticiPanel();
            yntpanel.Show();
        }

        private void YöneticiGrafikler_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ad,soyad,okunankitapsayisi from Uye",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                chart1.Series["Okunan Kitap Sayısı"].Points.AddXY(read["ad"].ToString().ToUpper()+" "+ read["soyad"].ToString().ToUpper(), read["okunankitapsayisi"]);
            }
            baglanti.Close();
            chart1.Series["Okunan Kitap Sayısı"].Color = Color.Orange;
        }
    }
}
