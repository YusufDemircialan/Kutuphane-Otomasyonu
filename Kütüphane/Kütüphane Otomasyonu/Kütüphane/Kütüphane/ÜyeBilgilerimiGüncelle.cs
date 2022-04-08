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
    public partial class ÜyeBilgilerimiGüncelle : Form
    {
        public ÜyeBilgilerimiGüncelle()
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

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Uye where tc like'" + txtTC.Text + "'", baglanti);
            
            SqlDataReader read = komut.ExecuteReader();
            
            while (read.Read())
            {
                
                txtKullanıcıAdı.Text = read["kullanici_adi"].ToString();
                txtAdı.Text = read["ad"].ToString();
                txtSoyadı.Text = read["soyad"].ToString();
                txtYas.Text = read["yas"].ToString();
                comboCinsiyet.Text = read["cinsiyet"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
                txtEmail.Text = read["email"].ToString();

            }

            if (txtTC.Text == "")
            {
                txtKullanıcıAdı.Clear();
                txtAdı.Clear();
                txtSoyadı.Clear();
                txtYas.Clear();
                txtTelefon.Clear();
                comboCinsiyet.SelectedIndex = -1;
                txtEmail.Clear();

            }
            baglanti.Close();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu kaydı güncellemek istiyor musunuz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Uye set kullanici_adi=@kullanici_adi,ad=@ad,soyad=@soyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,email=@email where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@kullanici_adi", txtKullanıcıAdı.Text);
                komut.Parameters.AddWithValue("@ad", txtAdı.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyadı.Text);
                komut.Parameters.AddWithValue("@yas", txtYas.Text);
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update ÜyeBilgi set kullanici_adi=@kullanici_adi",baglanti);
                komut2.Parameters.AddWithValue("@kullanici_adi", txtKullanıcıAdı.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTC.Clear();
                if (txtTC.Text == "")
                {
                    txtKullanıcıAdı.Clear();
                    txtAdı.Clear();
                    txtSoyadı.Clear();
                    txtYas.Clear();
                    txtTelefon.Clear();
                    comboCinsiyet.SelectedIndex = -1;
                    txtEmail.Clear();
                   
                }
            }
        }
    }
}
