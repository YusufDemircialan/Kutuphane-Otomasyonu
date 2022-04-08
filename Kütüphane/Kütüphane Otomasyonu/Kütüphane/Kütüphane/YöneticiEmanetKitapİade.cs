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
    public partial class YöneticiEmanetKitapİade : Form
    {
        public YöneticiEmanetKitapİade()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        
        DataSet daset = new DataSet();
        private void EmanetKitapListele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            guna2DataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
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

        private void YöneticiEmanetKitapİade_Load(object sender, EventArgs e)
        {
            EmanetKitapListele();
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

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where tc like '%"+txtTcAra.Text+"%'",baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txtTcAra.Text=="")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetKitapListele();
            }
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where barkodno like '%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txtBarkodNoAra.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetKitapListele();
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            if (MessageBox.Show("Seçili Olan Kitap Teslim Alınsın Mı ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from EmanetKitaplar where tc=@tc and barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@tc", guna2DataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.Parameters.AddWithValue("@barkodno", guna2DataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update Kitap set stoksayisi=stoksayisi+'" + guna2DataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString() + "' where barkodno=@barkodno", baglanti);
                komut2.Parameters.AddWithValue("@barkodno", guna2DataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap(lar) İade Edildi", "Bilgi");
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetKitapListele();
            }
        }
    }
}
