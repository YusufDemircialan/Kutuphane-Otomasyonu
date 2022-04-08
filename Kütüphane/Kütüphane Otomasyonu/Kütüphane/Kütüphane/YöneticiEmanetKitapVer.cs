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
    public partial class YöneticiEmanetKitapVer : Form
    {

        public YöneticiEmanetKitapVer()
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
        private void KitapSayisi()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayisi) from Sepet", baglanti);
            lblKitapSayi.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        private void SepetiListele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Sepet",baglanti);
            adtr.Fill(daset, "Sepet");
            guna2DataGridView1.DataSource = daset.Tables["Sepet"];
            baglanti.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiPanel yntpanel = new YöneticiPanel();
            yntpanel.Show();
        }


        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Sepet (barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdı.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazar.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayınEvi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayısı.Text);
            komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(txtKitapSayisi.Text));
            komut.Parameters.AddWithValue("@teslimtarihi", guna2DateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadetarihi", guna2DateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap(lar) sepete eklendi", "Ekleme İşlemi");
            daset.Tables["Sepet"].Clear();
            SepetiListele();
            lblKitapSayi.Text = "";
            KitapSayisi();
            txtBarkodNo.Clear();
            guna2DateTimePicker1.ResetText();
            guna2DateTimePicker2.ResetText();

            if (txtBarkodNo.Text == "")
            {

                txtKitapAdı.Clear();
                
                txtYayınEvi.Clear();
                txtYazar.Clear();
            }

        }

        private void YöneticiEmanetKitapVer_Load(object sender, EventArgs e)
        {
            SepetiListele();
            KitapSayisi();
            guna2DataGridView1.Columns[0].HeaderText = "Barkod No";
            guna2DataGridView1.Columns[1].HeaderText = "Kitap Adı";
            guna2DataGridView1.Columns[2].HeaderText = "Yazarı";
            guna2DataGridView1.Columns[3].HeaderText = "Yayın Evi";
            guna2DataGridView1.Columns[4].HeaderText = "Sayfa Sayısı";
            guna2DataGridView1.Columns[5].HeaderText = "Kitap Türü";
            guna2DataGridView1.Columns[6].HeaderText = "Stok Sayısı";
            guna2DataGridView1.Columns[7].HeaderText = "Raf No";

        }

        private void txtTcNoGir_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Uye where tc like'"+txtTcNoGir.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                
                txtKullanıcıAdı.Text = read["kullanici_adi"].ToString(); 
                txtAdı.Text = read["ad"].ToString(); 
                txtSoyadı.Text = read["soyad"].ToString();
                txtYaş.Text = read["yas"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayisi) from EmanetKitaplar where tc='"+txtTcNoGir.Text+"'", baglanti);
            lblKayitliKitapSayi.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();
            if (txtTcNoGir.Text=="")
            {
                
                txtAdı.Clear();
                txtSoyadı.Clear();
                txtYaş.Clear();
                txtTelefon.Clear();

                lblKayitliKitapSayi.Text = "";
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kitap where barkodno like'"+txtBarkodNo.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                
                txtKitapAdı.Text = read["kitapadi"].ToString();
                txtYazar.Text = read["yazari"].ToString();
                txtYayınEvi.Text = read["yayinevi"].ToString();
                txtSayfaSayısı.Text = read["sayfasayisi"].ToString();
            }
            baglanti.Close();
            if (txtBarkodNo.Text=="")
            {
                txtKitapAdı.Clear();
                txtYazar.Clear();
                txtYayınEvi.Clear();
                txtSayfaSayısı.Clear();
            }
           
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            if (MessageBox.Show("Emanet Kitap(lar) Verilsin Mi ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lblKitapSayi.Text != "")
                {
                    if (lblKayitliKitapSayi.Text == "" && int.Parse(lblKitapSayi.Text) <= 3 || lblKayitliKitapSayi.Text != "" && int.Parse(lblKayitliKitapSayi.Text) + int.Parse(lblKitapSayi.Text) <= 3)
                    {
                        if (txtTcNoGir.Text != "" && txtKullanıcıAdı.Text != "" && txtAdı.Text != "" && txtSoyadı.Text != "" && txtYaş.Text != "" && txtTelefon.Text != "")
                        {
                            for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
                            {
                                baglanti.Open();
                                SqlCommand komut = new SqlCommand("insert into EmanetKitaplar (tc,kullanici_adi,ad,soyad,yas,telefon,barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values(@tc,@kullanici_adi,@ad,@soyad,@yas,@telefon,@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
                                komut.Parameters.AddWithValue("@tc", txtTcNoGir.Text);
                                komut.Parameters.AddWithValue("@kullanici_adi", txtKullanıcıAdı.Text);
                                komut.Parameters.AddWithValue("@ad", txtAdı.Text);
                                komut.Parameters.AddWithValue("@soyad", txtSoyadı.Text);
                                komut.Parameters.AddWithValue("@yas", txtYaş.Text);
                                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                                komut.Parameters.AddWithValue("barkodno", guna2DataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                                komut.Parameters.AddWithValue("kitapadi", guna2DataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                                komut.Parameters.AddWithValue("yazari", guna2DataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                                komut.Parameters.AddWithValue("yayinevi", guna2DataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                                komut.Parameters.AddWithValue("sayfasayisi", guna2DataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                                komut.Parameters.AddWithValue("kitapsayisi", int.Parse(guna2DataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                                komut.Parameters.AddWithValue("teslimtarihi", guna2DataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                                komut.Parameters.AddWithValue("iadetarihi", guna2DataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                                komut.ExecuteNonQuery();

                                SqlCommand komut2 = new SqlCommand("update Uye set okunankitapsayisi=okunankitapsayisi+'" + int.Parse(guna2DataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where tc='" + txtTcNoGir.Text + "'", baglanti);
                                komut2.ExecuteNonQuery();
                                SqlCommand komut3 = new SqlCommand("update Kitap set stoksayisi=stoksayisi-'" + int.Parse(guna2DataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where barkodno='" + guna2DataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                                komut3.ExecuteNonQuery();
                                baglanti.Close();

                            }
                            baglanti.Open();
                            SqlCommand komut4 = new SqlCommand("delete from Sepet", baglanti);
                            komut4.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("Kitap(lar) Emanet Olarak Verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            daset.Tables["Sepet"].Clear();
                            SepetiListele();
                            txtKullanıcıAdı.Clear();
                            txtTcNoGir.Clear();
                            lblKitapSayi.Text = "";
                            KitapSayisi();
                            lblKayitliKitapSayi.Text = "";
                            txtBarkodNo.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Önce Üye İsmi Seçmeniz gerekir!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Emanet Kitap Sayısı 3'ten Fazla Olamaz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    MessageBox.Show("Önce Sepete Kitap Eklenmelidir!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }



        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            if (MessageBox.Show("Kayıt Silinsin Mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Sepet where barkodno='" + guna2DataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Yapıldı", "Silme İşlemi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                daset.Tables["Sepet"].Clear();
                SepetiListele();
                lblKitapSayi.Text = "";
                KitapSayisi();
            }
            
        }
    }
}
