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
    public partial class PatronYöneticiSil : Form
    {
        public PatronYöneticiSil()
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
        private void yöneticiistele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Admin", baglanti);
            adtr.Fill(daset, "Admin");
            guna2DataGridView1.DataSource = daset.Tables["Admin"];
            baglanti.Close();
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtTcAra.Text = guna2DataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }

        private void PatronYöneticiSil_Load(object sender, EventArgs e)
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

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            if (MessageBox.Show("Bu kaydı silmek istiyor musunuz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Admin where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", guna2DataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                SqlCommand komut2 = new SqlCommand("delete from AdminBilgi where kullanici_adi=@kullanici_adi", baglanti);
                komut2.Parameters.AddWithValue("@kullanici_adi", guna2DataGridView1.CurrentRow.Cells["kullanici_adi"].Value.ToString());
                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                daset.Tables["Admin"].Clear();
                yöneticiistele();
                txtTcAra.Clear();
            }
        }
    }
}
