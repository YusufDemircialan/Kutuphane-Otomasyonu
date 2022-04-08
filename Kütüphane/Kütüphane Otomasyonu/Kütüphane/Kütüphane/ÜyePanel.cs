using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class ÜyePanel : Form
    {
        public ÜyePanel()
        {
            InitializeComponent();
        }
        

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
                AnaSayfa as2 = new AnaSayfa();
                as2.Show();
            }
            
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Hide();
            ÜyeKitapAra üyekptara = new ÜyeKitapAra();
            üyekptara.Show();
        }

        private void ÜyePanel_Load(object sender, EventArgs e)
        {
            
            label2.Text = ÜyeGiriş.KullaniciAdSoyad;
     
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hide();
            ÜyeÜzerimdekiKitaplar üzerimdekiktp = new ÜyeÜzerimdekiKitaplar();
            üzerimdekiktp.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hide();
            ÜyeBilgilerimiGüncelle üyegüncelle = new ÜyeBilgilerimiGüncelle();
            üyegüncelle.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Hide();
            ÜyeŞifreDeğiştir üyeşifredeğiş = new ÜyeŞifreDeğiştir();
            üyeşifredeğiş.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToShortDateString();
        }
    }
}
