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
    public partial class YöneticiEmanetKitapListesi : Form
    {
        public YöneticiEmanetKitapListesi()
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

        private void YöneticiEmanetKitapListesi_Load(object sender, EventArgs e)
        {
            EmanetKitapListele();
            guna2ComboBox1.SelectedIndex = 0;
            guna2DataGridView1.Columns[0].HeaderText = "TC Kimlik Numarası";
            guna2DataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            guna2DataGridView1.Columns[2].HeaderText = "Adı";
            guna2DataGridView1.Columns[3].HeaderText = "Soyadı";
            guna2DataGridView1.Columns[4].HeaderText = "Yaş";
            guna2DataGridView1.Columns[5].HeaderText = "Telefon Numarası";
            guna2DataGridView1.Columns[6].HeaderText = "Barkod No";
            guna2DataGridView1.Columns[7].HeaderText = "Kitap Adı";
            guna2DataGridView1.Columns[8].HeaderText = "Yazarı";
            guna2DataGridView1.Columns[9].HeaderText = "Yayın Evi";
            guna2DataGridView1.Columns[10].HeaderText = "Sayfa Sayısı";
            guna2DataGridView1.Columns[11].HeaderText = "Kitap Sayısı";
            guna2DataGridView1.Columns[12].HeaderText = "Teslim Tarihi";
            guna2DataGridView1.Columns[13].HeaderText = "İade Tarihi";
        }

        private void EmanetKitapListele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            guna2DataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            daset.Tables["EmanetKitaplar"].Clear();

            if (guna2ComboBox1.SelectedIndex == 0)
            {
                EmanetKitapListele();
            }
            else if (guna2ComboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where '" + DateTime.Now.ToShortDateString() + "'>iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                guna2DataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
                

            }
            else if (guna2ComboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where '" + DateTime.Now.ToShortDateString() + "'<=iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                guna2DataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
        }
    }
}
