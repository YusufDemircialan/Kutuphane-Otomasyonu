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
    public partial class ÜyeÜzerimdekiKitaplar : Form
    {

        public ÜyeÜzerimdekiKitaplar()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();
        DataSet daset = new DataSet();
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hide();
            ÜyePanel üyepnl = new ÜyePanel();
            üyepnl.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        
        private void ÜyeÜzerimdekiKitaplar_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            label1.Text = ÜyeGiriş.KullaniciAdSoyad;
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where kullanici_adi like '%" + label1.Text + "%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            guna2DataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
            guna2DataGridView1.Columns[0].Visible = false; //KOLON GİZLEME
            guna2DataGridView1.Columns[1].Visible = false;
            guna2DataGridView1.Columns[4].Visible = false; 
            guna2DataGridView1.Columns[5].Visible = false; 
            guna2DataGridView1.Columns[10].Visible = false;
            guna2DataGridView1.Columns[11].Visible = false;
            guna2DataGridView1.Columns[2].HeaderText = "Adı";
            guna2DataGridView1.Columns[3].HeaderText = "Soyadı";
            guna2DataGridView1.Columns[6].HeaderText = "Barkod No";
            guna2DataGridView1.Columns[7].HeaderText = "Kitap Adı";
            guna2DataGridView1.Columns[8].HeaderText = "Yazarı";
            guna2DataGridView1.Columns[9].HeaderText = "Yayın Evi";
            guna2DataGridView1.Columns[12].HeaderText = "Teslim Tarihi";
            guna2DataGridView1.Columns[13].HeaderText = "İade Tarihi";


        }
    }
}
