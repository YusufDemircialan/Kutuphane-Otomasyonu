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
    public partial class PatronYöneticiListesiVeGüncelleme : Form
    {
        public PatronYöneticiListesiVeGüncelleme()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        DataSet daset = new DataSet();
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hide();
            PatronPanel ptrnpanel = new PatronPanel();
            ptrnpanel.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtTC.Text = guna2DataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }
        private void yöneticiistele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Admin", baglanti);
            adtr.Fill(daset, "Admin");
            guna2DataGridView1.DataSource = daset.Tables["Admin"];
            baglanti.Close();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            daset.Tables["Admin"].Clear();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from Admin where tc like '%" + txtTcAra.Text + "%'", baglanti);
            adtr.Fill(daset, "Admin");
            guna2DataGridView1.DataSource = daset.Tables["Admin"];
            baglanti.Close();
        }

        private void PatronYöneticiListesiVeGüncelleme_Load(object sender, EventArgs e)
        {
            yöneticiistele();
            guna2DataGridView1.Columns[0].HeaderText = "TC Kimlik Numarası";
            guna2DataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            guna2DataGridView1.Columns[2].HeaderText = "Adı";
            guna2DataGridView1.Columns[3].HeaderText = "Soyadı";
            guna2DataGridView1.Columns[4].HeaderText = "Yaş";
            guna2DataGridView1.Columns[5].HeaderText = "Cinsiyet";
            guna2DataGridView1.Columns[6].HeaderText = "Telefon Numarası";
            guna2DataGridView1.Columns[7].HeaderText = "E-mail";

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu kaydı güncellemek istiyor musunuz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Admin set ad=@ad,kullanici_adi=@kullanici_adi,soyad=@soyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,email=@email where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@kullanici_adi", txtKullanıcıAdı.Text);
                komut.Parameters.AddWithValue("@ad", txtAdı.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyadı.Text);
                komut.Parameters.AddWithValue("@yas", txtYas.Text);
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                daset.Tables["Admin"].Clear();
                yöneticiistele();
                txtTC.Clear();
                if (txtTC.Text == "")
                {
                    txtAdı.Clear();
                    txtSoyadı.Clear();
                    txtYas.Clear();
                    txtTelefon.Clear();
                    comboCinsiyet.SelectedIndex = -1;
                    txtEmail.Clear();
                }
            }
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Admin where tc like'%" + txtTC.Text + "%'", baglanti);
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
            }
            
            if (txtTC.Text == "")
            {
                txtAdı.Clear();
                txtSoyadı.Clear();
                txtYas.Clear();
                txtTelefon.Clear();
                comboCinsiyet.SelectedIndex = -1;
                txtEmail.Clear();
                txtKullanıcıAdı.Clear();
            }
            baglanti.Close();
        }
    }
}
