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
    public partial class YöneticiKitapListesiVeGüncelleme : Form
    {
        public YöneticiKitapListesiVeGüncelleme()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        DataSet daset = new DataSet();
        private void kitaplistele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap", baglanti);
            adtr.Fill(daset, "Kitap");
            guna2DataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
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
            YöneticiPanel yntpanel = new YöneticiPanel();
            yntpanel.Show();
        }

        private void YöneticiKitapListesiVeGüncelleme_Load(object sender, EventArgs e)
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

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            if (MessageBox.Show("Bu kaydı güncellemek istiyor musunuz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Kitap set kitapadi=@kitapadi,yazari=@yazari,yayinevi=@yayinevi,sayfasayisi=@sayfasayisi,kitapturu=@kitapturu,stoksayisi=@stoksayisi,rafno=@rafno where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazari", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayınEvi.Text);
                komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@kitapturu", comboKitapTürü.Text);
                komut.Parameters.AddWithValue("@stoksayisi", txtStokSayısı.Text);
                komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                daset.Tables["Kitap"].Clear();
                kitaplistele();
                txtBarkodNo.Clear();
                txtKitapAdi.Clear();
                txtYazar.Clear();
                txtYayınEvi.Clear();
                txtSayfaSayisi.Clear();
                comboKitapTürü.SelectedIndex = -1;
                txtStokSayısı.Clear();
                txtRafNo.Clear();
                
            }
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

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kitap where barkodno like'%" + txtBarkodNo.Text + "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["kitapadi"].ToString();
                txtYazar.Text = read["yazari"].ToString();
                txtYayınEvi.Text = read["yayinevi"].ToString();
                txtSayfaSayisi.Text = read["sayfasayisi"].ToString();
                comboKitapTürü.Text = read["kitapturu"].ToString();
                txtStokSayısı.Text = read["stoksayisi"].ToString();
                txtRafNo.Text = read["rafno"].ToString();
            }
            baglanti.Close();
            if (txtBarkodNo.Text == "")
            {
                txtKitapAdi.Clear();
                txtYazar.Clear();
                txtYayınEvi.Clear();
                txtSayfaSayisi.Clear();
                comboKitapTürü.SelectedIndex = -1;
                txtStokSayısı.Clear();
                txtRafNo.Clear();
            }
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtBarkodNo.Text = guna2DataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
        }
    }
}
