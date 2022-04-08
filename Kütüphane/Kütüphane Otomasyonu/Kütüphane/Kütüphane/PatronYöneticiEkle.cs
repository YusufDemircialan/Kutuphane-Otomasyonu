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
using System.Text.RegularExpressions;

namespace Kütüphane
{
    public partial class PatronYöneticiEkle : Form
    {
        Baglanti bgl = new Baglanti();
       
        public PatronYöneticiEkle()
        {
            InitializeComponent();
        }
        


        static bool EmailKontrol(string inputEmail)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(inputEmail);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            if (txtTc.Text != "")
            {
                
                if (txtTc.Text.Length == 11)
                {
                    char[] rakamlar = txtTc.Text.ToCharArray();
                    int kural1 = 0, hane11 = rakamlar[10], hane10 = rakamlar[9];
                    //kural1: ilk 10 rakamın toplamının birler basamağı, 11. rakamı vermektedir.
                    for (int i = 0; i < 10; i++)
                    {
                        kural1 += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    char[] birlerbasamagikural1 = kural1.ToString().ToCharArray();

                    int kural2tek = 0, kural2cift = 0;
                    //kural2:  1, 3, 5, 7 ve 9. rakamın toplamının 7 katı ile 2, 4, 6 ve 8. rakamın toplamının 9 katının toplamının birler basamağı 10. rakamı vermektedir.
                    for (int i = 0; i < 10; i += 2)
                    {
                        kural2tek += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    for (int i = 1; i < 9; i += 2)
                    {
                        kural2cift += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    char[] birlerbasamagikural2 = ((7 * kural2tek) + (9 * kural2cift)).ToString().ToCharArray();

                    int kural3 = 0;
                    //1, 3, 5, 7 ve 9. rakamın toplamının 8 katının birler basamağı 11. rakamı vermektedir.
                    for (int i = 0; i < 10; i += 2)
                    {
                        kural3 += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    char[] birlerbasamagikural3 = (8 * kural3).ToString().ToCharArray();

                    if ((birlerbasamagikural1[birlerbasamagikural1.Length - 1] == hane11) && (birlerbasamagikural2[birlerbasamagikural2.Length - 1] == hane10) && (birlerbasamagikural3[birlerbasamagikural3.Length - 1] == hane11))
                    {
                        string mail = txtEmail.Text;
                        bool kontrol = EmailKontrol(mail);

                        if (kontrol == true)
                        {
                            if (txtTelefon.Text.Length==11)
                            {
                                baglanti.Open();
                                SqlCommand komut = new SqlCommand("insert into Admin(tc,kullanici_adi,ad,soyad,yas,cinsiyet,telefon,email) values (@tc,@kullanici_adi,@ad,@soyad,@yas,@cinsiyet,@telefon,@email)", baglanti);
                                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                                komut.Parameters.AddWithValue("@kullanici_adi", txtKullanıcıAdı.Text);
                                komut.Parameters.AddWithValue("@ad", txtAdı.Text);
                                komut.Parameters.AddWithValue("@soyad", txtSoyadı.Text);
                                komut.Parameters.AddWithValue("@yas", txtYas.Text);
                                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
                                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                                SqlCommand komut2 = new SqlCommand("insert into AdminBilgi(kullanici_adi,sifre) values (@kullanıcıadı,@sifre)", baglanti);
                                komut2.Parameters.AddWithValue("@kullanıcıadı", txtKullanıcıAdı.Text);
                                komut2.Parameters.AddWithValue("@sifre", TxtSifre.Text);
                                komut.ExecuteNonQuery();
                                komut2.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Yönetici Kaydı Yapıldı.", "Bilgi");
                                txtAdı.Clear();
                                txtEmail.Clear();
                                txtKullanıcıAdı.Clear();
                                txtSoyadı.Clear();
                                txtTc.Clear();
                                txtTelefon.Clear();
                                txtYas.Clear();
                                TxtSifre.Clear();
                                comboCinsiyet.SelectedIndex = -1;
                            }
                            else
                            {
                                MessageBox.Show("Telefon Numarası Eksik veya Hatalı Girilmiştir.\nLütfen Tekrar Deneyiniz..!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtTelefon.Clear();
                                txtTelefon.Focus();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("E-mail Adresiniz Eksik veya Hatalı Girilmiştir.\nLütfen Tekrar Deneyiniz..!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtEmail.Clear();
                            txtEmail.Focus();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Kimlik Numarası Geçerli Değildir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTc.Clear();
                        txtTc.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show(" TC Kimlik Numaranızı Eksik ve ya Hatalı Girdiniz Lütfen Kontrol Ediniz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

                MessageBox.Show(" TC Kimlik Numarası Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hide();
            PatronPanel ptrnpanel = new PatronPanel();
            ptrnpanel.Show();
        }

        private void PatronYöneticiEkle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
