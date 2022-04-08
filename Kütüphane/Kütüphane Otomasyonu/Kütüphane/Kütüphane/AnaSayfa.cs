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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();

        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            YöneticiGiriş ynt = new YöneticiGiriş();
            ynt.Show();


        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            ÜyeGiriş üye = new ÜyeGiriş();
            üye.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hide();
            YöneticiGiriş ynt = new YöneticiGiriş();
            ynt.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hide();
            ÜyeGiriş üye = new ÜyeGiriş();
            üye.Show();
        }


        private void AnaSayfa_Load(object sender, EventArgs e)
        {
           
            
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Hide();
            PatronGiriş patronpnl = new PatronGiriş();
            patronpnl.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Hide();
            HakkımdaPanel hakkımda = new HakkımdaPanel();
            hakkımda.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToShortDateString();
        }
    }
}
