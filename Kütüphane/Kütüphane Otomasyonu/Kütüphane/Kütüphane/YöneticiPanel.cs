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
    public partial class YöneticiPanel : Form
    {
        public YöneticiPanel()
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
                AnaSayfa as1 = new AnaSayfa();
                as1.Show();
            }
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiÜyeEkle yntüyeekle = new YöneticiÜyeEkle();
            yntüyeekle.Show();
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiÜyeSil yntüyesil = new YöneticiÜyeSil();
            yntüyesil.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiÜyeListesi yntüyeliste = new YöneticiÜyeListesi();

            yntüyeliste.Show();
        }


        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiKitapEkle yntkitapekle = new YöneticiKitapEkle();
            yntkitapekle.Show();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiKitapSil yntkitapsil = new YöneticiKitapSil();
            yntkitapsil.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiKitapAra yntkitapara = new YöneticiKitapAra();
            yntkitapara.Show();
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiKitapListesiVeGüncelleme yntkitaplistegüncelle = new YöneticiKitapListesiVeGüncelleme();
            yntkitaplistegüncelle.Show();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiEmanetKitapVer yntemanetkitapver = new YöneticiEmanetKitapVer();
            yntemanetkitapver.Show();
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiEmanetKitapListesi yntemanetkitapliste = new YöneticiEmanetKitapListesi();
            yntemanetkitapliste.Show();
        }

        private void guna2GradientButton12_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiEmanetKitapİade yntemanetkitapiade = new YöneticiEmanetKitapİade();
            yntemanetkitapiade.Show();
        }

        private void guna2GradientButton13_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiSıralama yntsıralama = new YöneticiSıralama();
            yntsıralama.Show();
        }

        private void guna2GradientButton15_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiGrafikler yntgrafikler = new YöneticiGrafikler();
            yntgrafikler.Show();
        }

        private void YöneticiPanel_Load(object sender, EventArgs e)
        {
            
            label6.Text = YöneticiGiriş.YöneticiAd;
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiŞifreDeğiştir yntşifredeğiş = new YöneticiŞifreDeğiştir();
            yntşifredeğiş.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToShortDateString();
        }
    }
}
