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
    public partial class YöneticiSıralama : Form
    {
        public YöneticiSıralama()
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
            YöneticiPanel yntpanel = new YöneticiPanel();
            yntpanel.Show();
        }

        private void YöneticiSıralama_Load(object sender, EventArgs e)
        {
           

            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Uye order by okunankitapsayisi desc", baglanti);
            adtr.Fill(daset, "Uye");
            guna2DataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
            label3.Text = "";
            label4.Text = "";
            label3.Text = daset.Tables["Uye"].Rows[0]["ad"].ToString().ToUpper()+" "+ daset.Tables["Uye"].Rows[0]["soyad"].ToString().ToUpper() + " = "; 
            label3.Text += daset.Tables["Uye"].Rows[0]["okunankitapsayisi"].ToString();
            label4.Text = daset.Tables["Uye"].Rows[guna2DataGridView1.Rows.Count - 1]["ad"].ToString().ToUpper()+" "+ daset.Tables["Uye"].Rows[guna2DataGridView1.Rows.Count - 1]["soyad"].ToString().ToUpper() + " = ";
            label4.Text += daset.Tables["Uye"].Rows[guna2DataGridView1.Rows.Count - 1]["okunankitapsayisi"].ToString();
            guna2DataGridView1.Columns[0].HeaderText = "TC Kimlik Numarası";
            guna2DataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            guna2DataGridView1.Columns[2].HeaderText = "Adı";
            guna2DataGridView1.Columns[3].HeaderText = "Soyadı";
            guna2DataGridView1.Columns[4].HeaderText = "Yaş";
            guna2DataGridView1.Columns[5].HeaderText = "Cinsiyet";
            guna2DataGridView1.Columns[6].HeaderText = "Telefon Numarası";
            guna2DataGridView1.Columns[7].HeaderText = "E-mail";
            guna2DataGridView1.Columns[8].HeaderText = "Okunan Kitap Sayısı";

        }
    }
}
