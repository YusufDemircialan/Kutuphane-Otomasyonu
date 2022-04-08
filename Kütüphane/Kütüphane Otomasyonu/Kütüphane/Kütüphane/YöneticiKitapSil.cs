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
    public partial class YöneticiKitapSil : Form
    {
        public YöneticiKitapSil()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        DataSet daset = new DataSet();
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiPanel yntpanel = new YöneticiPanel();
            yntpanel.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            Hide();
            YöneticiPanel yntpanel = new YöneticiPanel();
            yntpanel.Show();
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

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            if (MessageBox.Show("Bu kaydı silmek istiyor musunuz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Kitap where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", guna2DataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                daset.Tables["Kitap"].Clear();
                kitaplistele();
                txtBarkodAra.Clear();
            }
        }

        private void YöneticiKitapSil_Load(object sender, EventArgs e)
        {
            kitaplistele();
            guna2DataGridView1.Columns[0].HeaderText = "Barkod No";
            guna2DataGridView1.Columns[1].HeaderText = "Kitap Adı";
            guna2DataGridView1.Columns[2].HeaderText = "Yazarı";
            guna2DataGridView1.Columns[3].HeaderText = "Yayın Evi";
            guna2DataGridView1.Columns[4].HeaderText = "Sayfa Sayısı";
            guna2DataGridView1.Columns[5].HeaderText = "Kitap Türü";
            guna2DataGridView1.Columns[6].HeaderText = "Stok Sayısı";
            guna2DataGridView1.Columns[7].HeaderText = "Raf No";
            guna2DataGridView1.Columns[8].HeaderText = "Kayıt Tarihi";
  

        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            daset.Tables["Kitap"].Clear();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap where barkodno like '%" + txtBarkodAra.Text + "%'", baglanti);
            adtr.Fill(daset, "Kitap");
            guna2DataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }
    }
}
