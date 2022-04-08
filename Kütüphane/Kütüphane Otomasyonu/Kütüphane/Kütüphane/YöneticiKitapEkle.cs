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
    public partial class YöneticiKitapEkle : Form
    {
        
        public YöneticiKitapEkle()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void YöneticiKitapEkle_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();

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

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitap(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapturu,stoksayisi,rafno,kayittarihi) values (@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapturu,@stoksayisi,@rafno,@kayittarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazar.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayınEvi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@kitapturu", comboKitapTürü.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtStokSayısı.Text);
            komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
            komut.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı Yapıldı");
            txtBarkodNo.Clear();
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtYayınEvi.Clear();
            txtSayfaSayisi.Clear();
            txtStokSayısı.Clear();
            txtRafNo.Clear();
            comboKitapTürü.SelectedIndex = -1;
            foreach (Control item in Controls)
            {
                if (item is Guna.UI2.WinForms.Guna2TextBox)
                {                 
                        item.Text = "";                   
                }
            }
        }
    }
}
