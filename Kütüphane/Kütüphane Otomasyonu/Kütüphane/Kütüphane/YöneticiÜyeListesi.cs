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
    public partial class YöneticiÜyeListesi : Form
    {
        public YöneticiÜyeListesi()
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
        DataSet daset = new DataSet();

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtTC.Text = guna2DataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            daset.Tables["Uye"].Clear();
            
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye where tc like '%"+txtTcAra.Text+"%'",baglanti);
            adtr.Fill(daset, "Uye");
            guna2DataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
        }
        private void uyelistele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye", baglanti);
            adtr.Fill(daset,"Uye");
            guna2DataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
        }

        private void YöneticiÜyeListesi_Load(object sender, EventArgs e)
        {
            uyelistele();
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



        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Uye where tc like'%" + txtTC.Text + "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdı.Text = read["ad"].ToString();
                txtKullanıcıAdı.Text = read["kullanici_adi"].ToString();
                txtSoyadı.Text = read["soyad"].ToString();
                txtYas.Text = read["yas"].ToString();
                comboCinsiyet.Text = read["cinsiyet"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
                txtEmail.Text = read["email"].ToString();
                txtOkunankitapsayisi.Text = read["okunankitapsayisi"].ToString();
            }
            if (txtTC.Text == "")
            {
                txtAdı.Clear();
                txtKullanıcıAdı.Clear();
                txtSoyadı.Clear();
                txtYas.Clear();
                txtTelefon.Clear();
                comboCinsiyet.SelectedIndex = -1;
                txtEmail.Clear();
                txtOkunankitapsayisi.Clear();
            }
            baglanti.Close();
        }

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            if (MessageBox.Show("Bu kaydı güncellemek istiyor musunuz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Uye set ad=@ad,kullanici_adi=@kullanici_adi,soyad=@soyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,email=@email,okunankitapsayisi=@okunankitapsayisi where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@kullanici_adi", txtKullanıcıAdı.Text);
                komut.Parameters.AddWithValue("@ad", txtAdı.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyadı.Text);
                komut.Parameters.AddWithValue("@yas", txtYas.Text);
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                komut.Parameters.AddWithValue("@okunankitapsayisi", int.Parse(txtOkunankitapsayisi.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                daset.Tables["Uye"].Clear();
                uyelistele();
                txtTC.Clear();
                if (txtTC.Text == "")
                {
                    txtAdı.Clear();
                    txtSoyadı.Clear();
                    txtYas.Clear();
                    txtTelefon.Clear();
                    comboCinsiyet.SelectedIndex = -1;
                    txtEmail.Clear();
                    txtOkunankitapsayisi.Clear();
                }
            }
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
