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
    public partial class YöneticiKitapAra : Form
    {
        public YöneticiKitapAra()
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

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

           
        }
        private void kitaplistele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap", baglanti);
            adtr.Fill(daset, "Kitap");
            guna2DataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }
        private void YöneticiKitapAra_Load(object sender, EventArgs e)
        {
            kitaplistele();
            guna2DataGridView1.Columns[8].Visible = false; //KOLON GİZLEME
            guna2DataGridView1.Columns[0].HeaderText = "Barkod No";
            guna2DataGridView1.Columns[1].HeaderText = "Kitap Adı";
            guna2DataGridView1.Columns[2].HeaderText = "Yazarı";
            guna2DataGridView1.Columns[3].HeaderText = "Yayın Evi";
            guna2DataGridView1.Columns[4].HeaderText = "Sayfa Sayısı";
            guna2DataGridView1.Columns[5].HeaderText = "Kitap Türü";
            guna2DataGridView1.Columns[6].HeaderText = "Stok Sayısı";
            guna2DataGridView1.Columns[7].HeaderText = "Raf No";
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            daset.Tables["Kitap"].Clear();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap where kitapadi like '%" + guna2TextBox1.Text + "%'", baglanti);
            adtr.Fill(daset, "Kitap");
            guna2DataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }

        private void txtYazar_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            daset.Tables["Kitap"].Clear();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap where yazari like '%" + txtYazar.Text + "%'", baglanti);
            adtr.Fill(daset, "Kitap");
            guna2DataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }
    }
}
