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
    public partial class PatronPanel : Form
    {
        public PatronPanel()
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

        private void PatronPanel_Load(object sender, EventArgs e)
        {
            
            label6.Text =PatronGiriş.PatronAd;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToShortDateString();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hide();
            PatronYöneticiEkle ptrnyntcekle = new PatronYöneticiEkle();
            ptrnyntcekle.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hide();
            PatronYöneticiSil ptrnyntcsil = new PatronYöneticiSil();
            ptrnyntcsil.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Hide();
            PatronYöneticiListesiVeGüncelleme ptrnyöneticiliste = new PatronYöneticiListesiVeGüncelleme();
            ptrnyöneticiliste.Show();
        }
    }
}
